// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.OperationalInsights;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    internal partial class DataSourceListResult
    {
        internal static DataSourceListResult DeserializeDataSourceListResult(JsonElement element)
        {
            Optional<IReadOnlyList<DataSourceData>> value = default;
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
                    List<DataSourceData> array = new List<DataSourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataSourceData.DeserializeDataSourceData(item));
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
            return new DataSourceListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
