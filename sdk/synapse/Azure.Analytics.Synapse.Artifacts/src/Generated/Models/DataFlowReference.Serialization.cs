// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(DataFlowReferenceConverter))]
    public partial class DataFlowReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("referenceName");
            writer.WriteStringValue(ReferenceName);
            if (Optional.IsDefined(DatasetParameters))
            {
                writer.WritePropertyName("datasetParameters");
                writer.WriteObjectValue(DatasetParameters);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static DataFlowReference DeserializeDataFlowReference(JsonElement element)
        {
            DataFlowReferenceType type = default;
            string referenceName = default;
            Optional<object> datasetParameters = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = new DataFlowReferenceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("referenceName"))
                {
                    referenceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("datasetParameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    datasetParameters = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DataFlowReference(type, referenceName, datasetParameters.Value, additionalProperties);
        }

        internal partial class DataFlowReferenceConverter : JsonConverter<DataFlowReference>
        {
            public override void Write(Utf8JsonWriter writer, DataFlowReference model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DataFlowReference Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDataFlowReference(document.RootElement);
            }
        }
    }
}
