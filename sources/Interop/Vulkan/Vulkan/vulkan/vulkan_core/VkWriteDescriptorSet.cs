// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkWriteDescriptorSet
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    public VkDescriptorSet dstSet;

    [NativeTypeName("uint32_t")]
    public uint dstBinding;

    [NativeTypeName("uint32_t")]
    public uint dstArrayElement;

    [NativeTypeName("uint32_t")]
    public uint descriptorCount;

    public VkDescriptorType descriptorType;

    [NativeTypeName("const VkDescriptorImageInfo *")]
    public VkDescriptorImageInfo* pImageInfo;

    [NativeTypeName("const VkDescriptorBufferInfo *")]
    public VkDescriptorBufferInfo* pBufferInfo;

    [NativeTypeName("const VkBufferView *")]
    public VkBufferView* pTexelBufferView;
}
