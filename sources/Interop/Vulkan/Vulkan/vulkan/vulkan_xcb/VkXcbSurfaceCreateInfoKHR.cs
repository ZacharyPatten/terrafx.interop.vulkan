// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_xcb.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkXcbSurfaceCreateInfoKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkXcbSurfaceCreateFlagsKHR")]
        public uint flags;

        public IntPtr connection;

        [NativeTypeName("xcb_window_t")]
        public uint window;
    }
}