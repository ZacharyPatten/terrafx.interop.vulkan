// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceDriverProperties
{
    public VkStructureType sType;

    public void* pNext;

    public VkDriverId driverID;

    [NativeTypeName("char[256]")]
    public fixed sbyte driverName[256];

    [NativeTypeName("char[256]")]
    public fixed sbyte driverInfo[256];

    public VkConformanceVersion conformanceVersion;
}
