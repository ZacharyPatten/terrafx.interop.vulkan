// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_xlib_xrandr.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

public static partial class Vulkan
{
    [NativeTypeName("#define VK_EXT_acquire_xlib_display 1")]
    public const int VK_EXT_acquire_xlib_display = 1;

    [NativeTypeName("#define VK_EXT_ACQUIRE_XLIB_DISPLAY_SPEC_VERSION 1")]
    public const int VK_EXT_ACQUIRE_XLIB_DISPLAY_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_ACQUIRE_XLIB_DISPLAY_EXTENSION_NAME \"VK_EXT_acquire_xlib_display\"")]
    public static ReadOnlySpan<byte> VK_EXT_ACQUIRE_XLIB_DISPLAY_EXTENSION_NAME => "VK_EXT_acquire_xlib_display"u8;
}
