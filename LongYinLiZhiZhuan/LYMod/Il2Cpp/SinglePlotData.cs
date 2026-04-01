using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2Cpp;

[System.Serializable]
public class SinglePlotData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_plotText;

	private static readonly System.IntPtr NativeFieldInfoPtr_heroFaceHightLightType;

	private static readonly System.IntPtr NativeFieldInfoPtr_plotSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_sourceName;

	private static readonly System.IntPtr NativeFieldInfoPtr_plotTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetName;

	private static readonly System.IntPtr NativeFieldInfoPtr_choices;

	private static readonly System.IntPtr NativeFieldInfoPtr_clickCallFuc;

	private static readonly System.IntPtr NativeFieldInfoPtr_noAutoJump;

	private static readonly System.IntPtr NativeFieldInfoPtr_backPic;

	private static readonly System.IntPtr NativeFieldInfoPtr_backBgm;

	private static readonly System.IntPtr NativeFieldInfoPtr_soundEffect;

	private static readonly System.IntPtr NativeFieldInfoPtr_plotShock;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetChoiceDataTexts_Public_Void_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_HeroFaceHightLightType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_PlotTargetHeroType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_PlotTargetHeroType_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_PlotTargetHeroType_String_PlotTargetHeroType_String_HeroFaceHightLightType_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_PlotTargetHeroType_String_PlotTargetHeroType_String_HeroFaceHightLightType_String_Boolean_String_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe string plotText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotText);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotText)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe HeroFaceHightLightType heroFaceHightLightType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroFaceHightLightType);
			return *(HeroFaceHightLightType*)num;
		}
		set
		{
			*(HeroFaceHightLightType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heroFaceHightLightType)) = heroFaceHightLightType;
		}
	}

	public unsafe PlotTargetHeroType plotSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotSource);
			return *(PlotTargetHeroType*)num;
		}
		set
		{
			*(PlotTargetHeroType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotSource)) = plotTargetHeroType;
		}
	}

	public unsafe string sourceName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe PlotTargetHeroType plotTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotTarget);
			return *(PlotTargetHeroType*)num;
		}
		set
		{
			*(PlotTargetHeroType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotTarget)) = plotTargetHeroType;
		}
	}

	public unsafe string targetName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<SinglePlotChoiceData> choices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_choices);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SinglePlotChoiceData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_choices)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string clickCallFuc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clickCallFuc);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clickCallFuc)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool noAutoJump
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noAutoJump);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noAutoJump)) = flag;
		}
	}

	public unsafe string backPic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backPic);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backPic)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string backBgm
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backBgm);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backBgm)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string soundEffect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_soundEffect);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_soundEffect)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool plotShock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotShock);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotShock)) = flag;
		}
	}

	static SinglePlotData()
	{
		Il2CppClassPointerStore<SinglePlotData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SinglePlotData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SinglePlotData>.NativeClassPtr);
		NativeFieldInfoPtr_plotText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SinglePlotData>.NativeClassPtr, "plotText");
		NativeFieldInfoPtr_heroFaceHightLightType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SinglePlotData>.NativeClassPtr, "heroFaceHightLightType");
		NativeFieldInfoPtr_plotSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SinglePlotData>.NativeClassPtr, "plotSource");
		NativeFieldInfoPtr_sourceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SinglePlotData>.NativeClassPtr, "sourceName");
		NativeFieldInfoPtr_plotTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SinglePlotData>.NativeClassPtr, "plotTarget");
		NativeFieldInfoPtr_targetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SinglePlotData>.NativeClassPtr, "targetName");
		NativeFieldInfoPtr_choices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SinglePlotData>.NativeClassPtr, "choices");
		NativeFieldInfoPtr_clickCallFuc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SinglePlotData>.NativeClassPtr, "clickCallFuc");
		NativeFieldInfoPtr_noAutoJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SinglePlotData>.NativeClassPtr, "noAutoJump");
		NativeFieldInfoPtr_backPic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SinglePlotData>.NativeClassPtr, "backPic");
		NativeFieldInfoPtr_backBgm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SinglePlotData>.NativeClassPtr, "backBgm");
		NativeFieldInfoPtr_soundEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SinglePlotData>.NativeClassPtr, "soundEffect");
		NativeFieldInfoPtr_plotShock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SinglePlotData>.NativeClassPtr, "plotShock");
		NativeMethodInfoPtr_SetChoiceDataTexts_Public_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SinglePlotData>.NativeClassPtr, 100669688);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SinglePlotData>.NativeClassPtr, 100669689);
		NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SinglePlotData>.NativeClassPtr, 100669690);
		NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_HeroFaceHightLightType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SinglePlotData>.NativeClassPtr, 100669691);
		NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_PlotTargetHeroType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SinglePlotData>.NativeClassPtr, 100669692);
		NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_PlotTargetHeroType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SinglePlotData>.NativeClassPtr, 100669693);
		NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_PlotTargetHeroType_String_PlotTargetHeroType_String_HeroFaceHightLightType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SinglePlotData>.NativeClassPtr, 100669694);
		NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_PlotTargetHeroType_String_PlotTargetHeroType_String_HeroFaceHightLightType_String_Boolean_String_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SinglePlotData>.NativeClassPtr, 100669695);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SinglePlotData>.NativeClassPtr, 100669696);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 209403, RefRangeEnd = 209410, XrefRangeStart = 209392, XrefRangeEnd = 209403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetChoiceDataTexts(List<string> choiceDataTexts)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)choiceDataTexts);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetChoiceDataTexts_Public_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 209418, RefRangeEnd = 209419, XrefRangeStart = 209410, XrefRangeEnd = 209418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SinglePlotData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SinglePlotData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 209430, RefRangeEnd = 209458, XrefRangeStart = 209419, XrefRangeEnd = 209430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SinglePlotData(string targetPlotText, List<string> choiceDataTexts)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SinglePlotData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(targetPlotText);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)choiceDataTexts);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(50)]
	[CachedScanResults(RefRangeStart = 209468, RefRangeEnd = 209518, XrefRangeStart = 209458, XrefRangeEnd = 209468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SinglePlotData(string targetPlotText, List<string> choiceDataTexts, HeroFaceHightLightType hightLightType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SinglePlotData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(targetPlotText);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)choiceDataTexts);
		*(HeroFaceHightLightType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hightLightType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_HeroFaceHightLightType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(43)]
	[CachedScanResults(RefRangeStart = 209529, RefRangeEnd = 209572, XrefRangeStart = 209518, XrefRangeEnd = 209529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SinglePlotData(string targetPlotText, List<string> choiceDataTexts, PlotTargetHeroType targetHeroType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SinglePlotData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(targetPlotText);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)choiceDataTexts);
		*(PlotTargetHeroType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetHeroType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_PlotTargetHeroType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(25)]
	[CachedScanResults(RefRangeStart = 209583, RefRangeEnd = 209608, XrefRangeStart = 209572, XrefRangeEnd = 209583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SinglePlotData(string targetPlotText, List<string> choiceDataTexts, PlotTargetHeroType targetHeroType, string targetHeroName)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SinglePlotData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(targetPlotText);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)choiceDataTexts);
		*(PlotTargetHeroType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetHeroType;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(targetHeroName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_PlotTargetHeroType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1131)]
	[CachedScanResults(RefRangeStart = 209621, RefRangeEnd = 210752, XrefRangeStart = 209608, XrefRangeEnd = 209621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SinglePlotData(string targetPlotText, List<string> choiceDataTexts, PlotTargetHeroType targetHeroType, string targetHeroName, PlotTargetHeroType sourceHeroType, string sourceHeroName, HeroFaceHightLightType hightLightType, string _soundEffect = null)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SinglePlotData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(targetPlotText);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)choiceDataTexts);
		*(PlotTargetHeroType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetHeroType;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(targetHeroName);
		*(PlotTargetHeroType**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceHeroType;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(sourceHeroName);
		*(HeroFaceHightLightType**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &hightLightType;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_soundEffect);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_PlotTargetHeroType_String_PlotTargetHeroType_String_HeroFaceHightLightType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(59)]
	[CachedScanResults(RefRangeStart = 210768, RefRangeEnd = 210827, XrefRangeStart = 210752, XrefRangeEnd = 210768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SinglePlotData(string targetPlotText, List<string> choiceDataTexts, PlotTargetHeroType targetHeroType, string targetHeroName, PlotTargetHeroType sourceHeroType, string sourceHeroName, HeroFaceHightLightType hightLightType, string _clickCallFuc, bool _noAutoJump, string _backPic = null, string _backBgm = null, string _soundEffect = null, bool _plotShock = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SinglePlotData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[13];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(targetPlotText);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)choiceDataTexts);
		*(PlotTargetHeroType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetHeroType;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(targetHeroName);
		*(PlotTargetHeroType**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceHeroType;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(sourceHeroName);
		*(HeroFaceHightLightType**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &hightLightType;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_clickCallFuc);
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &_noAutoJump;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_backPic);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_backBgm);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_soundEffect);
		*(bool**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &_plotShock;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_PlotTargetHeroType_String_PlotTargetHeroType_String_HeroFaceHightLightType_String_Boolean_String_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 210842, RefRangeEnd = 210843, XrefRangeStart = 210827, XrefRangeEnd = 210842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public SinglePlotData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
