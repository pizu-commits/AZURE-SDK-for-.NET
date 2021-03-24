// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.AnomalyDetector
{
    internal partial class ModelList
    {
        internal static ModelList DeserializeModelList(JsonElement element)
        {
            IReadOnlyList<ModelSnapshot> models = default;
            int currentCount = default;
            int maxCount = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("models"))
                {
                    List<ModelSnapshot> array = new List<ModelSnapshot>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ModelSnapshot.DeserializeModelSnapshot(item));
                    }
                    models = array;
                    continue;
                }
                if (property.NameEquals("currentCount"))
                {
                    currentCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxCount"))
                {
                    maxCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ModelList(models, currentCount, maxCount, nextLink.Value);
        }
    }
}
