using System.Globalization;
using Il2Cpp;
using LYMod;
using MelonLoader;
using UnityEngine;


[assembly: MelonInfo(typeof(LYMod.Plugin), ModConstants.MOD_NAME, ModConstants.MOD_VERSION, ModConstants.MOD_AUTHOR)]
[assembly:MelonGame("TppStudio", "LongYinLiZhiZhuan")]
[assembly:MelonPlatformDomain(MelonPlatformDomainAttribute.CompatibleDomains.IL2CPP)]
namespace LYMod;

public static class ModConstants
{
    public const string MOD_NAME = "LYMod";       // 插件名
    public const string MOD_VERSION = "1.5";    // 版本号
    public const string MOD_AUTHOR = "Can";       // 作者
}

public class Plugin : MelonMod 
{
    public static Plugin Instance { get; private set; }
    public static MelonLogger.Instance LOG = Melon<Plugin>.Logger;
    
    // 配置项
    private MelonPreferences_Category _mainCategory;
    public MelonPreferences_Entry<bool> _teachNewSkillToNPC; // 传授满级
    public MelonPreferences_Entry<bool> _teachNPC; // 指点满级
    public MelonPreferences_Entry<bool> _interaction; // 无限交互
    public MelonPreferences_Entry<float> _readBook; // 读书经验倍率
    public MelonPreferences_Entry<bool> _explore; // 探险耐力锁
    public MelonPreferences_Entry<bool> _cost0; // 建筑升级资源消耗0
    public MelonPreferences_Entry<bool> _redBook; // 必获得完本
    public MelonPreferences_Entry<bool> _redMaterial; // 必获得红色材料
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
    
    
    
    // GUI状态
    private Vector2 mainScrollPos;
    private Rect mainWindowRect = new(50, 50, 450, 440);
    private bool showMainWindow = false;
    private readonly string[] tabNames = { "功能开关", "功能说明" };
    private int selectedTab;

    public override void OnInitializeMelon()
    {
        Instance = this;
        _mainCategory = MelonPreferences.CreateCategory("LYModConfig", "配置true开启/false关闭");
        
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
        
        _teachNewSkillToNPC = _mainCategory.CreateEntry("teachNewSkillToNPCFull",false,  description: "传授满级");
        _teachNPC = _mainCategory.CreateEntry("teachNPCToFull",false,  description: "指点满级");
        _explore = _mainCategory.CreateEntry("explore", false,  description: "探险耐力锁定");
        _interaction = _mainCategory.CreateEntry("interaction", true,  description: "无限指点传授");
        _redBook = _mainCategory.CreateEntry("redBook", false,  description: "必定获得完本");
        _redMaterial = _mainCategory.CreateEntry("redMaterial", false,  description: "必获得红材料");
        _stealRate = _mainCategory.CreateEntry("stealRate", false,  description: "偷窃偷师必成功");
        _hgbj = _mainCategory.CreateEntry("hfbj", false,  description: "好感度不会减少");
        _cost0 = _mainCategory.CreateEntry("cost0", true,  description: "建筑升级资源零消耗");
        _redTreasure = _mainCategory.CreateEntry("redTreasure", false,  description: "必定是红色珍宝慎用");
        
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
        harmony.PatchAll(typeof(StudyUniqueSkillControllerPatches));
        harmony.PatchAll(typeof(StudyAttackSkillControllerPatches));
        
        
        LOG.Msg("LYMod is loaded!左alt + e 打开窗体!");
        
        ChaneMaxNum();
       
    }
   
