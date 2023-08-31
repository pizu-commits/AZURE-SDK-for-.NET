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
    public partial class StateUpdateCommonPostActionResult : IUtf8JsonSerializable, IModelJsonSerializable<StateUpdateCommonPostActionResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StateUpdateCommonPostActionResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StateUpdateCommonPostActionResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<StateUpdateCommonPostActionResult>(this, options.Format);

            writer.WriteStartObject();
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

        internal static StateUpdateCommonPostActionResult DeserializeStateUpdateCommonPostActionResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<NetworkFabricConfigurationState> configurationState = default;
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
            return new StateUpdateCommonPostActionResult(error.Value, Optional.ToNullable(configurationState), rawData);
        }

        StateUpdateCommonPostActionResult IModelJsonSerializable<StateUpdateCommonPostActionResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<StateUpdateCommonPostActionResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStateUpdateCommonPostActionResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StateUpdateCommonPostActionResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<StateUpdateCommonPostActionResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StateUpdateCommonPostActionResult IModelSerializable<StateUpdateCommonPostActionResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<StateUpdateCommonPostActionResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStateUpdateCommonPostActionResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StateUpdateCommonPostActionResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StateUpdateCommonPostActionResult"/> to convert. </param>
        public static implicit operator RequestContent(StateUpdateCommonPostActionResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StateUpdateCommonPostActionResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StateUpdateCommonPostActionResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStateUpdateCommonPostActionResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
