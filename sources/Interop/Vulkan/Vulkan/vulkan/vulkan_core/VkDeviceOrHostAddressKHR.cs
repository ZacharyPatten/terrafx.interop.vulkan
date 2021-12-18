// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct VkDeviceOrHostAddressKHR
    {
        [FieldOffset(0)]
        [NativeTypeName("VkDeviceAddress")]
        public ulong deviceAddress;

        [FieldOffset(0)]
        public void* hostAddress;
    }
}
