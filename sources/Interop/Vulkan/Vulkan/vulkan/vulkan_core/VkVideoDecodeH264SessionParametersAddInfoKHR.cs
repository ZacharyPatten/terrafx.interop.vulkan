// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkVideoDecodeH264SessionParametersAddInfoKHR
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    [NativeTypeName("uint32_t")]
    public uint stdSPSCount;

    [NativeTypeName("const StdVideoH264SequenceParameterSet *")]
    public StdVideoH264SequenceParameterSet* pStdSPSs;

    [NativeTypeName("uint32_t")]
    public uint stdPPSCount;

    [NativeTypeName("const StdVideoH264PictureParameterSet *")]
    public StdVideoH264PictureParameterSet* pStdPPSs;
}
