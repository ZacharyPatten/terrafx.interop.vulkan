// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkPhysicalDeviceDrmPropertiesEXT
    {
        public VkStructureType sType;

        public void* pNext;

        public VkBool32 hasPrimary;

        public VkBool32 hasRender;

        [NativeTypeName("int64_t")]
        public long primaryMajor;

        [NativeTypeName("int64_t")]
        public long primaryMinor;

        [NativeTypeName("int64_t")]
        public long renderMajor;

        [NativeTypeName("int64_t")]
        public long renderMinor;
    }
}