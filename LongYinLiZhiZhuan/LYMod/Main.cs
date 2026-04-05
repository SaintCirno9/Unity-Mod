using System.Globalization;
using Il2Cpp;
using LYMod;
using LYMod.Helpers;
using LYMod.Patches;
using MelonLoader;
using MelonLoader.Utils;
using UnityEngine;

[assembly: MelonInfo(typeof(Plugin), ModConfig.ModName, ModConfig.ModVersion, ModConfig.ModAuthor)]
[assembly:MelonGame("TppStudio", "LongYinLiZhiZhuan")]
[assembly:MelonPlatformDomain(MelonPlatformDomainAttribute.CompatibleDomains.IL2CPP)]
namespace LYMod;

public class Plugin : MelonMod
{
    public static Plugin Instance = null!;
    public static readonly MelonLogger.Instance LOG = Melon<Plugin>.Logger;
    
    
    #region 配置项
    public MelonPreferences_Category MainCategory= null!;
    private MelonPreferences_Category _otherCategory= null!;
    public MelonPreferences_Entry<bool> TeachNewSkillToNpc = null!; // 传授满级
    public MelonPreferences_Entry<bool> TeachNpc= null!; // 指点满级
    public MelonPreferences_Entry<bool> Interaction= null!; // 无限交互
    public MelonPreferences_Entry<float> ReadBook = null!; // 读书经验倍率
    public MelonPreferences_Entry<bool> Explore= null!; // 探险耐力锁
    public MelonPreferences_Entry<bool> Cost0= null!; // 建筑升级资源消耗0
    public MelonPreferences_Entry<bool> RedBook= null!; // 必获得完本
    public MelonPreferences_Entry<float> RedBreak= null!; // 突破倍率
    public MelonPreferences_Entry<bool> RedTreasure= null!; // 必红色珍宝
    public MelonPreferences_Entry<float> Pzqh= null!; // 烹饪铸造炼药强化
    public MelonPreferences_Entry<bool> StealRate= null!; // 偷窃/偷学成功
    public MelonPreferences_Entry<bool> Hgbj= null!; // 好感不减
    public MelonPreferences_Entry<float> WeightRatio= null!; // 负重倍率
    public MelonPreferences_Entry<float> EquipmentWeight= null!; // 装备重量倍率
    public MelonPreferences_Entry<int> MaxSkillNum= null!;// 武学最佳修习数量倍数
    public MelonPreferences_Entry<float> StudyFightRate= null!; // 练功房学习战斗经验倍率
    public MelonPreferences_Entry<float> StudyUniqeRate= null!; // 闭关室学习理论经验倍率
    public MelonPreferences_Entry<float> ShopLvRate= null!; // 拍卖会品质倍率
    public MelonPreferences_Entry<int> ItemNum= null!; // 拍卖会物品数量
    public MelonPreferences_Entry<bool> CopyBookFlag= null!; //默写/抄书1天
    public MelonPreferences_Entry<bool> ReasearchFlag= null!; //门派研究一天
    public MelonPreferences_Entry<int> FavorTimes= null!; //好感倍数
    public MelonPreferences_Entry<int> MoneyTimes= null!; //金钱倍数
    public MelonPreferences_Entry<bool> UpgradeDay1= null!; //门派升级一天
    public MelonPreferences_Entry<bool> JianBaoFlag= null!; //一眼鉴宝
    public MelonPreferences_Entry<float> LivingSkillExpRate= null!; //生活经验倍率
    public MelonPreferences_Entry<int> MaxLivingSkillExpTimes= null!; //生活潜力倍数
    public MelonPreferences_Entry<float> FavorMax= null!; //最大好感度
    public MelonPreferences_Entry<int> MaxSpeBuildingNum= null!; //最大特殊建筑数
    public MelonPreferences_Entry<bool> AutoJianBaoFlag= null!; //自动鉴宝
    public MelonPreferences_Entry<bool> TeachAnyNewSkill= null!; //传授任意技能
    public MelonPreferences_Entry<bool> RemoveAnySkill= null!; //遗忘任意技能
    private MelonPreferences_Entry<bool> _breakRollFlag= null!; //Roll开关
    public MelonPreferences_Entry<float> BattleChangeSkillFightRate= null!; //实战经验倍率
    public MelonPreferences_Entry<float> ZhongyuanLv= null!; //鬼市商店等级
    public MelonPreferences_Entry<float> ChanDaoRate= null!; //禅宗道法修行倍率
    public MelonPreferences_Entry<string> ForceSpeFunctions= null!; // 门派特性
    public MelonPreferences_Entry<float> PoisonRate= null!; // 淬毒倍率
    public MelonPreferences_Entry<bool> PoisonNumReduceFlag= null!; // 淬毒值消耗开关
    public MelonPreferences_Entry<bool> TimeFreezeFlag= null!; // 时间停止
    public MelonPreferences_Entry<bool> DrinkOneWinFlag= null!; // 斗酒一轮必胜
    public MelonPreferences_Entry<int> ExtraPopulationPerLevel= null!; // 客房每级额外人口
    public MelonPreferences_Entry<float> ExpRateMultiplier= null!; // 游戏难度经验倍率
    public MelonPreferences_Entry<bool> GoodTreasure= null!; // 珍宝品质修改当前等级全红
    public MelonPreferences_Entry<float> ForceContributionRate= null!; // 非本门派功绩倍率
    public MelonPreferences_Entry<bool> BattleSkipFlag= null!; // 跳过战斗
    public MelonPreferences_Entry<bool> BreakMaxLimitFlag= null!; // 突破潜力限制
    private MelonPreferences_Entry<bool> _breakMaxLimitLittleFlag= null!; // 突破潜力限制（轻微）
    public MelonPreferences_Entry<bool> RedQuality= null!; // 获得所有物品都是红品质
    public MelonPreferences_Entry<bool> NewGameTagNumFlag = null!; // 获得所有物品都是红品质
    public MelonPreferences_Entry<bool> AnyTagFlag = null!; // 天赋无视要求和前置
    public MelonPreferences_Entry<bool> NewGameAnyTagFlag = null!; // 新档天赋无视要求和前置

    
    
