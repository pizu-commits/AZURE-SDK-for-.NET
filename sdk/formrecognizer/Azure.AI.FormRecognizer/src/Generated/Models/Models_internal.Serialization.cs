// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Training
{
    internal partial class Models_internal
    {
        internal static Models_internal DeserializeModels_internal(JsonElement element)
        {
            ModelsSummary_internal summary = default;
            IReadOnlyList<ModelInfo_internal> modelList = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("summary"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    summary = ModelsSummary_internal.DeserializeModelsSummary_internal(property.Value);
                    continue;
                }
                if (property.NameEquals("modelList"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ModelInfo_internal> array = new List<ModelInfo_internal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(ModelInfo_internal.DeserializeModelInfo_internal(item));
                        }
                    }
                    modelList = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new Models_internal(summary, modelList, nextLink);
        }
    }
}
