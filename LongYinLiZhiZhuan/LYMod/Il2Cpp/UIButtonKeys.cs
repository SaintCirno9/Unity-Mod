using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2Cpp;

public class UIButtonKeys : UIKeyNavigation
{
	private static readonly IntPtr NativeFieldInfoPtr_selectOnClick;

	private static readonly IntPtr NativeFieldInfoPtr_selectOnUp;

	private static readonly IntPtr NativeFieldInfoPtr_selectOnDown;

	private static readonly IntPtr NativeFieldInfoPtr_selectOnLeft;

	private static readonly IntPtr NativeFieldInfoPtr_selectOnRight;

	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Upgrade_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe UIButtonKeys selectOnClick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectOnClick);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIButtonKeys>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectOnClick)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIButtonKeys));
		}
	}

	public unsafe UIButtonKeys selectOnUp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectOnUp);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIButtonKeys>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectOnUp)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIButtonKeys));
		}
	}

	public unsafe UIButtonKeys selectOnDown
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectOnDown);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIButtonKeys>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectOnDown)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIButtonKeys));
		}
	}

	public unsafe UIButtonKeys selectOnLeft
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectOnLeft);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIButtonKeys>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectOnLeft)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIButtonKeys));
		}
	}

	public unsafe UIButtonKeys selectOnRight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectOnRight);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIButtonKeys>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectOnRight)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIButtonKeys));
		}
	}

	static UIButtonKeys()
	{
		Il2CppClassPointerStore<UIButtonKeys>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UIButtonKeys");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIButtonKeys>.NativeClassPtr);
		NativeFieldInfoPtr_selectOnClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonKeys>.NativeClassPtr, "selectOnClick");
		NativeFieldInfoPtr_selectOnUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonKeys>.NativeClassPtr, "selectOnUp");
		NativeFieldInfoPtr_selectOnDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonKeys>.NativeClassPtr, "selectOnDown");
		NativeFieldInfoPtr_selectOnLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonKeys>.NativeClassPtr, "selectOnLeft");
		NativeFieldInfoPtr_selectOnRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonKeys>.NativeClassPtr, "selectOnRight");
		NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonKeys>.NativeClassPtr, 100663484);
		NativeMethodInfoPtr_Upgrade_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonKeys>.NativeClassPtr, 100663485);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonKeys>.NativeClassPtr, 100663486);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45076, XrefRangeEnd = 45078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 45146, RefRangeEnd = 45147, XrefRangeStart = 45078, XrefRangeEnd = 45146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Upgrade()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Upgrade_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45147, XrefRangeEnd = 45151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIButtonKeys()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIButtonKeys>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UIButtonKeys(IntPtr pointer)
		: base(pointer)
	{
	}
}
