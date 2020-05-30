// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum VkImageAspectFlagBits
    {
        VK_IMAGE_ASPECT_COLOR_BIT = 0x00000001,
        VK_IMAGE_ASPECT_DEPTH_BIT = 0x00000002,
        VK_IMAGE_ASPECT_STENCIL_BIT = 0x00000004,
        VK_IMAGE_ASPECT_METADATA_BIT = 0x00000008,
        VK_IMAGE_ASPECT_PLANE_0_BIT = 0x00000010,
        VK_IMAGE_ASPECT_PLANE_1_BIT = 0x00000020,
        VK_IMAGE_ASPECT_PLANE_2_BIT = 0x00000040,
        VK_IMAGE_ASPECT_MEMORY_PLANE_0_BIT_EXT = 0x00000080,
        VK_IMAGE_ASPECT_MEMORY_PLANE_1_BIT_EXT = 0x00000100,
        VK_IMAGE_ASPECT_MEMORY_PLANE_2_BIT_EXT = 0x00000200,
        VK_IMAGE_ASPECT_MEMORY_PLANE_3_BIT_EXT = 0x00000400,
        VK_IMAGE_ASPECT_PLANE_0_BIT_KHR = VK_IMAGE_ASPECT_PLANE_0_BIT,
        VK_IMAGE_ASPECT_PLANE_1_BIT_KHR = VK_IMAGE_ASPECT_PLANE_1_BIT,
        VK_IMAGE_ASPECT_PLANE_2_BIT_KHR = VK_IMAGE_ASPECT_PLANE_2_BIT,
        VK_IMAGE_ASPECT_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
    }
}
