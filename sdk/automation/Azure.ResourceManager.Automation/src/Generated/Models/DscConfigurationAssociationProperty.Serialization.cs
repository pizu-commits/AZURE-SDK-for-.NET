// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class DscConfigurationAssociationProperty : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ConfigurationName))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(ConfigurationName);
            }
            writer.WriteEndObject();
        }

        internal static DscConfigurationAssociationProperty DeserializeDscConfigurationAssociationProperty(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new DscConfigurationAssociationProperty(name.Value);
        }
    }
}
