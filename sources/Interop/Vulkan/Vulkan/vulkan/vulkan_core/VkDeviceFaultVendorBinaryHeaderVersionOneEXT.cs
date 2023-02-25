// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkDeviceFaultVendorBinaryHeaderVersionOneEXT
{
    [NativeTypeName("uint32_t")]
    public uint headerSize;

    public VkDeviceFaultVendorBinaryHeaderVersionEXT headerVersion;

    [NativeTypeName("uint32_t")]
    public uint vendorID;

    [NativeTypeName("uint32_t")]
    public uint deviceID;

    [NativeTypeName("uint32_t")]
    public uint driverVersion;

    [NativeTypeName("uint8_t[16]")]
    public fixed byte pipelineCacheUUID[16];

    [NativeTypeName("uint32_t")]
    public uint applicationNameOffset;

    [NativeTypeName("uint32_t")]
    public uint applicationVersion;

    [NativeTypeName("uint32_t")]
    public uint engineNameOffset;
}