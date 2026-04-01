using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2Cpp;

public static class Console : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_command;

	private static readonly System.IntPtr NativeFieldInfoPtr_releaseHideCommand;

	private static readonly System.IntPtr NativeFieldInfoPtr_developCommand;

	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	private static readonly System.IntPtr NativeFieldInfoPtr_consoleHistory;

	private static readonly System.IntPtr NativeFieldInfoPtr_invincible;

	private static readonly System.IntPtr NativeMethodInfoPtr_Input_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAreaData_Public_Static_AreaData_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkillID_Public_Static_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHeroData_Public_Static_HeroData_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetForceData_Public_Static_ForceData_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Last_Public_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Next_Public_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Show_Private_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Private_Static_String_0;

	public unsafe static Il2CppStringArray command
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_command, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_command, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray releaseHideCommand
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_releaseHideCommand, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_releaseHideCommand, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray developCommand
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_developCommand, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_developCommand, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static int position
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_position, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_position, (void*)(&num));
		}
	}

	public unsafe static List<string> consoleHistory
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_consoleHistory, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_consoleHistory, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static bool invincible
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_invincible, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_invincible, (void*)(&flag));
		}
	}

	static Console()
	{
		Il2CppClassPointerStore<Console>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Console");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console>.NativeClassPtr);
		NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "command");
		NativeFieldInfoPtr_releaseHideCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "releaseHideCommand");
		NativeFieldInfoPtr_developCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "developCommand");
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "position");
		NativeFieldInfoPtr_consoleHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "consoleHistory");
		NativeFieldInfoPtr_invincible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "invincible");
		NativeMethodInfoPtr_Input_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100668579);
		NativeMethodInfoPtr_GetAreaData_Public_Static_AreaData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100668580);
		NativeMethodInfoPtr_GetSkillID_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100668581);
		NativeMethodInfoPtr_GetHeroData_Public_Static_HeroData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100668582);
		NativeMethodInfoPtr_GetForceData_Public_Static_ForceData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100668583);
		NativeMethodInfoPtr_Last_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100668584);
		NativeMethodInfoPtr_Next_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100668585);
		NativeMethodInfoPtr_Show_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100668586);
		NativeMethodInfoPtr_Clear_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100668587);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160850, XrefRangeEnd = 161046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Input(string input)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Input_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161046, XrefRangeEnd = 161056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AreaData GetAreaData(string areaName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(areaName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAreaData_Public_Static_AreaData_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AreaData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161056, XrefRangeEnd = 161066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetSkillID(string skillName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(skillName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkillID_Public_Static_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161066, XrefRangeEnd = 161084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HeroData GetHeroData(string heroName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(heroName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHeroData_Public_Static_HeroData_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161084, XrefRangeEnd = 161103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ForceData GetForceData(string forceName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(forceName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetForceData_Public_Static_ForceData_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ForceData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161103, XrefRangeEnd = 161117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Last()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Last_Public_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 161132, RefRangeEnd = 161133, XrefRangeStart = 161117, XrefRangeEnd = 161132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Next()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Next_Public_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161133, XrefRangeEnd = 161162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Show()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Show_Private_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161162, XrefRangeEnd = 161172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Clear()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Private_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public Console(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
