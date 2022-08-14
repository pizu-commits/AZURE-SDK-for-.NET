// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class PackageShippingDetails
    {
        internal static PackageShippingDetails DeserializePackageShippingDetails(JsonElement element)
        {
            Optional<Uri> trackingUrl = default;
            Optional<string> carrierName = default;
            Optional<string> trackingId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("trackingUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        trackingUrl = null;
                        continue;
                    }
                    trackingUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("carrierName"))
                {
                    carrierName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trackingId"))
                {
                    trackingId = property.Value.GetString();
                    continue;
                }
            }
            return new PackageShippingDetails(trackingUrl.Value, carrierName.Value, trackingId.Value);
        }
    }
}
