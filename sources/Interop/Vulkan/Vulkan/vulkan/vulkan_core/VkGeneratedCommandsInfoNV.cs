// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkGeneratedCommandsInfoNV
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        public VkPipelineBindPoint pipelineBindPoint;

        public VkPipeline pipeline;

        public VkIndirectCommandsLayoutNV indirectCommandsLayout;

        [NativeTypeName("uint32_t")]
        public uint streamCount;

        [NativeTypeName("const VkIndirectCommandsStreamNV *")]
        public VkIndirectCommandsStreamNV* pStreams;

        [NativeTypeName("uint32_t")]
        public uint sequencesCount;

        public VkBuffer preprocessBuffer;

        [NativeTypeName("VkDeviceSize")]
        public ulong preprocessOffset;

        [NativeTypeName("VkDeviceSize")]
        public ulong preprocessSize;

        public VkBuffer sequencesCountBuffer;

        [NativeTypeName("VkDeviceSize")]
        public ulong sequencesCountOffset;

        public VkBuffer sequencesIndexBuffer;

        [NativeTypeName("VkDeviceSize")]
        public ulong sequencesIndexOffset;
    }
}