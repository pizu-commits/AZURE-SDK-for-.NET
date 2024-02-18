// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Resources
{
    public partial class SubscriptionPolicySetDefinitionResource : IJsonModel<PolicySetDefinitionData>
    {
        void IJsonModel<PolicySetDefinitionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        PolicySetDefinitionData IJsonModel<PolicySetDefinitionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<PolicySetDefinitionData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<PolicySetDefinitionData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        PolicySetDefinitionData IPersistableModel<PolicySetDefinitionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<PolicySetDefinitionData>(data, options);
        }

        string IPersistableModel<PolicySetDefinitionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
