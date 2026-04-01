using HarmonyLib;
using Il2Cpp;
using Object = UnityEngine.Object;

namespace LYMod;

[HarmonyPatch]
public class TestPatches
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(DrinkUIController), nameof(DrinkUIController.NextButtonClicked))]
    public static void DrinkUIController_NextButtonClicked_Prefix(DrinkUIController __instance)
    {
        if (__instance == null || !Plugin.Instance.DrinkOneWinFlag.Value) return;
        __instance.enemyLose = true;
        __instance.playerLose = false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlotController), nameof(PlotController.AskHeroMakeFriend))]
    public static void PlotController_AskHeroMakeFriend_Postfix(PlotController __instance)
    {
        if (!Plugin.Instance.EffeminateManFlag.Value) return;
        
        var shero = __instance.sourceInteractHero;
        if (shero == null)
            shero = GameController.Instance.worldData.Player();
        var targetHero = __instance.targetInteractHero;
        if (shero == null || targetHero == null) return;
        
        if (!shero.isFemale) return;
        
        var prefab = __instance.plotInteractPrefab;
        var plotPanel = __instance.plotPanel;
        if (prefab == null || plotPanel == null) return;
        
        var interactGrid = plotPanel.transform.Find("InteractGrid");
        if (interactGrid == null) return;
        
        for (int i = 0; i < interactGrid.childCount; i++)
        {
            var child = interactGrid.GetChild(i);
            var existingController = child.GetComponent<PlotInteractController>();
            if (existingController?.choiceData?.callFuc == "AskHeroToLover")
            {
                return;
            }
        }
        
        var newObj = Object.Instantiate(prefab, interactGrid);
        var controller = newObj.GetComponent<PlotInteractController>();
        if (controller == null) return;
        
        var choiceData = new SinglePlotChoiceData();
        choiceData.choiceText = "结缘";
        choiceData.callFuc = "AskHeroToLover";
        var requirements = new Il2CppSystem.Collections.Generic.List<PlotChoiceRequirement>();
        requirements.Add(new PlotChoiceRequirement(ChoiceRequirementType.FavorDegree,100));
        choiceData.requirements = requirements;
        choiceData.relations = new Il2CppSystem.Collections.Generic.List<RelationRequirementType>();
        choiceData.costResource = new Il2CppSystem.Collections.Generic.List<ResourceData>();
        controller.choiceData = choiceData;
        controller.meetRequire = true;
        controller.meetCost = true;
        
        var labelChild = newObj.transform.Find("Label");
        var requireChild = newObj.transform.Find("Require");
        
        var unityText = labelChild.GetComponent<UnityEngine.UI.Text>();
        var requireText = requireChild.GetComponent<UnityEngine.UI.Text>();
        
        unityText.text = "结缘";
        requireText.text = "需要好感100";
        requireChild.gameObject.SetActive(false);
        requireChild.gameObject.SetActive(true);
        labelChild.gameObject.SetActive(false);
        labelChild.gameObject.SetActive(true);
    }

    private static readonly int[] MaximizedLayout =
    {
        -1, -1, -1, -1, -1, -1, -1, -2, -1, -1, -1, -1, -1, -1, -1,
        -1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, -1,
        -1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, -1,
        -1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, -1,
        -1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, -1,
        -1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, -1,
        -1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, -1,
        -2, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, -2,
        -1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, -1,
        -1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, -1,
        -1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, -1,
        -1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, -1,
        -1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, -1,
        -1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, -1,
        -1, -1, -1, -1, -1, -1, -1, -2, -1, -1, -1, -1, -1, -1, -1
    };

    private static AreaTileType IntToTileType(int value)
    {
        if (TestElement.MaxAreaFlag1)
        {
            return value switch
            {
                -2 => AreaTileType.CityGate,
                -1 => AreaTileType.CityWall,
                0 => AreaTileType.EmptySpace,
                1 => AreaTileType.Road,
                2 => AreaTileType.MainBuilding,
                _ => AreaTileType.Null
            };
        }

        return value switch
        {
            -2 => AreaTileType.CityGate,
            -1 or 0 => AreaTileType.EmptySpace,
            1 => AreaTileType.Road,
            2 => AreaTileType.MainBuilding,
            _ => AreaTileType.Null
        };
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GameController), nameof(GameController.LoadAreaMapData))]
    public static void LoadAreaMapDataPostfix(GameController __instance, AreaData? areaData)
    {
        if (__instance != null && areaData != null && TestElement.MaxAreaFlag)
        {
            var tiles = areaData.areaTiles;
            if (tiles == null || tiles.Count == 0) return;


            if (areaData.areaID != 55)
            {
               return;
            }
            Plugin.LOG.Msg($"[LoadAreaMapData] 已跳过非仙霞派区域 (ID={areaData.areaID})");
            
            Plugin.LOG.Msg($"[LoadAreaMapData] 区域: {areaData.GetAreaName()} (ID={areaData.areaID}), " +
                           $"尺寸: {areaData.mapWidth}x{areaData.mapHeight}");

            var targetSize = 15;
            Plugin.LOG.Msg($"[LoadAreaMapData] 目标尺寸: {targetSize}x{targetSize}, " +
                           $"当前尺寸: {areaData.mapWidth}x{areaData.mapHeight}");
            Plugin.LOG.Msg($"[LoadAreaMapData] MaxAreaFlag1: {TestElement.MaxAreaFlag1}");

            if (areaData.mapWidth == targetSize && areaData.mapHeight == targetSize)
            {
                if (TestElement.MaxAreaFlag1)
                {
                    Plugin.LOG.Msg("[LoadAreaMapData] 已是最大尺寸，保留城墙");
                }
                else
                {
                    Plugin.LOG.Msg("[LoadAreaMapData] 已是最大尺寸，去掉城墙");
                    var modifiedCount = 0;
                    foreach (var tile in tiles)
                        if (tile.tileType == AreaTileType.CityWall || tile.tileType == AreaTileType.Null)
                        {
                            tile.tileType = AreaTileType.EmptySpace;
                            modifiedCount++;
                        }
                    Plugin.LOG.Msg($"[LoadAreaMapData] 修改 {modifiedCount} 个地块");
                }
                return;
            }

            Plugin.LOG.Msg($"[LoadAreaMapData] 扩展地图到 {targetSize}x{targetSize}");

            var newTiles = new Il2CppSystem.Collections.Generic.List<AreaTileData>();
            for (var i = 0; i < MaximizedLayout.Length; i++)
            {
                var row = i / targetSize;
                var col = i % targetSize;
                var tileType = IntToTileType(MaximizedLayout[i]);
                var tile = new AreaTileData(areaData.areaID, tileType);
                tile.row = row;
                tile.column = col;
                newTiles.Add(tile);
            }

            areaData.areaTiles = newTiles;
            areaData.mapWidth = targetSize;
            areaData.mapHeight = targetSize;

            Plugin.LOG.Msg($"[LoadAreaMapData] 完成！新建 {newTiles.Count} 个地块");
            TestElement.MaxAreaFlag = false;
            TestElement.MaxAreaFlag1 = false;
        }
    }
    
}