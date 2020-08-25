// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Security.KeyVault.Administration.Models
{
    public partial class RoleDefinition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(RoleName))
            {
                writer.WritePropertyName("roleName");
                writer.WriteStringValue(RoleName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(RoleType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(RoleType);
            }
            if (Optional.IsCollectionDefined(Permissions))
            {
                writer.WritePropertyName("permissions");
                writer.WriteStartArray();
                foreach (var item in Permissions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AssignableScopes))
            {
                writer.WritePropertyName("assignableScopes");
                writer.WriteStartArray();
                foreach (var item in AssignableScopes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static RoleDefinition DeserializeRoleDefinition(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> roleName = default;
            Optional<string> description = default;
            Optional<string> type0 = default;
            Optional<IList<KeyVaultPermission>> permissions = default;
            Optional<IList<string>> assignableScopes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
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
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("roleName"))
                        {
                            roleName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("type"))
                        {
                            type0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("permissions"))
                        {
                            List<KeyVaultPermission> array = new List<KeyVaultPermission>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(KeyVaultPermission.DeserializeKeyVaultPermission(item));
                            }
                            permissions = array;
                            continue;
                        }
                        if (property0.NameEquals("assignableScopes"))
                        {
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            assignableScopes = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RoleDefinition(id.Value, name.Value, type.Value, roleName.Value, description.Value, type0.Value, Optional.ToList(permissions), Optional.ToList(assignableScopes));
        }
    }
}
