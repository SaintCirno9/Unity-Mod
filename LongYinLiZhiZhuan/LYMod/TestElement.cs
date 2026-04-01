using System;
using System.Globalization;
using Il2Cpp;
using UnityEngine;

namespace LYMod;

public class TestElement
{
    public static string MaterialAttr = "6=20;70=0.2;131=0.2;132=0.2";
    public static HeroData? ReadedHeroData;
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
    public static bool MaxAreaFlag = false;
    public static bool MaxAreaFlag1 = false;
    public static bool RedQuality = false;
    
    public static void TestTab()
    {
        GUILayout.BeginVertical("Box");
        GUILayout.BeginHorizontal();
        
        if (GUILayout.Button("读取人物"))
        {
            var hdc = HeroDetailController._instance;
            if (hdc != null)
            {
                ReadedHeroData = hdc.nowShowHero;
                LoadHorseData();
            }
        }
        GUILayout.Label("人物：" + ReadedHeroData?.heroName + "-" +
                        ReadedHeroData?.heroID + "-"+ReadedHeroData?.age);
        GUILayout.Label("成长值：" + ReadedHeroData?.talent);
        if (GUILayout.Button("+") && ReadedHeroData != null)
        {
            ReadedHeroData.talent += 1;
        }
        if (GUILayout.Button("-") && ReadedHeroData != null)
        {
            ReadedHeroData.talent -= 1;
        }
        GUILayout.EndHorizontal();
        GUILayout.Space(10);

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("天赋点数999") && ReadedHeroData != null)
        {
            ReadedHeroData.ChangeTagPoint(999, true);
        }
        GUILayout.EndHorizontal();
        GUILayout.Space(10);

        GUILayout.BeginHorizontal();
        GUILayout.Label("装备马的数据:");
        GUILayout.Label("速度:" );
        _horseSpeed = GUILayout.TextField(_horseSpeed);
        GUILayout.Label("冲刺:" );
        _horseSprint = GUILayout.TextField(_horseSprint);
        GUILayout.Label("耐力:" );
        _horsePower = GUILayout.TextField(_horsePower);
        GUILayout.Label("坚韧:" );
        _horseResist = GUILayout.TextField(_horseResist);
        GUILayout.EndHorizontal();
        GUILayout.Space(10);

