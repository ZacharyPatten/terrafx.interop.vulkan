// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct StdVideoH265HrdParameters
{
    public StdVideoH265HrdFlags flags;

    [NativeTypeName("uint8_t")]
    public byte tick_divisor_minus2;

    [NativeTypeName("uint8_t")]
    public byte du_cpb_removal_delay_increment_length_minus1;

    [NativeTypeName("uint8_t")]
    public byte dpb_output_delay_du_length_minus1;

    [NativeTypeName("uint8_t")]
    public byte bit_rate_scale;

    [NativeTypeName("uint8_t")]
    public byte cpb_size_scale;

    [NativeTypeName("uint8_t")]
    public byte cpb_size_du_scale;

    [NativeTypeName("uint8_t")]
    public byte initial_cpb_removal_delay_length_minus1;

    [NativeTypeName("uint8_t")]
    public byte au_cpb_removal_delay_length_minus1;

    [NativeTypeName("uint8_t")]
    public byte dpb_output_delay_length_minus1;

    [NativeTypeName("uint8_t[7]")]
    public fixed byte cpb_cnt_minus1[7];

    [NativeTypeName("uint16_t[7]")]
    public fixed ushort elemental_duration_in_tc_minus1[7];

    [NativeTypeName("uint16_t[3]")]
    public fixed ushort reserved[3];

    [NativeTypeName("const StdVideoH265SubLayerHrdParameters *")]
    public StdVideoH265SubLayerHrdParameters* pSubLayerHrdParametersNal;

    [NativeTypeName("const StdVideoH265SubLayerHrdParameters *")]
    public StdVideoH265SubLayerHrdParameters* pSubLayerHrdParametersVcl;
}
