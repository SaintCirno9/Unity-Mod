using System;
using HarmonyLib;
using LYMod1;

namespace LongYinEditor
{
    // Token: 0x02000005 RID: 5
    public class UIPatches
    {
        // Token: 0x06000095 RID: 149 RVA: 0x0000A94D File Offset: 0x00008B4D
        [HarmonyPatch(typeof(GameController), "Update")]
        [HarmonyPostfix]
        public static void GameController_Update_Postfix()
        {
            if (!UIPatches._updateLogged)
            {
                Plugin.Instance.Log.LogInfo("GameController.Update Hook Active!");
                UIPatches._updateLogged = true;
            }
            if (Plugin.Instance != null)
            {
                Plugin.Instance.UpdateLogic();
            }
        }

        // Token: 0x06000096 RID: 150 RVA: 0x0000A981 File Offset: 0x00008B81
        [HarmonyPatch(typeof(UIRoot), "Update")]
        [HarmonyPostfix]
        public static void UIRoot_Update_Postfix()
        {
            if (Plugin.Instance != null)
            {
                Plugin.Instance.UpdateLogic();
            }
        }

        // Token: 0x06000097 RID: 151 RVA: 0x0000A994 File Offset: 0x00008B94
        [HarmonyPatch(typeof(UICamera), "Update")]
        [HarmonyPostfix]
        public static void UICamera_Update_Postfix()
        {
            if (Plugin.Instance != null)
            {
                Plugin.Instance.UpdateLogic();
            }
        }

        // Token: 0x06000098 RID: 152 RVA: 0x0000A9A7 File Offset: 0x00008BA7
        [HarmonyPatch(typeof(StartMenuController), "Update")]
        [HarmonyPostfix]
        public static void StartMenuController_Update_Postfix()
        {
            if (Plugin.Instance != null)
            {
                Plugin.Instance.UpdateLogic();
            }
        }

        // Token: 0x06000099 RID: 153 RVA: 0x0000A9BA File Offset: 0x00008BBA
        [HarmonyPatch(typeof(StartGameSettingController), "Update")]
        [HarmonyPostfix]
        public static void StartGameSettingController_Update_Postfix()
        {
            if (Plugin.Instance != null)
            {
                Plugin.Instance.UpdateLogic();
            }
        }

        // Token: 0x040000A9 RID: 169
        private static bool _updateLogged;
    }
}