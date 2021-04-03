// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.162
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkBindAccelerationStructureMemoryInfoNV
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkAccelerationStructureNV")]
        public ulong accelerationStructure;

        [NativeTypeName("VkDeviceMemory")]
        public ulong memory;

        [NativeTypeName("VkDeviceSize")]
        public ulong memoryOffset;

        [NativeTypeName("uint32_t")]
        public uint deviceIndexCount;

        [NativeTypeName("const uint32_t *")]
        public uint* pDeviceIndices;
    }
}