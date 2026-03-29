using HarmonyLib;
using Il2Cpp;
using UnityEngine;

namespace LYMod;

[HarmonyPatch]
public class UIPatches
{

    private static bool IsMouseOverIMGUI()
    {
        if (Plugin.Instance.ShowMainWindow)
        {
            Vector2 guiMousePos = new Vector2(Input.mousePosition.x, Screen.height - Input.mousePosition.y);
            if (Plugin.Instance.MainWindowRect.Contains(guiMousePos))
            {
                return true;
            }
        }
        return false;
    }
    [HarmonyPrefix]
    [HarmonyPatch(typeof(MouseController), "Update")]
    public static bool MouseController_Update_Prefix(MouseController __instance)
    {
        return !IsMouseOverIMGUI();
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(BuildQuickButtonController), "Update")]
    public static bool BuildQuickButtonController_Update_Prefix(BuildQuickButtonController __instance)
    {
        return !IsMouseOverIMGUI();
    }
    [HarmonyPrefix]
    [HarmonyPatch(typeof(BuildQuickButtonController), "OnClick")]
    public static bool BuildQuickButtonController_OnClick_Prefix(BuildQuickButtonController __instance)
    {
        return !IsMouseOverIMGUI();
    }
    [HarmonyPrefix]
    [HarmonyPatch(typeof(HeroIconController), nameof(HeroIconController.OnClick))]
    public static bool HeroIconController_OnClick_Prefix(HeroIconController __instance)
    {
        return !IsMouseOverIMGUI();
    }
    [HarmonyPrefix]
    [HarmonyPatch(typeof(ShowHeroDetail), nameof(ShowHeroDetail.OnClick))]
    public static bool ShowHeroDetail_OnClick_Prefix(ShowHeroDetail __instance)
    {
        return !IsMouseOverIMGUI();
    }
}
