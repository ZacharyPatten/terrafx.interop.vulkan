// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from src\spec\vk.xml in the Vulkan-Docs repository for tag v1.0.51-core
// Original source is Copyright © 2015-2017 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;
using System.Security;
using TerraFX.Utilities;

namespace TerraFX.Interop
{
    public static unsafe partial class Vulkan
    {
        #region Constants
        public const uint VK_KHR_xcb_surface = 1;

        public const uint VK_KHR_XCB_SURFACE_SPEC_VERSION = 6;

        public const string VK_KHR_XCB_SURFACE_EXTENSION_NAME = "VK_KHR_xcb_surface";
        #endregion

        #region External Methods
        [DllImport(DllName, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, EntryPoint = "vkCreateXcbSurfaceKHR", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        public static extern VkResult vkCreateXcbSurfaceKHR(
            [In, NativeTypeName("VkInstance")] IntPtr instance,
            [In] VkXcbSurfaceCreateInfoKHR* pCreateInfo,
            [In, Optional] VkAllocationCallbacks* pAllocator,
            [Out, NativeTypeName("VkSurfaceKHR")] IntPtr* pSurface
        );

        [DllImport(DllName, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, EntryPoint = "vkGetPhysicalDeviceXcbPresentationSupportKHR", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("VkBool32")]
        public static extern uint vkGetPhysicalDeviceXcbPresentationSupportKHR(
            [In, NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice,
            [In] uint queueFamilyIndex,
            [In, NativeTypeName("xcb_connection_t")] IntPtr connection,
            [In, NativeTypeName("xcb_visualid_t")] uint visual_id
        );
        #endregion
    }
}
