// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    public partial class ADGroup
    {
        internal static ADGroup DeserializeADGroup(JsonElement element)
        {
            Optional<string> displayName = default;
            Optional<bool> mailEnabled = default;
            Optional<string> mailNickname = default;
            Optional<bool> securityEnabled = default;
            Optional<string> mail = default;
            Optional<string> objectId = default;
            Optional<string> objectType = default;
            Optional<DateTimeOffset> deletionTimestamp = default;
            IReadOnlyDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mailEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    mailEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("mailNickname"))
                {
                    mailNickname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("securityEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    securityEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("mail"))
                {
                    mail = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectId"))
                {
                    objectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectType"))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deletionTimestamp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    deletionTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ADGroup(objectId.Value, objectType.Value, Optional.ToNullable(deletionTimestamp), additionalProperties, displayName.Value, Optional.ToNullable(mailEnabled), mailNickname.Value, Optional.ToNullable(securityEnabled), mail.Value);
        }
    }
}
