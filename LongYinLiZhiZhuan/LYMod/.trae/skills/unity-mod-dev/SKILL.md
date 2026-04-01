---
name: "unity-mod-dev"
description: "Unity Mod development assistant for IL2CPP games. Invoke when developing Unity mods, using MelonLoader/Harmony, analyzing IL2CPP code, or creating IMGUI/UGUI interfaces."
---

# Unity Mod Development Skill

Unity Mod 开发助手，专注于 IL2CPP 游戏 Mod 开发。

## 1. IL2CPP 反编译代码分析

### 识别方法签名
```csharp
// IL2CPP 方法调用模式
public unsafe ReturnType MethodName(ParamType param)
{
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
    System.IntPtr* ptr = stackalloc System.IntPtr[N];
    // 参数设置...
    System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MethodName, ...);
    return *(ReturnType*)IL2CPP.il2cpp_object_unbox(intPtr);
}
```

### 常见类型映射
| IL2CPP 类型 | C# 类型 |
|------------|---------|
| `Il2CppSystem.Object` | `object` |
| `Il2CppSystem.String` | `string` |
| `Il2CppSystem.Collections.Generic.List<T>` | `List<T>` |
| `Il2CppSystem.Collections.IEnumerator` | `IEnumerator` |

### 字段访问
```csharp
// 获取字段偏移
NativeFieldInfoPtr_fieldName = IL2CPP.GetIl2CppField(NativeClassPtr, "fieldName");

// 读取字段
nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(obj) + offset;
return *(int*)num;  // 值类型
return Il2CppObjectPool.Get<T>(*(IntPtr*)num);  // 引用类型
```

## 2. Harmony 补丁模板

### Prefix (方法执行前)
```csharp
[HarmonyPrefix]
[HarmonyPatch(typeof(TargetClass), nameof(TargetClass.TargetMethod))]
public static bool TargetMethod_Prefix(ref int param, ref int __result)
{
    // 返回 false 跳过原方法
    // 修改 __result 可以改变返回值
    return true;
}
```

### Postfix (方法执行后)
```csharp
[HarmonyPostfix]
[HarmonyPatch(typeof(TargetClass), nameof(TargetClass.TargetMethod))]
public static void TargetMethod_Postfix(ref int __result)
{
    __result = 999;  // 修改返回值
}
```

### Transpiler (IL修改)
```csharp
[HarmonyTranspiler]
[HarmonyPatch(typeof(TargetClass), nameof(TargetClass.TargetMethod))]
public static IEnumerable<CodeInstruction> TargetMethod_Transpiler(IEnumerable<CodeInstruction> instructions)
{
    foreach (var instruction in instructions)
    {
        if (instruction.opcode == OpCodes.Call && instruction.operand.ToString().Contains("TargetCall"))
        {
            instruction.operand = typeof(PatchClass).GetMethod("ReplacementMethod");
        }
        yield return instruction;
    }
}
```

## 3. MelonLoader 配置

### 创建配置项
```csharp
public class Plugin : MelonMod
{
    private MelonPreferences_Category _category;
    public MelonPreferences_Entry<bool> MyBoolOption;
    public MelonPreferences_Entry<float> MyFloatOption;
    public MelonPreferences_Entry<int> MyIntOption;
    
    public override void OnInitializeMelon()
    {
        _category = MelonPreferences.CreateCategory("MyMod", "MyMod");
        MyBoolOption = _category.CreateEntry("MyBool", false, "布尔选项");
        MyFloatOption = _category.CreateEntry("MyFloat", 1.0f, "浮点选项");
        MyIntOption = _category.CreateEntry("MyInt", 10, "整数选项");
    }
}
```

### 保存配置
```csharp
MyBoolOption.Value = true;
_category?.SaveToFile();
```

## 4. IMGUI 开发

### 基础窗口
```csharp
public Rect WindowRect = new Rect(50, 50, 400, 300);
public bool ShowWindow = false;

public override void OnGUI()
{
    if (!ShowWindow) return;
    
    // 设置字体大小
    GUI.skin.label.fontSize = 16;
    GUI.skin.button.fontSize = 16;
    GUI.skin.toggle.fontSize = 16;
    
    WindowRect = GUILayout.Window(0, WindowRect, DrawWindow, "窗口标题");
}

private void DrawWindow(int id)
{
    GUILayout.Label("标签文本");
    
    if (GUILayout.Button("按钮"))
    {
        // 点击事件
    }
    
    bool toggle = GUILayout.Toggle(false, "开关");
    
    GUILayout.BeginHorizontal();
    GUILayout.Label("滑动条:");
    float slider = GUILayout.HorizontalSlider(0.5f, 0f, 1f, GUILayout.Width(200));
    GUILayout.EndHorizontal();
    
    // 滚动视图
    _scrollPos = GUILayout.BeginScrollView(_scrollPos);
    // 内容...
    GUILayout.EndScrollView();
    
    GUI.DragWindow();  // 允许拖动窗口
}
```

