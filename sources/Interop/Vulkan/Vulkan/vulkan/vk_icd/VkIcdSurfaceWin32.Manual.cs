// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vk_icd.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2016 The Khronos Group Inc. Copyright © 2015-2016 Valve Corporation. Copyright © 2015-2016 LunarG, Inc.

using System;

namespace TerraFX.Interop.Vulkan;

public partial struct VkIcdSurfaceWin32
{
    public VkIcdSurfaceBase @base;

    [NativeTypeName("HINSTANCE")]
    public IntPtr hinstance;

    [NativeTypeName("HWND")]
    public IntPtr hwnd;
}