    private MelonPreferences_Entry<bool> _useModifier = null!; // 使用组合键
    private MelonPreferences_Entry<KeyCode> _key1 = null!; // 第一个键
    private MelonPreferences_Entry<KeyCode> _key2 = null!; // 第二个键
    public MelonPreferences_Entry<float> _windowScaling = null!; // 窗体缩放百分比
    
    #endregion
    
    // 其他数据
    private HeroData? _readedHeroData;
    public string BreakChoiceListStr = "";// 随机选择列表
    public bool BreakChoiceFlag;// 突破选择类型和数值修改
    public bool BreakFlag;// 突破指定类型和数值修改
    public string BreakType = "0";// 属性类别
    public string BreakValue = "5";// 属性数值
    public bool RedMaterial;//必定获得红材料
    public string MaterialAttr = "6=20;70=0.2;131=0.2;132=0.2";//材料属性
    public bool MaxAreaFlag; //是否仙霞初建存档地块最大化
    public bool MaxAreaFlag1; //是否需要城墙
    public static HashSet<int> BuildIds = new();// 选择修改倍数的建筑 
    
    
    // GUI状态
    private Vector2 _mainScrollPos;
    private const float Hight = 1000;
    private const int Width = 590;
    private Rect _mainWindowRect = new(50, 50, Width, Hight);
    private bool _showMainWindow;
    private readonly string[] _tabNames = { "功能开关", "属性ID", "门派特性" };
    private int _selectedTab;
    private bool _isCapturingMainWindowPointer;
    private static GUIStyle _windowStyle = null!;
    private static GUIStyle _titleBarStyle = null!;
    private static GUIStyle _closeButtonStyle = null!;
    private static bool _windowStyleInitialized;
        
        
    public override void OnInitializeMelon()
    {
        Instance = this;
        _otherCategory = MelonPreferences.CreateCategory("UIConfig", "UI配置");
        _otherCategory.SetFilePath(MelonEnvironment.UserDataDirectory + "\\LYModConfig.cfg");
        MainCategory = MelonPreferences.CreateCategory("LYModConfig", "功能配置");
        MainCategory.SetFilePath(MelonEnvironment.UserDataDirectory + "\\LYModConfig.cfg");
        
        #region 配置项
        _useModifier = _otherCategory.CreateEntry("_useModifier", true,  description: "使用组合键");
        _key1 = _otherCategory.CreateEntry("_key1", KeyCode.LeftAlt,  description: "键1");
        _key2 = _otherCategory.CreateEntry("_key2", KeyCode.E,  description: "键2");
        _windowScaling = _otherCategory.CreateEntry("WindowScaling", 1.0f,  description: "窗体缩放百分比");
        
        StudyFightRate = MainCategory.CreateEntry("studyFightRate", 1.0f,  description: "练功房学习战斗经验倍率");
        StudyUniqeRate = MainCategory.CreateEntry("studyUniqeRate", 1.0f,  description: "闭关室学习理论经验倍率");
        ReadBook = MainCategory.CreateEntry("readBookRate", 1.0f,  description: "读书倍率");
        RedBreak = MainCategory.CreateEntry("redBreakRate",1.0f,  description: "突破倍率");
        Pzqh = MainCategory.CreateEntry("pzlRate", 1.0f,  description: "烹饪铸造炼药倍率");
        WeightRatio = MainCategory.CreateEntry("weightRatio", 1.0f,  description: "物品负重清零");
        EquipmentWeight = MainCategory.CreateEntry("equipmentWeight", 1.0f, description: "装备负重清零");
        MaxSkillNum = MainCategory.CreateEntry("maxSkillNum", 1,  description: "武学最佳修习数量倍数");
        ShopLvRate = MainCategory.CreateEntry("shopLvRate", 1.0f,  description: "拍卖会品质倍率");
        ItemNum = MainCategory.CreateEntry("itemNum", -1,  description: "拍卖会物品数量");
        FavorTimes = MainCategory.CreateEntry("favorTimes", 1,  description: "好感倍数");
        MoneyTimes = MainCategory.CreateEntry("MoneyTimes", 1,  description: "金钱倍数");
        LivingSkillExpRate = MainCategory.CreateEntry("LivingSkillExpRate", 1.0f, description:"生活经验倍率");
        MaxLivingSkillExpTimes = MainCategory.CreateEntry("MaxLivingSkillExpRate", 1, description:"生活潜力倍数");
        FavorMax = MainCategory.CreateEntry("FavorMax", 100.0f, description:"最大好感度");
        MaxSpeBuildingNum = MainCategory.CreateEntry("MaxSpeBuildingNum", 5, description:"特殊建筑限制数");
        BattleChangeSkillFightRate = MainCategory.CreateEntry("BattleChangeSkillFightRate", 1.0f, description:"实战经验倍率");
        ZhongyuanLv = MainCategory.CreateEntry("ZhongyuanLv", 13.5f, description:"鬼市商店等级");
        ChanDaoRate = MainCategory.CreateEntry("ChanDaoRate", 1.0f, description:"禅宗道法修行倍率");
        ForceSpeFunctions = MainCategory.CreateEntry("ForceSpeFunctions", "", description:"选择的门派特性");
        PoisonRate = MainCategory.CreateEntry("PoisonRate", 1.0f, description:"淬毒值倍率");
        ExtraPopulationPerLevel = MainCategory.CreateEntry("ExtraPopulationPerLevel", 1, description: "客房每级增加的额外弟子人口数量");
        ExpRateMultiplier = MainCategory.CreateEntry("ExpRateMultiplier", 1.0f, description:"游戏难度经验倍率,最高难度非本门经验倍率1.6（+60%）,这里默认2（+100%）");
        ForceContributionRate = MainCategory.CreateEntry("ForceContributionRate", 1.0f,description:"非本门功绩倍率");
        
        PoisonNumReduceFlag = MainCategory.CreateEntry("PoisonNumReduceFlag", false, description:"淬毒消耗开关");
        UpgradeDay1 = MainCategory.CreateEntry("upgrade1", false, description:"升级一天");
        CopyBookFlag = MainCategory.CreateEntry("copyBookFlag", false, description:"抄书一天");
        ReasearchFlag = MainCategory.CreateEntry("reaserchFlag", false, description:"研究一天");
        TeachNewSkillToNpc = MainCategory.CreateEntry("teachNewSkillToNPCFull",false,  description: "传授满级");
        TeachNpc = MainCategory.CreateEntry("teachNPCToFull",false,  description: "指点满级");
        Explore = MainCategory.CreateEntry("explore", false,  description: "探险耐力锁定");
        Interaction = MainCategory.CreateEntry("interaction", false,  description: "无限指点传授");
        RedBook = MainCategory.CreateEntry("redBook", false,  description: "必定获得完本");
        StealRate = MainCategory.CreateEntry("stealRate", false,  description: "偷窃偷师必成功");
        Hgbj = MainCategory.CreateEntry("hfbj", false,  description: "好感度不会减少");
        Cost0 = MainCategory.CreateEntry("cost0", false,  description: "建筑升级资源零消耗");
        RedTreasure = MainCategory.CreateEntry("redTreasure", false,  description: "必定是红色珍宝慎用");
        JianBaoFlag = MainCategory.CreateEntry("JianBaoFlag", false,  description: "一眼看穿宝物品质");
        AutoJianBaoFlag = MainCategory.CreateEntry("AutoJianBaoFlag", false,  description: "自动鉴宝");
        _breakRollFlag = MainCategory.CreateEntry("BreakRollFlag", false,  description: "Roll开关");
        TeachAnyNewSkill = MainCategory.CreateEntry("TeachAnyNewSkill", false,  description: "传授任意等级技能");
        RemoveAnySkill = MainCategory.CreateEntry("RemoveAnySkill", false,  description: "遗忘任意等级技能");
        TimeFreezeFlag = MainCategory.CreateEntry("TimeFreezeFlag", false,  description: "时间停止");
        DrinkOneWinFlag = MainCategory.CreateEntry("DrinkOneWinFlag", false,  description: "斗酒一轮必胜");
        GoodTreasure = MainCategory.CreateEntry("GoodTreasure", false,  description: "珍宝等级不变品质变红");
        BattleSkipFlag = MainCategory.CreateEntry("BattleSkipFlag", false,  description: "跳过战斗");
        BreakMaxLimitFlag = MainCategory.CreateEntry("BreakMaxLimitFlag", false,  description: "突破潜力限制");
        _breakMaxLimitLittleFlag = MainCategory.CreateEntry("BreakMaxLimitLittleFlag", false,  description: "突破潜力限制（轻微）");
        RedQuality = MainCategory.CreateEntry("RedQuality", false,  description: "获得所有物品品质都是红");
        NewGameTagNumFlag = MainCategory.CreateEntry("NewGameTagNumFlag", false,  description: "新档天赋点数999");
        AnyTagFlag = MainCategory.CreateEntry("AnyTagFlag", false,  description: "天赋无视前置要求");
        NewGameAnyTagFlag = MainCategory.CreateEntry("NewGameAnyTagFlag", false,  description: "新档天赋无视前置要求");
        #endregion
      
        var harmony = new HarmonyLib.Harmony("LYMod");
        harmony.PatchAll(typeof(ReadBookControllerPatches));
        harmony.PatchAll(typeof(ItemListDataPatches));
        harmony.PatchAll(typeof(BreakThroughControllerPatches));
        harmony.PatchAll(typeof(ForceDataPatches));
        harmony.PatchAll(typeof(ExploreControllerPatches));
        harmony.PatchAll(typeof(PlotControllerPatches));
        harmony.PatchAll(typeof(CraftingPatches));
        harmony.PatchAll(typeof(HeroDataPatch));
        harmony.PatchAll(typeof(StudySkillPatches));
        harmony.PatchAll(typeof(BookWriterUIControllerPatches));
        harmony.PatchAll(typeof(BreakThroughChoiceControllerPatch));
        harmony.PatchAll(typeof(AreaBuildingDataPatches));
        harmony.PatchAll(typeof(HeroTagIconControllerPatches));
        harmony.PatchAll(typeof(LivingSkillPatches));
        harmony.PatchAll(typeof(IdentifyMatchControllerPatches));
        harmony.PatchAll(typeof(ChooseControllerPatches));
        harmony.PatchAll(typeof(MeditationDataPatches));
        harmony.PatchAll(typeof(PoisonPatches));
        harmony.PatchAll(typeof(TimeDataPatches));
        harmony.PatchAll(typeof(TestPatches));
        harmony.PatchAll(typeof(UIPatches));
        MelonLogger.Msg("LYMod is loaded!左alt + e 打开窗体!");
        
        var allMods = MelonBase.RegisteredMelons.OfType<MelonMod>();
        foreach (var mod in allMods)
        {
            if (mod.Info.Name == "Refresh Auction") RollHelper.IsHaveAucRoll = false;
            if (mod.Info.Name == "SelfHouseLover") RollHelper.IsRecruitReRoll = false;
        }
        
        OtherHelper.ChaneMaxNum();
    }

