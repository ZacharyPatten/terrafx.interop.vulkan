// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vk_icd.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2016 The Khronos Group Inc. Copyright © 2015-2016 Valve Corporation. Copyright © 2015-2016 LunarG, Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref="VkIcdSurfaceBase" /> struct.</summary>
public static unsafe partial class VkIcdSurfaceBaseTests
{
    /// <summary>Validates that the <see cref="VkIcdSurfaceBase" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<VkIcdSurfaceBase>(), Is.EqualTo(sizeof(VkIcdSurfaceBase)));
    }

    /// <summary>Validates that the <see cref="VkIcdSurfaceBase" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(VkIcdSurfaceBase).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="VkIcdSurfaceBase" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(VkIcdSurfaceBase), Is.EqualTo(4));
    }
}
