// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_win32.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkD3D12FenceSubmitInfoKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("uint32_t")]
        public uint waitSemaphoreValuesCount;

        [NativeTypeName("const uint64_t *")]
        public ulong* pWaitSemaphoreValues;

        [NativeTypeName("uint32_t")]
        public uint signalSemaphoreValuesCount;

        [NativeTypeName("const uint64_t *")]
        public ulong* pSignalSemaphoreValues;
    }
}