    private bool IsOpenWindowTriggered()
    {
        if (!_useModifier.Value)
        {
            return Input.GetKeyDown(_key1.Value);
        }
        return Input.GetKey(_key1.Value) && Input.GetKeyDown(_key2.Value);
    }
    public override void OnUpdate()
    {
        // Alt+E 切换主面板
        if (IsOpenWindowTriggered())
        {
            _showMainWindow = !_showMainWindow;
            _isCapturingMainWindowPointer = false;
            
            UIBuilderExtensions.RefreshForceList();
            if (_showMainWindow)
            {
                HeroHelper.TryReadNowHero(out _readedHeroData);
            }
            OtherHelper.ChaneMaxNum();
        }

        // 按 R 重刷几个可复用的 Roll 场景
        if (Input.GetKeyDown(KeyCode.R) && _breakRollFlag.Value)
        {
            RollHelper.TryBreakThoughtRoll();
            RollHelper.TryCraftRoll();
            RollHelper.TryAuctionRoll();
            RollHelper.TryZhongyuanRoll();
            RollHelper.TryRefreshRecruitList();
        }
        
        if (BreakMaxLimitFlag.Value || _breakMaxLimitLittleFlag.Value)
        {
            GlobalData.HeroMaxAttriNum = 999;
            GlobalData.HeroMaxFightSkillNum = 999;
            GlobalData.HeroMaxLivingSkillNum = 999;
        }
        else
        {
            GlobalData.HeroMaxAttriNum = 120;
            GlobalData.HeroMaxFightSkillNum = 120;
            GlobalData.HeroMaxLivingSkillNum = 100;
        }
       
        
        // if (Input.GetKeyDown(KeyCode.F6))
        // {
        //     var buildingDataBases = GameDataController.Instance.buildingDataBase;
        //     foreach (var buildingDataBase in buildingDataBases)
        //     {
        //         LOG.Msg($"name: {buildingDataBase.name}");
        //         
        //         int i = 0;
        //         
        //         var a = buildingDataBase.GetBuildingSpeAddData(i);
        //         var b = a.forceSpeAddData;
        //         foreach (var c in b)
        //         {
        //             LOG.Msg($"name:{buildingDataBase.name}, c.key: {c.Key},lv:{i} c.value: {c.Value}");
        //         }
        //     }
        // }
    }
 
    
    public override void OnGUI()
    {
        var scale = _windowScaling.Value;
        var baseFontSize = 18;
        var scaledFontSize = (int)(baseFontSize * scale);
        
        GUI.skin.label.fontSize = scaledFontSize;
        GUI.skin.button.fontSize = scaledFontSize;
        GUI.skin.toggle.fontSize = scaledFontSize;
        GUI.skin.textField.fontSize = scaledFontSize;

        if (!_showMainWindow)
        {
            _isCapturingMainWindowPointer = false;
            return;
        }
        

        var currentEvent = Event.current;
        // IMGUI 先决定这次鼠标事件是否由 MOD 窗口接管
        var shouldConsumePointerEvent = UpdateMainWindowPointerCapture(currentEvent);
        var scaledWidth = Width * scale;
        var scaledHeight = Hight * scale;
        _mainWindowRect = new Rect(_mainWindowRect.x, _mainWindowRect.y, scaledWidth, scaledHeight);
        _mainWindowRect = GUI.ModalWindow(0, _mainWindowRect, (GUI.WindowFunction)DrawMainWindow, "");

        if (shouldConsumePointerEvent && currentEvent != null)
        {
            // 只消费当前已由 IMGUI 面板接管的鼠标事件，键盘不在这里处理
            currentEvent.Use();
        }
    }

