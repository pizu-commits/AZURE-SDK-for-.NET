// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace.Models
{
    public partial class DynatraceAccountCredentialsInfo
    {
        internal static DynatraceAccountCredentialsInfo DeserializeDynatraceAccountCredentialsInfo(JsonElement element)
        {
            Optional<string> accountId = default;
            Optional<string> apiKey = default;
            Optional<string> regionId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountId"))
                {
                    accountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiKey"))
                {
                    apiKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("regionId"))
                {
                    regionId = property.Value.GetString();
                    continue;
                }
            }
            return new DynatraceAccountCredentialsInfo(accountId.Value, apiKey.Value, regionId.Value);
        }
    }
}
