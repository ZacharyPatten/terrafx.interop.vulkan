// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public enum VkOpticalFlowUsageFlagBitsNV
{
    VK_OPTICAL_FLOW_USAGE_UNKNOWN_NV = 0,
    VK_OPTICAL_FLOW_USAGE_INPUT_BIT_NV = 0x00000001,
    VK_OPTICAL_FLOW_USAGE_OUTPUT_BIT_NV = 0x00000002,
    VK_OPTICAL_FLOW_USAGE_HINT_BIT_NV = 0x00000004,
    VK_OPTICAL_FLOW_USAGE_COST_BIT_NV = 0x00000008,
    VK_OPTICAL_FLOW_USAGE_GLOBAL_FLOW_BIT_NV = 0x00000010,
    VK_OPTICAL_FLOW_USAGE_FLAG_BITS_MAX_ENUM_NV = 0x7FFFFFFF,
}
