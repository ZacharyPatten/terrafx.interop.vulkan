// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public partial struct VkBufferCopy
    {
        [NativeTypeName("VkDeviceSize")]
        public ulong srcOffset;

        [NativeTypeName("VkDeviceSize")]
        public ulong dstOffset;

        [NativeTypeName("VkDeviceSize")]
        public ulong size;
    }
}
