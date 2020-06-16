// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkGeometryTypeKHR
    {
        VK_GEOMETRY_TYPE_TRIANGLES_KHR = 0,
        VK_GEOMETRY_TYPE_AABBS_KHR = 1,
        VK_GEOMETRY_TYPE_INSTANCES_KHR = 1000150000,
        VK_GEOMETRY_TYPE_TRIANGLES_NV = VK_GEOMETRY_TYPE_TRIANGLES_KHR,
        VK_GEOMETRY_TYPE_AABBS_NV = VK_GEOMETRY_TYPE_AABBS_KHR,
        VK_GEOMETRY_TYPE_BEGIN_RANGE_KHR = VK_GEOMETRY_TYPE_TRIANGLES_KHR,
        VK_GEOMETRY_TYPE_END_RANGE_KHR = VK_GEOMETRY_TYPE_AABBS_KHR,
        VK_GEOMETRY_TYPE_RANGE_SIZE_KHR = (VK_GEOMETRY_TYPE_AABBS_KHR - VK_GEOMETRY_TYPE_TRIANGLES_KHR + 1),
        VK_GEOMETRY_TYPE_MAX_ENUM_KHR = 0x7FFFFFFF,
    }
}