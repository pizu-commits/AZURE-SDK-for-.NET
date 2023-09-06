// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Authorization.Models
{
    public partial class RoleManagementExpandedProperties : IUtf8JsonSerializable, IModelJsonSerializable<RoleManagementExpandedProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RoleManagementExpandedProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RoleManagementExpandedProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RoleManagementExpandedProperties>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("principal"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PrincipalId))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(PrincipalId.Value);
            }
            if (Optional.IsDefined(PrincipalDisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(PrincipalDisplayName);
            }
            if (Optional.IsDefined(Email))
            {
                writer.WritePropertyName("email"u8);
                writer.WriteStringValue(Email);
            }
            if (Optional.IsDefined(PrincipalType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(PrincipalType.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WritePropertyName("roleDefinition"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(RoleDefinitionId))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(RoleDefinitionId);
            }
            if (Optional.IsDefined(RoleDefinitionDisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(RoleDefinitionDisplayName);
            }
            if (Optional.IsDefined(RoleType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(RoleType.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WritePropertyName("scope"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ScopeId))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(ScopeId);
            }
            if (Optional.IsDefined(ScopeDisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(ScopeDisplayName);
            }
            if (Optional.IsDefined(ScopeType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ScopeType.Value.ToString());
            }
            writer.WriteEndObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static RoleManagementExpandedProperties DeserializeRoleManagementExpandedProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> id = default;
            Optional<string> displayName = default;
            Optional<string> email = default;
            Optional<RoleManagementPrincipalType> type = default;
            Optional<ResourceIdentifier> id0 = default;
            Optional<string> displayName0 = default;
            Optional<AuthorizationRoleType> type0 = default;
            Optional<ResourceIdentifier> id1 = default;
            Optional<string> displayName1 = default;
            Optional<RoleManagementScopeType> type1 = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("principal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("id"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            id = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("email"u8))
                        {
                            email = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("type"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            type = new RoleManagementPrincipalType(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (property.NameEquals("roleDefinition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("id"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            id0 = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("type"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            type0 = new AuthorizationRoleType(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (property.NameEquals("scope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("id"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            id1 = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName1 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("type"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            type1 = new RoleManagementScopeType(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RoleManagementExpandedProperties(Optional.ToNullable(id), displayName.Value, email.Value, Optional.ToNullable(type), id0.Value, displayName0.Value, Optional.ToNullable(type0), id1.Value, displayName1.Value, Optional.ToNullable(type1), rawData);
        }

        RoleManagementExpandedProperties IModelJsonSerializable<RoleManagementExpandedProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RoleManagementExpandedProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRoleManagementExpandedProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RoleManagementExpandedProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RoleManagementExpandedProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RoleManagementExpandedProperties IModelSerializable<RoleManagementExpandedProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RoleManagementExpandedProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRoleManagementExpandedProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RoleManagementExpandedProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RoleManagementExpandedProperties"/> to convert. </param>
        public static implicit operator RequestContent(RoleManagementExpandedProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RoleManagementExpandedProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RoleManagementExpandedProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRoleManagementExpandedProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
