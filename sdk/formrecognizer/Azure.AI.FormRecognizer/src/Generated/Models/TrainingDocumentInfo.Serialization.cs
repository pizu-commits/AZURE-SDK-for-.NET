// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.FormRecognizer.Models;

namespace Azure.AI.FormRecognizer.Training
{
    public partial class TrainingDocumentInfo
    {
        internal static TrainingDocumentInfo DeserializeTrainingDocumentInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string documentName = default;
            int pages = default;
            IReadOnlyList<FormRecognizerError> errors = default;
            TrainingStatus status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("documentName"u8))
                {
                    documentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pages"u8))
                {
                    pages = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    List<FormRecognizerError> array = new List<FormRecognizerError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FormRecognizerError.DeserializeFormRecognizerError(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString().ToTrainingStatus();
                    continue;
                }
            }
            return new TrainingDocumentInfo(documentName, pages, errors, status);
        }
    }
}
