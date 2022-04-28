// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkImageViewMinLodCreateInfoEXT" /> struct.</summary>
    public static unsafe partial class VkImageViewMinLodCreateInfoEXTTests
    {
        /// <summary>Validates that the <see cref="VkImageViewMinLodCreateInfoEXT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkImageViewMinLodCreateInfoEXT>(), Is.EqualTo(sizeof(VkImageViewMinLodCreateInfoEXT)));
        }

        /// <summary>Validates that the <see cref="VkImageViewMinLodCreateInfoEXT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkImageViewMinLodCreateInfoEXT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkImageViewMinLodCreateInfoEXT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkImageViewMinLodCreateInfoEXT), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(VkImageViewMinLodCreateInfoEXT), Is.EqualTo(12));
            }
        }
    }
}