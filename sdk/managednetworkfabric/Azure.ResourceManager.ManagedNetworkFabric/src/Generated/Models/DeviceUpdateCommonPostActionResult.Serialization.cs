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

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class DeviceUpdateCommonPostActionResult : IUtf8JsonSerializable, IModelJsonSerializable<DeviceUpdateCommonPostActionResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DeviceUpdateCommonPostActionResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DeviceUpdateCommonPostActionResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeviceUpdateCommonPostActionResult>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(SuccessfulDevices))
            {
                writer.WritePropertyName("successfulDevices"u8);
                writer.WriteStartArray();
                foreach (var item in SuccessfulDevices)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(FailedDevices))
            {
                writer.WritePropertyName("failedDevices"u8);
                writer.WriteStartArray();
                foreach (var item in FailedDevices)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                writer.WriteObjectValue(Error);
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

        internal static DeviceUpdateCommonPostActionResult DeserializeDeviceUpdateCommonPostActionResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<NetworkFabricConfigurationState> configurationState = default;
            Optional<IReadOnlyList<string>> successfulDevices = default;
            Optional<IReadOnlyList<string>> failedDevices = default;
            Optional<ResponseError> error = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("configurationState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configurationState = new NetworkFabricConfigurationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("successfulDevices"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    successfulDevices = array;
                    continue;
                }
                if (property.NameEquals("failedDevices"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    failedDevices = array;
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DeviceUpdateCommonPostActionResult(error.Value, Optional.ToNullable(configurationState), Optional.ToList(successfulDevices), Optional.ToList(failedDevices), rawData);
        }

        DeviceUpdateCommonPostActionResult IModelJsonSerializable<DeviceUpdateCommonPostActionResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeviceUpdateCommonPostActionResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDeviceUpdateCommonPostActionResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DeviceUpdateCommonPostActionResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeviceUpdateCommonPostActionResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DeviceUpdateCommonPostActionResult IModelSerializable<DeviceUpdateCommonPostActionResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeviceUpdateCommonPostActionResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDeviceUpdateCommonPostActionResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DeviceUpdateCommonPostActionResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DeviceUpdateCommonPostActionResult"/> to convert. </param>
        public static implicit operator RequestContent(DeviceUpdateCommonPostActionResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DeviceUpdateCommonPostActionResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DeviceUpdateCommonPostActionResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDeviceUpdateCommonPostActionResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
