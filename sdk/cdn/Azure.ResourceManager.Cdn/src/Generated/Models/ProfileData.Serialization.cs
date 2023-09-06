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
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Cdn
{
    public partial class ProfileData : IUtf8JsonSerializable, IModelJsonSerializable<ProfileData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ProfileData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ProfileData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProfileData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("sku"u8);
            if (Sku is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<CdnSku>)Sku).Serialize(writer, options);
            }
            if (Optional.IsCollectionDefined(Tags))
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
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(OriginResponseTimeoutSeconds))
            {
                if (OriginResponseTimeoutSeconds != null)
                {
                    writer.WritePropertyName("originResponseTimeoutSeconds"u8);
                    writer.WriteNumberValue(OriginResponseTimeoutSeconds.Value);
                }
                else
                {
                    writer.WriteNull("originResponseTimeoutSeconds");
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

        internal static ProfileData DeserializeProfileData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CdnSku sku = default;
            Optional<string> kind = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ProfileResourceState> resourceState = default;
            Optional<ProfileProvisioningState> provisioningState = default;
            Optional<Guid> frontDoorId = default;
            Optional<int?> originResponseTimeoutSeconds = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    sku = CdnSku.DeserializeCdnSku(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("resourceState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceState = new ProfileResourceState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProfileProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("frontDoorId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            frontDoorId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("originResponseTimeoutSeconds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                originResponseTimeoutSeconds = null;
                                continue;
                            }
                            originResponseTimeoutSeconds = property0.Value.GetInt32();
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
            return new ProfileData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, sku, kind.Value, Optional.ToNullable(resourceState), Optional.ToNullable(provisioningState), Optional.ToNullable(frontDoorId), Optional.ToNullable(originResponseTimeoutSeconds), rawData);
        }

        ProfileData IModelJsonSerializable<ProfileData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProfileData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeProfileData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ProfileData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProfileData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ProfileData IModelSerializable<ProfileData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProfileData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeProfileData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ProfileData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ProfileData"/> to convert. </param>
        public static implicit operator RequestContent(ProfileData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ProfileData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ProfileData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeProfileData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
