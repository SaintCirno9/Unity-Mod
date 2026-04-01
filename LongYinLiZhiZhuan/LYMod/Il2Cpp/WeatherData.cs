using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp;

[System.Serializable]
public class WeatherData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseLastTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_nextAvailableWeatherID;

	private static readonly System.IntPtr NativeFieldInfoPtr_weatherSpeObj;

	private static readonly System.IntPtr NativeFieldInfoPtr_weatherSpeObjs;

	private static readonly System.IntPtr NativeFieldInfoPtr_weatherSpeObjOriginEmitRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_weatherSpeShowType;

	private static readonly System.IntPtr NativeFieldInfoPtr_weatherTravelSpeedRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseRandomRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxRateMonth;

	private static readonly System.IntPtr NativeFieldInfoPtr_generateThunder;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxVolumn;

	private static readonly System.IntPtr NativeFieldInfoPtr_cloudNumRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_cloudSpeedRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_cloudColor;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomRate_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float baseLastTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseLastTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseLastTime)) = num;
		}
	}

	public unsafe List<int> nextAvailableWeatherID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextAvailableWeatherID);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextAvailableWeatherID)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe GameObject weatherSpeObj
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weatherSpeObj);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weatherSpeObj)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe List<GameObject> weatherSpeObjs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weatherSpeObjs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weatherSpeObjs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<float> weatherSpeObjOriginEmitRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weatherSpeObjOriginEmitRate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weatherSpeObjOriginEmitRate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe WeatherSpeShowType weatherSpeShowType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weatherSpeShowType);
			return *(WeatherSpeShowType*)num;
		}
		set
		{
			*(WeatherSpeShowType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weatherSpeShowType)) = weatherSpeShowType;
		}
	}

	public unsafe float weatherTravelSpeedRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weatherTravelSpeedRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weatherTravelSpeedRate)) = num;
		}
	}

	public unsafe float baseRandomRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseRandomRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseRandomRate)) = num;
		}
	}

	public unsafe int maxRateMonth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRateMonth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRateMonth)) = num;
		}
	}

	public unsafe bool generateThunder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generateThunder);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generateThunder)) = flag;
		}
	}

	public unsafe float maxVolumn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxVolumn);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxVolumn)) = num;
		}
	}

	public unsafe float cloudNumRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cloudNumRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cloudNumRate)) = num;
		}
	}

	public unsafe float cloudSpeedRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cloudSpeedRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cloudSpeedRate)) = num;
		}
	}

	public unsafe Color cloudColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cloudColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cloudColor)) = color;
		}
	}

	static WeatherData()
	{
		Il2CppClassPointerStore<WeatherData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WeatherData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeatherData>.NativeClassPtr);
		NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherData>.NativeClassPtr, "name");
		NativeFieldInfoPtr_baseLastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherData>.NativeClassPtr, "baseLastTime");
		NativeFieldInfoPtr_nextAvailableWeatherID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherData>.NativeClassPtr, "nextAvailableWeatherID");
		NativeFieldInfoPtr_weatherSpeObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherData>.NativeClassPtr, "weatherSpeObj");
		NativeFieldInfoPtr_weatherSpeObjs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherData>.NativeClassPtr, "weatherSpeObjs");
		NativeFieldInfoPtr_weatherSpeObjOriginEmitRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherData>.NativeClassPtr, "weatherSpeObjOriginEmitRate");
		NativeFieldInfoPtr_weatherSpeShowType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherData>.NativeClassPtr, "weatherSpeShowType");
		NativeFieldInfoPtr_weatherTravelSpeedRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherData>.NativeClassPtr, "weatherTravelSpeedRate");
		NativeFieldInfoPtr_baseRandomRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherData>.NativeClassPtr, "baseRandomRate");
		NativeFieldInfoPtr_maxRateMonth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherData>.NativeClassPtr, "maxRateMonth");
		NativeFieldInfoPtr_generateThunder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherData>.NativeClassPtr, "generateThunder");
		NativeFieldInfoPtr_maxVolumn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherData>.NativeClassPtr, "maxVolumn");
		NativeFieldInfoPtr_cloudNumRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherData>.NativeClassPtr, "cloudNumRate");
		NativeFieldInfoPtr_cloudSpeedRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherData>.NativeClassPtr, "cloudSpeedRate");
		NativeFieldInfoPtr_cloudColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherData>.NativeClassPtr, "cloudColor");
		NativeMethodInfoPtr_GetRandomRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherData>.NativeClassPtr, 100672086);
		NativeMethodInfoPtr_GetRandomRate_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherData>.NativeClassPtr, 100672087);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherData>.NativeClassPtr, 100672088);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 341218, RefRangeEnd = 341220, XrefRangeStart = 341205, XrefRangeEnd = 341218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetRandomRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341220, XrefRangeEnd = 341225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetRandomRate(int targetMonth)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&targetMonth);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomRate_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341225, XrefRangeEnd = 341227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WeatherData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeatherData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public WeatherData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
