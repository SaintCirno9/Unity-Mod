using System.Globalization;
using Il2Cpp;
using LYMod;
using MelonLoader;
using UnityEngine;
using Object = UnityEngine.Object;


[assembly: MelonInfo(typeof(Plugin), ModConstants.ModName, ModConstants.ModVersion, ModConstants.ModAuthor)]
[assembly:MelonGame("TppStudio", "LongYinLiZhiZhuan")]
[assembly:MelonPlatformDomain(MelonPlatformDomainAttribute.CompatibleDomains.IL2CPP)]
namespace LYMod;

public static class ModConstants
{
    public const string ModName = "LYMod";     // 插件名
    public const string ModVersion = "3.1.1";    // 版本号
    public const string ModAuthor = "Can";     // 作者
}

public class Plugin : MelonMod
{
    public static Plugin Instance;
    public static readonly MelonLogger.Instance LOG = Melon<Plugin>.Logger;
    
    // 配置项
    public MelonPreferences_Category? _mainCategory;
    public MelonPreferences_Entry<bool> _teachNewSkillToNPC; // 传授满级
    public MelonPreferences_Entry<bool> _teachNPC; // 指点满级
    public MelonPreferences_Entry<bool> _interaction; // 无限交互
    public MelonPreferences_Entry<float> _readBook; // 读书经验倍率
    public MelonPreferences_Entry<bool> _explore; // 探险耐力锁
    public MelonPreferences_Entry<bool> _cost0; // 建筑升级资源消耗0
    public MelonPreferences_Entry<bool> _redBook; // 必获得完本
    public MelonPreferences_Entry<float> _redBreak; // 突破倍率
    public MelonPreferences_Entry<bool> _redTreasure; // 必红色珍宝
    public MelonPreferences_Entry<float> _pzqh; // 烹饪铸造炼药强化
    public MelonPreferences_Entry<bool> _stealRate; // 偷窃/偷学成功
    public MelonPreferences_Entry<bool> _hgbj; // 好感不减
    public MelonPreferences_Entry<int> _leaveDay; // 离队时间99999
    public MelonPreferences_Entry<int> _tagMaxNum;//天赋最大数量
    public MelonPreferences_Entry<float> _weightRatio; // 负重倍率
    public MelonPreferences_Entry<float> _equipmentWeight; // 装备重量倍率
    public MelonPreferences_Entry<int> _maxSkillNum; // 武学最佳修习数量倍数
    public MelonPreferences_Entry<float> _studyFightRate; // 练功房学习战斗经验倍率
    public MelonPreferences_Entry<float> _studyUniqeRate; // 闭关室学习理论经验倍率
    public MelonPreferences_Entry<float> _shopLvRate; // 拍卖会品质倍率
    public MelonPreferences_Entry<int> _itemNum; // 拍卖会物品数量
    public MelonPreferences_Entry<bool> _copyBookFlag; //默写/抄书1天
    public MelonPreferences_Entry<bool> _reasearchFlag; //门派研究一天
    public MelonPreferences_Entry<int> _favorTimes; //好感倍数
    public MelonPreferences_Entry<int> MoneyTimes; //金钱倍数
    public MelonPreferences_Entry<bool> _upgradeDay1; //门派升级一天
    public MelonPreferences_Entry<bool> _playerOutForceContribution; //非本门功绩
    public MelonPreferences_Entry<bool> JianBaoFlag; //一眼鉴宝
    public MelonPreferences_Entry<bool> MaxBreak; //测试项-上限突破到999
    public MelonPreferences_Entry<float> MaxBreakValue; //测试项-玩家上限突破值
    public MelonPreferences_Entry<bool> NpcMaxBreak; // 测试项-NPC上限突破到999
    public MelonPreferences_Entry<float> NpcMaxBreakValue; //测试项-Npc上限突破值
    public MelonPreferences_Entry<float> LivingSkillExpRate; //生活经验倍率
    public MelonPreferences_Entry<int> MaxLivingSkillExpTimes; //生活潜力倍数
    public MelonPreferences_Entry<float> FavorMax; //最大好感度
    public MelonPreferences_Entry<int> MaxSpeBuildingNum; //最大特殊建筑数
    public MelonPreferences_Entry<bool> AutoJianBaoFlag; //自动鉴宝
    public MelonPreferences_Entry<bool> TeachAnyNewSkill; //传授任意技能
    public MelonPreferences_Entry<bool> RemoveAnySkill; //遗忘任意技能
    private MelonPreferences_Entry<bool> _breakRollFlag; //Roll开关
    public MelonPreferences_Entry<float> BattleChangeSkillFightRate; //实战经验倍率
    private static MelonPreferences_Entry<float> ZhongyuanLy; //鬼市商店等级
    public MelonPreferences_Entry<float> ChanDaoRate; //禅宗道法修行倍率
    public MelonPreferences_Entry<string> ForceSpeFunctions; // 门派特性
    public MelonPreferences_Entry<float> PoisonRate; // 淬毒倍率
    public MelonPreferences_Entry<float> PoisonReduceRate; // 淬毒消耗倍率
    // public MelonPreferences_Entry<bool> CanControlableFlag; // 操作别人的装备和武学
    public MelonPreferences_Entry<bool> TimeFreezeFlag; // 时间停止
    public MelonPreferences_Entry<bool> EffeminateManFlag; // 女性恋爱自由
    public MelonPreferences_Entry<bool> DrinkOneWinFlag; // 斗酒一轮必胜
    public MelonPreferences_Entry<float> WindowScaling; // 窗体缩放百分比
    
