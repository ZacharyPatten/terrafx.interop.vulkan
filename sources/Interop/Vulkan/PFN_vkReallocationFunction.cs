// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from src\spec\vk.xml in the Vulkan-Docs repository for tag v1.0.51-core
// Original source is Copyright © 2015-2017 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [SuppressUnmanagedCodeSecurity]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, BestFitMapping = false, CharSet = CharSet.Ansi, SetLastError = false, ThrowOnUnmappableChar = false)]
    public /* static */ unsafe delegate void* PFN_vkReallocationFunction(
        [In] void* pUserData,
        [In, Optional] void* pOriginal,
        [In] UIntPtr size,
        [In] UIntPtr alignment,
        [In] VkSystemAllocationScope allocationScope
    );
}
