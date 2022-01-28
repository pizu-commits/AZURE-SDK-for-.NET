// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute
{
    public partial class GalleryApplicationData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Eula))
            {
                writer.WritePropertyName("eula");
                writer.WriteStringValue(Eula);
            }
            if (Optional.IsDefined(PrivacyStatementUri))
            {
                writer.WritePropertyName("privacyStatementUri");
                writer.WriteStringValue(PrivacyStatementUri);
            }
            if (Optional.IsDefined(ReleaseNoteUri))
            {
                writer.WritePropertyName("releaseNoteUri");
                writer.WriteStringValue(ReleaseNoteUri);
            }
            if (Optional.IsDefined(EndOfLifeDate))
            {
                writer.WritePropertyName("endOfLifeDate");
                writer.WriteStringValue(EndOfLifeDate.Value, "O");
            }
            if (Optional.IsDefined(SupportedOSType))
            {
                writer.WritePropertyName("supportedOSType");
                writer.WriteStringValue(SupportedOSType.Value.ToSerialString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static GalleryApplicationData DeserializeGalleryApplicationData(JsonElement element)
        {
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> description = default;
            Optional<string> eula = default;
            Optional<string> privacyStatementUri = default;
            Optional<string> releaseNoteUri = default;
            Optional<DateTimeOffset> endOfLifeDate = default;
            Optional<OperatingSystemTypes> supportedOSType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("eula"))
                        {
                            eula = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privacyStatementUri"))
                        {
                            privacyStatementUri = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("releaseNoteUri"))
                        {
                            releaseNoteUri = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endOfLifeDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            endOfLifeDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("supportedOSType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            supportedOSType = property0.Value.GetString().ToOperatingSystemTypes();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new GalleryApplicationData(id, name, type, systemData, tags, location, description.Value, eula.Value, privacyStatementUri.Value, releaseNoteUri.Value, Optional.ToNullable(endOfLifeDate), Optional.ToNullable(supportedOSType));
        }
    }
}
