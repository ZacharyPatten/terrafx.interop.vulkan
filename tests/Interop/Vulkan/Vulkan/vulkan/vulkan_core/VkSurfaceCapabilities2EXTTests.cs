// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref="VkSurfaceCapabilities2EXT" /> struct.</summary>
public static unsafe partial class VkSurfaceCapabilities2EXTTests
{
    /// <summary>Validates that the <see cref="VkSurfaceCapabilities2EXT" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<VkSurfaceCapabilities2EXT>(), Is.EqualTo(sizeof(VkSurfaceCapabilities2EXT)));
    }

    /// <summary>Validates that the <see cref="VkSurfaceCapabilities2EXT" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(VkSurfaceCapabilities2EXT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="VkSurfaceCapabilities2EXT" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(VkSurfaceCapabilities2EXT), Is.EqualTo(72));
        }
        else
        {
            Assert.That(sizeof(VkSurfaceCapabilities2EXT), Is.EqualTo(64));
        }
    }
}
