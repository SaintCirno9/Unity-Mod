using HarmonyLib;
using Il2Cpp;
using UnityEngine;

namespace LYMod;

[HarmonyPatch]
public class UIPatches
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(MouseController), "Update")]
    public static bool MouseController_Update_Prefix(MouseController __instance)
    {
        if (Plugin.Instance.ShowMainWindow)
        {
            Vector2 guiMousePos = new Vector2(Input.mousePosition.x, Screen.height - Input.mousePosition.y);
            if (Plugin.Instance.MainWindowRect.Contains(guiMousePos))
            {
                return false;
            }
        }
        return true;
    }
}