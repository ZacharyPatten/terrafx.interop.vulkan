// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public partial struct VkSurfaceCapabilitiesKHR
    {
        [NativeTypeName("uint32_t")]
        public uint minImageCount;

        [NativeTypeName("uint32_t")]
        public uint maxImageCount;

        public VkExtent2D currentExtent;

        public VkExtent2D minImageExtent;

        public VkExtent2D maxImageExtent;

        [NativeTypeName("uint32_t")]
        public uint maxImageArrayLayers;

        [NativeTypeName("VkSurfaceTransformFlagsKHR")]
        public uint supportedTransforms;

        public VkSurfaceTransformFlagBitsKHR currentTransform;

        [NativeTypeName("VkCompositeAlphaFlagsKHR")]
        public uint supportedCompositeAlpha;

        [NativeTypeName("VkImageUsageFlags")]
        public uint supportedUsageFlags;
    }
}