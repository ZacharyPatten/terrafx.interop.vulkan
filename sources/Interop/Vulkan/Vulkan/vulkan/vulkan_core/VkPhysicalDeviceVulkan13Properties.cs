// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceVulkan13Properties
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("uint32_t")]
    public uint minSubgroupSize;

    [NativeTypeName("uint32_t")]
    public uint maxSubgroupSize;

    [NativeTypeName("uint32_t")]
    public uint maxComputeWorkgroupSubgroups;

    public VkShaderStageFlags requiredSubgroupSizeStages;

    [NativeTypeName("uint32_t")]
    public uint maxInlineUniformBlockSize;

    [NativeTypeName("uint32_t")]
    public uint maxPerStageDescriptorInlineUniformBlocks;

    [NativeTypeName("uint32_t")]
    public uint maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;

    [NativeTypeName("uint32_t")]
    public uint maxDescriptorSetInlineUniformBlocks;

    [NativeTypeName("uint32_t")]
    public uint maxDescriptorSetUpdateAfterBindInlineUniformBlocks;

    [NativeTypeName("uint32_t")]
    public uint maxInlineUniformTotalSize;

    public VkBool32 integerDotProduct8BitUnsignedAccelerated;

    public VkBool32 integerDotProduct8BitSignedAccelerated;

    public VkBool32 integerDotProduct8BitMixedSignednessAccelerated;

    public VkBool32 integerDotProduct4x8BitPackedUnsignedAccelerated;

    public VkBool32 integerDotProduct4x8BitPackedSignedAccelerated;

    public VkBool32 integerDotProduct4x8BitPackedMixedSignednessAccelerated;

    public VkBool32 integerDotProduct16BitUnsignedAccelerated;

    public VkBool32 integerDotProduct16BitSignedAccelerated;

    public VkBool32 integerDotProduct16BitMixedSignednessAccelerated;

    public VkBool32 integerDotProduct32BitUnsignedAccelerated;

    public VkBool32 integerDotProduct32BitSignedAccelerated;

    public VkBool32 integerDotProduct32BitMixedSignednessAccelerated;

    public VkBool32 integerDotProduct64BitUnsignedAccelerated;

    public VkBool32 integerDotProduct64BitSignedAccelerated;

    public VkBool32 integerDotProduct64BitMixedSignednessAccelerated;

    public VkBool32 integerDotProductAccumulatingSaturating8BitUnsignedAccelerated;

    public VkBool32 integerDotProductAccumulatingSaturating8BitSignedAccelerated;

    public VkBool32 integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;

    public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;

    public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;

    public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;

    public VkBool32 integerDotProductAccumulatingSaturating16BitUnsignedAccelerated;

    public VkBool32 integerDotProductAccumulatingSaturating16BitSignedAccelerated;

    public VkBool32 integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;

    public VkBool32 integerDotProductAccumulatingSaturating32BitUnsignedAccelerated;

    public VkBool32 integerDotProductAccumulatingSaturating32BitSignedAccelerated;

    public VkBool32 integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;

    public VkBool32 integerDotProductAccumulatingSaturating64BitUnsignedAccelerated;

    public VkBool32 integerDotProductAccumulatingSaturating64BitSignedAccelerated;

    public VkBool32 integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;

    [NativeTypeName("VkDeviceSize")]
    public ulong storageTexelBufferOffsetAlignmentBytes;

    public VkBool32 storageTexelBufferOffsetSingleTexelAlignment;

    [NativeTypeName("VkDeviceSize")]
    public ulong uniformTexelBufferOffsetAlignmentBytes;

    public VkBool32 uniformTexelBufferOffsetSingleTexelAlignment;

    [NativeTypeName("VkDeviceSize")]
    public ulong maxBufferSize;
}
