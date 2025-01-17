// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct StdVideoH264SequenceParameterSetVui
{
    public StdVideoH264SpsVuiFlags flags;

    public StdVideoH264AspectRatioIdc aspect_ratio_idc;

    [NativeTypeName("uint16_t")]
    public ushort sar_width;

    [NativeTypeName("uint16_t")]
    public ushort sar_height;

    [NativeTypeName("uint8_t")]
    public byte video_format;

    [NativeTypeName("uint8_t")]
    public byte colour_primaries;

    [NativeTypeName("uint8_t")]
    public byte transfer_characteristics;

    [NativeTypeName("uint8_t")]
    public byte matrix_coefficients;

    [NativeTypeName("uint32_t")]
    public uint num_units_in_tick;

    [NativeTypeName("uint32_t")]
    public uint time_scale;

    [NativeTypeName("uint8_t")]
    public byte max_num_reorder_frames;

    [NativeTypeName("uint8_t")]
    public byte max_dec_frame_buffering;

    [NativeTypeName("uint8_t")]
    public byte chroma_sample_loc_type_top_field;

    [NativeTypeName("uint8_t")]
    public byte chroma_sample_loc_type_bottom_field;

    [NativeTypeName("uint32_t")]
    public uint reserved1;

    [NativeTypeName("const StdVideoH264HrdParameters *")]
    public StdVideoH264HrdParameters* pHrdParameters;
}
