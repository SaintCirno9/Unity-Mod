using System.Globalization;
using Il2Cpp;
using UnityEngine;

namespace LYMod;

public class TestElement
{
    public static string MaterialAttr = "6=20;70=0.2;131=0.2;132=0.2";
    public static HeroData? HeroData;
    public static bool BreakFlag1 = false;
    public static string BreakType = "0";
    public static string BreakValue = "5";
    public static bool RedMaterial = false;
    private static string? _horseSpeed;
    private static string? _horseArmorSpeed;
    private static string? _horseSprint;
    private static string? _horseArmorSprint;
    private static string? _horsePower;
    private static string? _horseArmorPower;
    private static string? _horseResist;
    private static string? _horseArmorResist;
    private static string? _maxSkillNumInput;
    private static string? _npcMaxSkillNumInput;
    public static bool AnyTagFlag = false;
    public static string? BreakChoiceListStr = "";
    public static bool BreakChoiceFlag = false;
    
    public static void TestTab()
    {
        GUILayout.BeginVertical("Box");
        GUILayout.BeginHorizontal();
        
        if (GUILayout.Button("读取人物"))
        {
            var hdc = HeroDetailController._instance;
            if (hdc != null)
            {
                HeroData = hdc.nowShowHero;
                LoadHorseData();
            }
        }
        GUILayout.Label("人物：" + HeroData?.heroName + ": " + HeroData?.heroID);
        GUILayout.Label("成长值：" + HeroData?.talent);
        if (GUILayout.Button("+") && HeroData != null)
        {
            HeroData.talent += 1;
        }
        if (GUILayout.Button("-") && HeroData != null)
        {
            HeroData.talent -= 1;
        }
        GUILayout.EndHorizontal();
        GUILayout.Space(5);
        
        GUILayout.BeginHorizontal();
        if (GUILayout.Button("天赋点数999") && HeroData != null)
        {
            HeroData.ChangeTagPoint(999, true);
        }
        GUILayout.EndHorizontal();
        GUILayout.Space(5);
        
        GUILayout.BeginHorizontal();
        GUILayout.Label("装备马的数据:" );
        GUILayout.Label("速度:" );
        _horseSpeed = GUILayout.TextField(_horseSpeed);
        GUILayout.Label("冲刺:" );
        _horseSprint = GUILayout.TextField(_horseSprint);
        GUILayout.Label("耐力:" );
        _horsePower = GUILayout.TextField(_horsePower);
        GUILayout.Label("坚韧:" );
        _horseResist = GUILayout.TextField(_horseResist);
        GUILayout.EndHorizontal();
        GUILayout.Space(5);
        
        GUILayout.BeginHorizontal();
        GUILayout.Label("装备马鞍数据:" );
        GUILayout.Label("速度:" );
        _horseArmorSpeed = GUILayout.TextField(_horseArmorSpeed);
        GUILayout.Label("冲刺:" );
        _horseArmorSprint = GUILayout.TextField(_horseArmorSprint);
        GUILayout.Label("耐力:" );
        _horseArmorPower = GUILayout.TextField(_horseArmorPower);
        GUILayout.Label("坚韧:" );
        _horseArmorResist = GUILayout.TextField(_horseArmorResist);
        GUILayout.EndHorizontal();
        GUILayout.Space(5);
        
        GUILayout.BeginHorizontal();
        if (GUILayout.Button("保存马和马鞍的数据") && HeroData != null && HeroData.horse != null)
        {
            HeroData.horseArmor.horseData.speed = float.Parse(_horseArmorSpeed, CultureInfo.InvariantCulture);
            HeroData.horseArmor.horseData.sprint = float.Parse(_horseArmorSprint, CultureInfo.InvariantCulture);
            HeroData.horseArmor.horseData.power = float.Parse(_horseArmorPower, CultureInfo.InvariantCulture);
            HeroData.horseArmor.horseData.resist = float.Parse(_horseArmorResist, CultureInfo.InvariantCulture);
            HeroData.horse.horseData.speed = float.Parse(_horseSpeed, CultureInfo.InvariantCulture);
            HeroData.horse.horseData.sprint = float.Parse(_horseSprint, CultureInfo.InvariantCulture);
            HeroData.horse.horseData.power = float.Parse(_horsePower, CultureInfo.InvariantCulture);
            HeroData.horse.horseData.resist = float.Parse(_horseResist, CultureInfo.InvariantCulture);
        }
        GUILayout.EndHorizontal();
        GUILayout.Space(5);
        GUILayout.BeginHorizontal();
        if (GUILayout.Button("基础潜力全120")&& HeroData != null)
        {
            var mas = HeroData?.maxAttri;
            if (mas != null)
            {
                for (var i = 0; i < mas.Count; i++)
                {
                    mas[i] = 120;
                }
            }
        }
        GUILayout.Space(5);
        if (GUILayout.Button("武学潜力全120")&& HeroData != null)
        {
            var mfs = HeroData?.maxFightSkill;
            if (mfs != null)
            {
                for (var i = 0; i < mfs.Count; i++)
                {
                    mfs[i] = 120;
                }
            }
        }
        GUILayout.Space(5);
        if (GUILayout.Button("生活潜力全100")&& HeroData != null)
        {
            var mls = HeroData?.maxLivingSkill;
            if (mls != null)
            {
                for (var i = 0; i < mls.Count; i++)
                {
                    mls[i] = 100;
                }
            }
        }
        GUILayout.EndHorizontal();
        GUILayout.Space(5);
        GUILayout.BeginHorizontal();
        if (GUILayout.Button("基础属性全120")&& HeroData != null)
        {
            var bas = HeroData?.baseAttri;
            if (bas != null)
            {
                for (var i = 0; i < bas.Count; i++)
                {
                    bas[i] = 120;
                }
            }
        }
        GUILayout.Space(5);
        if (GUILayout.Button("武学属性全120")&& HeroData != null)
        {
            var mfs = HeroData?.baseFightSkill;
            if (mfs != null)
            {
                for (var i = 0; i < mfs.Count; i++)
                {
                    mfs[i] = 120;
                }
            }
        }
        GUILayout.Space(5);
        if (GUILayout.Button("生活属性全100")&& HeroData != null)
        {
            var bls = HeroData?.baseLivingSkill;
            if (bls != null)
            {
                for (var i = 0; i < bls.Count; i++)
                {
                    bls[i] = 100;
                }
            }
        }
        GUILayout.EndHorizontal();
        GUILayout.Space(5);
        GUILayout.BeginHorizontal();
        _maxSkillNumInput ??= Convert.ToString(Plugin.Instance.MaxBreakValue.Value, CultureInfo.InvariantCulture);
        _maxSkillNumInput = GUILayout.TextField(_maxSkillNumInput);
        var maxBreak = GUILayout.Toggle(Plugin.Instance.MaxBreak.Value, "主角最大属性上限锁定");
        if (maxBreak != Plugin.Instance.MaxBreak.Value)
        {
            Plugin.Instance.MaxBreakValue.Value = float.Parse(_maxSkillNumInput);
            Plugin.Instance.MaxBreak.Value = maxBreak;
            Plugin.Instance._mainCategory?.SaveToFile();
        }
        GUILayout.Space(5);
        _npcMaxSkillNumInput ??= Convert.ToString(Plugin.Instance.NpcMaxBreakValue.Value, CultureInfo.InvariantCulture);
        _npcMaxSkillNumInput = GUILayout.TextField(_npcMaxSkillNumInput);
        var npcMaxBreak = GUILayout.Toggle(Plugin.Instance.NpcMaxBreak.Value, "NPC最大属性上限锁定");
        if (npcMaxBreak != Plugin.Instance.NpcMaxBreak.Value)
        {
            Plugin.Instance.NpcMaxBreakValue.Value = float.Parse(_npcMaxSkillNumInput);
            Plugin.Instance.NpcMaxBreak.Value = npcMaxBreak;
            Plugin.Instance._mainCategory?.SaveToFile();
        }
        GUILayout.EndHorizontal();
        GUILayout.EndVertical();
        GUILayout.Space(5);
        
        GUILayout.BeginVertical("Box");
        GUILayout.BeginHorizontal();
        GUILayout.Label("突破属性修改方案一：");
        GUILayout.EndHorizontal();
        GUILayout.Space(5);
        GUILayout.BeginHorizontal();
        if (GUILayout.Button("获取当前武学突破随机值"))
        {
            var btc = BreakThroughController._instance;
            if (btc != null)
            {
                var kfsld = btc.targetSkill;
                var list = kfsld.GetBreakThroughAvailableChoice();
                BreakChoiceListStr = string.Join(",", list.ToArray());
            }
        }
        BreakChoiceListStr = GUILayout.TextField(BreakChoiceListStr);
        var breakChoiceFlag = GUILayout.Toggle(BreakChoiceFlag, "指定随机值");
        BreakChoiceFlag = breakChoiceFlag;
        GUILayout.EndHorizontal();
        GUILayout.Space(5);
        GUILayout.BeginHorizontal();
        GUILayout.Label("突破属性修改方案二：");
        GUILayout.EndHorizontal();
        GUILayout.Space(5);
        GUILayout.BeginHorizontal();
        GUILayout.Label("指定后突破选什么都是指定的属性,属性类别参考属性ID栏");
        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal();
        BreakFlag1 = GUILayout.Toggle(BreakFlag1, "指定突破属性类别");
        BreakType = GUILayout.TextField(BreakType);
        GUILayout.Label("指定突破属性数值");
        BreakValue = GUILayout.TextField(BreakValue);
        GUILayout.EndHorizontal();
        GUILayout.EndVertical();
        GUILayout.Space(5);
        
        GUILayout.BeginVertical("Box");
        GUILayout.BeginHorizontal();
        RedMaterial = GUILayout.Toggle(RedMaterial, "必获得红材料,下面是填写材料属性，参考属性id栏");
        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal();
        MaterialAttr = GUILayout.TextField(MaterialAttr);
        GUILayout.EndHorizontal();
        GUILayout.EndVertical();
        GUILayout.Space(5);
        
        GUILayout.BeginVertical("Box");
        GUILayout.BeginHorizontal();
        var maxNum = GUILayout.TextField("99");
        if (GUILayout.Button("修改友人/结义/情侣上限"))
        {
            GlobalData.MaxLoverNum = int.Parse(maxNum);
            GlobalData.MaxFriendNum = int.Parse(maxNum);
            GlobalData.MaxBrotherNum = int.Parse(maxNum);
            GlobalData.PlayTestMaxFavor =  999;
        }
        if (GUILayout.Button("创建人物时属性点数999"))
        {
            var smc = StartMenuController._instance;
            if (smc != null)
            {
                smc.leftAttriPoint = 999;
                smc.leftFightSkillPoint = 999;
                smc.leftLivingSkillPoint = 999;
            }
        }
        GUILayout.EndHorizontal();
        GUILayout.Space(5);
        
        GUILayout.BeginHorizontal();
        AnyTagFlag = GUILayout.Toggle(AnyTagFlag, "获取天赋没有前提要求，可以直接获取红色天赋");
        GUILayout.EndHorizontal();
        
        GUILayout.EndVertical();
    }

    public static void LoadHorseData()
    {
        if (HeroData == null) return;
        if (HeroData.horse != null)
        {
            _horseSpeed = Convert.ToString(HeroData.horse.horseData.speed, CultureInfo.InvariantCulture);
            _horseSprint = Convert.ToString(HeroData.horse.horseData.sprint, CultureInfo.InvariantCulture);
            _horsePower = Convert.ToString(HeroData.horse.horseData.power, CultureInfo.InvariantCulture);
            _horseResist = Convert.ToString(HeroData.horse.horseData.resist, CultureInfo.InvariantCulture);
        }

        if (HeroData.horseArmor == null) return;
        _horseArmorPower = Convert.ToString(HeroData.horseArmor.horseData.power, CultureInfo.InvariantCulture);
        _horseArmorSpeed = Convert.ToString(HeroData.horseArmor.horseData.speed, CultureInfo.InvariantCulture);
        _horseArmorSprint = Convert.ToString(HeroData.horseArmor.horseData.sprint, CultureInfo.InvariantCulture);
        _horseArmorResist = Convert.ToString(HeroData.horseArmor.horseData.resist, CultureInfo.InvariantCulture);
    }
}