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
public class PlotData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_plotName;

	private static readonly System.IntPtr NativeFieldInfoPtr_spePlot;

	private static readonly System.IntPtr NativeFieldInfoPtr_plotID;

	private static readonly System.IntPtr NativeFieldInfoPtr_plotRandomHero;

	private static readonly System.IntPtr NativeFieldInfoPtr_differentForce;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetHeroID;

	private static readonly System.IntPtr NativeFieldInfoPtr_plotCallFuc;

	private static readonly System.IntPtr NativeFieldInfoPtr_randomStartPlot;

	private static readonly System.IntPtr NativeFieldInfoPtr_plotDatas;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	public unsafe string plotName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool spePlot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spePlot);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spePlot)) = flag;
		}
	}

	public unsafe int plotID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotID)) = num;
		}
	}

	public unsafe List<PlotRandomHeroData> plotRandomHero
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotRandomHero);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<PlotRandomHeroData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotRandomHero)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool differentForce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_differentForce);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_differentForce)) = flag;
		}
	}

	public unsafe int targetHeroID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetHeroID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetHeroID)) = num;
		}
	}

	public unsafe string plotCallFuc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotCallFuc);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotCallFuc)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool randomStartPlot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomStartPlot);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomStartPlot)) = flag;
		}
	}

	public unsafe List<SinglePlotData> plotDatas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotDatas);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SinglePlotData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plotDatas)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static PlotData()
	{
		Il2CppClassPointerStore<PlotData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PlotData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlotData>.NativeClassPtr);
		NativeFieldInfoPtr_plotName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlotData>.NativeClassPtr, "plotName");
		NativeFieldInfoPtr_spePlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlotData>.NativeClassPtr, "spePlot");
		NativeFieldInfoPtr_plotID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlotData>.NativeClassPtr, "plotID");
		NativeFieldInfoPtr_plotRandomHero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlotData>.NativeClassPtr, "plotRandomHero");
		NativeFieldInfoPtr_differentForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlotData>.NativeClassPtr, "differentForce");
		NativeFieldInfoPtr_targetHeroID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlotData>.NativeClassPtr, "targetHeroID");
		NativeFieldInfoPtr_plotCallFuc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlotData>.NativeClassPtr, "plotCallFuc");
		NativeFieldInfoPtr_randomStartPlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlotData>.NativeClassPtr, "randomStartPlot");
		NativeFieldInfoPtr_plotDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlotData>.NativeClassPtr, "plotDatas");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlotData>.NativeClassPtr, 100667270);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlotData>.NativeClassPtr, 100667271);
	}

	[CallerCount(160)]
	[CachedScanResults(RefRangeStart = 123221, RefRangeEnd = 123381, XrefRangeStart = 123206, XrefRangeEnd = 123221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlotData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlotData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 123396, RefRangeEnd = 123405, XrefRangeStart = 123381, XrefRangeEnd = 123396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public PlotData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
