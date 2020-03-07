// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkDeviceCreateInfo
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkDeviceCreateFlags")]
        public uint flags;

        [NativeTypeName("uint32_t")]
        public uint queueCreateInfoCount;

        [NativeTypeName("const VkDeviceQueueCreateInfo *")]
        public VkDeviceQueueCreateInfo* pQueueCreateInfos;

        [NativeTypeName("uint32_t")]
        public uint enabledLayerCount;

        [NativeTypeName("const char *const *")]
        public sbyte** ppEnabledLayerNames;

        [NativeTypeName("uint32_t")]
        public uint enabledExtensionCount;

        [NativeTypeName("const char *const *")]
        public sbyte** ppEnabledExtensionNames;

        [NativeTypeName("const VkPhysicalDeviceFeatures *")]
        public VkPhysicalDeviceFeatures* pEnabledFeatures;
    }
}