    #region  防止点穿窗体的方法
    
    public bool ShouldBlockGamePointerInput()
    {
        return _showMainWindow && (_isCapturingMainWindowPointer || IsPointerInsideMainWindow(ToGuiMousePosition(Input.mousePosition)));
    }

    private static Vector2 ToGuiMousePosition(Vector3 mousePosition)
    {
        return new Vector2(mousePosition.x, Screen.height - mousePosition.y);
    }

    private bool IsPointerInsideMainWindow(Vector2 guiMousePosition)
    {
        return _showMainWindow && _mainWindowRect.Contains(guiMousePosition);
    }

    private bool UpdateMainWindowPointerCapture(Event? currentEvent)
    {
        if (!_showMainWindow)
        {
            _isCapturingMainWindowPointer = false;
            return false;
        }

        if (currentEvent == null)
        {
            return false;
        }

        var isInsideWindow = IsPointerInsideMainWindow(currentEvent.mousePosition);
        switch (currentEvent.type)
        {
            case EventType.MouseDown:
                // 在窗内按下后，直到 MouseUp 前都持续认为由窗口接管
                if (isInsideWindow)
                {
                    _isCapturingMainWindowPointer = true;
                    return true;
                }
                return false;
            case EventType.MouseDrag:
                if (_isCapturingMainWindowPointer || isInsideWindow)
                {
                    _isCapturingMainWindowPointer = true;
                    return true;
                }
                return false;
            case EventType.MouseMove:
            case EventType.ContextClick:
            case EventType.ScrollWheel:
                return _isCapturingMainWindowPointer || isInsideWindow;
            case EventType.MouseUp:
            {
                var shouldBlock = _isCapturingMainWindowPointer || isInsideWindow;
                _isCapturingMainWindowPointer = false;
                return shouldBlock;
            }
            default:
                return false;
        }
    }
    #endregion
    
