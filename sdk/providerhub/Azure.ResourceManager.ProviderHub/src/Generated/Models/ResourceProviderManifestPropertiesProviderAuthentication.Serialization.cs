// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    internal partial class ResourceProviderManifestPropertiesProviderAuthentication : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("allowedAudiences");
            writer.WriteStartArray();
            foreach (var item in AllowedAudiences)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static ResourceProviderManifestPropertiesProviderAuthentication DeserializeResourceProviderManifestPropertiesProviderAuthentication(JsonElement element)
        {
            IList<string> allowedAudiences = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowedAudiences"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedAudiences = array;
                    continue;
                }
            }
            return new ResourceProviderManifestPropertiesProviderAuthentication(allowedAudiences);
        }
    }
}
