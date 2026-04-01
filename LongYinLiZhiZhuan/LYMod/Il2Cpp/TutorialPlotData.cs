using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp;

[System.Serializable]
public class TutorialPlotData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_tutorialText;

	private static readonly System.IntPtr NativeFieldInfoPtr_tutorialPic;

	private static readonly System.IntPtr NativeFieldInfoPtr_highLightTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_useSpeHightLightPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_hightLightPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_hightLightSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_needClickHighLightArea;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoClickTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_tutorialSpeFuc;

	private static readonly System.IntPtr NativeFieldInfoPtr_tutorialEndSpeFuc;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string tutorialText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tutorialText);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tutorialText)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string tutorialPic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tutorialPic);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tutorialPic)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe GameObject highLightTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highLightTarget);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highLightTarget)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe bool useSpeHightLightPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useSpeHightLightPos);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useSpeHightLightPos)) = flag;
		}
	}

	public unsafe Vector3 hightLightPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hightLightPos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hightLightPos)) = vector;
		}
	}

	public unsafe Vector3 hightLightSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hightLightSize);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hightLightSize)) = vector;
		}
	}

	public unsafe bool needClickHighLightArea
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needClickHighLightArea);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needClickHighLightArea)) = flag;
		}
	}

	public unsafe GameObject autoClickTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoClickTarget);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoClickTarget)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe string tutorialSpeFuc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tutorialSpeFuc);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tutorialSpeFuc)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string tutorialEndSpeFuc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tutorialEndSpeFuc);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tutorialEndSpeFuc)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static TutorialPlotData()
	{
		Il2CppClassPointerStore<TutorialPlotData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TutorialPlotData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialPlotData>.NativeClassPtr);
		NativeFieldInfoPtr_tutorialText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPlotData>.NativeClassPtr, "tutorialText");
		NativeFieldInfoPtr_tutorialPic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPlotData>.NativeClassPtr, "tutorialPic");
		NativeFieldInfoPtr_highLightTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPlotData>.NativeClassPtr, "highLightTarget");
		NativeFieldInfoPtr_useSpeHightLightPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPlotData>.NativeClassPtr, "useSpeHightLightPos");
		NativeFieldInfoPtr_hightLightPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPlotData>.NativeClassPtr, "hightLightPos");
		NativeFieldInfoPtr_hightLightSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPlotData>.NativeClassPtr, "hightLightSize");
		NativeFieldInfoPtr_needClickHighLightArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPlotData>.NativeClassPtr, "needClickHighLightArea");
		NativeFieldInfoPtr_autoClickTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPlotData>.NativeClassPtr, "autoClickTarget");
		NativeFieldInfoPtr_tutorialSpeFuc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPlotData>.NativeClassPtr, "tutorialSpeFuc");
		NativeFieldInfoPtr_tutorialEndSpeFuc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPlotData>.NativeClassPtr, "tutorialEndSpeFuc");
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialPlotData>.NativeClassPtr, 100671990);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialPlotData>.NativeClassPtr, 100671991);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339084, XrefRangeEnd = 339099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(1513)]
	[CachedScanResults(RefRangeStart = 4870, RefRangeEnd = 6383, XrefRangeStart = 4870, XrefRangeEnd = 6383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TutorialPlotData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialPlotData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TutorialPlotData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
