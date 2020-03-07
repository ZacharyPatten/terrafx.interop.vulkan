// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkPipelineExecutableStatisticFormatKHR
    {
        VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_BOOL32_KHR = 0,
        VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_INT64_KHR = 1,
        VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_UINT64_KHR = 2,
        VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_FLOAT64_KHR = 3,
        VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_BEGIN_RANGE_KHR = VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_BOOL32_KHR,
        VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_END_RANGE_KHR = VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_FLOAT64_KHR,
        VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_RANGE_SIZE_KHR = (VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_FLOAT64_KHR - VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_BOOL32_KHR + 1),
        VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_MAX_ENUM_KHR = 0x7FFFFFFF,
    }
}