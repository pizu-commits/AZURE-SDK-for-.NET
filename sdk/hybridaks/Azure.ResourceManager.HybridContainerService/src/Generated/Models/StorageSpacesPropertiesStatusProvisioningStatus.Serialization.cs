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
    public partial class StorageSpacesPropertiesStatusProvisioningStatus : IUtf8JsonSerializable, IModelJsonSerializable<StorageSpacesPropertiesStatusProvisioningStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StorageSpacesPropertiesStatusProvisioningStatus>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StorageSpacesPropertiesStatusProvisioningStatus>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                if (Error is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<StorageSpacesPropertiesStatusProvisioningStatusError>)Error).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(OperationId))
            {
                writer.WritePropertyName("operationId"u8);
                writer.WriteStringValue(OperationId);
            }
            if (Optional.IsDefined(Phase))
            {
                writer.WritePropertyName("phase"u8);
                writer.WriteStringValue(Phase);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
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

        internal static StorageSpacesPropertiesStatusProvisioningStatus DeserializeStorageSpacesPropertiesStatusProvisioningStatus(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<StorageSpacesPropertiesStatusProvisioningStatusError> error = default;
            Optional<string> operationId = default;
            Optional<string> phase = default;
            Optional<string> status = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = StorageSpacesPropertiesStatusProvisioningStatusError.DeserializeStorageSpacesPropertiesStatusProvisioningStatusError(property.Value);
                    continue;
                }
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phase"u8))
                {
                    phase = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StorageSpacesPropertiesStatusProvisioningStatus(error.Value, operationId.Value, phase.Value, status.Value, rawData);
        }

        StorageSpacesPropertiesStatusProvisioningStatus IModelJsonSerializable<StorageSpacesPropertiesStatusProvisioningStatus>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageSpacesPropertiesStatusProvisioningStatus(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StorageSpacesPropertiesStatusProvisioningStatus>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StorageSpacesPropertiesStatusProvisioningStatus IModelSerializable<StorageSpacesPropertiesStatusProvisioningStatus>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStorageSpacesPropertiesStatusProvisioningStatus(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StorageSpacesPropertiesStatusProvisioningStatus"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StorageSpacesPropertiesStatusProvisioningStatus"/> to convert. </param>
        public static implicit operator RequestContent(StorageSpacesPropertiesStatusProvisioningStatus model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StorageSpacesPropertiesStatusProvisioningStatus"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StorageSpacesPropertiesStatusProvisioningStatus(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStorageSpacesPropertiesStatusProvisioningStatus(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
