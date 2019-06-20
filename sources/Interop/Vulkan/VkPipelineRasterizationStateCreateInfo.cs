// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from src\spec\vk.xml in the Vulkan-Docs repository for tag v1.0.51-core
// Original source is Copyright © 2015-2017 The Khronos Group Inc.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    [Unmanaged]
    public unsafe struct VkPipelineRasterizationStateCreateInfo
    {
        #region Fields
        public VkStructureType sType;

        public void* pNext;

        [NativeTypeName("VkPipelineRasterizationStateCreateFlags")]
        public uint flags;

        [NativeTypeName("VkBool32")]
        public uint depthClampEnable;

        [NativeTypeName("VkBool32")]
        public uint rasterizerDiscardEnable;

        public VkPolygonMode polygonMode;

        [NativeTypeName("VkCullModeFlags")]
        public uint cullMode;

        public VkFrontFace frontFace;

        [NativeTypeName("VkBool32")]
        public uint depthBiasEnable;

        public float depthBiasConstantFactor;

        public float depthBiasClamp;

        public float depthBiasSlopeFactor;

        public float lineWidth;
        #endregion
    }
}
