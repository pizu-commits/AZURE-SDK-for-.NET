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

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class IotHubRegistryStatistics : IUtf8JsonSerializable, IModelJsonSerializable<IotHubRegistryStatistics>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IotHubRegistryStatistics>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IotHubRegistryStatistics>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotHubRegistryStatistics>(this, options.Format);

            writer.WriteStartObject();
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

        internal static IotHubRegistryStatistics DeserializeIotHubRegistryStatistics(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> totalDeviceCount = default;
            Optional<long> enabledDeviceCount = default;
            Optional<long> disabledDeviceCount = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalDeviceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalDeviceCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("enabledDeviceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabledDeviceCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("disabledDeviceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disabledDeviceCount = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IotHubRegistryStatistics(Optional.ToNullable(totalDeviceCount), Optional.ToNullable(enabledDeviceCount), Optional.ToNullable(disabledDeviceCount), rawData);
        }

        IotHubRegistryStatistics IModelJsonSerializable<IotHubRegistryStatistics>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotHubRegistryStatistics>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIotHubRegistryStatistics(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IotHubRegistryStatistics>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotHubRegistryStatistics>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IotHubRegistryStatistics IModelSerializable<IotHubRegistryStatistics>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotHubRegistryStatistics>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIotHubRegistryStatistics(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="IotHubRegistryStatistics"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="IotHubRegistryStatistics"/> to convert. </param>
        public static implicit operator RequestContent(IotHubRegistryStatistics model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="IotHubRegistryStatistics"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator IotHubRegistryStatistics(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIotHubRegistryStatistics(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
