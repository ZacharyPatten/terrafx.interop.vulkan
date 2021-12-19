// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_fuchsia.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public enum VkImageConstraintsInfoFlagBitsFUCHSIA
    {
        VK_IMAGE_CONSTRAINTS_INFO_CPU_READ_RARELY_FUCHSIA = 0x00000001,
        VK_IMAGE_CONSTRAINTS_INFO_CPU_READ_OFTEN_FUCHSIA = 0x00000002,
        VK_IMAGE_CONSTRAINTS_INFO_CPU_WRITE_RARELY_FUCHSIA = 0x00000004,
        VK_IMAGE_CONSTRAINTS_INFO_CPU_WRITE_OFTEN_FUCHSIA = 0x00000008,
        VK_IMAGE_CONSTRAINTS_INFO_PROTECTED_OPTIONAL_FUCHSIA = 0x00000010,
        VK_IMAGE_CONSTRAINTS_INFO_FLAG_BITS_MAX_ENUM_FUCHSIA = 0x7FFFFFFF,
    }
}