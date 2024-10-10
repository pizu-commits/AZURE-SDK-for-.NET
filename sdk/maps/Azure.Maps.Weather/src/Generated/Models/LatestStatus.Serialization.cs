// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Maps.Weather.Models
{
    public partial class LatestStatus
    {
        internal static LatestStatus DeserializeLatestStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string localized = default;
            LatestStatusKeyword? english = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("localized"u8))
                {
                    localized = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("english"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    english = new LatestStatusKeyword(property.Value.GetString());
                    continue;
                }
            }
            return new LatestStatus(localized, english);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static LatestStatus FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeLatestStatus(document.RootElement);
        }
    }
}
