// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_fuchsia.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkBufferCollectionPropertiesFUCHSIA
    {
        public VkStructureType sType;

        public void* pNext;

        [NativeTypeName("uint32_t")]
        public uint memoryTypeBits;

        [NativeTypeName("uint32_t")]
        public uint bufferCount;

        [NativeTypeName("uint32_t")]
        public uint createInfoIndex;

        [NativeTypeName("uint64_t")]
        public ulong sysmemPixelFormat;

        public VkFormatFeatureFlags formatFeatures;

        public VkSysmemColorSpaceFUCHSIA sysmemColorSpaceIndex;

        public VkComponentMapping samplerYcbcrConversionComponents;

        public VkSamplerYcbcrModelConversion suggestedYcbcrModel;

        public VkSamplerYcbcrRange suggestedYcbcrRange;

        public VkChromaLocation suggestedXChromaOffset;

        public VkChromaLocation suggestedYChromaOffset;
    }
}