// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class PolicySignaturesOverridesForIdpsResource : IJsonModel<PolicySignaturesOverridesForIdpsData>
    {
        void IJsonModel<PolicySignaturesOverridesForIdpsData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        PolicySignaturesOverridesForIdpsData IJsonModel<PolicySignaturesOverridesForIdpsData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<PolicySignaturesOverridesForIdpsData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<PolicySignaturesOverridesForIdpsData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        PolicySignaturesOverridesForIdpsData IPersistableModel<PolicySignaturesOverridesForIdpsData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<PolicySignaturesOverridesForIdpsData>(data, options);
        }

        string IPersistableModel<PolicySignaturesOverridesForIdpsData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
