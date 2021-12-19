// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_fuchsia.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkImageFormatConstraintsInfoFUCHSIA" /> struct.</summary>
    public static unsafe partial class VkImageFormatConstraintsInfoFUCHSIATests
    {
        /// <summary>Validates that the <see cref="VkImageFormatConstraintsInfoFUCHSIA" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkImageFormatConstraintsInfoFUCHSIA>(), Is.EqualTo(sizeof(VkImageFormatConstraintsInfoFUCHSIA)));
        }

        /// <summary>Validates that the <see cref="VkImageFormatConstraintsInfoFUCHSIA" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkImageFormatConstraintsInfoFUCHSIA).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkImageFormatConstraintsInfoFUCHSIA" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkImageFormatConstraintsInfoFUCHSIA), Is.EqualTo(136));
            }
            else
            {
                Assert.That(sizeof(VkImageFormatConstraintsInfoFUCHSIA), Is.EqualTo(104));
            }
        }
    }
}