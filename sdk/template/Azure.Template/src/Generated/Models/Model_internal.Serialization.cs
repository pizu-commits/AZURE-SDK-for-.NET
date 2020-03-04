// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.AI.FormRecognizer;
using Azure.AI.FormRecognizer.Custom;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class Model_internal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("modelInfo");
            writer.WriteObjectValue(ModelInfo);
            if (Keys != null)
            {
                writer.WritePropertyName("keys");
                writer.WriteObjectValue(Keys);
            }
            if (TrainResult != null)
            {
                writer.WritePropertyName("trainResult");
                writer.WriteObjectValue(TrainResult);
            }
            writer.WriteEndObject();
        }
        internal static Model_internal DeserializeModel_internal(JsonElement element)
        {
            Model_internal result = new Model_internal();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modelInfo"))
                {
                    result.ModelInfo = ModelInfo_internal.DeserializeModelInfo_internal(property.Value);
                    continue;
                }
                if (property.NameEquals("keys"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Keys = KeysResult_internal.DeserializeKeysResult_internal(property.Value);
                    continue;
                }
                if (property.NameEquals("trainResult"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.TrainResult = TrainResult_internal.DeserializeTrainResult_internal(property.Value);
                    continue;
                }
            }
            return result;
        }
    }
}
