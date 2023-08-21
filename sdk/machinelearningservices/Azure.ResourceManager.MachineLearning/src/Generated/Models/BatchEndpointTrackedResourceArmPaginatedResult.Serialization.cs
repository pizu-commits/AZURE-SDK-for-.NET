// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class BatchEndpointTrackedResourceArmPaginatedResult
    {
        internal static BatchEndpointTrackedResourceArmPaginatedResult DeserializeBatchEndpointTrackedResourceArmPaginatedResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> nextLink = default;
            Core.Optional<IReadOnlyList<MachineLearningBatchEndpointData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MachineLearningBatchEndpointData> array = new List<MachineLearningBatchEndpointData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningBatchEndpointData.DeserializeMachineLearningBatchEndpointData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new BatchEndpointTrackedResourceArmPaginatedResult(nextLink.Value, Core.Optional.ToList(value));
        }
    }
}
