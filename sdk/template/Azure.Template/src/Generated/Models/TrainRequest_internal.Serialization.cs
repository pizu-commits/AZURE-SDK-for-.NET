// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.AI.FormRecognizer.Custom;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class TrainRequest_internal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("source");
            writer.WriteStringValue(Source);
            if (SourceFilter != null)
            {
                writer.WritePropertyName("sourceFilter");
                writer.WriteObjectValue(SourceFilter);
            }
            if (UseLabelFile != null)
            {
                writer.WritePropertyName("useLabelFile");
                writer.WriteBooleanValue(UseLabelFile.Value);
            }
            writer.WriteEndObject();
        }
        internal static TrainRequest_internal DeserializeTrainRequest_internal(JsonElement element)
        {
            TrainRequest_internal result = new TrainRequest_internal();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("source"))
                {
                    result.Source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceFilter"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.SourceFilter = TrainingFileFilter.DeserializeTrainingFileFilter(property.Value);
                    continue;
                }
                if (property.NameEquals("useLabelFile"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.UseLabelFile = property.Value.GetBoolean();
                    continue;
                }
            }
            return result;
        }
    }
}
