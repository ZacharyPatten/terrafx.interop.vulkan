// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkCopyImageToBufferInfo2KHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        public VkImage srcImage;

        public VkImageLayout srcImageLayout;

        public VkBuffer dstBuffer;

        [NativeTypeName("uint32_t")]
        public uint regionCount;

        [NativeTypeName("const VkBufferImageCopy2KHR *")]
        public VkBufferImageCopy2KHR* pRegions;
    }
}
