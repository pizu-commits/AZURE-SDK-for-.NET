// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.FormRecognizer.Models;
using Azure.Core;

namespace Azure.Template.Models
{
    public partial class CustomModelCollection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Summary != null)
            {
                writer.WritePropertyName("summary");
                writer.WriteObjectValue(Summary);
            }
            if (ModelList != null)
            {
                writer.WritePropertyName("modelList");
                writer.WriteStartArray();
                foreach (var item in ModelList)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (NextLink != null)
            {
                writer.WritePropertyName("nextLink");
                writer.WriteStringValue(NextLink);
            }
            writer.WriteEndObject();
        }
        internal static CustomModelCollection DeserializeCustomModelCollection(JsonElement element)
        {
            CustomModelCollection result = new CustomModelCollection();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("summary"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Summary = ModelsSummary.DeserializeModelsSummary(property.Value);
                    continue;
                }
                if (property.NameEquals("modelList"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ModelList = new List<ModelInfo_internal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.ModelList.Add(ModelInfo_internal.DeserializeModelInfo_internal(item));
                    }
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.NextLink = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
