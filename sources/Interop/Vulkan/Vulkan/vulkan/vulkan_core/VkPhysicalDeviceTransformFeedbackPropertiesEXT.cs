// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceTransformFeedbackPropertiesEXT
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("uint32_t")]
    public uint maxTransformFeedbackStreams;

    [NativeTypeName("uint32_t")]
    public uint maxTransformFeedbackBuffers;

    [NativeTypeName("VkDeviceSize")]
    public ulong maxTransformFeedbackBufferSize;

    [NativeTypeName("uint32_t")]
    public uint maxTransformFeedbackStreamDataSize;

    [NativeTypeName("uint32_t")]
    public uint maxTransformFeedbackBufferDataSize;

    [NativeTypeName("uint32_t")]
    public uint maxTransformFeedbackBufferDataStride;

    public VkBool32 transformFeedbackQueries;

    public VkBool32 transformFeedbackStreamsLinesTriangles;

    public VkBool32 transformFeedbackRasterizationStreamSelect;

    public VkBool32 transformFeedbackDraw;
}
