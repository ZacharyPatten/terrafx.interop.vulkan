// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from src\spec\vk.xml in the Vulkan-Docs repository for tag v1.0.51-core
// Original source is Copyright © 2015-2017 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum VkDependencyFlagBits : uint
    {
        VK_DEPENDENCY_BY_REGION_BIT = 0x00000001,

        VK_DEPENDENCY_VIEW_LOCAL_BIT_KHX = 0x00000002,

        VK_DEPENDENCY_DEVICE_GROUP_BIT_KHX = 0x00000004,

        VK_DEPENDENCY_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
}
