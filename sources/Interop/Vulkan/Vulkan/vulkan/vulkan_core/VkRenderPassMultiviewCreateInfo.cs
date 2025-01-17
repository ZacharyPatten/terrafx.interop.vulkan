// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkRenderPassMultiviewCreateInfo
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    [NativeTypeName("uint32_t")]
    public uint subpassCount;

    [NativeTypeName("const uint32_t *")]
    public uint* pViewMasks;

    [NativeTypeName("uint32_t")]
    public uint dependencyCount;

    [NativeTypeName("const int32_t *")]
    public int* pViewOffsets;

    [NativeTypeName("uint32_t")]
    public uint correlationMaskCount;

    [NativeTypeName("const uint32_t *")]
    public uint* pCorrelationMasks;
}
