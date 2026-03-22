using System.Globalization;
using Il2Cpp;
using Il2CppNewtonsoft.Json;
using UnityEngine;
using Console = System.Console;

namespace LYMod;

public class TestElement
{
    public static string MaterialAttr = "6=20;70=0.2;131=0.2;132=0.2";
    private static HeroData? _heroData;
    public static bool BreakFlag1 = false;
    public static string BreakType = "0";
    public static string BreakValue = "5";
    public static bool RedMaterial = false;
    private static string? _horseSpeed;
    private static string? _horseSprint;
    private static string? _horsePower;
    private static string? _horseResist;
    public static bool AnyTagFlag = false;
    
    public static void TestTab()
    {
        GUILayout.Label("<size=14><b>测试</b></size>");
        GUILayout.BeginVertical("Box");
        GUILayout.BeginHorizontal();
        
        if (GUILayout.Button("读取人物"))
        {
            var hdc = HeroDetailController._instance;
            if (hdc != null)
            {
                _heroData = hdc.nowShowHero;
                if (_heroData != null && _heroData.horse != null)
                {
                    _horseSpeed = Convert.ToString(_heroData.horse.horseData.speed, CultureInfo.InvariantCulture);
                    _horseSprint = Convert.ToString(_heroData.horse.horseData.sprint, CultureInfo.InvariantCulture);
                    _horsePower = Convert.ToString(_heroData.horse.horseData.power, CultureInfo.InvariantCulture);
                    _horseResist = Convert.ToString(_heroData.horse.horseData.resist, CultureInfo.InvariantCulture);
                }
            }
        }
        GUILayout.Label("读取到的人物：" + _heroData?.heroName);
        GUILayout.Label("成长值：" + _heroData?.talent);
        if (GUILayout.Button("+") && _heroData != null)
        {
            _heroData.talent += 1;
        }
        if (GUILayout.Button("-") && _heroData != null)
        {
            _heroData.talent -= 1;
        }
        GUILayout.EndHorizontal();
        GUILayout.Space(5);
        
        GUILayout.BeginHorizontal();
        if (GUILayout.Button("天赋点数999") && _heroData != null)
        {
            _heroData.ChangeTagPoint(999, true);
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
        if (GUILayout.Button("保存") && _heroData != null && _heroData.horse != null)
        {
            _heroData.horse.horseData.speed = float.Parse(_horseSpeed, CultureInfo.InvariantCulture);
            _heroData.horse.horseData.sprint = float.Parse(_horseSprint, CultureInfo.InvariantCulture);
            _heroData.horse.horseData.power = float.Parse(_horsePower, CultureInfo.InvariantCulture);
            _heroData.horse.horseData.resist = float.Parse(_horseResist, CultureInfo.InvariantCulture);
        }
        GUILayout.EndHorizontal();
        GUILayout.Space(5);
        
        GUILayout.BeginHorizontal();
        if (GUILayout.Button("基础潜力全120")&& _heroData != null)
        {
            var mas = _heroData?.maxAttri;
            if (mas != null)
            {
                for (var i = 0; i < mas.Count; i++)
                {
                    mas[i] = 120;
                }
            }
        }
        GUILayout.Space(5);
        if (GUILayout.Button("武学潜力全120")&& _heroData != null)
        {
            var mfs = _heroData?.maxFightSkill;
            if (mfs != null)
            {
                for (var i = 0; i < mfs.Count; i++)
                {
                    mfs[i] = 120;
                }
            }
        }
        GUILayout.Space(5);
        if (GUILayout.Button("生活潜力全100")&& _heroData != null)
        {
            var mls = _heroData?.maxLivingSkill;
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
        if (GUILayout.Button("基础属性全120")&& _heroData != null)
        {
            var bas = _heroData?.baseAttri;
            if (bas != null)
            {
                for (var i = 0; i < bas.Count; i++)
                {
                    bas[i] = 120;
                }
            }
        }
        GUILayout.Space(5);
        if (GUILayout.Button("武学属性全120")&& _heroData != null)
        {
            var mfs = _heroData?.baseFightSkill;
            if (mfs != null)
            {
                for (var i = 0; i < mfs.Count; i++)
                {
                    mfs[i] = 120;
                }
            }
        }
        GUILayout.Space(5);
        if (GUILayout.Button("生活属性全100")&& _heroData != null)
        {
            var bls = _heroData?.baseLivingSkill;
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
        var maxBreak = GUILayout.Toggle(Plugin.Instance.MaxBreak.Value, "最大属性上限999");
        if (maxBreak != Plugin.Instance.MaxBreak.Value)
        {
            Plugin.Instance.MaxBreak.Value = maxBreak;
            Plugin.Instance._mainCategory?.SaveToFile();
        }
        GUILayout.EndHorizontal();
        GUILayout.EndVertical();
        
        GUILayout.Space(5);
        
        GUILayout.BeginVertical("Box");
        GUILayout.BeginHorizontal();
        GUILayout.Label("指定后突破选什么都是指定的属性,属性类别参考属性ID栏");
        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal();
        BreakFlag1 = GUILayout.Toggle(BreakFlag1, "指定突破属性类别");
        BreakType = GUILayout.TextField(BreakType);
        GUILayout.Label("指定突破属性数值");
        BreakValue = GUILayout.TextField(BreakValue);
        GUILayout.EndHorizontal();
        
        RedMaterial = GUILayout.Toggle(RedMaterial, "必获得红材料,下面是填写材料属性，参考属性id栏");
        MaterialAttr = GUILayout.TextField(MaterialAttr);
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
}