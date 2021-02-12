// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.162
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkCopyAccelerationStructureModeKHR
    {
        VK_COPY_ACCELERATION_STRUCTURE_MODE_CLONE_KHR = 0,
        VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_KHR = 1,
        VK_COPY_ACCELERATION_STRUCTURE_MODE_SERIALIZE_KHR = 2,
        VK_COPY_ACCELERATION_STRUCTURE_MODE_DESERIALIZE_KHR = 3,
        VK_COPY_ACCELERATION_STRUCTURE_MODE_CLONE_NV = VK_COPY_ACCELERATION_STRUCTURE_MODE_CLONE_KHR,
        VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_NV = VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_KHR,
        VK_COPY_ACCELERATION_STRUCTURE_MODE_MAX_ENUM_KHR = 0x7FFFFFFF,
    }
}
