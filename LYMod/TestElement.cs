using Il2Cpp;
using UnityEngine;

namespace LYMod;

public class TestElement
{
    public static string _materialAttr = "6=20;70=0.2;131=0.2;132=0.2";
    private static HeroData? heroData;
    public static bool _breakFlag1 = false;
    public static string _breakType = "0";
    public static string _breakValue = "5";
    public static bool _redMaterial = false;
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
                heroData = hdc.nowShowHero;
            }
        }
        GUILayout.Label("读取到的人物：" + heroData?.heroName);
        GUILayout.Label("成长值：" + heroData?.talent);
        if (GUILayout.Button("+") && heroData != null)
        {
            heroData.talent += 1;
        }
        if (GUILayout.Button("-") && heroData != null)
        {
            heroData.talent -= 1;
        }
        GUILayout.EndHorizontal();
        
        GUILayout.Space(5);
        
        GUILayout.BeginHorizontal();
        if (GUILayout.Button("基础潜力全120"))
        {
            var mas = heroData?.maxAttri;
            if (mas != null)
            {
                for (var i = 0; i < mas.Count; i++)
                {
                    mas[i] = 120;
                }
            }
        }
        GUILayout.Space(5);
        if (GUILayout.Button("武学潜力全120"))
        {
            var mfs = heroData?.maxFightSkill;
            if (mfs != null)
            {
                for (var i = 0; i < mfs.Count; i++)
                {
                    mfs[i] = 120;
                }
            }
        }
        GUILayout.Space(5);
        if (GUILayout.Button("生活潜力全100"))
        {
            var mls = heroData?.maxLivingSkill;
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
        if (GUILayout.Button("基础属性全120"))
        {
            var bas = heroData?.baseAttri;
            if (bas != null)
            {
                for (var i = 0; i < bas.Count; i++)
                {
                    bas[i] = 120;
                }
            }
        }
        GUILayout.Space(5);
        if (GUILayout.Button("武学属性全120"))
        {
            var mfs = heroData?.baseFightSkill;
            if (mfs != null)
            {
                for (var i = 0; i < mfs.Count; i++)
                {
                    mfs[i] = 120;
                }
            }
        }
        GUILayout.Space(5);
        if (GUILayout.Button("生活属性全100"))
        {
            var bls = heroData?.baseLivingSkill;
            if (bls != null)
            {
                for (var i = 0; i < bls.Count; i++)
                {
                    bls[i] = 100;
                }
            }
        }
        GUILayout.EndHorizontal();
        GUILayout.EndVertical();
        GUILayout.Space(5);
        GUILayout.BeginVertical("Box");
        GUILayout.BeginHorizontal();
        GUILayout.Label("指定后突破选什么都是指定的属性,属性类别参考属性ID栏");
        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal();
        _breakFlag1 = GUILayout.Toggle(_breakFlag1, "指定突破属性类别");
        _breakType = GUILayout.TextField(_breakType);
        GUILayout.Label("指定突破属性数值");
        _breakValue = GUILayout.TextField(_breakValue);
        GUILayout.EndHorizontal();
        
        _redMaterial = GUILayout.Toggle(_redMaterial, "必获得红材料");
        _materialAttr = GUILayout.TextField(_materialAttr);
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
        new HeroData().isFemale
        GUILayout.EndHorizontal();
        GUILayout.EndVertical();
    }
}