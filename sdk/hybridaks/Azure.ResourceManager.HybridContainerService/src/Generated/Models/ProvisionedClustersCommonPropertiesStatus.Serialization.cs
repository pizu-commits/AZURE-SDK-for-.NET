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
    public partial class ProvisionedClustersCommonPropertiesStatus : IUtf8JsonSerializable, IModelJsonSerializable<ProvisionedClustersCommonPropertiesStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ProvisionedClustersCommonPropertiesStatus>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ProvisionedClustersCommonPropertiesStatus>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(FeaturesStatus))
            {
                writer.WritePropertyName("featuresStatus"u8);
                if (FeaturesStatus is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ProvisionedClustersCommonPropertiesStatusFeaturesStatus>)FeaturesStatus).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(AddonStatus))
            {
                writer.WritePropertyName("addonStatus"u8);
                writer.WriteStartObject();
                foreach (var item in AddonStatus)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<AddonStatus>)item.Value).Serialize(writer, options);
                    }
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ErrorMessage))
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
            }
            if (Optional.IsDefined(ProvisioningStatus))
            {
                writer.WritePropertyName("provisioningStatus"u8);
                if (ProvisioningStatus is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ProvisionedClustersCommonPropertiesStatusProvisioningStatus>)ProvisioningStatus).Serialize(writer, options);
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

        internal static ProvisionedClustersCommonPropertiesStatus DeserializeProvisionedClustersCommonPropertiesStatus(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ProvisionedClustersCommonPropertiesStatusFeaturesStatus> featuresStatus = default;
            Optional<IReadOnlyDictionary<string, AddonStatus>> addonStatus = default;
            Optional<string> errorMessage = default;
            Optional<ProvisionedClustersCommonPropertiesStatusProvisioningStatus> provisioningStatus = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("featuresStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    featuresStatus = ProvisionedClustersCommonPropertiesStatusFeaturesStatus.DeserializeProvisionedClustersCommonPropertiesStatusFeaturesStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("addonStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, AddonStatus> dictionary = new Dictionary<string, AddonStatus>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, Models.AddonStatus.DeserializeAddonStatus(property0.Value));
                    }
                    addonStatus = dictionary;
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningStatus = ProvisionedClustersCommonPropertiesStatusProvisioningStatus.DeserializeProvisionedClustersCommonPropertiesStatusProvisioningStatus(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ProvisionedClustersCommonPropertiesStatus(featuresStatus.Value, Optional.ToDictionary(addonStatus), errorMessage.Value, provisioningStatus.Value, rawData);
        }

        ProvisionedClustersCommonPropertiesStatus IModelJsonSerializable<ProvisionedClustersCommonPropertiesStatus>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeProvisionedClustersCommonPropertiesStatus(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ProvisionedClustersCommonPropertiesStatus>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ProvisionedClustersCommonPropertiesStatus IModelSerializable<ProvisionedClustersCommonPropertiesStatus>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeProvisionedClustersCommonPropertiesStatus(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ProvisionedClustersCommonPropertiesStatus"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ProvisionedClustersCommonPropertiesStatus"/> to convert. </param>
        public static implicit operator RequestContent(ProvisionedClustersCommonPropertiesStatus model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ProvisionedClustersCommonPropertiesStatus"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ProvisionedClustersCommonPropertiesStatus(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeProvisionedClustersCommonPropertiesStatus(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
