// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class WebApplicationFirewallPolicyResource : IJsonModel<WebApplicationFirewallPolicyData>
    {
        void IJsonModel<WebApplicationFirewallPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        WebApplicationFirewallPolicyData IJsonModel<WebApplicationFirewallPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<WebApplicationFirewallPolicyData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<WebApplicationFirewallPolicyData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        WebApplicationFirewallPolicyData IPersistableModel<WebApplicationFirewallPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<WebApplicationFirewallPolicyData>(data, options);
        }

        string IPersistableModel<WebApplicationFirewallPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
