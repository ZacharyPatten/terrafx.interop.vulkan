// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("uint32_t")]
    public uint maxGraphicsShaderGroupCount;

    [NativeTypeName("uint32_t")]
    public uint maxIndirectSequenceCount;

    [NativeTypeName("uint32_t")]
    public uint maxIndirectCommandsTokenCount;

    [NativeTypeName("uint32_t")]
    public uint maxIndirectCommandsStreamCount;

    [NativeTypeName("uint32_t")]
    public uint maxIndirectCommandsTokenOffset;

    [NativeTypeName("uint32_t")]
    public uint maxIndirectCommandsStreamStride;

    [NativeTypeName("uint32_t")]
    public uint minSequencesCountBufferOffsetAlignment;

    [NativeTypeName("uint32_t")]
    public uint minSequencesIndexBufferOffsetAlignment;

    [NativeTypeName("uint32_t")]
    public uint minIndirectCommandsBufferOffsetAlignment;
}
