// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public enum StdVideoH264SliceType
{
    STD_VIDEO_H264_SLICE_TYPE_P = 0,
    STD_VIDEO_H264_SLICE_TYPE_B = 1,
    STD_VIDEO_H264_SLICE_TYPE_I = 2,
    STD_VIDEO_H264_SLICE_TYPE_INVALID = 0x7FFFFFFF,
    STD_VIDEO_H264_SLICE_TYPE_MAX_ENUM = 0x7FFFFFFF,
}
