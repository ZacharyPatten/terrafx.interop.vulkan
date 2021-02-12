// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.162
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
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
        VK_DYNAMIC_STATE_VIEWPORT_W_SCALING_NV = 1000087000,
        VK_DYNAMIC_STATE_DISCARD_RECTANGLE_EXT = 1000099000,
        VK_DYNAMIC_STATE_SAMPLE_LOCATIONS_EXT = 1000143000,
        VK_DYNAMIC_STATE_VIEWPORT_SHADING_RATE_PALETTE_NV = 1000164004,
        VK_DYNAMIC_STATE_VIEWPORT_COARSE_SAMPLE_ORDER_NV = 1000164006,
        VK_DYNAMIC_STATE_EXCLUSIVE_SCISSOR_NV = 1000205001,
        VK_DYNAMIC_STATE_LINE_STIPPLE_EXT = 1000259000,
        VK_DYNAMIC_STATE_CULL_MODE_EXT = 1000267000,
        VK_DYNAMIC_STATE_FRONT_FACE_EXT = 1000267001,
        VK_DYNAMIC_STATE_PRIMITIVE_TOPOLOGY_EXT = 1000267002,
        VK_DYNAMIC_STATE_VIEWPORT_WITH_COUNT_EXT = 1000267003,
        VK_DYNAMIC_STATE_SCISSOR_WITH_COUNT_EXT = 1000267004,
        VK_DYNAMIC_STATE_VERTEX_INPUT_BINDING_STRIDE_EXT = 1000267005,
        VK_DYNAMIC_STATE_DEPTH_TEST_ENABLE_EXT = 1000267006,
        VK_DYNAMIC_STATE_DEPTH_WRITE_ENABLE_EXT = 1000267007,
        VK_DYNAMIC_STATE_DEPTH_COMPARE_OP_EXT = 1000267008,
        VK_DYNAMIC_STATE_DEPTH_BOUNDS_TEST_ENABLE_EXT = 1000267009,
        VK_DYNAMIC_STATE_STENCIL_TEST_ENABLE_EXT = 1000267010,
        VK_DYNAMIC_STATE_STENCIL_OP_EXT = 1000267011,
        VK_DYNAMIC_STATE_MAX_ENUM = 0x7FFFFFFF,
    }
}
