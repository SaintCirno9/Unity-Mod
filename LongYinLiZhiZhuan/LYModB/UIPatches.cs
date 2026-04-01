using HarmonyLib;

namespace LYModB
{
    public class UIPatches
    {
        // [HarmonyPatch(typeof(GameController), "Update")]
        // [HarmonyPostfix]
        // public static void GameController_Update_Postfix()
        // {
        //     if (!UIPatches._updateLogged)
        //     {
        //         LyModPlugin.Instance.Log.LogInfo("GameController.Update Hook Active!");
        //         UIPatches._updateLogged = true;
        //     }
        //     if (LyModPlugin.Instance != null)
        //     {
        //         LyModPlugin.Instance.OnUpdate();
        //     }
        // }
        //
        // [HarmonyPatch(typeof(UIRoot), "Update")]
        // [HarmonyPostfix]
        // public static void UIRoot_Update_Postfix()
        // {
        //     if (LyModPlugin.Instance != null)
        //     {
        //         LyModPlugin.Instance.OnUpdate();
        //     }
        // }
        //
        // [HarmonyPatch(typeof(UICamera), "Update")]
        // [HarmonyPostfix]
        // public static void UICamera_Update_Postfix()
        // {
        //     if (LyModPlugin.Instance != null)
        //     {
        //         LyModPlugin.Instance.OnUpdate();
        //     }
        // }
        //
        // [HarmonyPatch(typeof(StartMenuController), "Update")]
        // [HarmonyPostfix]
        // public static void StartMenuController_Update_Postfix()
        // {
        //     if (LyModPlugin.Instance != null)
        //     {
        //         LyModPlugin.Instance.OnUpdate();
        //     }
        // }
        //
        // [HarmonyPatch(typeof(StartGameSettingController), "Update")]
        // [HarmonyPostfix]
        // public static void StartGameSettingController_Update_Postfix()
        // {
        //     if (LyModPlugin.Instance != null)
        //     {
        //         LyModPlugin.Instance.OnUpdate();
        //     }
        // }
        

        private static bool _updateLogged;
    }
}