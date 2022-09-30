// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    internal partial class ResourceProviderManifestPropertiesRequestHeaderOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OptInHeaders))
            {
                writer.WritePropertyName("optInHeaders");
                writer.WriteStringValue(OptInHeaders.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ResourceProviderManifestPropertiesRequestHeaderOptions DeserializeResourceProviderManifestPropertiesRequestHeaderOptions(JsonElement element)
        {
            Optional<OptInHeaderType> optInHeaders = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("optInHeaders"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    optInHeaders = new OptInHeaderType(property.Value.GetString());
                    continue;
                }
            }
            return new ResourceProviderManifestPropertiesRequestHeaderOptions(Optional.ToNullable(optInHeaders));
        }
    }
}
