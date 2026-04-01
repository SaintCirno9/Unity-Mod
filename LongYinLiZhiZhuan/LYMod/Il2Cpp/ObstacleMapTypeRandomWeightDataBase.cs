using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class ObstacleMapTypeRandomWeightDataBase : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_targetMapType;

	private static readonly System.IntPtr NativeFieldInfoPtr_extraRandomWeight;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe BattleMapType targetMapType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetMapType);
			return *(BattleMapType*)num;
		}
		set
		{
			*(BattleMapType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetMapType)) = battleMapType;
		}
	}

	public unsafe int extraRandomWeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraRandomWeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraRandomWeight)) = num;
		}
	}

	static ObstacleMapTypeRandomWeightDataBase()
	{
		Il2CppClassPointerStore<ObstacleMapTypeRandomWeightDataBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ObstacleMapTypeRandomWeightDataBase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObstacleMapTypeRandomWeightDataBase>.NativeClassPtr);
		NativeFieldInfoPtr_targetMapType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstacleMapTypeRandomWeightDataBase>.NativeClassPtr, "targetMapType");
		NativeFieldInfoPtr_extraRandomWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstacleMapTypeRandomWeightDataBase>.NativeClassPtr, "extraRandomWeight");
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObstacleMapTypeRandomWeightDataBase>.NativeClassPtr, 100666474);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObstacleMapTypeRandomWeightDataBase>.NativeClassPtr, 100666475);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96610, XrefRangeEnd = 96625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public unsafe ObstacleMapTypeRandomWeightDataBase()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObstacleMapTypeRandomWeightDataBase>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ObstacleMapTypeRandomWeightDataBase(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
