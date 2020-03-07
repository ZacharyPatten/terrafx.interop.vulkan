// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_xlib.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("VkBool32")]
    public unsafe delegate uint PFN_vkGetPhysicalDeviceXlibPresentationSupportKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t")] uint queueFamilyIndex, [NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("VisualID")] UIntPtr visualID);
}