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

namespace Azure.ResourceManager.KeyVault.Models
{
    public partial class ManagedHsmGeoReplicatedRegion : IUtf8JsonSerializable, IModelJsonSerializable<ManagedHsmGeoReplicatedRegion>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedHsmGeoReplicatedRegion>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedHsmGeoReplicatedRegion>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedHsmGeoReplicatedRegion>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(IsPrimary))
            {
                writer.WritePropertyName("isPrimary"u8);
                writer.WriteBooleanValue(IsPrimary.Value);
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

        internal static ManagedHsmGeoReplicatedRegion DeserializeManagedHsmGeoReplicatedRegion(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<ManagedHsmGeoReplicatedRegionProvisioningState> provisioningState = default;
            Optional<bool> isPrimary = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ManagedHsmGeoReplicatedRegionProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isPrimary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPrimary = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManagedHsmGeoReplicatedRegion(name.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(isPrimary), rawData);
        }

        ManagedHsmGeoReplicatedRegion IModelJsonSerializable<ManagedHsmGeoReplicatedRegion>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedHsmGeoReplicatedRegion>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedHsmGeoReplicatedRegion(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedHsmGeoReplicatedRegion>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedHsmGeoReplicatedRegion>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedHsmGeoReplicatedRegion IModelSerializable<ManagedHsmGeoReplicatedRegion>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedHsmGeoReplicatedRegion>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedHsmGeoReplicatedRegion(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ManagedHsmGeoReplicatedRegion"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ManagedHsmGeoReplicatedRegion"/> to convert. </param>
        public static implicit operator RequestContent(ManagedHsmGeoReplicatedRegion model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ManagedHsmGeoReplicatedRegion"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ManagedHsmGeoReplicatedRegion(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedHsmGeoReplicatedRegion(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