    private void InitWindowStyle()
    {
        if (_windowStyleInitialized && _windowStyle.normal?.background != null) return;
        
        var bgTex = new Texture2D(2, 2);
        var pixels = new Color[4];
        for (int i = 0; i < 4; i++)
            pixels[i] = new Color(0.1f, 0.1f, 0.1f, 0.95f);
        bgTex.SetPixels(pixels);
        bgTex.Apply();
        
        _windowStyle = new GUIStyle(GUI.skin.window)
        {
            normal = { background = bgTex, textColor = Color.white }
        };
        
        _titleBarStyle = new GUIStyle(GUI.skin.box)
        {
            normal = { background = null, textColor = Color.white },
            fontSize = 18,
            fontStyle = FontStyle.Bold,
            alignment = TextAnchor.MiddleCenter,
            padding = new RectOffset(5, 5, 5, 5),
            margin = new RectOffset(0, 0, 0, 0)
        };
        
        _closeButtonStyle = new GUIStyle(GUI.skin.button)
        {
            fontSize = 15,
            fontStyle = FontStyle.Bold,
            padding = new RectOffset(5, 5, 2, 2),
            margin = new RectOffset(0, 0, 0, 0)
        };
        
        _windowStyleInitialized = true;
    }
   
    private void DrawMainWindow(int windowId)
    {
        var scale = _windowScaling.Value;
        var scaledWidth = (Width - 30) * scale;
        var scaledHeight = (Hight * scale) - (70 * scale);
       
        InitWindowStyle();
        GUI.Box(new Rect(0, 0, _mainWindowRect.width, _mainWindowRect.height), "", _windowStyle);
        
        var titleBarHeight = 30 * scale;
        var titleBarRect = new Rect(0, 0, _mainWindowRect.width, titleBarHeight);
        
        GUI.Box(titleBarRect, "", _titleBarStyle);
        
        var titleText = $"LYMod {ModConfig.ModVersion}";
        var titleSize = _titleBarStyle.CalcSize(new GUIContent(titleText));
        var titlePos = new Vector2((_mainWindowRect.width - titleSize.x) / 2, (titleBarHeight - titleSize.y) / 2);
        GUI.Label(new Rect(titlePos.x, titlePos.y, titleSize.x, titleSize.y), titleText, _titleBarStyle);
        
        var closeButtonSize = new Vector2(50 * scale, 20 * scale);
        var closeButtonRect = new Rect(_mainWindowRect.width - closeButtonSize.x - 5 * scale, 
                                       (titleBarHeight - closeButtonSize.y) / 2, 
                                       closeButtonSize.x, 
                                       closeButtonSize.y);
        if (GUI.Button(closeButtonRect, "✕", _closeButtonStyle))
        {
            _showMainWindow = false;
        }
        
        GUI.DragWindow(titleBarRect);
        
        GUILayout.Space(10 * scale);
        // 标签页
        GUILayout.BeginHorizontal();
        for (var i = 0; i < _tabNames.Length; i++)
        {
            if (GUILayout.Toggle(_selectedTab == i, _tabNames[i], "Button")) _selectedTab = i;
            GUILayout.Space(10 * scale);
        }

        GUILayout.EndHorizontal();
        // 主滚动区域
        _mainScrollPos = GUILayout.BeginScrollView(_mainScrollPos, GUILayout.Width(scaledWidth), GUILayout.Height(scaledHeight));
        
        // 根据标签页绘制内容
        switch (_selectedTab)
        {
            case 0: // 功能开关
                DrawMainTab();
                break;
            case 1: // 属性ID
                OtherElement.Label();
                break;
            case 2: // 门派特性
                OtherElement.ForceSpeFunction();
                break;
        }

        GUILayout.EndScrollView();
    }
    