        GUILayout.BeginHorizontal();
        GUILayout.Label("装备马鞍数据:");
        GUILayout.Label("速度:" );
        _horseArmorSpeed = GUILayout.TextField(_horseArmorSpeed);
        GUILayout.Label("冲刺:" );
        _horseArmorSprint = GUILayout.TextField(_horseArmorSprint);
        GUILayout.Label("耐力:" );
        _horseArmorPower = GUILayout.TextField(_horseArmorPower);
        GUILayout.Label("坚韧:" );
        _horseArmorResist = GUILayout.TextField(_horseArmorResist);
        GUILayout.EndHorizontal();
        GUILayout.Space(10);

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("保存马和马鞍的数据") && ReadedHeroData != null && ReadedHeroData.horse != null)
        {
            ReadedHeroData.horseArmor.horseData.speed = float.Parse(_horseArmorSpeed, CultureInfo.InvariantCulture);
            ReadedHeroData.horseArmor.horseData.sprint = float.Parse(_horseArmorSprint, CultureInfo.InvariantCulture);
            ReadedHeroData.horseArmor.horseData.power = float.Parse(_horseArmorPower, CultureInfo.InvariantCulture);
            ReadedHeroData.horseArmor.horseData.resist = float.Parse(_horseArmorResist, CultureInfo.InvariantCulture);
            ReadedHeroData.horse.horseData.speed = float.Parse(_horseSpeed, CultureInfo.InvariantCulture);
            ReadedHeroData.horse.horseData.sprint = float.Parse(_horseSprint, CultureInfo.InvariantCulture);
            ReadedHeroData.horse.horseData.power = float.Parse(_horsePower, CultureInfo.InvariantCulture);
            ReadedHeroData.horse.horseData.resist = float.Parse(_horseResist, CultureInfo.InvariantCulture);
        }
        GUILayout.EndHorizontal();
        GUILayout.Space(10);

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("基础潜力全120")&& ReadedHeroData != null)
        {
            var mas = ReadedHeroData?.maxAttri;
            if (mas != null)
            {
                for (var i = 0; i < mas.Count; i++)
                {
                    mas[i] = 120;
                }
            }
        }
        GUILayout.Space(10);
        if (GUILayout.Button("武学潜力全120")&& ReadedHeroData != null)
        {
            var mfs = ReadedHeroData?.maxFightSkill;
            if (mfs != null)
            {
                for (var i = 0; i < mfs.Count; i++)
                {
                    mfs[i] = 120;
                }
            }
        }
        GUILayout.Space(10);
        if (GUILayout.Button("生活潜力全100")&& ReadedHeroData != null)
        {
            var mls = ReadedHeroData?.maxLivingSkill;
            if (mls != null)
            {
                for (var i = 0; i < mls.Count; i++)
                {
                    mls[i] = 100;
                }
            }
        }
        GUILayout.EndHorizontal();
        GUILayout.Space(10);

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("基础属性全120")&& ReadedHeroData != null)
        {
            var bas = ReadedHeroData?.baseAttri;
            if (bas != null)
            {
                for (var i = 0; i < bas.Count; i++)
                {
                    bas[i] = 120;
                }
            }
        }
        GUILayout.Space(10);
        if (GUILayout.Button("武学属性全120")&& ReadedHeroData != null)
        {
            var mfs = ReadedHeroData?.baseFightSkill;
            if (mfs != null)
            {
                for (var i = 0; i < mfs.Count; i++)
                {
                    mfs[i] = 120;
                }
            }
        }
        GUILayout.Space(10);
        if (GUILayout.Button("生活属性全100")&& ReadedHeroData != null)
        {
            var bls = ReadedHeroData?.baseLivingSkill;
            if (bls != null)
            {
                for (var i = 0; i < bls.Count; i++)
                {
                    bls[i] = 100;
                }
            }
        }
        GUILayout.EndHorizontal();
        GUILayout.Space(10);

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
        GUILayout.Space(10);
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
        GUILayout.Space(10);

        GUILayout.BeginVertical("Box");
        GUILayout.BeginHorizontal();
        GUILayout.Label("突破属性修改方案一：");
        GUILayout.EndHorizontal();
        GUILayout.Space(10);

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
        GUILayout.Space(10);

        GUILayout.BeginHorizontal();
        GUILayout.Label("突破属性修改方案二：");
        GUILayout.EndHorizontal();
        GUILayout.Space(10);

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
        GUILayout.Space(10);

        GUILayout.BeginVertical("Box");
        GUILayout.BeginHorizontal();
        RedMaterial = GUILayout.Toggle(RedMaterial, "必获得红材料,下面是填写材料属性，参考属性id栏");
        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal();
        MaterialAttr = GUILayout.TextField(MaterialAttr);
        GUILayout.EndHorizontal();
        GUILayout.EndVertical();
        GUILayout.Space(10);

        GUILayout.BeginVertical("Box");
        GUILayout.BeginHorizontal();
        var maxNum = GUILayout.TextField("99");
        if (GUILayout.Button("修改友人/结义/情侣上限"))
        {
            GlobalData.MaxLoverNum = int.Parse(maxNum);
            GlobalData.MaxFriendNum = int.Parse(maxNum);
            GlobalData.MaxBrotherNum = int.Parse(maxNum);
        }
        GUILayout.EndHorizontal();
        GUILayout.Space(10);

        GUILayout.BeginHorizontal();
        AnyTagFlag = GUILayout.Toggle(AnyTagFlag, "获取天赋没有前提要求，可以直接获取红色天赋");
        GUILayout.EndHorizontal();
        GUILayout.EndVertical();
        GUILayout.Space(10);
        // 人物建档时
        GUILayout.BeginVertical("Box");
        GUILayout.BeginHorizontal();
        if (GUILayout.Button("新档人物属性点数999"))
        {
            
            var smc = StartMenuController._instance;
            if (smc != null)
            {
                smc.leftAttriPoint = 999;
                smc.leftFightSkillPoint = 999;
                smc.leftLivingSkillPoint = 999;
            }
        }
        MaxAreaFlag = GUILayout.Toggle(MaxAreaFlag, "仙霞初建存档地块最大化");
        MaxAreaFlag1 = GUILayout.Toggle(MaxAreaFlag1, "需要城墙？");
        GUILayout.EndHorizontal();
        GUILayout.EndVertical();
        GUILayout.Space(10);
        
        GUILayout.BeginVertical("Box");
        GUILayout.BeginHorizontal();
        if (GUILayout.Button("测试-刷新玩家个人月限制"))
        {
            var gc = GameController.Instance;
            if (gc == null) return;
            ResetWorldDataLimits(gc.worldData);
        }
        if (GUILayout.Button("测试-刷新门派月限制"))
        {
            var gc = GameController.Instance;
            if (gc == null) return;
            var player = gc.worldData.Player();
            if (player == null) return;
            var force = player.GetForce();
            if (force == null) return;
            ResetForceLimits(force);
        }
        GUILayout.EndHorizontal();
        GUILayout.EndVertical();
        GUILayout.BeginVertical("Box");
        GUILayout.BeginHorizontal();
        if (GUILayout.Button("解锁所有衣服"))
        {
            var gc = GameController.Instance;
            if (gc == null) return;
            int[] skinIds = {-10,-9,-8,-7,-6,-5,-4,-3,-2,-1,0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,-100,-101};
            int[] lvs = { 0, 1, 2, 3, 4, 5 };
            for (int i = 0; i < skinIds.Length; i++)
            {
                for (int j = 0; j < lvs.Length; j++)
                {
                    gc.worldData.UnlockSkin(skinIds[i], lvs[j], true);
                }
            }
        }
        RedQuality = GUILayout.Toggle(RedQuality, "获得的物品品质是红");
        
        GUILayout.EndHorizontal();
        GUILayout.EndVertical();
        
        GUILayout.BeginVertical("Box");
        GUILayout.BeginHorizontal();
        GUILayout.Label("窗体/字体缩放: " + Plugin.Instance.WindowScaling.Value.ToString("F2") + "x");
        if (GUILayout.Button("重置"))
        {
            Plugin.Instance.WindowScaling.Value = 1;
            Plugin.Instance._mainCategory?.SaveToFile();
        }
        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal();
        var newScale = GUILayout.HorizontalSlider(Plugin.Instance.WindowScaling.Value, 0.5f, 2.0f);
        if (Math.Abs(newScale - Plugin.Instance.WindowScaling.Value) > 0.001f)
        {
            Plugin.Instance.WindowScaling.Value = newScale;
            Plugin.Instance._mainCategory?.SaveToFile();
        }
        GUILayout.EndHorizontal();
        GUILayout.EndVertical();
        
        
        
    }

    public static void LoadHorseData()
    {
        if (ReadedHeroData == null) return;
        if (ReadedHeroData.horse != null)
        {
            _horseSpeed = Convert.ToString(ReadedHeroData.horse.horseData.speed, CultureInfo.InvariantCulture);
            _horseSprint = Convert.ToString(ReadedHeroData.horse.horseData.sprint, CultureInfo.InvariantCulture);
            _horsePower = Convert.ToString(ReadedHeroData.horse.horseData.power, CultureInfo.InvariantCulture);
            _horseResist = Convert.ToString(ReadedHeroData.horse.horseData.resist, CultureInfo.InvariantCulture);
        }

        if (ReadedHeroData.horseArmor == null) return;
        _horseArmorPower = Convert.ToString(ReadedHeroData.horseArmor.horseData.power, CultureInfo.InvariantCulture);
        _horseArmorSpeed = Convert.ToString(ReadedHeroData.horseArmor.horseData.speed, CultureInfo.InvariantCulture);
        _horseArmorSprint = Convert.ToString(ReadedHeroData.horseArmor.horseData.sprint, CultureInfo.InvariantCulture);
        _horseArmorResist = Convert.ToString(ReadedHeroData.horseArmor.horseData.resist, CultureInfo.InvariantCulture);
    }
    
    private static void ResetWorldDataLimits(WorldData worldData)
    {
        worldData.monthBreakEquipTime = 0;
        worldData.monthKillTime = 0;
        worldData.monthCatchBadFamePlayerTime = 0;
        worldData.monthGambleTime = 0;
        worldData.monthPartyTime = 0;
        worldData.monthForcePartyTime = 0;
        worldData.monthDoctorTime = 0;
        worldData.monthPerformForMoneyTime = 0;
        worldData.monthCoachTime = 0;
        worldData.monthAttackMartialClubTime = 0;
        worldData.monthSpeReduceBadFameTime = 0;
        worldData.monthSpeAddFameTime = 0;
        worldData.monthSpeGetTalentPointTime = 0;
        worldData.monthChallengeTime = 0;
        worldData.monthBuyAreaInfoTime = 0;
        worldData.monthGiveMoneyToGovernTime = 0;
        worldData.monthFreshBountyTime = 0;
      // - monthBreakEquipTime - 拆解装备次数
      // - monthKillTime - 击杀次数
      // - monthCatchBadFamePlayerTime - 缉拿恶名玩家
      // - monthGambleTime - 赌博次数
      // - monthPartyTime - 宴会次数
      // - monthForcePartyTime - 门派宴会
      // - monthDoctorTime - 看病次数
      // - monthPerformForMoneyTime - 卖艺次数
      // - monthCoachTime - 指导次数
      // - monthAttackMartialClubTime - 挑战武馆
      // - monthSpeReduceBadFameTime - 特殊减少恶名
      // - monthSpeAddFameTime - 特殊增加声望
      // - monthSpeGetTalentPointTime - 获取天赋点
      // - monthChallengeTime - 挑战次数
      // - monthBuyAreaInfoTime - 购买区域信息
      // - monthGiveMoneyToGovernTime - 捐款治理
      // - monthFreshBountyTime - 刷新悬赏
    }
    private static void ResetForceLimits(ForceData force)
    {
         // - thisMonthAttack - 本月是否已攻打门派
         //  - thisMonthAttackResourcePoint - 攻打资源点次数
         //  - thisMonthGetResource - 获取资源次数
         //  - thisMonthAddOtherForceFavor - 增加其他门派好感
         //  - thisMonthReduceOtherForceFavor - 减少其他门派好感
         //  - thisMonthGetHero - 获取弟子次数
         //  - thisMonthManaged - 管理次数
        force.thisMonthAttack = false;
        force.thisMonthAttackResourcePoint = 0;
        force.thisMonthGetResource = 0;
        force.thisMonthAddOtherForceFavor = 0;
        force.thisMonthReduceOtherForceFavor = 0;
        force.thisMonthGetHero = 0;
        force.thisMonthManaged = 0;
    }
}