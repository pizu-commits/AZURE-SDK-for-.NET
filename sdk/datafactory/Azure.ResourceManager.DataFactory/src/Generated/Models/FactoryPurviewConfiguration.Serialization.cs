// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    internal partial class FactoryPurviewConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PurviewResourceId))
            {
                writer.WritePropertyName("purviewResourceId");
                writer.WriteStringValue(PurviewResourceId);
            }
            writer.WriteEndObject();
        }

        internal static FactoryPurviewConfiguration DeserializeFactoryPurviewConfiguration(JsonElement element)
        {
            Optional<ResourceIdentifier> purviewResourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("purviewResourceId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    purviewResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new FactoryPurviewConfiguration(purviewResourceId.Value);
        }
    }
}
