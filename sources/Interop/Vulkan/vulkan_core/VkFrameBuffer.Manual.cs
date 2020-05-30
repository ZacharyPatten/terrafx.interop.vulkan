// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public struct VkFramebuffer : IEquatable<VkFramebuffer>
    {
        private ulong _value;

        public VkFramebuffer(ulong value)
        {
            _value = value;
        }

        public static bool operator ==(VkFramebuffer l, VkFramebuffer r) => l._value == r._value;

        public static bool operator !=(VkFramebuffer l, VkFramebuffer r) => !(l == r);

        public static implicit operator VkFramebuffer(ulong value) => new VkFramebuffer(value);

        public static implicit operator ulong(VkFramebuffer value) => value._value;

        public override bool Equals(object? obj) => (obj is VkFramebuffer other) && Equals(other);

        public bool Equals(VkFramebuffer other) => this == other;

        public override int GetHashCode() => _value.GetHashCode();
    }
}
