// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class TrainResult_internal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("trainingDocuments");
            writer.WriteStartArray();
            foreach (var item in TrainingDocuments)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Fields != null)
            {
                writer.WritePropertyName("fields");
                writer.WriteStartArray();
                foreach (var item0 in Fields)
                {
                    writer.WriteObjectValue(item0);
                }
                writer.WriteEndArray();
            }
            if (AverageModelAccuracy != null)
            {
                writer.WritePropertyName("averageModelAccuracy");
                writer.WriteNumberValue(AverageModelAccuracy.Value);
            }
            if (Errors != null)
            {
                writer.WritePropertyName("errors");
                writer.WriteStartArray();
                foreach (var item0 in Errors)
                {
                    writer.WriteObjectValue(item0);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
        internal static TrainResult_internal DeserializeTrainResult_internal(JsonElement element)
        {
            TrainResult_internal result = new TrainResult_internal();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("trainingDocuments"))
                {
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.TrainingDocuments.Add(TrainingDocumentInfo.DeserializeTrainingDocumentInfo(item));
                    }
                    continue;
                }
                if (property.NameEquals("fields"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Fields = new List<FormFieldsReport_internal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Fields.Add(FormFieldsReport_internal.DeserializeFormFieldsReport_internal(item));
                    }
                    continue;
                }
                if (property.NameEquals("averageModelAccuracy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.AverageModelAccuracy = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("errors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Errors = new List<FormRecognizerError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Errors.Add(FormRecognizerError.DeserializeFormRecognizerError(item));
                    }
                    continue;
                }
            }
            return result;
        }
    }
}
