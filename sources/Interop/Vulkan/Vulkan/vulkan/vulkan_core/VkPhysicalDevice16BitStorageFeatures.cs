// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDevice16BitStorageFeatures
{
    public VkStructureType sType;

    public void* pNext;

    public VkBool32 storageBuffer16BitAccess;

    public VkBool32 uniformAndStorageBuffer16BitAccess;

    public VkBool32 storagePushConstant16;

    public VkBool32 storageInputOutput16;
}
