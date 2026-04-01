using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class InvStat : Il2CppSystem.Object
{
	[OriginalName("Assembly-CSharp.dll", "", "Identifier")]
	public enum Identifier
	{
		Strength,
		Constitution,
		Agility,
		Intelligence,
		Damage,
		Crit,
		Armor,
		Health,
		Mana,
		Other
	}

	[OriginalName("Assembly-CSharp.dll", "", "Modifier")]
	public enum Modifier
	{
		Added,
		Percent
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_id;

	private static readonly System.IntPtr NativeFieldInfoPtr_modifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_amount;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_Identifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDescription_Public_Static_String_Identifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareArmor_Public_Static_Int32_InvStat_InvStat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareWeapon_Public_Static_Int32_InvStat_InvStat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Identifier id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
			return *(Identifier*)num;
		}
		set
		{
			*(Identifier*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = identifier;
		}
	}

	public unsafe Modifier modifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modifier);
			return *(Modifier*)num;
		}
		set
		{
			*(Modifier*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modifier)) = modifier;
		}
	}

	public unsafe int amount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_amount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_amount)) = num;
		}
	}

	static InvStat()
	{
		Il2CppClassPointerStore<InvStat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "InvStat");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvStat>.NativeClassPtr);
		NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvStat>.NativeClassPtr, "id");
		NativeFieldInfoPtr_modifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvStat>.NativeClassPtr, "modifier");
		NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvStat>.NativeClassPtr, "amount");
		NativeMethodInfoPtr_GetName_Public_Static_String_Identifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvStat>.NativeClassPtr, 100663358);
		NativeMethodInfoPtr_GetDescription_Public_Static_String_Identifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvStat>.NativeClassPtr, 100663359);
		NativeMethodInfoPtr_CompareArmor_Public_Static_Int32_InvStat_InvStat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvStat>.NativeClassPtr, 100663360);
		NativeMethodInfoPtr_CompareWeapon_Public_Static_Int32_InvStat_InvStat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvStat>.NativeClassPtr, 100663361);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvStat>.NativeClassPtr, 100663362);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43848, XrefRangeEnd = 43852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetName(Identifier i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetName_Public_Static_String_Identifier_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43852, XrefRangeEnd = 43862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetDescription(Identifier i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDescription_Public_Static_String_Identifier_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43862, XrefRangeEnd = 43864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CompareArmor(InvStat a, InvStat b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareArmor_Public_Static_Int32_InvStat_InvStat_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43864, XrefRangeEnd = 43866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CompareWeapon(InvStat a, InvStat b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareWeapon_Public_Static_Int32_InvStat_InvStat_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1513)]
	[CachedScanResults(RefRangeStart = 4870, RefRangeEnd = 6383, XrefRangeStart = 4870, XrefRangeEnd = 6383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InvStat()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvStat>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public InvStat(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
