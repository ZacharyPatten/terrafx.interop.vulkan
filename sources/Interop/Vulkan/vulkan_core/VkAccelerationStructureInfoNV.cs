// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkAccelerationStructureInfoNV
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkAccelerationStructureTypeNV")]
        public VkAccelerationStructureTypeKHR type;

        [NativeTypeName("VkBuildAccelerationStructureFlagsNV")]
        public uint flags;

        [NativeTypeName("uint32_t")]
        public uint instanceCount;

        [NativeTypeName("uint32_t")]
        public uint geometryCount;

        [NativeTypeName("const VkGeometryNV *")]
        public VkGeometryNV* pGeometries;
    }
}
