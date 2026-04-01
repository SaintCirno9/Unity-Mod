using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2Cpp;

public class DebateCardData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_isPlayerCard;

	private static readonly System.IntPtr NativeFieldInfoPtr_isSpeCard;

	private static readonly System.IntPtr NativeFieldInfoPtr_rareLv;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetAttriID;

	private static readonly System.IntPtr NativeFieldInfoPtr_attriLv;

	private static readonly System.IntPtr NativeFieldInfoPtr_SpeCardName;

	private static readonly System.IntPtr NativeFieldInfoPtr_SpeCardDescribe;

	private static readonly System.IntPtr NativeFieldInfoPtr_SpeCardTalk;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Int32_Int32_Int32_0;

	public unsafe bool isPlayerCard
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPlayerCard);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPlayerCard)) = flag;
		}
	}

	public unsafe bool isSpeCard
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSpeCard);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSpeCard)) = flag;
		}
	}

	public unsafe int rareLv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rareLv);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rareLv)) = num;
		}
	}

	public unsafe int targetAttriID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetAttriID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetAttriID)) = num;
		}
	}

	public unsafe int attriLv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attriLv);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attriLv)) = num;
		}
	}

	public unsafe static List<string> SpeCardName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SpeCardName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SpeCardName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> SpeCardDescribe
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SpeCardDescribe, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SpeCardDescribe, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> SpeCardTalk
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SpeCardTalk, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SpeCardTalk, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static DebateCardData()
	{
		Il2CppClassPointerStore<DebateCardData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DebateCardData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebateCardData>.NativeClassPtr);
		NativeFieldInfoPtr_isPlayerCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebateCardData>.NativeClassPtr, "isPlayerCard");
		NativeFieldInfoPtr_isSpeCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebateCardData>.NativeClassPtr, "isSpeCard");
		NativeFieldInfoPtr_rareLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebateCardData>.NativeClassPtr, "rareLv");
		NativeFieldInfoPtr_targetAttriID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebateCardData>.NativeClassPtr, "targetAttriID");
		NativeFieldInfoPtr_attriLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebateCardData>.NativeClassPtr, "attriLv");
		NativeFieldInfoPtr_SpeCardName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebateCardData>.NativeClassPtr, "SpeCardName");
		NativeFieldInfoPtr_SpeCardDescribe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebateCardData>.NativeClassPtr, "SpeCardDescribe");
		NativeFieldInfoPtr_SpeCardTalk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebateCardData>.NativeClassPtr, "SpeCardTalk");
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebateCardData>.NativeClassPtr, 100668152);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147448, XrefRangeEnd = 147449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DebateCardData(bool _isPlayerCard, bool _isSpeCard, int _rareLv, int _targetAttriID, int _attriLv)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebateCardData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&_isPlayerCard);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_isSpeCard;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &_rareLv;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &_targetAttriID;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &_attriLv;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DebateCardData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
