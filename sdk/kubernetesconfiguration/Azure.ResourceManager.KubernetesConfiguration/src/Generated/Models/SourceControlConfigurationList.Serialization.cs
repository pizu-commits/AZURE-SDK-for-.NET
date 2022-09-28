// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.KubernetesConfiguration;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    internal partial class SourceControlConfigurationList
    {
        internal static SourceControlConfigurationList DeserializeSourceControlConfigurationList(JsonElement element)
        {
            Optional<IReadOnlyList<SourceControlConfigurationData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SourceControlConfigurationData> array = new List<SourceControlConfigurationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SourceControlConfigurationData.DeserializeSourceControlConfigurationData(item));
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
            return new SourceControlConfigurationList(Optional.ToList(value), nextLink.Value);
        }
    }
}
