// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceMeshShaderPropertiesEXT
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("uint32_t")]
    public uint maxTaskWorkGroupTotalCount;

    [NativeTypeName("uint32_t[3]")]
    public fixed uint maxTaskWorkGroupCount[3];

    [NativeTypeName("uint32_t")]
    public uint maxTaskWorkGroupInvocations;

    [NativeTypeName("uint32_t[3]")]
    public fixed uint maxTaskWorkGroupSize[3];

    [NativeTypeName("uint32_t")]
    public uint maxTaskPayloadSize;

    [NativeTypeName("uint32_t")]
    public uint maxTaskSharedMemorySize;

    [NativeTypeName("uint32_t")]
    public uint maxTaskPayloadAndSharedMemorySize;

    [NativeTypeName("uint32_t")]
    public uint maxMeshWorkGroupTotalCount;

    [NativeTypeName("uint32_t[3]")]
    public fixed uint maxMeshWorkGroupCount[3];

    [NativeTypeName("uint32_t")]
    public uint maxMeshWorkGroupInvocations;

    [NativeTypeName("uint32_t[3]")]
    public fixed uint maxMeshWorkGroupSize[3];

    [NativeTypeName("uint32_t")]
    public uint maxMeshSharedMemorySize;

    [NativeTypeName("uint32_t")]
    public uint maxMeshPayloadAndSharedMemorySize;

    [NativeTypeName("uint32_t")]
    public uint maxMeshOutputMemorySize;

    [NativeTypeName("uint32_t")]
    public uint maxMeshPayloadAndOutputMemorySize;

    [NativeTypeName("uint32_t")]
    public uint maxMeshOutputComponents;

    [NativeTypeName("uint32_t")]
    public uint maxMeshOutputVertices;

    [NativeTypeName("uint32_t")]
    public uint maxMeshOutputPrimitives;

    [NativeTypeName("uint32_t")]
    public uint maxMeshOutputLayers;

    [NativeTypeName("uint32_t")]
    public uint maxMeshMultiviewViewCount;

    [NativeTypeName("uint32_t")]
    public uint meshOutputPerVertexGranularity;

    [NativeTypeName("uint32_t")]
    public uint meshOutputPerPrimitiveGranularity;

    [NativeTypeName("uint32_t")]
    public uint maxPreferredTaskWorkGroupInvocations;

    [NativeTypeName("uint32_t")]
    public uint maxPreferredMeshWorkGroupInvocations;

    public VkBool32 prefersLocalInvocationVertexOutput;

    public VkBool32 prefersLocalInvocationPrimitiveOutput;

    public VkBool32 prefersCompactVertexOutput;

    public VkBool32 prefersCompactPrimitiveOutput;
}
