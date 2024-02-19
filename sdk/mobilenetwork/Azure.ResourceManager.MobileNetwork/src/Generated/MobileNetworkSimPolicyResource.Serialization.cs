// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MobileNetwork
{
    public partial class MobileNetworkSimPolicyResource : IJsonModel<MobileNetworkSimPolicyData>
    {
        void IJsonModel<MobileNetworkSimPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        MobileNetworkSimPolicyData IJsonModel<MobileNetworkSimPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MobileNetworkSimPolicyData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<MobileNetworkSimPolicyData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        MobileNetworkSimPolicyData IPersistableModel<MobileNetworkSimPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MobileNetworkSimPolicyData>(data, options);
        }

        string IPersistableModel<MobileNetworkSimPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
