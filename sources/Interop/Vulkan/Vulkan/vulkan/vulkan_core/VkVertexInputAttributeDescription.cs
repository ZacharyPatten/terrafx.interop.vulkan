// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public partial struct VkVertexInputAttributeDescription
    {
        [NativeTypeName("uint32_t")]
        public uint location;

        [NativeTypeName("uint32_t")]
        public uint binding;

        public VkFormat format;

        [NativeTypeName("uint32_t")]
        public uint offset;
    }
}