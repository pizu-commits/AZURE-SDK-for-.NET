// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsIncidentEntitiesMetadata
    {
        internal static SecurityInsightsIncidentEntitiesMetadata DeserializeSecurityInsightsIncidentEntitiesMetadata(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int count = default;
            SecurityInsightsEntityKind entityKind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("count"u8))
                {
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("entityKind"u8))
                {
                    entityKind = new SecurityInsightsEntityKind(property.Value.GetString());
                    continue;
                }
            }
            return new SecurityInsightsIncidentEntitiesMetadata(count, entityKind);
        }
    }
}
