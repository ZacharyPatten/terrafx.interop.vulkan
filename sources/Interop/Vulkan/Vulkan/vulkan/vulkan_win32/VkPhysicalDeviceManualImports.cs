// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_win32.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkPhysicalDeviceManualImports
    {
        public delegate* unmanaged<VkPhysicalDevice, uint, VkBool32> vkGetPhysicalDeviceWin32PresentationSupportKHR;

        public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceSurfaceInfo2KHR*, uint*, VkPresentModeKHR*, VkResult> vkGetPhysicalDeviceSurfacePresentModes2EXT;
    }
}