// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Custom
{
    public partial class ModelInfo_internal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("modelId");
            writer.WriteStringValue(ModelId);
            writer.WritePropertyName("status");
            writer.WriteStringValue(Status.ToSerialString());
            writer.WritePropertyName("createdDateTime");
            writer.WriteStringValue(CreatedDateTime, "S");
            writer.WritePropertyName("lastUpdatedDateTime");
            writer.WriteStringValue(LastUpdatedDateTime, "S");
            writer.WriteEndObject();
        }
        internal static ModelInfo_internal DeserializeModelInfo_internal(JsonElement element)
        {
            ModelInfo_internal result = new ModelInfo_internal();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modelId"))
                {
                    result.ModelId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    result.Status = property.Value.GetString().ToModelStatus();
                    continue;
                }
                if (property.NameEquals("createdDateTime"))
                {
                    result.CreatedDateTime = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("lastUpdatedDateTime"))
                {
                    result.LastUpdatedDateTime = property.Value.GetDateTimeOffset("S");
                    continue;
                }
            }
            return result;
        }
    }
}
