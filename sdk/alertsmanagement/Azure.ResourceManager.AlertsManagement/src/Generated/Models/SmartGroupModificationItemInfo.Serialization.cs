// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class SmartGroupModificationItemInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ModificationEvent))
            {
                writer.WritePropertyName("modificationEvent");
                writer.WriteStringValue(ModificationEvent.Value.ToSerialString());
            }
            if (Optional.IsDefined(OldValue))
            {
                writer.WritePropertyName("oldValue");
                writer.WriteStringValue(OldValue);
            }
            if (Optional.IsDefined(NewValue))
            {
                writer.WritePropertyName("newValue");
                writer.WriteStringValue(NewValue);
            }
            if (Optional.IsDefined(ModifiedOn))
            {
                writer.WritePropertyName("modifiedAt");
                writer.WriteStringValue(ModifiedOn.Value, "O");
            }
            if (Optional.IsDefined(ModifiedBy))
            {
                writer.WritePropertyName("modifiedBy");
                writer.WriteStringValue(ModifiedBy);
            }
            if (Optional.IsDefined(Comments))
            {
                writer.WritePropertyName("comments");
                writer.WriteStringValue(Comments);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WriteEndObject();
        }

        internal static SmartGroupModificationItemInfo DeserializeSmartGroupModificationItemInfo(JsonElement element)
        {
            Optional<SmartGroupModificationEvent> modificationEvent = default;
            Optional<string> oldValue = default;
            Optional<string> newValue = default;
            Optional<DateTimeOffset> modifiedAt = default;
            Optional<string> modifiedBy = default;
            Optional<string> comments = default;
            Optional<string> description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modificationEvent"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    modificationEvent = property.Value.GetString().ToSmartGroupModificationEvent();
                    continue;
                }
                if (property.NameEquals("oldValue"))
                {
                    oldValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("newValue"))
                {
                    newValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modifiedAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    modifiedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("modifiedBy"))
                {
                    modifiedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("comments"))
                {
                    comments = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new SmartGroupModificationItemInfo(Optional.ToNullable(modificationEvent), oldValue.Value, newValue.Value, Optional.ToNullable(modifiedAt), modifiedBy.Value, comments.Value, description.Value);
        }
    }
}
