// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan
{
    public enum VkDynamicState
    {
        VK_DYNAMIC_STATE_VIEWPORT = 0,
        VK_DYNAMIC_STATE_SCISSOR = 1,
        VK_DYNAMIC_STATE_LINE_WIDTH = 2,
        VK_DYNAMIC_STATE_DEPTH_BIAS = 3,
        VK_DYNAMIC_STATE_BLEND_CONSTANTS = 4,
        VK_DYNAMIC_STATE_DEPTH_BOUNDS = 5,
        VK_DYNAMIC_STATE_STENCIL_COMPARE_MASK = 6,
        VK_DYNAMIC_STATE_STENCIL_WRITE_MASK = 7,
        VK_DYNAMIC_STATE_STENCIL_REFERENCE = 8,
        VK_DYNAMIC_STATE_CULL_MODE = 1000267000,
        VK_DYNAMIC_STATE_FRONT_FACE = 1000267001,
        VK_DYNAMIC_STATE_PRIMITIVE_TOPOLOGY = 1000267002,
        VK_DYNAMIC_STATE_VIEWPORT_WITH_COUNT = 1000267003,
        VK_DYNAMIC_STATE_SCISSOR_WITH_COUNT = 1000267004,
        VK_DYNAMIC_STATE_VERTEX_INPUT_BINDING_STRIDE = 1000267005,
        VK_DYNAMIC_STATE_DEPTH_TEST_ENABLE = 1000267006,
        VK_DYNAMIC_STATE_DEPTH_WRITE_ENABLE = 1000267007,
        VK_DYNAMIC_STATE_DEPTH_COMPARE_OP = 1000267008,
        VK_DYNAMIC_STATE_DEPTH_BOUNDS_TEST_ENABLE = 1000267009,
        VK_DYNAMIC_STATE_STENCIL_TEST_ENABLE = 1000267010,
        VK_DYNAMIC_STATE_STENCIL_OP = 1000267011,
        VK_DYNAMIC_STATE_RASTERIZER_DISCARD_ENABLE = 1000377001,
        VK_DYNAMIC_STATE_DEPTH_BIAS_ENABLE = 1000377002,
        VK_DYNAMIC_STATE_PRIMITIVE_RESTART_ENABLE = 1000377004,
        VK_DYNAMIC_STATE_VIEWPORT_W_SCALING_NV = 1000087000,
        VK_DYNAMIC_STATE_DISCARD_RECTANGLE_EXT = 1000099000,
        VK_DYNAMIC_STATE_SAMPLE_LOCATIONS_EXT = 1000143000,
        VK_DYNAMIC_STATE_RAY_TRACING_PIPELINE_STACK_SIZE_KHR = 1000347000,
        VK_DYNAMIC_STATE_VIEWPORT_SHADING_RATE_PALETTE_NV = 1000164004,
        VK_DYNAMIC_STATE_VIEWPORT_COARSE_SAMPLE_ORDER_NV = 1000164006,
        VK_DYNAMIC_STATE_EXCLUSIVE_SCISSOR_NV = 1000205001,
        VK_DYNAMIC_STATE_FRAGMENT_SHADING_RATE_KHR = 1000226000,
        VK_DYNAMIC_STATE_LINE_STIPPLE_EXT = 1000259000,
        VK_DYNAMIC_STATE_VERTEX_INPUT_EXT = 1000352000,
        VK_DYNAMIC_STATE_PATCH_CONTROL_POINTS_EXT = 1000377000,
        VK_DYNAMIC_STATE_LOGIC_OP_EXT = 1000377003,
        VK_DYNAMIC_STATE_COLOR_WRITE_ENABLE_EXT = 1000381000,
        VK_DYNAMIC_STATE_CULL_MODE_EXT = VK_DYNAMIC_STATE_CULL_MODE,
        VK_DYNAMIC_STATE_FRONT_FACE_EXT = VK_DYNAMIC_STATE_FRONT_FACE,
        VK_DYNAMIC_STATE_PRIMITIVE_TOPOLOGY_EXT = VK_DYNAMIC_STATE_PRIMITIVE_TOPOLOGY,
        VK_DYNAMIC_STATE_VIEWPORT_WITH_COUNT_EXT = VK_DYNAMIC_STATE_VIEWPORT_WITH_COUNT,
        VK_DYNAMIC_STATE_SCISSOR_WITH_COUNT_EXT = VK_DYNAMIC_STATE_SCISSOR_WITH_COUNT,
        VK_DYNAMIC_STATE_VERTEX_INPUT_BINDING_STRIDE_EXT = VK_DYNAMIC_STATE_VERTEX_INPUT_BINDING_STRIDE,
        VK_DYNAMIC_STATE_DEPTH_TEST_ENABLE_EXT = VK_DYNAMIC_STATE_DEPTH_TEST_ENABLE,
        VK_DYNAMIC_STATE_DEPTH_WRITE_ENABLE_EXT = VK_DYNAMIC_STATE_DEPTH_WRITE_ENABLE,
        VK_DYNAMIC_STATE_DEPTH_COMPARE_OP_EXT = VK_DYNAMIC_STATE_DEPTH_COMPARE_OP,
        VK_DYNAMIC_STATE_DEPTH_BOUNDS_TEST_ENABLE_EXT = VK_DYNAMIC_STATE_DEPTH_BOUNDS_TEST_ENABLE,
        VK_DYNAMIC_STATE_STENCIL_TEST_ENABLE_EXT = VK_DYNAMIC_STATE_STENCIL_TEST_ENABLE,
        VK_DYNAMIC_STATE_STENCIL_OP_EXT = VK_DYNAMIC_STATE_STENCIL_OP,
        VK_DYNAMIC_STATE_RASTERIZER_DISCARD_ENABLE_EXT = VK_DYNAMIC_STATE_RASTERIZER_DISCARD_ENABLE,
        VK_DYNAMIC_STATE_DEPTH_BIAS_ENABLE_EXT = VK_DYNAMIC_STATE_DEPTH_BIAS_ENABLE,
        VK_DYNAMIC_STATE_PRIMITIVE_RESTART_ENABLE_EXT = VK_DYNAMIC_STATE_PRIMITIVE_RESTART_ENABLE,
        VK_DYNAMIC_STATE_MAX_ENUM = 0x7FFFFFFF,
    }
}