    private static bool _isHaveAucRoll = false; 
    
    // GUI状态
    private Vector2 mainScrollPos;
    private const float Hight = 1000;
    private const int Width = 590;
    public Rect MainWindowRect = new(50, 100, Width, Hight);
    public bool ShowMainWindow = false;
    private readonly string[] tabNames = { "功能开关", "测试", "属性ID", "门派特性" };
    private int selectedTab;
    
    
    public override void OnInitializeMelon()
    {
        Instance = this;
        _mainCategory = MelonPreferences.CreateCategory("LYModConfig", "LYModConfig");
        
        _studyFightRate = _mainCategory.CreateEntry<float>("studyFightRate", 1,  description: "练功房学习战斗经验倍率");
        _studyUniqeRate = _mainCategory.CreateEntry<float>("studyUniqeRate", 1,  description: "闭关室学习理论经验倍率");
        _readBook = _mainCategory.CreateEntry<float>("readBookRate", 1,  description: "读书倍率");
        _redBreak = _mainCategory.CreateEntry<float>("redBreakRate",1,  description: "突破倍率");
        _leaveDay = _mainCategory.CreateEntry("leaveDay", 30,  description: "队友离队天数");
        _tagMaxNum = _mainCategory.CreateEntry("tagMaxNum",15,  description: "天赋最大数量");
        _pzqh = _mainCategory.CreateEntry<float>("pzlRate", 1,  description: "烹饪铸造炼药倍率");
        _weightRatio = _mainCategory.CreateEntry<float>("weightRatio", 1,  description: "物品负重清零");
        _equipmentWeight = _mainCategory.CreateEntry<float>("equipmentWeight", 1,  description: "装备负重清零");
        _maxSkillNum = _mainCategory.CreateEntry("maxSkillNum", 1,  description: "武学最佳修习数量倍数");
        _shopLvRate = _mainCategory.CreateEntry<float>("shopLvRate", 1,  description: "拍卖会品质倍率");
        _itemNum = _mainCategory.CreateEntry("itemNum", -1,  description: "拍卖会物品数量");
        _favorTimes = _mainCategory.CreateEntry("favorTimes", 1,  description: "好感倍数");
        MoneyTimes = _mainCategory.CreateEntry("MoneyTimes", 1,  description: "金钱倍数");
        LivingSkillExpRate = _mainCategory.CreateEntry<float>("LivingSkillExpRate", 1, "生活经验倍率");
        MaxLivingSkillExpTimes = _mainCategory.CreateEntry("MaxLivingSkillExpRate", 1, "生活潜力倍率");
        MaxBreakValue = _mainCategory.CreateEntry<float>("MaxBreakValue", 999, "玩家上限突破到的值");
        NpcMaxBreakValue = _mainCategory.CreateEntry<float>("NpcMaxBreakValue", 999, "NPC上限突破到的值");
        FavorMax = _mainCategory.CreateEntry<float>("FavorMax", 100, "最大好感度");
        MaxSpeBuildingNum = _mainCategory.CreateEntry("MaxSpeBuildingNum", 5, "特殊建筑限制数");
        BattleChangeSkillFightRate = _mainCategory.CreateEntry<float>("BattleChangeSkillFightRate", 1, "实战经验倍率");
        ZhongyuanLy = _mainCategory.CreateEntry("ZhongyuanLy", 13.5f, "鬼市商店等级");
        ChanDaoRate = _mainCategory.CreateEntry<float>("ChanDaoRate", 1, "禅宗道法修行倍率");
        ForceSpeFunctions = _mainCategory.CreateEntry("ForceSpeFunctions", "", "选择的门派特性");
        PoisonRate = _mainCategory.CreateEntry<float>("PoisonRate", 1, "淬毒值倍率");
        PoisonReduceRate = _mainCategory.CreateEntry("PoisonReduceRate", 0.8f, "淬毒消耗值");
        
        NpcMaxBreak = _mainCategory.CreateEntry("NpcMaxBreak", false, "NPC上限突破到999");
        MaxBreak = _mainCategory.CreateEntry("MaxBreak", false, "玩家上限突破到999");
        _playerOutForceContribution = _mainCategory.CreateEntry("playerOutForceContribution", false, "非本门功绩");
        _upgradeDay1 = _mainCategory.CreateEntry("upgrade1", false, "升级一天");
        _copyBookFlag = _mainCategory.CreateEntry("copyBookFlag", false, "抄书一天");
        _reasearchFlag = _mainCategory.CreateEntry("reaserchFlag", false, "研究一天");
        _teachNewSkillToNPC = _mainCategory.CreateEntry("teachNewSkillToNPCFull",false,  description: "传授满级");
        _teachNPC = _mainCategory.CreateEntry("teachNPCToFull",false,  description: "指点满级");
        _explore = _mainCategory.CreateEntry("explore", false,  description: "探险耐力锁定");
        _interaction = _mainCategory.CreateEntry("interaction", true,  description: "无限指点传授");
        _redBook = _mainCategory.CreateEntry("redBook", false,  description: "必定获得完本");
        _stealRate = _mainCategory.CreateEntry("stealRate", false,  description: "偷窃偷师必成功");
        _hgbj = _mainCategory.CreateEntry("hfbj", false,  description: "好感度不会减少");
        _cost0 = _mainCategory.CreateEntry("cost0", true,  description: "建筑升级资源零消耗");
        _redTreasure = _mainCategory.CreateEntry("redTreasure", false,  description: "必定是红色珍宝慎用");
        JianBaoFlag = _mainCategory.CreateEntry("JianBaoFlag", false,  description: "一眼看穿宝物品质");
        AutoJianBaoFlag = _mainCategory.CreateEntry("AutoJianBaoFlag", false,  description: "自动鉴宝");
        _breakRollFlag = _mainCategory.CreateEntry("BreakRollFlag", false,  description: "Roll开关");
        TeachAnyNewSkill = _mainCategory.CreateEntry("TeachAnyNewSkill", false,  description: "传授任意等级技能");
        RemoveAnySkill = _mainCategory.CreateEntry("RemoveAnySkill", false,  description: "遗忘任意等级技能");
        // CanControlableFlag = _mainCategory.CreateEntry("CanControlableFlag", false,  description: "是否可以操控别人的装备和武学");
        TimeFreezeFlag = _mainCategory.CreateEntry("TimeFreezeFlag", false,  description: "时间停止");
        EffeminateManFlag = _mainCategory.CreateEntry("EffeminateManFlag", false,  description: "女性恋爱自由");
        DrinkOneWinFlag = _mainCategory.CreateEntry("DrinkOneWinFlag", false,  description: "斗酒一轮必胜");
        WindowScaling = _mainCategory.CreateEntry<float>("WindowScaling", 1,  description: "窗体缩放百分比");
        
        
        var harmony = new HarmonyLib.Harmony("LYMod");
        harmony.PatchAll(typeof(ReadBookControllerPatches));
        harmony.PatchAll(typeof(ItemListDataPatches));
        harmony.PatchAll(typeof(BreakThroughControllerPatches));
        harmony.PatchAll(typeof(ForceDataPatches));
        harmony.PatchAll(typeof(ExploreControllerPatches));
        harmony.PatchAll(typeof(PlotControllerPatches));
        harmony.PatchAll(typeof(CraftingPatches));
        harmony.PatchAll(typeof(HeroDataPatch));
        harmony.PatchAll(typeof(GameControllerPatches));
        harmony.PatchAll(typeof(StudySkillPatches));
        harmony.PatchAll(typeof(BookWriterUIControllerPatches));
        harmony.PatchAll(typeof(BreakThroughChoiceControllerPatch));
        harmony.PatchAll(typeof(AreaBuildingDataPatches));
        harmony.PatchAll(typeof(CraftPoisonUIControllerPatches));
        harmony.PatchAll(typeof(HeroTagIconControllerPatches));
        harmony.PatchAll(typeof(LivingSkillPatches));
        harmony.PatchAll(typeof(IdentifyMatchControllerPatches));
        harmony.PatchAll(typeof(ChooseControllerPatches));
        harmony.PatchAll(typeof(MeditationDataPatches));
        harmony.PatchAll(typeof(PoisonPatches));
        harmony.PatchAll(typeof(TimeDataPatches));
        harmony.PatchAll(typeof(TestPatches));
        MelonLogger.Msg("LYMod is loaded!左alt + e 打开窗体!");
        
        var allMods = MelonBase.RegisteredMelons.OfType<MelonMod>();
        _isHaveAucRoll = allMods.Any(mod => mod.Info.Name != "Refresh Auction");
        
        ChaneMaxNum();
    }
   
