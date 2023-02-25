// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkDirectDriverLoadingInfoLUNARG
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("VkDirectDriverLoadingFlagsLUNARG")]
    public uint flags;

    [NativeTypeName("PFN_vkGetInstanceProcAddrLUNARG")]
    public delegate* unmanaged<VkInstance, sbyte*, delegate* unmanaged<void>> pfnGetInstanceProcAddr;
}
