// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan
{
    public enum VkToolPurposeFlags
    {
        VK_TOOL_PURPOSE_VALIDATION_BIT = 0x00000001,
        VK_TOOL_PURPOSE_PROFILING_BIT = 0x00000002,
        VK_TOOL_PURPOSE_TRACING_BIT = 0x00000004,
        VK_TOOL_PURPOSE_ADDITIONAL_FEATURES_BIT = 0x00000008,
        VK_TOOL_PURPOSE_MODIFYING_FEATURES_BIT = 0x00000010,
        VK_TOOL_PURPOSE_DEBUG_REPORTING_BIT_EXT = 0x00000020,
        VK_TOOL_PURPOSE_DEBUG_MARKERS_BIT_EXT = 0x00000040,
        VK_TOOL_PURPOSE_VALIDATION_BIT_EXT = VK_TOOL_PURPOSE_VALIDATION_BIT,
        VK_TOOL_PURPOSE_PROFILING_BIT_EXT = VK_TOOL_PURPOSE_PROFILING_BIT,
        VK_TOOL_PURPOSE_TRACING_BIT_EXT = VK_TOOL_PURPOSE_TRACING_BIT,
        VK_TOOL_PURPOSE_ADDITIONAL_FEATURES_BIT_EXT = VK_TOOL_PURPOSE_ADDITIONAL_FEATURES_BIT,
        VK_TOOL_PURPOSE_MODIFYING_FEATURES_BIT_EXT = VK_TOOL_PURPOSE_MODIFYING_FEATURES_BIT,
        VK_TOOL_PURPOSE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
    }
}