### 布局技巧
```csharp
// 垂直布局
GUILayout.BeginVertical("Box");  // "Box" 添加边框
GUILayout.Label("内容");
GUILayout.EndVertical();

// 水平布局
GUILayout.BeginHorizontal();
GUILayout.Label("标签:", GUILayout.Width(80));
GUILayout.TextField("输入框", GUILayout.Width(200));
GUILayout.EndHorizontal();

// 弹性空间
GUILayout.FlexibleSpace();  // 填充剩余空间
```

### 窗口缩放
```csharp
public override void OnGUI()
{
    var scale = WindowScaling.Value;
    GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3(scale, scale, 1));
    
    // 设置缩放后的字体
    GUI.skin.label.fontSize = (int)(16 * scale);
}
```

## 5. UGUI 开发

### 获取UI组件
```csharp
var uiController = SomeUIController.Instance;
var panel = uiController?.uiPanel;
var button = panel?.transform?.Find("ButtonPath")?.GetComponent<Button>();
var text = panel?.transform?.Find("TextPath")?.GetComponent<Text>();
```

### 创建UI元素
```csharp
// 实例化预制体
var newObj = GameObject.Instantiate(prefab, parent.transform);
newObj.SetActive(true);

// 添加点击事件
var button = newObj.GetComponent<Button>();
button.onClick.AddListener(() => {
    // 点击事件
});

// 修改文本
var text = newObj.transform.Find("Text")?.GetComponent<Text>();
if (text != null) text.text = "新文本";
```

### 刷新UI显示
```csharp
// 有时文本不显示，需要刷新
text.gameObject.SetActive(false);
text.gameObject.SetActive(true);
```

## 6. 常用游戏类查找

### 查找单例
```csharp
GameController.Instance        // 游戏主控制器
GameDataController.Instance    // 游戏数据控制器
PlotController.Instance        // 剧情控制器
HeroDetailController._instance // 英雄详情控制器
```

### 访问玩家数据
```csharp
var gc = GameController.Instance;
var player = gc.worldData.Player();        // 玩家角色
var force = player?.GetForce();            // 玩家门派
var forceLv = force?.forceLv ?? 0;         // 门派等级
var tempHeros = gc.worldData.TempHeros;    // 临时角色列表
```

### 生成角色/物品
```csharp
// 生成角色
var hero = gc.GenerateHeroData(name, heroID, forceID, forceLv, null, true, SexLimit.Female, false, false);

// 生成物品
var item = gc.GenerateBook(itemID, quality, forceLv, num, null);
```

## 7. 调试技巧

### 日志输出
```csharp
MelonLogger.Msg("普通日志");
MelonLogger.Warning("警告日志");
MelonLogger.Error("错误日志");
Plugin.LOG.Msg("使用实例日志");
```

### 按键检测
```csharp
public override void OnUpdate()
{
    if (Input.GetKeyDown(KeyCode.R))
    {
        // R键按下
    }
    
    if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKeyDown(KeyCode.E))
    {
        // Alt+E 组合键
    }
}
```

### 检查UI状态
```csharp
var uiController = SomeUIController.Instance;
if (uiController != null && uiController.uiPanel != null && uiController.uiPanel.activeInHierarchy)
{
    // UI已打开
}
```

## 8. 常见问题解决

### UI点击穿透
```csharp
// 检查鼠标是否在UI上
if (ShowWindow && WindowRect.Contains(Event.current.mousePosition))
{
    // 消费事件，防止穿透
    Event.current.Use();
}
```

### 空引用检查
```csharp
// 安全访问链
var result = controller?.data?.list?.FirstOrDefault(x => x.id == targetId);

// 使用 null 合并
var value = obj?.property ?? defaultValue;
```

### IL2CPP类型转换
```csharp
// Il2CppString 转 C# string
string csString = il2cppString;

// C# string 转 Il2CppString
Il2CppSystem.String il2cppString = (Il2CppSystem.String)csString;

// 或使用
IntPtr ptr = IL2CPP.ManagedStringToIl2Cpp(csString);
```
