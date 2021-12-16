// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class DiagnosticDetectorCollection
    {
        internal static DiagnosticDetectorCollection DeserializeDiagnosticDetectorCollection(JsonElement element)
        {
            IReadOnlyList<DetectorDefinitionAutoGeneratedData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<DetectorDefinitionAutoGeneratedData> array = new List<DetectorDefinitionAutoGeneratedData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DetectorDefinitionAutoGeneratedData.DeserializeDetectorDefinitionAutoGeneratedData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new DiagnosticDetectorCollection(value, nextLink.Value);
        }
    }
}
