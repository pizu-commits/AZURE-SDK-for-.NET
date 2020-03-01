// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    public partial class TrainingFileFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Prefix != null)
            {
                writer.WritePropertyName("prefix");
                writer.WriteStringValue(Prefix);
            }
            if (IncludeSubFolders != null)
            {
                writer.WritePropertyName("includeSubFolders");
                writer.WriteBooleanValue(IncludeSubFolders.Value);
            }
            writer.WriteEndObject();
        }
        internal static TrainingFileFilter DeserializeTrainingFileFilter(JsonElement element)
        {
            TrainingFileFilter result = new TrainingFileFilter();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("prefix"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Prefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("includeSubFolders"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.IncludeSubFolders = property.Value.GetBoolean();
                    continue;
                }
            }
            return result;
        }
    }
}
