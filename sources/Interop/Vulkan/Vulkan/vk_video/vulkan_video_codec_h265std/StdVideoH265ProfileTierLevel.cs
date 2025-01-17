// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoH265ProfileTierLevel
{
    public StdVideoH265ProfileTierLevelFlags flags;

    public StdVideoH265ProfileIdc general_profile_idc;

    public StdVideoH265LevelIdc general_level_idc;
}
