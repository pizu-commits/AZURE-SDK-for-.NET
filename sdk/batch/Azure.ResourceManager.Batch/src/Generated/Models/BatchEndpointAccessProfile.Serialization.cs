// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchEndpointAccessProfile : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("defaultAction"u8);
            writer.WriteStringValue(DefaultAction.ToSerialString());
            if (Core.Optional.IsCollectionDefined(IPRules))
            {
                writer.WritePropertyName("ipRules"u8);
                writer.WriteStartArray();
                foreach (var item in IPRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static BatchEndpointAccessProfile DeserializeBatchEndpointAccessProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BatchEndpointAccessDefaultAction defaultAction = default;
            Core.Optional<IList<BatchIPRule>> ipRules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultAction"u8))
                {
                    defaultAction = property.Value.GetString().ToBatchEndpointAccessDefaultAction();
                    continue;
                }
                if (property.NameEquals("ipRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BatchIPRule> array = new List<BatchIPRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BatchIPRule.DeserializeBatchIPRule(item));
                    }
                    ipRules = array;
                    continue;
                }
            }
            return new BatchEndpointAccessProfile(defaultAction, Core.Optional.ToList(ipRules));
        }
    }
}
