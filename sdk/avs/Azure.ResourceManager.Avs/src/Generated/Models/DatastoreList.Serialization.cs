// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Avs;

namespace Azure.ResourceManager.Avs.Models
{
    internal partial class DatastoreList
    {
        internal static DatastoreList DeserializeDatastoreList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<AvsPrivateCloudDatastoreData>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AvsPrivateCloudDatastoreData> array = new List<AvsPrivateCloudDatastoreData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AvsPrivateCloudDatastoreData.DeserializeAvsPrivateCloudDatastoreData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new DatastoreList(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
