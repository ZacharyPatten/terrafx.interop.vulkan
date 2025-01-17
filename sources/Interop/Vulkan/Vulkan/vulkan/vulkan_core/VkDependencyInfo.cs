// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkDependencyInfo
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    public VkDependencyFlags dependencyFlags;

    [NativeTypeName("uint32_t")]
    public uint memoryBarrierCount;

    [NativeTypeName("const VkMemoryBarrier2 *")]
    public VkMemoryBarrier2* pMemoryBarriers;

    [NativeTypeName("uint32_t")]
    public uint bufferMemoryBarrierCount;

    [NativeTypeName("const VkBufferMemoryBarrier2 *")]
    public VkBufferMemoryBarrier2* pBufferMemoryBarriers;

    [NativeTypeName("uint32_t")]
    public uint imageMemoryBarrierCount;

    [NativeTypeName("const VkImageMemoryBarrier2 *")]
    public VkImageMemoryBarrier2* pImageMemoryBarriers;
}
