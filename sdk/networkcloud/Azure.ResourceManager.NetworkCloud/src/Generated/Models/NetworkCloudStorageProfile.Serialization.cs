// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class NetworkCloudStorageProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("osDisk"u8);
            writer.WriteObjectValue(OSDisk);
            if (Optional.IsCollectionDefined(VolumeAttachments))
            {
                writer.WritePropertyName("volumeAttachments"u8);
                writer.WriteStartArray();
                foreach (var item in VolumeAttachments)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static NetworkCloudStorageProfile DeserializeNetworkCloudStorageProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OSDisk osDisk = default;
            Optional<IList<ResourceIdentifier>> volumeAttachments = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("osDisk"u8))
                {
                    osDisk = OSDisk.DeserializeOSDisk(property.Value);
                    continue;
                }
                if (property.NameEquals("volumeAttachments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    volumeAttachments = array;
                    continue;
                }
            }
            return new NetworkCloudStorageProfile(osDisk, Optional.ToList(volumeAttachments));
        }
    }
}
