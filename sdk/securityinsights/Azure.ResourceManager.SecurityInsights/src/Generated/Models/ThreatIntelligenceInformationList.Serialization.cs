// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    internal partial class ThreatIntelligenceInformationList
    {
        internal static ThreatIntelligenceInformationList DeserializeThreatIntelligenceInformationList(JsonElement element)
        {
            Optional<string> nextLink = default;
            IReadOnlyList<ThreatIntelligenceInformation> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    List<ThreatIntelligenceInformation> array = new List<ThreatIntelligenceInformation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ThreatIntelligenceInformation.DeserializeThreatIntelligenceInformation(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ThreatIntelligenceInformationList(nextLink.Value, value);
        }
    }
}
