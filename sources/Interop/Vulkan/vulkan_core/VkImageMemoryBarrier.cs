// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.162
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkImageMemoryBarrier
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkAccessFlags")]
        public uint srcAccessMask;

        [NativeTypeName("VkAccessFlags")]
        public uint dstAccessMask;

        public VkImageLayout oldLayout;

        public VkImageLayout newLayout;

        [NativeTypeName("uint32_t")]
        public uint srcQueueFamilyIndex;

        [NativeTypeName("uint32_t")]
        public uint dstQueueFamilyIndex;

        [NativeTypeName("VkImage")]
        public ulong image;

        public VkImageSubresourceRange subresourceRange;
    }
}
