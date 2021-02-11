// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.PhoneNumbers.Models
{
    public partial class LocationOptionsResponse
    {
        internal static LocationOptionsResponse DeserializeLocationOptionsResponse(JsonElement element)
        {
            Optional<LocationOptions> locationOptions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("locationOptions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    locationOptions = LocationOptions.DeserializeLocationOptions(property.Value);
                    continue;
                }
            }
            return new LocationOptionsResponse(locationOptions.Value);
        }
    }
}
