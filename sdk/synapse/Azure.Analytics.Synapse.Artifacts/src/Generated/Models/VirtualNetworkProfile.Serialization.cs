// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(VirtualNetworkProfileConverter))]
    public partial class VirtualNetworkProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ComputeSubnetId))
            {
                writer.WritePropertyName("computeSubnetId"u8);
                writer.WriteStringValue(ComputeSubnetId);
            }
            writer.WriteEndObject();
        }

        internal static VirtualNetworkProfile DeserializeVirtualNetworkProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string computeSubnetId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("computeSubnetId"u8))
                {
                    computeSubnetId = property.Value.GetString();
                    continue;
                }
            }
            return new VirtualNetworkProfile(computeSubnetId);
        }

        internal partial class VirtualNetworkProfileConverter : JsonConverter<VirtualNetworkProfile>
        {
            public override void Write(Utf8JsonWriter writer, VirtualNetworkProfile model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override VirtualNetworkProfile Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeVirtualNetworkProfile(document.RootElement);
            }
        }
    }
}
