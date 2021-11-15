// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkImageFormatProperties" /> struct.</summary>
    public static unsafe partial class VkImageFormatPropertiesTests
    {
        /// <summary>Validates that the <see cref="VkImageFormatProperties" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkImageFormatProperties>(), Is.EqualTo(sizeof(VkImageFormatProperties)));
        }

        /// <summary>Validates that the <see cref="VkImageFormatProperties" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkImageFormatProperties).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkImageFormatProperties" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(VkImageFormatProperties), Is.EqualTo(32));
        }
    }
}