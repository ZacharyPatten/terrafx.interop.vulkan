// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref="StdVideoH264HrdParameters" /> struct.</summary>
public static unsafe partial class StdVideoH264HrdParametersTests
{
    /// <summary>Validates that the <see cref="StdVideoH264HrdParameters" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<StdVideoH264HrdParameters>(), Is.EqualTo(sizeof(StdVideoH264HrdParameters)));
    }

    /// <summary>Validates that the <see cref="StdVideoH264HrdParameters" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(StdVideoH264HrdParameters).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="StdVideoH264HrdParameters" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(StdVideoH264HrdParameters), Is.EqualTo(308));
    }
}
