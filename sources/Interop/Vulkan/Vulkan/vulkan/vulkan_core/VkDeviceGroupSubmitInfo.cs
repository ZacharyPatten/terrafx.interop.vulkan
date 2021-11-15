// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkDeviceGroupSubmitInfo
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("uint32_t")]
        public uint waitSemaphoreCount;

        [NativeTypeName("const uint32_t *")]
        public uint* pWaitSemaphoreDeviceIndices;

        [NativeTypeName("uint32_t")]
        public uint commandBufferCount;

        [NativeTypeName("const uint32_t *")]
        public uint* pCommandBufferDeviceMasks;

        [NativeTypeName("uint32_t")]
        public uint signalSemaphoreCount;

        [NativeTypeName("const uint32_t *")]
        public uint* pSignalSemaphoreDeviceIndices;
    }
}