    public override void OnUpdate()
    {
        // 左alt + e 打开窗体
        if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKeyDown(KeyCode.E))
        {
            ShowMainWindow = !ShowMainWindow;
            
            OtherElement.RefreshForceList();
            var hero = HeroDetailController._instance;
            if (hero != null && ShowMainWindow)
            {
                TestElement.ReadedHeroData = hero.nowShowHero;
                TestElement.LoadHorseData();
            }
        }

        // 按R开始Roll
        if (Input.GetKeyDown(KeyCode.R) && _breakRollFlag.Value)
        {
            TryBreakThoughtRoll();
            TryCraftRoll();
            TryAuctionRoll();
            TryZhongyuanRoll();
            TryRefreshRecruitList();
        }

       
        
        // if (Input.GetKeyDown(KeyCode.BackQuote))
        // {
        //     MelonLogger.Msg(string.Join(",", OtherElement.enabledForceIDs.Select(n => n.ToString())));
        //     MelonLogger.Msg(Instance.ForceSpeFunctions.Value);
        // }
    }
 
    
    public override void OnGUI()
    {
        var scale = WindowScaling.Value;
        var baseFontSize = 18;
        var scaledFontSize = (int)(baseFontSize * scale);
        
        GUI.skin.label.fontSize = scaledFontSize;
        GUI.skin.button.fontSize = scaledFontSize;
        GUI.skin.toggle.fontSize = scaledFontSize;
        GUI.skin.textField.fontSize = scaledFontSize;
        
        if (ShowMainWindow)
        {
            var scaledWidth = 590 * scale;
            var scaledHeight = Hight * scale;
            MainWindowRect = new Rect(MainWindowRect.x, MainWindowRect.y, scaledWidth, scaledHeight);
            MainWindowRect = GUI.ModalWindow(0, MainWindowRect, (GUI.WindowFunction)DrawMainWindow, "LYMod " + ModConstants.ModVersion);
        }
    }

    private void DrawMainWindow(int windowId)
    {
        var scale = WindowScaling.Value;
        var scaledWidth = 560 * scale;
        var scaledHeight = (Hight * scale) - (70 * scale);
       
        GUILayout.Space(5 * scale);
        // 标签页选择
        GUILayout.BeginHorizontal();
        for (var i = 0; i < tabNames.Length; i++)
        {
            if (GUILayout.Toggle(selectedTab == i, tabNames[i], "Button")) selectedTab = i;
            GUILayout.Space(10 * scale);
        }

        GUILayout.EndHorizontal();
       

        // 滚动区域
        mainScrollPos = GUILayout.BeginScrollView(mainScrollPos, GUILayout.Width(scaledWidth), GUILayout.Height(scaledHeight));

        
        
        // 根据选择的标签页绘制不同内容
        switch (selectedTab)
        {
            case 0: // 功能
                DrawMainTab();
                break;
            case 1:// 测试
                TestElement.TestTab(); 
                break;
            case 2: //属性id
                OtherElement.Label();
                break;
            case 3: //帮派特性选择
                OtherElement.ForceSpeFunction();
                break;
        }

        GUILayout.EndScrollView();
        // 启用窗口拖拽（仅标题栏区域）
        // GUI.DragWindow(new Rect(0, 0, Screen.width, 20));
        GUI.DragWindow(new Rect(0, 0, MainWindowRect.width, MainWindowRect.height));
    }

    private void DrawMainTab()
    {
        GUILayout.BeginVertical("Box");
        GUILayout.Space(10);

        GUILayout.BeginHorizontal();
        var copyFlag = GUILayout.Toggle(_copyBookFlag.Value, "抄书一天");
        if (copyFlag != _copyBookFlag.Value)
        {
            _copyBookFlag.Value = copyFlag;
            _mainCategory?.SaveToFile();
        }
        var reasearchFlag = GUILayout.Toggle(_reasearchFlag.Value, "研究一天");
        if (reasearchFlag != _reasearchFlag.Value)
        {
            _reasearchFlag.Value = reasearchFlag;
            _mainCategory?.SaveToFile();
        }
        GUILayout.EndHorizontal();
        GUILayout.Space(10);

        GUILayout.BeginHorizontal();
        var teachNpc = GUILayout.Toggle(_teachNPC.Value, "指点满级");
        if (teachNpc != _teachNPC.Value)
        {
            _teachNPC.Value = teachNpc;
            _mainCategory?.SaveToFile();
        }
        var teachNewSkillToNpc = GUILayout.Toggle(_teachNewSkillToNPC.Value, "传授满级");
        if (teachNewSkillToNpc != _teachNewSkillToNPC.Value)
        {
            _teachNewSkillToNPC.Value = teachNewSkillToNpc;
            _mainCategory?.SaveToFile();
        }
        GUILayout.EndHorizontal();
        GUILayout.Space(10);

        GUILayout.BeginHorizontal();
        var explore = GUILayout.Toggle(_explore.Value, "探险耐力锁定");
        if (explore != _explore.Value)
        {
            _explore.Value = explore;
            _mainCategory?.SaveToFile();
        }
        var interaction = GUILayout.Toggle(_interaction.Value, "真的无限交互");
        if (interaction != _interaction.Value)
        {
            _interaction.Value = interaction;
            _mainCategory?.SaveToFile();
        }
        GUILayout.EndHorizontal();
        GUILayout.Space(10);

        GUILayout.BeginHorizontal();
        var redbook = GUILayout.Toggle(_redBook.Value, "必定获得完本");
        if (redbook != _redBook.Value)
        {
            _redBook.Value = redbook;
            _mainCategory?.SaveToFile();
        }
        var redTreasure = GUILayout.Toggle(_redTreasure.Value, "必定红色珍宝");
        if (redTreasure != _redTreasure.Value)
        {
            _redTreasure.Value = redTreasure;
            _mainCategory?.SaveToFile();
        }
        GUILayout.EndHorizontal();
        GUILayout.Space(10);

        GUILayout.BeginHorizontal();
        var stealRate = GUILayout.Toggle(_stealRate.Value, "偷窃偷师必成功");
        if (stealRate != _stealRate.Value)
        {
            _stealRate.Value = stealRate;
            _mainCategory?.SaveToFile();
        }
        var hgbj = GUILayout.Toggle(_hgbj.Value, "好感度不会减少");
        if (hgbj != _hgbj.Value)
        {
            _hgbj.Value = hgbj;
            _mainCategory?.SaveToFile();
        }
        GUILayout.EndHorizontal();
        GUILayout.Space(10);

        GUILayout.BeginHorizontal();
        var cost0 = GUILayout.Toggle(_cost0.Value, "建筑升级资源零消耗");
        if (cost0 != _cost0.Value)
        {
            _cost0.Value = cost0;
            _mainCategory?.SaveToFile();
        }
        var upgradeDay1 = GUILayout.Toggle(_upgradeDay1.Value, "建筑升级移动拆除1天");
        if (upgradeDay1 != _upgradeDay1.Value)
        {
            _upgradeDay1.Value = upgradeDay1;
            _mainCategory?.SaveToFile();
        }
        GUILayout.EndHorizontal();
        GUILayout.Space(10);

        GUILayout.BeginHorizontal();
        var playerOutForceContribution = GUILayout.Toggle(_playerOutForceContribution.Value, "门派功绩9999");
        if (playerOutForceContribution != _playerOutForceContribution.Value)
        {
            _playerOutForceContribution.Value = playerOutForceContribution;
            _mainCategory?.SaveToFile();
        }
        var jianBaoBool = GUILayout.Toggle(JianBaoFlag.Value, "一眼鉴宝");
        if (jianBaoBool != JianBaoFlag.Value)
        {
            JianBaoFlag.Value = jianBaoBool;
            _mainCategory?.SaveToFile();
        }
        GUILayout.EndHorizontal();
        GUILayout.Space(10);

        GUILayout.BeginHorizontal();
        var autoJianBaoFlag = GUILayout.Toggle(AutoJianBaoFlag.Value, "卖艺自动鉴宝");
        if (autoJianBaoFlag != AutoJianBaoFlag.Value)
        {
            AutoJianBaoFlag.Value = autoJianBaoFlag;
            _mainCategory?.SaveToFile();
        }
        var breakRollFlag = GUILayout.Toggle(_breakRollFlag.Value, "按R键重新Roll");
        if (breakRollFlag != _breakRollFlag.Value)
        {
            _breakRollFlag.Value = breakRollFlag;
            _mainCategory?.SaveToFile();
        }
        GUILayout.EndHorizontal();
        GUILayout.Space(10);
        
        GUILayout.BeginHorizontal();
        var teachAnySkillFlag = GUILayout.Toggle(TeachAnyNewSkill.Value, "传授任意技能");
        if (teachAnySkillFlag != TeachAnyNewSkill.Value)
        {
            TeachAnyNewSkill.Value = teachAnySkillFlag;
            _mainCategory?.SaveToFile();
        }
        var removeAnySkillFlag = GUILayout.Toggle(RemoveAnySkill.Value, "遗忘任意技能");
        if (removeAnySkillFlag != RemoveAnySkill.Value)
        {
            RemoveAnySkill.Value = removeAnySkillFlag;
            _mainCategory?.SaveToFile();
        }
        GUILayout.EndHorizontal();
        GUILayout.Space(10);
        
        GUILayout.BeginHorizontal();
        // var canControlable = GUILayout.Toggle(CanControlableFlag.Value, "修改他人装备和武学");
        // if (canControlable != CanControlableFlag.Value)
        // {
        //     CanControlableFlag.Value = canControlable;
        //     _mainCategory?.SaveToFile();
        // }
        var effeminateMan = GUILayout.Toggle(EffeminateManFlag.Value, "女性恋爱自由");
        if (effeminateMan != EffeminateManFlag.Value)
        {
            EffeminateManFlag.Value = effeminateMan;
            _mainCategory?.SaveToFile();
        }
        var dringkFlag = GUILayout.Toggle(DrinkOneWinFlag.Value, "斗酒一回胜利");
        if (dringkFlag != DrinkOneWinFlag.Value)
        {
            DrinkOneWinFlag.Value = dringkFlag;
            _mainCategory?.SaveToFile();
        }  
        
        GUILayout.EndHorizontal();
        GUILayout.Space(10);
        
        GUILayout.BeginHorizontal();
        var timeFreeze = GUILayout.Toggle(TimeFreezeFlag.Value, "时间暂停");
        if (timeFreeze != TimeFreezeFlag.Value)
        {
            TimeFreezeFlag.Value = timeFreeze;
            _mainCategory?.SaveToFile();
        } 
        GUILayout.EndHorizontal();
        GUILayout.EndVertical();
        GUILayout.Space(10);

        GUILayout.BeginVertical("Box");
        GUILayout.BeginHorizontal();
        GUILayout.Label("获得好感倍数：");
        _favorTimesInput ??= Convert.ToString(_favorTimes.Value);
        _favorTimesInput = GUILayout.TextField(_favorTimesInput);
        GUILayout.Label("获得金钱倍数：");
        _moneyTimes ??= Convert.ToString(MoneyTimes.Value);
        _moneyTimes = GUILayout.TextField(_moneyTimes);
        GUILayout.EndHorizontal();
        GUILayout.Space(10);

        GUILayout.BeginHorizontal();
        GUILayout.Label("练功倍率：");
        _studyFightRateInput ??= Convert.ToString(_studyFightRate.Value, CultureInfo.InvariantCulture);
        _studyFightRateInput = GUILayout.TextField(_studyFightRateInput);
        GUILayout.Label("闭关倍率：");
        _studyUniqeRateInput ??= Convert.ToString(_studyUniqeRate.Value, CultureInfo.InvariantCulture);
        _studyUniqeRateInput = GUILayout.TextField(_studyUniqeRateInput);
        GUILayout.EndHorizontal(); 
        
        GUILayout.BeginHorizontal();
        GUILayout.Label("实战倍率：");
        _battleChangeSkillFightRateInput ??= Convert.ToString(BattleChangeSkillFightRate.Value, CultureInfo.InvariantCulture);
        _battleChangeSkillFightRateInput = GUILayout.TextField(_battleChangeSkillFightRateInput);
        GUILayout.Label("鬼市商店刷新等级：");
        _zhongyuanLvInput ??= Convert.ToString(ZhongyuanLy.Value, CultureInfo.InvariantCulture);
        _zhongyuanLvInput = GUILayout.TextField(_zhongyuanLvInput);
        GUILayout.EndHorizontal();

        GUILayout.Space(10);
        GUILayout.BeginHorizontal();
        GUILayout.Label("读书倍率：");
        _readBookRateInput ??= Convert.ToString(_readBook.Value, CultureInfo.InvariantCulture);
        _readBookRateInput = GUILayout.TextField(_readBookRateInput);
        GUILayout.Label("突破倍率：");
        _breakRateInput ??= Convert.ToString(_redBreak.Value, CultureInfo.InvariantCulture);
        _breakRateInput = GUILayout.TextField(_breakRateInput);
        GUILayout.EndHorizontal();
        GUILayout.Space(10);

        GUILayout.BeginHorizontal();
        GUILayout.Label("队友离队天数：");
        _leaveDayInput ??= Convert.ToString(_leaveDay.Value);
        _leaveDayInput = GUILayout.TextField(_leaveDayInput);
        GUILayout.Label("天赋最大数量：");
        _tagMaxNumInput ??= Convert.ToString(_tagMaxNum.Value);
        _tagMaxNumInput = GUILayout.TextField(_tagMaxNumInput);
        GUILayout.EndHorizontal();
        GUILayout.Space(10);

        GUILayout.BeginHorizontal();
        GUILayout.Label("物品负重倍率(0-1)：");
        _itemWeightRateInput ??= Convert.ToString(_weightRatio.Value, CultureInfo.InvariantCulture);
        _itemWeightRateInput = GUILayout.TextField(_itemWeightRateInput);
        GUILayout.Label("装备负重倍率(0-1)：");
        _equipWeightInput ??= Convert.ToString(_equipmentWeight.Value, CultureInfo.InvariantCulture);
        _equipWeightInput = GUILayout.TextField(_equipWeightInput);
        GUILayout.EndHorizontal();
        GUILayout.Space(10);

        GUILayout.BeginHorizontal();
        GUILayout.Label("拍卖会品质倍率：");
        _shopLvRateInput ??= Convert.ToString(_shopLvRate.Value, CultureInfo.InvariantCulture);
        _shopLvRateInput = GUILayout.TextField(_shopLvRateInput);
        GUILayout.Label("拍卖会物品数量：");
        _itemNumInput ??= Convert.ToString(_itemNum.Value);
        _itemNumInput = GUILayout.TextField(_itemNumInput);
        GUILayout.EndHorizontal();
        GUILayout.Space(10);

        GUILayout.BeginHorizontal();
        GUILayout.Label("武学修习数量倍数：");
        _maxSkillNumInput ??= Convert.ToString(_maxSkillNum.Value);
        _maxSkillNumInput = GUILayout.TextField(_maxSkillNumInput);
        GUILayout.Label("烹饪铸造炼药倍率：");
        _pzqhInput ??= Convert.ToString(_pzqh.Value, CultureInfo.InvariantCulture);
        _pzqhInput = GUILayout.TextField(_pzqhInput);
        GUILayout.EndHorizontal();
        GUILayout.Space(10);

        GUILayout.BeginHorizontal();
        GUILayout.Label("生活经验倍率：");
        _livingSkillExpRateInpute ??= Convert.ToString(LivingSkillExpRate.Value, CultureInfo.InvariantCulture);
        _livingSkillExpRateInpute = GUILayout.TextField(_livingSkillExpRateInpute);
        GUILayout.Label("生活潜力倍率：");
        _maxLivingSkillExpRateInpute ??= Convert.ToString(MaxLivingSkillExpTimes.Value);
        _maxLivingSkillExpRateInpute = GUILayout.TextField(_maxLivingSkillExpRateInpute);
        GUILayout.EndHorizontal();
        GUILayout.Space(10);

        GUILayout.BeginHorizontal();
        GUILayout.Label("好感度上限修改：");
        _favorMaxInput ??= Convert.ToString(FavorMax.Value, CultureInfo.InvariantCulture);
        _favorMaxInput = GUILayout.TextField(_favorMaxInput);
        GUILayout.Label("特殊建筑上限数：");
        _maxSpeBuildingNum ??= Convert.ToString(MaxSpeBuildingNum.Value);
        _maxSpeBuildingNum = GUILayout.TextField(_maxSpeBuildingNum);
        GUILayout.EndHorizontal();
        GUILayout.Space(10);
        
        GUILayout.BeginHorizontal();
        GUILayout.Label("淬毒值倍率：");
        _poisonRateInput ??= Convert.ToString(PoisonRate.Value, CultureInfo.InvariantCulture);
        _poisonRateInput = GUILayout.TextField(_poisonRateInput);
        GUILayout.Label("淬毒消耗率(0-0.8)：");
        _poisonReduceRateInput ??= Convert.ToString(PoisonReduceRate.Value, CultureInfo.InvariantCulture);
        _poisonReduceRateInput = GUILayout.TextField(_poisonReduceRateInput);
        GUILayout.EndHorizontal();
        GUILayout.Space(10);
        
        GUILayout.BeginHorizontal();
        GUILayout.Label("特殊建筑禅宗道法等修行倍率（等级好像没上限）：");
        _chanDaoRateInput ??= Convert.ToString(ChanDaoRate.Value, CultureInfo.InvariantCulture);
        _chanDaoRateInput =  GUILayout.TextField(_chanDaoRateInput);
        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal();
        GUILayout.Label("以上填写时务必确认后点击保存修改");
        if (GUILayout.Button("保存修改"))
        {
            PoisonRate.Value = float.Parse(_poisonRateInput);
            PoisonReduceRate.Value = float.Parse(_poisonReduceRateInput);
            ChanDaoRate.Value = float.Parse(_chanDaoRateInput);
            ZhongyuanLy.Value = float.Parse(_zhongyuanLvInput);
            BattleChangeSkillFightRate.Value = float.Parse(_battleChangeSkillFightRateInput);
            MaxSpeBuildingNum.Value = int.Parse(_maxSpeBuildingNum);
            FavorMax.Value = float.Parse(_favorMaxInput);
            MoneyTimes.Value = int.Parse(_moneyTimes);
            MaxLivingSkillExpTimes.Value = int.Parse(_maxLivingSkillExpRateInpute);
            LivingSkillExpRate.Value = float.Parse(_livingSkillExpRateInpute);
            _readBook.Value = float.Parse(_readBookRateInput);
            _redBreak.Value = float.Parse(_breakRateInput);
            _weightRatio.Value = float.Parse(_itemWeightRateInput);
            _equipmentWeight.Value = float.Parse(_equipWeightInput);
            _pzqh.Value = float.Parse(_pzqhInput);
            _leaveDay.Value = int.Parse(_leaveDayInput);
            _tagMaxNum.Value = int.Parse(_tagMaxNumInput);
            _studyFightRate.Value = float.Parse(_studyFightRateInput);
            _studyUniqeRate.Value = float.Parse(_studyUniqeRateInput);
            _shopLvRate.Value = int.Parse(_shopLvRateInput);
            _itemNum.Value = int.Parse(_itemNumInput);
            _maxSkillNum.Value = int.Parse(_maxSkillNumInput);
            _favorTimes.Value = int.Parse(_favorTimesInput);
            ChaneMaxNum();
            
            _mainCategory?.SaveToFile();
        }

        if (GUILayout.Button("重置"))
        {
            ZhongyuanLy.Value = 13.5f;
            _zhongyuanLvInput = "13.5";
            BattleChangeSkillFightRate.Value = 1f;
            _battleChangeSkillFightRateInput = "1";
            MaxSpeBuildingNum.Value = 5;
            _maxSpeBuildingNum = "5";
            FavorMax.Value = 100;
            _favorMaxInput = "100";
            MoneyTimes.Value = 1;
            _moneyTimes = "1";
            MaxLivingSkillExpTimes.Value = 1;
            _maxLivingSkillExpRateInpute = "1";
            LivingSkillExpRate.Value = 1;
            _livingSkillExpRateInpute = "1";
            _readBook.Value = 1;
            _readBookRateInput = "1";
            _redBreak.Value = 1;
            _breakRateInput = "1";
            _weightRatio.Value = 1;
            _itemWeightRateInput = "1";
            _equipmentWeight.Value = 1;
            _equipWeightInput = "1";
            _pzqh.Value = 1;
            _pzqhInput = "1";
            _leaveDay.Value = 30;
            _leaveDayInput = "30";
            _studyFightRate.Value = 1;
            _studyFightRateInput = "1";
            _studyUniqeRate.Value = 1;
            _studyUniqeRateInput = "1";
            _shopLvRate.Value = 1;
            _shopLvRateInput = "1";
            _itemNum.Value = -1;
            _itemNumInput = "1";
            _maxSkillNum.Value = 1;
            _maxSkillNumInput = "1";
            _favorTimes.Value = 1;
            _favorTimesInput = "1";
            _tagMaxNum.Value = 15;
            _tagMaxNumInput = "15";
            ChanDaoRate.Value = 1;
            _chanDaoRateInput = "1";
            _mainCategory?.SaveToFile();
        }
        GUILayout.EndHorizontal();
        GUILayout.EndVertical();
    }
    
    private void ChaneMaxNum()
    {
        if (_maxSkillNum.Value > 1)
        {
            var maxSkillNum = GlobalData.MaxSkillNum;
            if (maxSkillNum.Count == 6)
            {
                for (int i = 0; i < 6; i++)
                {
                    maxSkillNum[i] = _skillBaseNum[i] * _maxSkillNum.Value;
                }
            }
        }
    }
    
    private string? _readBookRateInput;
    private string? _breakRateInput;
    private string? _leaveDayInput;
    private string? _tagMaxNumInput;
    private string? _pzqhInput;
    private string? _itemWeightRateInput;
    private string? _equipWeightInput;
    private string? _maxSkillNumInput;
    private string? _studyFightRateInput;
    private string? _studyUniqeRateInput;
    private string? _shopLvRateInput;
    private string? _itemNumInput;
    private string? _favorTimesInput;
    private string? _moneyTimes;
    private string? _livingSkillExpRateInpute;
    private string? _maxLivingSkillExpRateInpute;
    private string? _favorMaxInput;
    private string? _maxSpeBuildingNum;
    private string? _battleChangeSkillFightRateInput;
    private string? _zhongyuanLvInput;
    private string? _chanDaoRateInput;
    private string? _poisonRateInput;
    private string? _poisonReduceRateInput;
    
    private readonly List<float> _skillBaseNum = new() {12,10,8,6,4,2};
    
    // 拍卖会Roll
    private static void TryAuctionRoll()
    {
        if (!_isHaveAucRoll) return;
        var auc = AuctionController.Instance;
        var plot = PlotController.Instance;
        if (auc != null && plot != null && auc.auctionPanel.activeInHierarchy)
        {
            foreach (var gm in auc.auctionItemIconList)
            {
                if (gm != null)
                    Object.Destroy(gm);
            }
            auc.auctionItemIconList.Clear();
        
            foreach (var gm in auc.heroIconList)
            {
                if (gm != null)
                    Object.Destroy(gm);
            }
            auc.heroIconList.Clear();
        
            var itemListData = new ItemListData();
            plot.GenerateAuctionItem(itemListData, auc.auctionDifficulty);
            auc.RestartAuction(auc.heroList, itemListData, auc.playerSellItem, 
                auc.endMatchCallPlot, auc.auctionDifficulty, auc.havePlayer, auc.auctionKeeper);
        }
    }

    // 突破roll
    private static void TryBreakThoughtRoll()
    {
        var btc = BreakThroughController.Instance;
        if (btc != null && btc.breakThroughPanel != null && btc.breakThroughPanel.activeInHierarchy
            && btc.breakThroughPos != null && btc.breakThroughPos.transform.childCount > 0)
        {
            var componentsInChildren = btc.breakThroughPos
                .GetComponentsInChildren<BreakThroughChoiceController>();
            foreach (var btcc in componentsInChildren)
            {
                if (btcc != null && btcc.gameObject != null)
                {
                    Object.Destroy(btcc.gameObject);
                }
            }
            btc.StartShowBreakChoice();
        }
    }
    // 制造roll
    private static void TryCraftRoll()
    {
        var cuc = CraftUIController.Instance;
        if (cuc == null || cuc.creaftUIPanel == null || !cuc.creaftUIPanel.activeInHierarchy ||
            cuc.craftResultList == null || cuc.craftResultList.Count == 0)
            return;

        var craftType = cuc.craftType;
        
        var oldList = cuc.craftResultList;
        var newList = new Il2CppSystem.Collections.Generic.List<ItemData>();
        var gc = GameController.Instance;
        var heroData = gc.worldData.Player();

        var baseValue = cuc.GetCraftFinalValue();

        foreach (var itemData in oldList)
        {
            ItemData newItem;

            if (craftType == CraftType.Equipment)
            {
                var subType = itemData.subType;
                var littleType = itemData.equipmentData?.littleType ?? -1;
                var targetWeaponType = cuc.targetWeaponType;
                
                if (subType == 0)
                    newItem = gc.GenerateRandomItemValue(baseValue, (int)itemData.type, 1f,
                        subType, -1, heroData, targetWeaponType);
                else
                    newItem = gc.GenerateRandomItemValue(baseValue, (int)itemData.type, 1f,
                        subType, littleType, heroData);
            }
            else
            {
                newItem = gc.GenerateRandomItemValue(baseValue, (int)itemData.type, 1f,
                    itemData.subType, -1, heroData);
            }

            newList.Add(newItem);
        }

        cuc.craftResultList = newList;
        cuc.ShowCraftResultChoosePanel();
    }

    
    // 中元鬼市roll
    private static void TryZhongyuanRoll()
    {
        var tuic = TradeUIController.Instance;
        if (tuic == null || !tuic.tradeUI.activeInHierarchy) return;
        
        var plotController = PlotController.Instance;
        if (plotController == null || plotController.nowEvent == null) return;
        
        var currentEvent = plotController.nowEvent;

        if (!currentEvent.eventName.Contains("中元鬼市")) return;
        
        var tradeUI = TradeUIController.Instance;
        if (tradeUI == null || tradeUI.rightList == null) return;
        

        var rightItemListData = tradeUI.rightList.targetItemList;
        if (rightItemListData == null) return;
       
        var oldCount = rightItemListData.allItem?.Count ?? 0;

        var gc = GameController.Instance;
        if (gc == null) return;
        
        rightItemListData.ClearAllItem();

        gc.GenerateRandomItem(rightItemListData, oldCount, null, ZhongyuanLy.Value, 0f, false);
        tradeUI.rightList.RefreshItemList(rightItemListData, ItemListInteractType.TradeRight, false);
        
    }

    // roll招募，只有女性角色
    private static void TryRefreshRecruitList()
    {
        var ruic = RecruitUIController.Instance;
        if (ruic == null || ruic.recruitUIPanel == null || !ruic.recruitUIPanel.activeInHierarchy) return;

        GameController gc = GameController.Instance;
        GameDataController gdc = GameDataController.Instance;
        var baseHero = new HeroData
        {
            age = 20,
            isFemale = true,
            talent = 4,
            heroTagPoint = 100
        };
        if (gc != null && gdc != null)
        {
            var tempHeros = gc.worldData.TempHeros;
            tempHeros.Clear();
            var forceLv = gc.worldData.Player()?.GetForce()?.forceLv ?? 0;
            var heroNum = 4;
            for (int i = 0; i < heroNum; i++)
            {
                // 生成女性名称
                var randomName = gdc.GenerateRandomHeroName(true, gdc.GenerateRandomHeroFamilyName(), true);
                // 生成女性hero
                var newHero = gc.GenerateHeroData(randomName, -1, -1, forceLv - 1, baseHero, true, 
                    SexLimit.Female, false, false);
                gc.worldData.AddTempHero(newHero);
            }
            ruic.HideRecruitUI();
            ruic.ShowRecruitUI(RecruitUIType.Normal, heroNum, forceLv);
        } 
        
    }

    // 刷新特殊事件 没啥意思
    // private static void TryRerollSpeMasterOrStele()
    // {
    //     var pc = PlotController.Instance;
    //     if (pc == null || pc.nowEvent == null) return;
    //
    //     var plotPanel = pc.plotPanel;
    //     if (plotPanel == null || !plotPanel.activeInHierarchy) return;
    //
    //     var eventName = pc.nowEvent.eventName;
    //     if (string.IsNullOrEmpty(eventName)) return;
    //
    //     if (eventName.Contains("世外高人"))
    //     {
    //         pc.FindSpeMasterEvent("");
    //     }
    //     else if (eventName.Contains("失传秘籍") || eventName.Contains("石碑"))
    //     {
    //         pc.FindSpeSteleFight();
    //     }
    // }
  
}