    public override void OnUpdate()
    {
        // 左alt + e 打开窗体
        if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKeyDown(KeyCode.E))
        {
            showMainWindow = !showMainWindow;
        }
    }
    
    public override void OnGUI()
    {
        // 开启 / 关闭窗体
        if (showMainWindow)
            // 主窗口
            mainWindowRect = GUI.Window(0, mainWindowRect, (GUI.WindowFunction)DrawMainWindow, "LYMod " + ModConstants.MOD_VERSION);
    }

    private void DrawMainWindow(int windowId)
    {
        // 启用窗口拖拽（仅标题栏区域）
        GUI.DragWindow(new Rect(0, 0, Screen.width, 20));
        GUILayout.Space(10);
        // 标签页选择
        GUILayout.BeginHorizontal();
        for (var i = 0; i < tabNames.Length; i++)
        {
            if (GUILayout.Toggle(selectedTab == i, tabNames[i], "Button")) selectedTab = i;
            GUILayout.Space(10);
        }

        GUILayout.EndHorizontal();
       

        // 滚动区域
        mainScrollPos = GUILayout.BeginScrollView(mainScrollPos, GUILayout.Width(430), GUILayout.Height(380));

        // 根据选择的标签页绘制不同内容
        switch (selectedTab)
        {
            case 0: // 功能
                DrawMainTab();
                break;
            case 1: // 功能说明
                DrawInfoTab();
                break;
        }

        GUILayout.EndScrollView();
    }

    private void DrawMainTab()
    {
        GUILayout.Label("<size=14><b>功能</b></size>");
        GUILayout.BeginVertical("Box");
        GUILayout.Space(5);
        GUILayout.BeginHorizontal();
        var teachNpc = GUILayout.Toggle(_teachNPC.Value, "指点满级");
        if (teachNpc != _teachNPC.Value)
        {
            _teachNPC.Value = teachNpc;
            _mainCategory.SaveToFile();
        }
        var teachNewSkillToNpc = GUILayout.Toggle(_teachNewSkillToNPC.Value, "传授满级");
        if (teachNewSkillToNpc != _teachNewSkillToNPC.Value)
        {
            _teachNewSkillToNPC.Value = teachNewSkillToNpc;
            _mainCategory.SaveToFile();
        }
        GUILayout.EndHorizontal();
        GUILayout.Space(5);
        GUILayout.BeginHorizontal();
        var explore = GUILayout.Toggle(_explore.Value, "探险耐力锁定");
        if (explore != _explore.Value)
        {
            _explore.Value = explore;
            _mainCategory.SaveToFile();
        }
        var interaction = GUILayout.Toggle(_interaction.Value, "真的无限交互");
        if (interaction != _interaction.Value)
        {
            _interaction.Value = interaction;
            _mainCategory.SaveToFile();
        }
        GUILayout.EndHorizontal();
        GUILayout.Space(5);
        GUILayout.BeginHorizontal();
        var redbook = GUILayout.Toggle(_redBook.Value, "必定获得完本");
        if (redbook != _redBook.Value)
        {
            _redBook.Value = redbook;
            _mainCategory.SaveToFile();
        }
        var redMaterial = GUILayout.Toggle(_redMaterial.Value, "必获得红材料");
        if (redMaterial != _redMaterial.Value)
        {
            _redMaterial.Value = redMaterial;
            _mainCategory.SaveToFile();
        }
        GUILayout.EndHorizontal();
        GUILayout.Space(5);
        GUILayout.BeginHorizontal();
        var stealRate = GUILayout.Toggle(_stealRate.Value, "偷窃偷师必成功");
        if (stealRate != _stealRate.Value)
        {
            _stealRate.Value = stealRate;
            _mainCategory.SaveToFile();
        }
        var hgbj = GUILayout.Toggle(_hgbj.Value, "好感度不会减少");
        if (hgbj != _hgbj.Value)
        {
            _hgbj.Value = hgbj;
            _mainCategory.SaveToFile();
        }
        GUILayout.EndHorizontal();
        GUILayout.Space(5);
        GUILayout.BeginHorizontal();
        var cost0 = GUILayout.Toggle(_cost0.Value, "建筑升级资源零消耗");
        if (cost0 != _cost0.Value)
        {
            _cost0.Value = cost0;
            _mainCategory.SaveToFile();
        }
        var redTreasure = GUILayout.Toggle(_redTreasure.Value, "必定是红色珍宝慎用");
        if (redTreasure != _redTreasure.Value)
        {
            _redTreasure.Value = redTreasure;
            _mainCategory.SaveToFile();
        }
        GUILayout.EndHorizontal();
        GUILayout.EndVertical();
        
        GUILayout.Space(10);
        
        GUILayout.BeginVertical("Box");
        GUILayout.Space(5);
        GUILayout.BeginHorizontal();
        GUILayout.Label("练功倍率：");
        _studyFightRateInput ??= Convert.ToString(_studyFightRate.Value, CultureInfo.InvariantCulture);
        _studyFightRateInput = GUILayout.TextField(_studyFightRateInput);
        GUILayout.Space(5);
        GUILayout.Label("闭关倍率：");
        _studyUniqeRateInput ??= Convert.ToString(_studyUniqeRate.Value, CultureInfo.InvariantCulture);
        _studyUniqeRateInput = GUILayout.TextField(_studyUniqeRateInput);
        GUILayout.EndHorizontal();
        GUILayout.Space(5);
        GUILayout.BeginHorizontal();
        GUILayout.Label("读书倍率：");
        _readBookRateInput ??= Convert.ToString(_readBook.Value, CultureInfo.InvariantCulture);
        _readBookRateInput = GUILayout.TextField(_readBookRateInput);
        GUILayout.Space(5);
        GUILayout.Label("突破倍率：");
        _breakRateInput ??= Convert.ToString(_redBreak.Value, CultureInfo.InvariantCulture);
        _breakRateInput = GUILayout.TextField(_breakRateInput);
        GUILayout.EndHorizontal();
        
        GUILayout.Space(5);
        
        GUILayout.BeginHorizontal();
        GUILayout.Label("队友离队天数：");
        _leaveDayInput ??= Convert.ToString(_leaveDay.Value);
        _leaveDayInput = GUILayout.TextField(_leaveDayInput);
        GUILayout.Space(5);
        GUILayout.Label("天赋最大数量：");
        _tagMaxNumInput ??= Convert.ToString(_tagMaxNum.Value);
        _tagMaxNumInput = GUILayout.TextField(_tagMaxNumInput);
        GUILayout.EndHorizontal();
        
        GUILayout.Space(5);
        
        GUILayout.BeginHorizontal();
        GUILayout.Label("物品负重倍率(0-1)：");
        _itemWeightRateInput ??= Convert.ToString(_weightRatio.Value, CultureInfo.InvariantCulture);
        _itemWeightRateInput = GUILayout.TextField(_itemWeightRateInput);
        GUILayout.Space(5);
        GUILayout.Label("装备负重倍率(0-1)：");
        _equipWeightInput ??= Convert.ToString(_equipmentWeight.Value, CultureInfo.InvariantCulture);
        _equipWeightInput = GUILayout.TextField(_equipWeightInput);
        GUILayout.EndHorizontal();
        
        GUILayout.Space(5);
        
        GUILayout.BeginHorizontal();
        GUILayout.Label("武学最佳修习数量倍数：");
        _maxSkillNumInput ??= Convert.ToString(_maxSkillNum.Value);
        _maxSkillNumInput = GUILayout.TextField(_maxSkillNumInput);
        GUILayout.Space(5);
        GUILayout.Label("烹饪铸造炼药倍率：");
        _pzqhInput ??= Convert.ToString(_pzqh.Value, CultureInfo.InvariantCulture);
        _pzqhInput = GUILayout.TextField(_pzqhInput);
        GUILayout.EndHorizontal();
        
        GUILayout.BeginHorizontal();
        GUILayout.Label("以上填写时务必确认后点击保存修改");
        if (GUILayout.Button("保存修改"))
        {
            _readBook.Value = float.Parse(_readBookRateInput);
            _redBreak.Value = float.Parse(_breakRateInput);
            _weightRatio.Value = float.Parse(_itemWeightRateInput);
            _equipmentWeight.Value = float.Parse(_equipWeightInput);
            _pzqh.Value = float.Parse(_pzqhInput);
            _leaveDay.Value = int.Parse(_leaveDayInput);
            _tagMaxNum.Value = int.Parse(_tagMaxNumInput);
            _studyFightRate.Value = float.Parse(_studyFightRateInput);
            _studyUniqeRate.Value = float.Parse(_studyUniqeRateInput);

            _maxSkillNum.Value = int.Parse(_maxSkillNumInput);
            ChaneMaxNum();
            
            
            _mainCategory.SaveToFile();
        }
        GUILayout.EndHorizontal();
        GUILayout.EndVertical();
    }

    private void DrawInfoTab()
    {
        GUILayout.Label("<size=14><b>说明</b></size>");
        GUILayout.BeginVertical("Box");
        GUILayout.Label("严重说明：填写不要乱填，确定无误点击保存修改后就生效了，出问题自己负责");
        GUILayout.Label("1.探险耐力锁定1000");
        GUILayout.Label("2.无限交互，指点满级和传授满级");
        GUILayout.Label("3.必定获得完本秘籍，红品质材料，红色珍品（有bug慎用，但是貌似可以刷贡献）");
        GUILayout.Label("4.偷窃偷师必定成功，好感不会减少");
        GUILayout.Label("5.读书经验、突破数值、闭关经验、练功房经验可以设置倍率，允许小数");
        GUILayout.Label("6.队友自动离队天数，默认30天，必须是正整数");
        GUILayout.Label("7.可以设置天赋最大数");
        GUILayout.Label("8.物品负重和装备负重可以设置倍率，必须是0-1的范围，物品负重影响范围：藏经阁/仓库/背包");
        GUILayout.Label("9.传授完可以追加指点次数。必须是正整数");
        GUILayout.Label("10.烹饪铸造炼药强化倍率，貌似可以是小数");
        GUILayout.Label("11.武学最佳修习数量倍数，必须是正整数");
        
        GUILayout.EndVertical();
        
    }

    private void ChaneMaxNum()
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
    private List<float> _skillBaseNum = new List<float>() {12,10,8,6,4,2};
}