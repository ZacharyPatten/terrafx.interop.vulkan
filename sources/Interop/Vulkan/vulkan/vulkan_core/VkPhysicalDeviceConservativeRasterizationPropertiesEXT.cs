// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPhysicalDeviceConservativeRasterizationPropertiesEXT
    {
        public VkStructureType sType;

        public void* pNext;

        public float primitiveOverestimationSize;

        public float maxExtraPrimitiveOverestimationSize;

        public float extraPrimitiveOverestimationSizeGranularity;

        public VkBool32 primitiveUnderestimation;

        public VkBool32 conservativePointAndLineRasterization;

        public VkBool32 degenerateTrianglesRasterized;

        public VkBool32 degenerateLinesRasterized;

        public VkBool32 fullyCoveredFragmentShaderInputVariable;

        public VkBool32 conservativeRasterizationPostDepthCoverage;
    }
}
