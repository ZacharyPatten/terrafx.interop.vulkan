// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkLayerProperties
    {
        [NativeTypeName("char [256]")]
        public fixed sbyte layerName[256];

        [NativeTypeName("uint32_t")]
        public uint specVersion;

        [NativeTypeName("uint32_t")]
        public uint implementationVersion;

        [NativeTypeName("char [256]")]
        public fixed sbyte description[256];
    }
}
