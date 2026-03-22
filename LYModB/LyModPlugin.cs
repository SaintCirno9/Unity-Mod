using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;
using Logger = BepInEx.Logging.Logger;
using Object = UnityEngine.Object;

namespace LYModB;

public abstract class ModConstants
{
    public const string ModGuid = "LyMod";
    public const string ModName = "LyMod";
    public const string ModVersion = "1.0";
}

[BepInPlugin(ModConstants.ModGuid, ModConstants.ModName, ModConstants.ModVersion)]
public class LyModPlugin : BasePlugin
{
    private static int _lastFrame = -1;
    // UGUI 静态变量
    private static GameObject _canvas;
    private static bool _uiCreated;
    public static ManualLogSource _staticLog = Logger.CreateLogSource("LyModPlugin");
    // 插件加载入口
    public override void Load()
    {
        // 正确用法：直接用BasePlugin自带的Logger，无需额外创建
        Log.LogInfo("✅ LyMod 插件加载成功！按 F1 测试按键");
        // 注册Harmony补丁
        Harmony.CreateAndPatchAll(typeof(LyModPlugin));
    }

     // 创建 UGUI 界面
    private static void CreateUGUI()
    {
        if (_uiCreated) return;
        _uiCreated = true;
        _staticLog.LogInfo("🔨 正在创建极简 UGUI...");

        // 1. 创建 UGUI 根画布 Canvas（关键：用非泛型 AddComponent）
        _canvas = new GameObject("LyMod_Canvas");
        _canvas.hideFlags = HideFlags.HideAndDontSave;
        Object.DontDestroyOnLoad(_canvas);
        _canvas.SetActive(false);

        // 关键：彻底避免泛型 AddComponent<T>()，改用 Type + Cast
        
        var canvasType = Il2CppSystem.Type.GetType("UnityEngine.Canvas, UnityEngine");
        var canvasScalerType = Il2CppSystem.Type.GetType("UnityEngine.CanvasScaler, UnityEngine");
        var graphicRaycasterType = Il2CppSystem.Type.GetType("UnityEngine.UI.GraphicRaycaster, UnityEngine.UI");
        
        var canvasComp = _canvas.AddComponent(canvasType).Cast<Canvas>();
        canvasComp.renderMode = RenderMode.ScreenSpaceOverlay;
        _canvas.AddComponent(canvasScalerType);
        _canvas.AddComponent(graphicRaycasterType);

        // 2. 创建一个简单的半透明面板（仅用于验证显示）
        var panel = new GameObject("LyMod_Panel");
        panel.transform.SetParent(_canvas.transform, false);
        
        var panelRectType = Il2CppSystem.Type.GetType("UnityEngine.RectTransform, UnityEngine");
        var panelRect = panel.AddComponent(panelRectType).Cast<RectTransform>();
        panelRect.anchorMin = panelRect.anchorMax = new Vector2(0.5f, 0.5f);
        panelRect.sizeDelta = new Vector2(300, 200);
        
        var rawImageType = Il2CppSystem.Type.GetType("UnityEngine.UI.RawImage, UnityEngine.UI");
        var panelImg = panel.AddComponent(rawImageType).Cast<RawImage>();
        panelImg.color = new Color(0.2f, 0.2f, 0.2f, 0.9f);

        _staticLog.LogInfo("🔨 极简 UGUI 创建完成");
    }

    // Harmony补丁：Hook MonoBehaviour.Update 检测按键
    [HarmonyPatch(typeof(StartMenuController), "Update")]
    [HarmonyPrefix]
    public static void UpdatePrefix()
    {
        // 每帧只执行1次，避免重复检测
        if (Time.frameCount == _lastFrame) return;
        _lastFrame = Time.frameCount;

        // 检测F1按键
        if (Input.GetKeyDown(KeyCode.F1))
        {
            _staticLog.LogInfo("🎯 F1 按键被按下！");
            if (!_uiCreated) CreateUGUI();
                
            // 切换 UI 显示/隐藏
            if (_canvas != null)
            {
                bool newState = !_canvas.activeSelf;
                _canvas.SetActive(newState);
                _staticLog.LogInfo($"📌 UI 状态：{newState}");
            }
        }
    }
}