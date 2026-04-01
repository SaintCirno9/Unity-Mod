using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp;

public class INGUIAtlas : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_get_spriteMaterial_Public_Abstract_Virtual_New_get_Material_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_spriteMaterial_Public_Abstract_Virtual_New_set_Void_Material_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_spriteList_Public_Abstract_Virtual_New_get_List_1_UISpriteData_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_spriteList_Public_Abstract_Virtual_New_set_Void_List_1_UISpriteData_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_texture_Public_Abstract_Virtual_New_get_Texture_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_pixelSize_Public_Abstract_Virtual_New_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_pixelSize_Public_Abstract_Virtual_New_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_premultipliedAlpha_Public_Abstract_Virtual_New_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_replacement_Public_Abstract_Virtual_New_get_INGUIAtlas_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_replacement_Public_Abstract_Virtual_New_set_Void_INGUIAtlas_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSprite_Public_Abstract_Virtual_New_UISpriteData_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetListOfSprites_Public_Abstract_Virtual_New_BetterList_1_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetListOfSprites_Public_Abstract_Virtual_New_BetterList_1_String_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_References_Public_Abstract_Virtual_New_Boolean_INGUIAtlas_0;

	private static readonly IntPtr NativeMethodInfoPtr_MarkAsChanged_Public_Abstract_Virtual_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SortAlphabetically_Public_Abstract_Virtual_New_Void_0;

	public unsafe virtual Material spriteMaterial
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_spriteMaterial_Public_Abstract_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_spriteMaterial_Public_Abstract_Virtual_New_set_Void_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe virtual List<UISpriteData> spriteList
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_spriteList_Public_Abstract_Virtual_New_get_List_1_UISpriteData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<UISpriteData>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_spriteList_Public_Abstract_Virtual_New_set_Void_List_1_UISpriteData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe virtual Texture texture
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_texture_Public_Abstract_Virtual_New_get_Texture_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr) : null;
		}
	}

	public unsafe virtual float pixelSize
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_pixelSize_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_pixelSize_Public_Abstract_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe virtual bool premultipliedAlpha
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_premultipliedAlpha_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe virtual INGUIAtlas replacement
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_replacement_Public_Abstract_Virtual_New_get_INGUIAtlas_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<INGUIAtlas>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_replacement_Public_Abstract_Virtual_New_set_Void_INGUIAtlas_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static INGUIAtlas()
	{
		Il2CppClassPointerStore<INGUIAtlas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "INGUIAtlas");
		NativeMethodInfoPtr_get_spriteMaterial_Public_Abstract_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INGUIAtlas>.NativeClassPtr, 100664861);
		NativeMethodInfoPtr_set_spriteMaterial_Public_Abstract_Virtual_New_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INGUIAtlas>.NativeClassPtr, 100664862);
		NativeMethodInfoPtr_get_spriteList_Public_Abstract_Virtual_New_get_List_1_UISpriteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INGUIAtlas>.NativeClassPtr, 100664863);
		NativeMethodInfoPtr_set_spriteList_Public_Abstract_Virtual_New_set_Void_List_1_UISpriteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INGUIAtlas>.NativeClassPtr, 100664864);
		NativeMethodInfoPtr_get_texture_Public_Abstract_Virtual_New_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INGUIAtlas>.NativeClassPtr, 100664865);
		NativeMethodInfoPtr_get_pixelSize_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INGUIAtlas>.NativeClassPtr, 100664866);
		NativeMethodInfoPtr_set_pixelSize_Public_Abstract_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INGUIAtlas>.NativeClassPtr, 100664867);
		NativeMethodInfoPtr_get_premultipliedAlpha_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INGUIAtlas>.NativeClassPtr, 100664868);
		NativeMethodInfoPtr_get_replacement_Public_Abstract_Virtual_New_get_INGUIAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INGUIAtlas>.NativeClassPtr, 100664869);
		NativeMethodInfoPtr_set_replacement_Public_Abstract_Virtual_New_set_Void_INGUIAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INGUIAtlas>.NativeClassPtr, 100664870);
		NativeMethodInfoPtr_GetSprite_Public_Abstract_Virtual_New_UISpriteData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INGUIAtlas>.NativeClassPtr, 100664871);
		NativeMethodInfoPtr_GetListOfSprites_Public_Abstract_Virtual_New_BetterList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INGUIAtlas>.NativeClassPtr, 100664872);
		NativeMethodInfoPtr_GetListOfSprites_Public_Abstract_Virtual_New_BetterList_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INGUIAtlas>.NativeClassPtr, 100664873);
		NativeMethodInfoPtr_References_Public_Abstract_Virtual_New_Boolean_INGUIAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INGUIAtlas>.NativeClassPtr, 100664874);
		NativeMethodInfoPtr_MarkAsChanged_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INGUIAtlas>.NativeClassPtr, 100664875);
		NativeMethodInfoPtr_SortAlphabetically_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INGUIAtlas>.NativeClassPtr, 100664876);
	}

	[CallerCount(0)]
	public unsafe virtual UISpriteData GetSprite(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetSprite_Public_Abstract_Virtual_New_UISpriteData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UISpriteData>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual BetterList<string> GetListOfSprites()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetListOfSprites_Public_Abstract_Virtual_New_BetterList_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BetterList<string>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual BetterList<string> GetListOfSprites(string match)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(match);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetListOfSprites_Public_Abstract_Virtual_New_BetterList_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BetterList<string>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual bool References(INGUIAtlas atlas)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)atlas);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_References_Public_Abstract_Virtual_New_Boolean_INGUIAtlas_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void MarkAsChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_MarkAsChanged_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void SortAlphabetically()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SortAlphabetically_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public INGUIAtlas(IntPtr pointer)
		: base(pointer)
	{
	}
}