    private void DrawMainTab()
    {
        var scale = _windowScaling.Value;
        var builder = UIHelper.CreateBuilder(scale);

        builder.AddButtonRow("重置所有", OtherHelper.ResetAllMainConfig, 100);
        
        #region 人物相关
        builder.BeginFoldout("人物相关").Space(10)
            .BeginHorizontal()
            .AddButton("读取人物", () =>
            {
                HeroHelper.TryReadNowHero(out _readedHeroData);
            }, width:100)
            .AddButton("刷新玩家月限制", HeroHelper.ResetWorldDataLimits, 175)
            .AddButton("解锁所有服装", HeroHelper.UnlockSkins,150)
            .EndHorizontal().Space(5)
            .BeginHorizontal()
            .AddButton("友人/结义/情侣上限99", () =>
            {
                GlobalData.MaxLoverNum = 99;
                GlobalData.MaxFriendNum = 99;
                GlobalData.MaxBrotherNum = 99;
            }, 220)
            .EndHorizontal()
            .BeginHorizontal()
            .AddInfoRow(60,
                new InfoItem("ID：", _readedHeroData?.heroID),
                new InfoItem("姓名：", _readedHeroData?.heroName),
                new InfoItem("年龄：", _readedHeroData?.age)
            )
            .AddInfoRow(60, new InfoItem("天赋：", GlobalData.TalentText[_readedHeroData?.talent ?? 0]))
           .AddButton("+", () =>
            {
                if (_readedHeroData != null && _readedHeroData.talent != 4) _readedHeroData.talent += 1;
            })
            .EndHorizontal()
            .BeginHorizontal()
            .AddLabel("天赋点数：",100).AddLabel(_readedHeroData?.heroTagPoint.ToString(CultureInfo.InvariantCulture) ?? "")
            .AddButton("+100", () =>
            {
                _readedHeroData?.ChangeTagPoint(100,  true);
            }, 60)
            .EndHorizontal()
            .AddAutoSave("无前置天赋要求", AnyTagFlag, labelWidth:150)
            .AddAutoSaveRow("突破潜力限制(轻微)",_breakMaxLimitLittleFlag,  "突破潜力限制(无限制)",BreakMaxLimitFlag)
            .AddLabelRow("装备马的数据:", 125)
            .BeginHorizontal()
            .AddLinkedFloat("速度：", () => _readedHeroData?.horse?.horseData.speed ?? 0f, val =>
            {
                if (_readedHeroData?.horse != null)_readedHeroData.horse.horseData.speed = val;
            }, "hs_speed",60,50)
            .AddLinkedFloat("冲刺：", () => _readedHeroData?.horse?.horseData.sprint ?? 0f, val =>
            {
                if (_readedHeroData?.horse != null)_readedHeroData.horse.horseData.sprint = val;
            }, "hs_sprint",60,50)
            .AddLinkedFloat("耐力：", () => _readedHeroData?.horse?.horseData.power ?? 0f, val =>
            {
                if (_readedHeroData?.horse != null)_readedHeroData.horse.horseData.power = val;
            }, "hs_power",60,50)
            .AddLinkedFloat("坚韧：", () => _readedHeroData?.horse?.horseData.resist ?? 0f, val =>
            {
                if (_readedHeroData?.horse != null)_readedHeroData.horse.horseData.resist = val;
            }, "hs_resist",60,50)
            .EndHorizontal()
            .AddLabelRow("装备马鞍数据:", 125)
            .BeginHorizontal()
            .AddLinkedFloat("速度：", () => _readedHeroData?.horseArmor?.horseData.speed ?? 0f, val =>
            {
                if (_readedHeroData?.horseArmor != null)_readedHeroData.horseArmor.horseData.speed = val;
            }, "ha_speed",60,50)
            .AddLinkedFloat("冲刺：", () => _readedHeroData?.horseArmor?.horseData.sprint ?? 0f, val =>
            {
                if (_readedHeroData?.horseArmor != null)_readedHeroData.horseArmor.horseData.sprint = val;
            }, "ha_sprint",60,50)
            .AddLinkedFloat("耐力：", () => _readedHeroData?.horseArmor?.horseData.power ?? 0f, val =>
            {
                if (_readedHeroData?.horseArmor != null)_readedHeroData.horseArmor.horseData.power = val;
            }, "ha_power",60,50)
            .AddLinkedFloat("坚韧：", () => _readedHeroData?.horseArmor?.horseData.resist ?? 0f, val =>
            {
                if (_readedHeroData?.horseArmor != null)_readedHeroData.horseArmor.horseData.resist = val;
            }, "ha_resist",60,50)
            .EndHorizontal()
            .EndFoldout();
        #endregion

        builder.BeginFoldout("个人相关").Space(10)
            .AddAutoSaveRow("练功倍率:", StudyFightRate, "闭关倍率:",  StudyUniqeRate)
            .AddAutoSaveRow("实战倍率:", BattleChangeSkillFightRate,  "读书倍率:", ReadBook)
            .AddAutoSaveRow("突破倍率:", RedBreak, "抄书一天", CopyBookFlag)
            .AddAutoSaveRow("获得金钱倍数",MoneyTimes, "武学修习倍数",MaxSkillNum)
            .AddAutoSaveRow("生活经验倍率", LivingSkillExpRate, "生活潜力倍数", MaxLivingSkillExpTimes)
            .AddAutoSave("莫高窟遗忘任意技能", RemoveAnySkill)
            
            .AddLabelRow("突破属性修改方案1：")
            .BeginHorizontal()
            .AddButton("获取当前武学突破随机值", () =>
            {
                var btc = BreakThroughController._instance;
                if (btc != null)
                {
                    var kfsld = btc.targetSkill;
                    var list = kfsld.GetBreakThroughAvailableChoice();
                    BreakChoiceListStr = string.Join(",", list.ToArray());
                }
            }, 275)
            .EndHorizontal()
            .BeginHorizontal().AddLinkedString("随机值：", ()=> BreakChoiceListStr,val => BreakChoiceListStr = val, "bcls", labelWidth: 75, inputWidth: 225).EndHorizontal()
            .BeginHorizontal().AddLinkedBool("指定随机值：", ()=>BreakChoiceFlag, val => BreakChoiceFlag = val, labelWidth:110).EndHorizontal()
            .AddLabelRow("突破属性修改方案2：")
            .BeginHorizontal()
            .AddLinkedString("指定属性类别：", ()=>BreakType, val => BreakType = val, "bt",labelWidth:130, inputWidth:40)
            .Space(10)
            .AddLinkedString("指定属性的值：", ()=>BreakValue, val => BreakValue = val, "bv",labelWidth:130, inputWidth:40)
            .EndHorizontal()
            .BeginHorizontal().AddLinkedBool("突破指定类型和值：",()=>BreakFlag, val => BreakFlag = val, labelWidth:170).EndHorizontal()
            .EndFoldout();
        
        builder.BeginFoldout("门派相关").Space(10)
            .AddButtonRow("刷新门派月限制", ForceHelper.ResetForceLimits)
            .AddAutoSaveRow("研究一天",ReasearchFlag, "禅道修行倍率:", ChanDaoRate)
            .AddAutoSaveRow("建筑资源零消耗",Cost0, "建造升级移动拆除1天:", UpgradeDay1)
            .AddAutoSaveRow("非本门功绩倍率:", ForceContributionRate,"特殊建筑上限", MaxSpeBuildingNum)
            .AddAutoSave("客房人口倍数:", ExtraPopulationPerLevel)
            .EndFoldout();
        
        builder.BeginFoldout("交互相关").Space(10)
            .AddAutoSaveRow("好感不减",Hgbj,"偷窃偷师必成功:", StealRate)
            .AddAutoSaveRow("好感倍数",FavorTimes,"好感上限:", FavorMax)
            .AddAutoSaveRow("指点满级",TeachNpc,"传授满级:", TeachNewSkillToNpc)
            .AddAutoSaveRow("无限交互",Interaction,"传授任意技能:", TeachAnyNewSkill)
            .EndFoldout();
        
        builder.BeginFoldout("道具相关").Space(10)
            .AddAutoSaveRow("必定获得完本",RedBook,"一眼鉴宝:",JianBaoFlag)
            .AddAutoSaveRow("珍宝品质变红",GoodTreasure,"必定红色珍宝:", RedTreasure)
            .AddAutoSaveRow("物品负重倍率(0-1)",WeightRatio,"装备负重倍率(0-1):", EquipmentWeight)
            .AddAutoSaveRow("淬毒值倍率",PoisonRate,"淬毒不减:", PoisonNumReduceFlag)
            .AddAutoSaveRow("拍卖品质倍率",ShopLvRate,"拍卖物品数量:", ItemNum)
            .AddAutoSaveRow("烹饪铸造炼药倍率",Pzqh,"鬼市商店等级:", ZhongyuanLv)
            .AddAutoSave("获得物品时品质是红色", RedQuality, labelWidth:200)
            .BeginHorizontal()
            .AddLinkedBool("指定材料属性：",()=>RedMaterial, val => RedMaterial = val, labelWidth:130)
            .EndHorizontal()
            .BeginHorizontal()
            .AddLinkedString("红材料属性：", ()=>MaterialAttr, val => MaterialAttr = val, "ma",labelWidth:110, inputWidth:400)
            .EndHorizontal()
            .EndFoldout();
        
        builder.BeginFoldout("其他相关").Space(10)
            .AddAutoSaveRow("探险耐力锁定", Explore, "跳过战斗", BattleSkipFlag)
            .AddAutoSaveRow("按R键重新Roll", _breakRollFlag, "时间暂停", TimeFreezeFlag)
            .AddAutoSaveRow("自动鉴宝",AutoJianBaoFlag, "斗酒一回胜利", DrinkOneWinFlag)
            .AddAutoSave("难度经验倍率", ExpRateMultiplier)
            .AddSlider("窗体/字体缩放", _windowScaling,0.5f, 2.0f, _otherCategory, labelWidth:100, sliderWidth:200, useFixedLayout:true)
            .AddButtonRow("重置缩放", () =>
            {
                _windowScaling.Value = 1;
                _otherCategory.SaveToFile();
            })
            .EndFoldout();

        builder.BeginFoldout("新档相关").Space(10)
            .BeginHorizontal().AddButtonRow("新档人物属性点数999", () =>
            {
                var smc = StartMenuController._instance;
                if (smc == null) return;
                smc.leftAttriPoint = 999;
                smc.leftFightSkillPoint = 999;
                smc.leftLivingSkillPoint = 999;
            }, 225).EndHorizontal()
            .AddAutoSave("新档天赋点数999(选中后重启生效)", NewGameTagNumFlag, labelWidth:280)
            .AddAutoSave("新档天赋无视要求", NewGameAnyTagFlag, labelWidth:150)
            .BeginHorizontal()
            .AddLinkedBool("仙霞初建存档地块最大化：", ()=>MaxAreaFlag, val => MaxAreaFlag = val, labelWidth:220)
            .AddLinkedBool("需要城墙：", ()=>MaxAreaFlag1, val => MaxAreaFlag1 = val, labelWidth:95)
            .EndHorizontal()
            .EndFoldout();
        
       
    }
}

