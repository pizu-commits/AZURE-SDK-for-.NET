// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Compute
{
    public partial class VirtualMachineScaleSetResource : IJsonModel<VirtualMachineScaleSetData>
    {
        void IJsonModel<VirtualMachineScaleSetData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<VirtualMachineScaleSetData>)Data).Write(writer, options);

        VirtualMachineScaleSetData IJsonModel<VirtualMachineScaleSetData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<VirtualMachineScaleSetData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<VirtualMachineScaleSetData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        VirtualMachineScaleSetData IPersistableModel<VirtualMachineScaleSetData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<VirtualMachineScaleSetData>(data, options);

        string IPersistableModel<VirtualMachineScaleSetData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<VirtualMachineScaleSetData>)Data).GetFormatFromOptions(options);
    }
}
