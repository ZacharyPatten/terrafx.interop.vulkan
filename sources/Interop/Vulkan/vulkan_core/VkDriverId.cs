// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.170
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkDriverId
    {
        VK_DRIVER_ID_AMD_PROPRIETARY = 1,
        VK_DRIVER_ID_AMD_OPEN_SOURCE = 2,
        VK_DRIVER_ID_MESA_RADV = 3,
        VK_DRIVER_ID_NVIDIA_PROPRIETARY = 4,
        VK_DRIVER_ID_INTEL_PROPRIETARY_WINDOWS = 5,
        VK_DRIVER_ID_INTEL_OPEN_SOURCE_MESA = 6,
        VK_DRIVER_ID_IMAGINATION_PROPRIETARY = 7,
        VK_DRIVER_ID_QUALCOMM_PROPRIETARY = 8,
        VK_DRIVER_ID_ARM_PROPRIETARY = 9,
        VK_DRIVER_ID_GOOGLE_SWIFTSHADER = 10,
        VK_DRIVER_ID_GGP_PROPRIETARY = 11,
        VK_DRIVER_ID_BROADCOM_PROPRIETARY = 12,
        VK_DRIVER_ID_MESA_LLVMPIPE = 13,
        VK_DRIVER_ID_MOLTENVK = 14,
        VK_DRIVER_ID_AMD_PROPRIETARY_KHR = VK_DRIVER_ID_AMD_PROPRIETARY,
        VK_DRIVER_ID_AMD_OPEN_SOURCE_KHR = VK_DRIVER_ID_AMD_OPEN_SOURCE,
        VK_DRIVER_ID_MESA_RADV_KHR = VK_DRIVER_ID_MESA_RADV,
        VK_DRIVER_ID_NVIDIA_PROPRIETARY_KHR = VK_DRIVER_ID_NVIDIA_PROPRIETARY,
        VK_DRIVER_ID_INTEL_PROPRIETARY_WINDOWS_KHR = VK_DRIVER_ID_INTEL_PROPRIETARY_WINDOWS,
        VK_DRIVER_ID_INTEL_OPEN_SOURCE_MESA_KHR = VK_DRIVER_ID_INTEL_OPEN_SOURCE_MESA,
        VK_DRIVER_ID_IMAGINATION_PROPRIETARY_KHR = VK_DRIVER_ID_IMAGINATION_PROPRIETARY,
        VK_DRIVER_ID_QUALCOMM_PROPRIETARY_KHR = VK_DRIVER_ID_QUALCOMM_PROPRIETARY,
        VK_DRIVER_ID_ARM_PROPRIETARY_KHR = VK_DRIVER_ID_ARM_PROPRIETARY,
        VK_DRIVER_ID_GOOGLE_SWIFTSHADER_KHR = VK_DRIVER_ID_GOOGLE_SWIFTSHADER,
        VK_DRIVER_ID_GGP_PROPRIETARY_KHR = VK_DRIVER_ID_GGP_PROPRIETARY,
        VK_DRIVER_ID_BROADCOM_PROPRIETARY_KHR = VK_DRIVER_ID_BROADCOM_PROPRIETARY,
        VK_DRIVER_ID_MAX_ENUM = 0x7FFFFFFF,
    }
}
