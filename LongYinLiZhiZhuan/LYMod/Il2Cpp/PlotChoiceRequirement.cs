using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class PlotChoiceRequirement : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_requireType;

	private static readonly System.IntPtr NativeFieldInfoPtr_requireNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoChangeReuqireByDifficulty;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ChoiceRequirementType_Single_0;

	public unsafe ChoiceRequirementType requireType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requireType);
			return *(ChoiceRequirementType*)num;
		}
		set
		{
			*(ChoiceRequirementType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requireType)) = choiceRequirementType;
		}
	}

	public unsafe float requireNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requireNum);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requireNum)) = num;
		}
	}

	public unsafe bool autoChangeReuqireByDifficulty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoChangeReuqireByDifficulty);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoChangeReuqireByDifficulty)) = flag;
		}
	}

	static PlotChoiceRequirement()
	{
		Il2CppClassPointerStore<PlotChoiceRequirement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PlotChoiceRequirement");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlotChoiceRequirement>.NativeClassPtr);
		NativeFieldInfoPtr_requireType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlotChoiceRequirement>.NativeClassPtr, "requireType");
		NativeFieldInfoPtr_requireNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlotChoiceRequirement>.NativeClassPtr, "requireNum");
		NativeFieldInfoPtr_autoChangeReuqireByDifficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlotChoiceRequirement>.NativeClassPtr, "autoChangeReuqireByDifficulty");
		NativeMethodInfoPtr__ctor_Public_Void_ChoiceRequirementType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlotChoiceRequirement>.NativeClassPtr, 100669701);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 113338, RefRangeEnd = 113353, XrefRangeStart = 113338, XrefRangeEnd = 113353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlotChoiceRequirement(ChoiceRequirementType _requireType, float _requireNum)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlotChoiceRequirement>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_requireType);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_requireNum;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ChoiceRequirementType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PlotChoiceRequirement(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
