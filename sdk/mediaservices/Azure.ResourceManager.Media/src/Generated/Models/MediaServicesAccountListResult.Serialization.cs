// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Media;

namespace Azure.ResourceManager.Media.Models
{
    internal partial class MediaServicesAccountListResult
    {
        internal static MediaServicesAccountListResult DeserializeMediaServicesAccountListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<MediaServicesAccountData>> value = default;
            Core.Optional<string> odataNextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MediaServicesAccountData> array = new List<MediaServicesAccountData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaServicesAccountData.DeserializeMediaServicesAccountData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("@odata.nextLink"u8))
                {
                    odataNextLink = property.Value.GetString();
                    continue;
                }
            }
            return new MediaServicesAccountListResult(Core.Optional.ToList(value), odataNextLink.Value);
        }
    }
}
