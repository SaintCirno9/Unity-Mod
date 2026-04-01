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

public class TypewriterEffect : MonoBehaviour
{
	public sealed class FadeEntry : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_index;

		private static readonly System.IntPtr NativeFieldInfoPtr_text;

		private static readonly System.IntPtr NativeFieldInfoPtr_alpha;

		public unsafe int index
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_index);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_index)) = num;
			}
		}

		public unsafe string text
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_text)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe float alpha
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alpha);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alpha)) = num;
			}
		}

		static FadeEntry()
		{
			Il2CppClassPointerStore<FadeEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypewriterEffect>.NativeClassPtr, "FadeEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FadeEntry>.NativeClassPtr);
			NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeEntry>.NativeClassPtr, "index");
			NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeEntry>.NativeClassPtr, "text");
			NativeFieldInfoPtr_alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeEntry>.NativeClassPtr, "alpha");
		}

		public FadeEntry(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public FadeEntry()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FadeEntry>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_current;

	private static readonly System.IntPtr NativeFieldInfoPtr_charsPerSecond;

	private static readonly System.IntPtr NativeFieldInfoPtr_fadeInTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_delayOnPeriod;

	private static readonly System.IntPtr NativeFieldInfoPtr_delayOnNewLine;

	private static readonly System.IntPtr NativeFieldInfoPtr_scrollView;

	private static readonly System.IntPtr NativeFieldInfoPtr_keepFullDimensions;

	private static readonly System.IntPtr NativeFieldInfoPtr_onFinished;

	private static readonly System.IntPtr NativeFieldInfoPtr_mLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr_mFullText;

	private static readonly System.IntPtr NativeFieldInfoPtr_mCurrentOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_mNextChar;

	private static readonly System.IntPtr NativeFieldInfoPtr_mReset;

	private static readonly System.IntPtr NativeFieldInfoPtr_mActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_mFade;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetToBeginning_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finish_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static TypewriterEffect current
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_current, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TypewriterEffect>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_current, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)typewriterEffect));
		}
	}

	public unsafe int charsPerSecond
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_charsPerSecond);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_charsPerSecond)) = num;
		}
	}

	public unsafe float fadeInTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeInTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeInTime)) = num;
		}
	}

	public unsafe float delayOnPeriod
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delayOnPeriod);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delayOnPeriod)) = num;
		}
	}

	public unsafe float delayOnNewLine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delayOnNewLine);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delayOnNewLine)) = num;
		}
	}

	public unsafe UIScrollView scrollView
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scrollView);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIScrollView>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scrollView)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIScrollView));
		}
	}

	public unsafe bool keepFullDimensions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keepFullDimensions);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keepFullDimensions)) = flag;
		}
	}

	public unsafe List<EventDelegate> onFinished
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onFinished);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<EventDelegate>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onFinished)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe UILabel mLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mLabel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UILabel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mLabel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uILabel));
		}
	}

	public unsafe string mFullText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mFullText);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mFullText)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int mCurrentOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mCurrentOffset);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mCurrentOffset)) = num;
		}
	}

	public unsafe float mNextChar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mNextChar);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mNextChar)) = num;
		}
	}

	public unsafe bool mReset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mReset);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mReset)) = flag;
		}
	}

	public unsafe bool mActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mActive)) = flag;
		}
	}

	public unsafe BetterList<FadeEntry> mFade
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mFade);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BetterList<FadeEntry>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mFade)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)betterList));
		}
	}

	public unsafe bool isActive
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static TypewriterEffect()
	{
		Il2CppClassPointerStore<TypewriterEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TypewriterEffect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypewriterEffect>.NativeClassPtr);
		NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypewriterEffect>.NativeClassPtr, "current");
		NativeFieldInfoPtr_charsPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypewriterEffect>.NativeClassPtr, "charsPerSecond");
		NativeFieldInfoPtr_fadeInTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypewriterEffect>.NativeClassPtr, "fadeInTime");
		NativeFieldInfoPtr_delayOnPeriod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypewriterEffect>.NativeClassPtr, "delayOnPeriod");
		NativeFieldInfoPtr_delayOnNewLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypewriterEffect>.NativeClassPtr, "delayOnNewLine");
		NativeFieldInfoPtr_scrollView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypewriterEffect>.NativeClassPtr, "scrollView");
		NativeFieldInfoPtr_keepFullDimensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypewriterEffect>.NativeClassPtr, "keepFullDimensions");
		NativeFieldInfoPtr_onFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypewriterEffect>.NativeClassPtr, "onFinished");
		NativeFieldInfoPtr_mLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypewriterEffect>.NativeClassPtr, "mLabel");
		NativeFieldInfoPtr_mFullText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypewriterEffect>.NativeClassPtr, "mFullText");
		NativeFieldInfoPtr_mCurrentOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypewriterEffect>.NativeClassPtr, "mCurrentOffset");
		NativeFieldInfoPtr_mNextChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypewriterEffect>.NativeClassPtr, "mNextChar");
		NativeFieldInfoPtr_mReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypewriterEffect>.NativeClassPtr, "mReset");
		NativeFieldInfoPtr_mActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypewriterEffect>.NativeClassPtr, "mActive");
		NativeFieldInfoPtr_mFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypewriterEffect>.NativeClassPtr, "mFade");
		NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypewriterEffect>.NativeClassPtr, 100663441);
		NativeMethodInfoPtr_ResetToBeginning_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypewriterEffect>.NativeClassPtr, 100663442);
		NativeMethodInfoPtr_Finish_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypewriterEffect>.NativeClassPtr, 100663443);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypewriterEffect>.NativeClassPtr, 100663444);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypewriterEffect>.NativeClassPtr, 100663445);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypewriterEffect>.NativeClassPtr, 100663446);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypewriterEffect>.NativeClassPtr, 100663447);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44627, XrefRangeEnd = 44629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetToBeginning()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetToBeginning_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 44647, RefRangeEnd = 44649, XrefRangeStart = 44629, XrefRangeEnd = 44647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Finish()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Finish_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44649, XrefRangeEnd = 44650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 44709, RefRangeEnd = 44710, XrefRangeStart = 44650, XrefRangeEnd = 44709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44710, XrefRangeEnd = 44728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TypewriterEffect()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypewriterEffect>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TypewriterEffect(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
