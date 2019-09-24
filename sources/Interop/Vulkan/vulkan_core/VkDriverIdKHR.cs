// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkDriverIdKHR
    {
        VK_DRIVER_ID_AMD_PROPRIETARY_KHR = 1,
        VK_DRIVER_ID_AMD_OPEN_SOURCE_KHR = 2,
        VK_DRIVER_ID_MESA_RADV_KHR = 3,
        VK_DRIVER_ID_NVIDIA_PROPRIETARY_KHR = 4,
        VK_DRIVER_ID_INTEL_PROPRIETARY_WINDOWS_KHR = 5,
        VK_DRIVER_ID_INTEL_OPEN_SOURCE_MESA_KHR = 6,
        VK_DRIVER_ID_IMAGINATION_PROPRIETARY_KHR = 7,
        VK_DRIVER_ID_QUALCOMM_PROPRIETARY_KHR = 8,
        VK_DRIVER_ID_ARM_PROPRIETARY_KHR = 9,
        VK_DRIVER_ID_GOOGLE_SWIFTSHADER_KHR = 10,
        VK_DRIVER_ID_GGP_PROPRIETARY_KHR = 11,
        VK_DRIVER_ID_BROADCOM_PROPRIETARY_KHR = 12,
        VK_DRIVER_ID_BEGIN_RANGE_KHR = VK_DRIVER_ID_AMD_PROPRIETARY_KHR,
        VK_DRIVER_ID_END_RANGE_KHR = VK_DRIVER_ID_BROADCOM_PROPRIETARY_KHR,
        VK_DRIVER_ID_RANGE_SIZE_KHR = (VK_DRIVER_ID_BROADCOM_PROPRIETARY_KHR - VK_DRIVER_ID_AMD_PROPRIETARY_KHR + 1),
        VK_DRIVER_ID_MAX_ENUM_KHR = 0x7FFFFFFF,
    }
}
