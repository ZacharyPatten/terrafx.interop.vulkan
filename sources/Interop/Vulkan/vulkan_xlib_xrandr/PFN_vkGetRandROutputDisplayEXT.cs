// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_xlib_xrandr.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetRandROutputDisplayEXT([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("Display *")] IntPtr dpy, [NativeTypeName("RROutput")] uint rrOutput, [NativeTypeName("VkDisplayKHR *")] ulong* pDisplay);
}
