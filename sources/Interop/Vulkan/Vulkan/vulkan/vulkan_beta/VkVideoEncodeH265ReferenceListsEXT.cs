// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkVideoEncodeH265ReferenceListsEXT
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("uint8_t")]
        public byte referenceList0EntryCount;

        [NativeTypeName("const VkVideoEncodeH265DpbSlotInfoEXT *")]
        public VkVideoEncodeH265DpbSlotInfoEXT* pReferenceList0Entries;

        [NativeTypeName("uint8_t")]
        public byte referenceList1EntryCount;

        [NativeTypeName("const VkVideoEncodeH265DpbSlotInfoEXT *")]
        public VkVideoEncodeH265DpbSlotInfoEXT* pReferenceList1Entries;

        [NativeTypeName("const StdVideoEncodeH265ReferenceModifications *")]
        public StdVideoEncodeH265ReferenceModifications* pReferenceModifications;
    }
}