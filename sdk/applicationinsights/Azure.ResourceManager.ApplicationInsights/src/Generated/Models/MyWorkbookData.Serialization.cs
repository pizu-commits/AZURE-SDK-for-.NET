// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ApplicationInsights.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApplicationInsights
{
    public partial class MyWorkbookData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind.Value.ToString());
            }
            if (Core.Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                writer.WriteObjectValue(Identity);
            }
            if (Core.Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Core.Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Core.Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (Core.Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Core.Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Core.Optional.IsCollectionDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStartObject();
                foreach (var item in ETag)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Core.Optional.IsDefined(SerializedData))
            {
                if (SerializedData != null)
                {
                    writer.WritePropertyName("serializedData"u8);
                    writer.WriteStringValue(SerializedData);
                }
                else
                {
                    writer.WriteNull("serializedData");
                }
            }
            if (Core.Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (Core.Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category);
            }
            if (Core.Optional.IsDefined(SourceId))
            {
                writer.WritePropertyName("sourceId"u8);
                writer.WriteStringValue(SourceId);
            }
            if (Core.Optional.IsDefined(StorageUri))
            {
                if (StorageUri != null)
                {
                    writer.WritePropertyName("storageUri"u8);
                    writer.WriteStringValue(StorageUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("storageUri");
                }
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static MyWorkbookData DeserializeMyWorkbookData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ApplicationInsightsKind> kind = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<MyWorkbookManagedIdentity> identity = default;
            Core.Optional<string> id = default;
            Core.Optional<string> name = default;
            Core.Optional<string> type = default;
            Core.Optional<AzureLocation> location = default;
            Core.Optional<IDictionary<string, string>> tags = default;
            Core.Optional<IDictionary<string, string>> etag = default;
            Core.Optional<string> displayName = default;
            Core.Optional<string> serializedData = default;
            Core.Optional<string> version = default;
            Core.Optional<string> timeModified = default;
            Core.Optional<string> category = default;
            Core.Optional<string> userId = default;
            Core.Optional<string> sourceId = default;
            Core.Optional<Uri> storageUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = new ApplicationInsightsKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = MyWorkbookManagedIdentity.DeserializeMyWorkbookManagedIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    etag = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serializedData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                serializedData = null;
                                continue;
                            }
                            serializedData = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("timeModified"u8))
                        {
                            timeModified = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("category"u8))
                        {
                            category = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("userId"u8))
                        {
                            userId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sourceId"u8))
                        {
                            sourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                storageUri = null;
                                continue;
                            }
                            storageUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new MyWorkbookData(identity.Value, id.Value, name.Value, type.Value, Core.Optional.ToNullable(location), Core.Optional.ToDictionary(tags), Core.Optional.ToDictionary(etag), Core.Optional.ToNullable(kind), systemData, displayName.Value, serializedData.Value, version.Value, timeModified.Value, category.Value, userId.Value, sourceId.Value, storageUri.Value);
        }
    }
}
