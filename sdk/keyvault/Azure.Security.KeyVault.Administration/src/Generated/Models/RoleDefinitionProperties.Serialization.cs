// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Security.KeyVault.Administration.Models
{
    internal partial class RoleDefinitionProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(RoleName))
            {
                writer.WritePropertyName("roleName"u8);
                writer.WriteStringValue(RoleName);
            }
            if (Core.Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Core.Optional.IsDefined(RoleType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(RoleType.Value.ToString());
            }
            if (Core.Optional.IsCollectionDefined(Permissions))
            {
                writer.WritePropertyName("permissions"u8);
                writer.WriteStartArray();
                foreach (var item in Permissions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsCollectionDefined(AssignableScopes))
            {
                writer.WritePropertyName("assignableScopes"u8);
                writer.WriteStartArray();
                foreach (var item in AssignableScopes)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
