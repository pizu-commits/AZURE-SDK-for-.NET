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
using Azure.ResourceManager.Blueprint.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Blueprint
{
    public partial class AssignmentData : IUtf8JsonSerializable, IModelJsonSerializable<AssignmentData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AssignmentData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AssignmentData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AssignmentData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("identity"u8);
            if (Identity is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<Models.ManagedServiceIdentity>)Identity).Serialize(writer, options);
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(BlueprintId))
            {
                writer.WritePropertyName("blueprintId"u8);
                writer.WriteStringValue(BlueprintId);
            }
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope);
            }
            writer.WritePropertyName("parameters"u8);
            writer.WriteStartObject();
            foreach (var item in Parameters)
            {
                writer.WritePropertyName(item.Key);
                if (item.Value is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ParameterValue>)item.Value).Serialize(writer, options);
                }
            }
            writer.WriteEndObject();
            writer.WritePropertyName("resourceGroups"u8);
            writer.WriteStartObject();
            foreach (var item in ResourceGroups)
            {
                writer.WritePropertyName(item.Key);
                if (item.Value is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ResourceGroupValue>)item.Value).Serialize(writer, options);
                }
            }
            writer.WriteEndObject();
            if (Optional.IsDefined(Locks))
            {
                writer.WritePropertyName("locks"u8);
                if (Locks is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AssignmentLockSettings>)Locks).Serialize(writer, options);
                }
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

        internal static AssignmentData DeserializeAssignmentData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Models.ManagedServiceIdentity identity = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> displayName = default;
            Optional<string> description = default;
            Optional<string> blueprintId = default;
            Optional<string> scope = default;
            IDictionary<string, ParameterValue> parameters = default;
            IDictionary<string, ResourceGroupValue> resourceGroups = default;
            Optional<AssignmentStatus> status = default;
            Optional<AssignmentLockSettings> locks = default;
            Optional<AssignmentProvisioningState> provisioningState = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    identity = Models.ManagedServiceIdentity.DeserializeManagedServiceIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
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
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("blueprintId"u8))
                        {
                            blueprintId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("scope"u8))
                        {
                            scope = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("parameters"u8))
                        {
                            Dictionary<string, ParameterValue> dictionary = new Dictionary<string, ParameterValue>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, ParameterValue.DeserializeParameterValue(property1.Value));
                            }
                            parameters = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("resourceGroups"u8))
                        {
                            Dictionary<string, ResourceGroupValue> dictionary = new Dictionary<string, ResourceGroupValue>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, ResourceGroupValue.DeserializeResourceGroupValue(property1.Value));
                            }
                            resourceGroups = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = AssignmentStatus.DeserializeAssignmentStatus(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("locks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            locks = AssignmentLockSettings.DeserializeAssignmentLockSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new AssignmentProvisioningState(property0.Value.GetString());
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
            return new AssignmentData(id, name, type, systemData.Value, identity, displayName.Value, description.Value, blueprintId.Value, scope.Value, parameters, resourceGroups, status.Value, locks.Value, Optional.ToNullable(provisioningState), location, rawData);
        }

        AssignmentData IModelJsonSerializable<AssignmentData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AssignmentData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAssignmentData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AssignmentData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AssignmentData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AssignmentData IModelSerializable<AssignmentData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AssignmentData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAssignmentData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AssignmentData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AssignmentData"/> to convert. </param>
        public static implicit operator RequestContent(AssignmentData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AssignmentData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AssignmentData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAssignmentData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
