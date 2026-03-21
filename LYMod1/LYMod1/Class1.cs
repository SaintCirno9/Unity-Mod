using BepInEx;
using BepInEx.Configuration;
using BepInEx.Unity.IL2CPP;


namespace LYMod1;


public static class ModConstants
{
    public const string MOD_NAME = "LYMod";       // 插件名
    public const string MOD_VERSION = "1.2";    // 版本号
}

[BepInPlugin(ModConstants.MOD_NAME, ModConstants.MOD_NAME, ModConstants.MOD_VERSION)]
public class Plugin : BasePlugin
{
    public static Plugin Instance { get; private set; }
    
    
    // 配置项
    public ConfigEntry<bool> _teachNewSkillToNPC;
    public ConfigEntry<bool> _teachNPC; // 传授满级
    public ConfigEntry<bool> _interaction; // 无限交互
    public ConfigEntry<bool> _readBook; // 读书经验50w
    public ConfigEntry<bool> _explore; // 探险耐力锁1000
    public ConfigEntry<bool> _cost0; // 建筑升级资源消耗0
    public ConfigEntry<bool> _redBook; // 必获得完本
    public ConfigEntry<bool> _redMaterial; // 必获得红色材料
    public ConfigEntry<bool> _redBreak; // 必红色突破
    public ConfigEntry<bool> _redTreasure; // 必红色珍宝
    public ConfigEntry<bool> _pzqh; // 烹饪铸造强化

    

   
    public override void Load()
    {
        Instance = this;
        _teachNewSkillToNPC = Config.Bind("Config", "testNumChangeToggle", false, "传授满级");
        _teachNPC = Config.Bind("Config", "teachNPC", false, "传授满级");
        _interaction = Config.Bind("Config", "interaction", false, "无限交互");
        _readBook = Config.Bind("Config", "testNumChangeToggle", false, "读书经验50w");
        _explore = Config.Bind("Config", "explore", false, "探险耐力锁1000");
        _cost0 = Config.Bind("Config", "cost0", false, "建筑升级资源消耗0");
        _redBook = Config.Bind("Config", "redBook", true, "必获得完本");
        _redMaterial = Config.Bind("Config", "redMaterial", true, "必获得红色材料");
        _redBreak = Config.Bind("Config", "redBreak", true, "必红色突破");
        _redTreasure = Config.Bind("Config", "redTreasure", false, "必红色珍宝");
        _pzqh = Config.Bind("Config", "pzqh", true, "烹饪铸造强化");


        var harmony = new HarmonyLib.Harmony("LYMod");
        harmony.PatchAll(typeof(ReadBookControllerPatches));
        harmony.PatchAll(typeof(ItemListDataPatches));
        harmony.PatchAll(typeof(BreakThroughControllerPatches));
        harmony.PatchAll(typeof(ForceDataPatches));
        harmony.PatchAll(typeof(ExploreControllerPatches));
        harmony.PatchAll(typeof(PlotControllerPatches));
        harmony.PatchAll(typeof(CraftingPatches));
       
    }
}

