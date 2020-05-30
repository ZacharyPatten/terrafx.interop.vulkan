// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint PFN_vkGetDeferredOperationMaxConcurrencyKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDeferredOperationKHR")] ulong operation);
}
