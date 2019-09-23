// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_win32.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkWin32KeyedMutexAcquireReleaseInfoNV
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("uint32_t")]
        public uint acquireCount;

        [NativeTypeName("const VkDeviceMemory *")]
        public ulong* pAcquireSyncs;

        [NativeTypeName("const uint64_t *")]
        public ulong* pAcquireKeys;

        [NativeTypeName("const uint32_t *")]
        public uint* pAcquireTimeoutMilliseconds;

        [NativeTypeName("uint32_t")]
        public uint releaseCount;

        [NativeTypeName("const VkDeviceMemory *")]
        public ulong* pReleaseSyncs;

        [NativeTypeName("const uint64_t *")]
        public ulong* pReleaseKeys;
    }
}
