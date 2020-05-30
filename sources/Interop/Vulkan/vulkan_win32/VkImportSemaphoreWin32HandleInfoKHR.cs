// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_win32.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct VkImportSemaphoreWin32HandleInfoKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkSemaphore")]
        public ulong semaphore;

        [NativeTypeName("VkSemaphoreImportFlags")]
        public uint flags;

        public VkExternalSemaphoreHandleTypeFlagBits handleType;

        [NativeTypeName("HANDLE")]
        public IntPtr handle;

        [NativeTypeName("LPCWSTR")]
        public ushort* name;
    }
}
