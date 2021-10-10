// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public partial struct VkAccelerationStructureInstanceKHR
    {
        public VkTransformMatrixKHR transform;

        public uint _bitfield1;

        [NativeTypeName("uint32_t : 24")]
        public uint instanceCustomIndex
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield1 & 0xFFFFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (_bitfield1 & ~0xFFFFFFu) | (value & 0xFFFFFFu);
            }
        }

        [NativeTypeName("uint32_t : 8")]
        public uint mask
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield1 >> 24) & 0xFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (_bitfield1 & ~(0xFFu << 24)) | ((value & 0xFFu) << 24);
            }
        }

        public uint _bitfield2;

        [NativeTypeName("uint32_t : 24")]
        public uint instanceShaderBindingTableRecordOffset
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield2 & 0xFFFFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield2 = (_bitfield2 & ~0xFFFFFFu) | (value & 0xFFFFFFu);
            }
        }

        [NativeTypeName("VkGeometryInstanceFlagsKHR : 8")]
        public VkGeometryInstanceFlagsKHR flags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (VkGeometryInstanceFlagsKHR)((_bitfield2 >> 24) & 0xFFu);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield2 = (_bitfield2 & ~(0xFFu << 24)) | (((uint)(value) & 0xFFu) << 24);
            }
        }

        [NativeTypeName("uint64_t")]
        public ulong accelerationStructureReference;
    }
}
