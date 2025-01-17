// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoEncodeH265WeightTableFlags
{
    [NativeTypeName("uint16_t")]
    public ushort luma_weight_l0_flag;

    [NativeTypeName("uint16_t")]
    public ushort chroma_weight_l0_flag;

    [NativeTypeName("uint16_t")]
    public ushort luma_weight_l1_flag;

    [NativeTypeName("uint16_t")]
    public ushort chroma_weight_l1_flag;
}
