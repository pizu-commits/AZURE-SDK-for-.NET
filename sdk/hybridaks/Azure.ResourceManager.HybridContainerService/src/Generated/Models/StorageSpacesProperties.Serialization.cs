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

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class StorageSpacesProperties : IUtf8JsonSerializable, IModelJsonSerializable<StorageSpacesProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StorageSpacesProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StorageSpacesProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageSpacesProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(HciStorageProfile))
            {
                writer.WritePropertyName("hciStorageProfile"u8);
                if (HciStorageProfile is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<StorageSpacesPropertiesHciStorageProfile>)HciStorageProfile).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(VmwareStorageProfile))
            {
                writer.WritePropertyName("vmwareStorageProfile"u8);
                if (VmwareStorageProfile is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<StorageSpacesPropertiesVmwareStorageProfile>)VmwareStorageProfile).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                if (Status is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<StorageSpacesPropertiesStatus>)Status).Serialize(writer, options);
                }
            }
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

        internal static StorageSpacesProperties DeserializeStorageSpacesProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<StorageSpacesPropertiesHciStorageProfile> hciStorageProfile = default;
            Optional<StorageSpacesPropertiesVmwareStorageProfile> vmwareStorageProfile = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<StorageSpacesPropertiesStatus> status = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hciStorageProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hciStorageProfile = StorageSpacesPropertiesHciStorageProfile.DeserializeStorageSpacesPropertiesHciStorageProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("vmwareStorageProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmwareStorageProfile = StorageSpacesPropertiesVmwareStorageProfile.DeserializeStorageSpacesPropertiesVmwareStorageProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = StorageSpacesPropertiesStatus.DeserializeStorageSpacesPropertiesStatus(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StorageSpacesProperties(hciStorageProfile.Value, vmwareStorageProfile.Value, Optional.ToNullable(provisioningState), status.Value, rawData);
        }

        StorageSpacesProperties IModelJsonSerializable<StorageSpacesProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageSpacesProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageSpacesProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StorageSpacesProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageSpacesProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StorageSpacesProperties IModelSerializable<StorageSpacesProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageSpacesProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStorageSpacesProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StorageSpacesProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StorageSpacesProperties"/> to convert. </param>
        public static implicit operator RequestContent(StorageSpacesProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StorageSpacesProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StorageSpacesProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStorageSpacesProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
