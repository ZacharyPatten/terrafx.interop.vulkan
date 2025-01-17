// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_fuchsia.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkImageFormatConstraintsInfoFUCHSIA
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    public VkImageCreateInfo imageCreateInfo;

    public VkFormatFeatureFlags requiredFormatFeatures;

    public VkImageFormatConstraintsFlagsFUCHSIA flags;

    [NativeTypeName("uint64_t")]
    public ulong sysmemPixelFormat;

    [NativeTypeName("uint32_t")]
    public uint colorSpaceCount;

    [NativeTypeName("const VkSysmemColorSpaceFUCHSIA *")]
    public VkSysmemColorSpaceFUCHSIA* pColorSpaces;
}
