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
    internal partial class AppServicePlanCollection
    {
        internal static AppServicePlanCollection DeserializeAppServicePlanCollection(JsonElement element)
        {
            IReadOnlyList<AppServicePlanData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<AppServicePlanData> array = new List<AppServicePlanData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppServicePlanData.DeserializeAppServicePlanData(item));
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
            return new AppServicePlanCollection(value, nextLink.Value);
        }
    }
}
