// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.162
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkClearValue" /> struct.</summary>
    public static unsafe class VkClearValueTests
    {
        /// <summary>Validates that the <see cref="VkClearValue" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkClearValue>(), Is.EqualTo(sizeof(VkClearValue)));
        }

        /// <summary>Validates that the <see cref="VkClearValue" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutExplicitTest()
        {
            Assert.That(typeof(VkClearValue).IsExplicitLayout, Is.True);
        }

        /// <summary>Validates that the <see cref="VkClearValue" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(VkClearValue), Is.EqualTo(16));
        }
    }
}
