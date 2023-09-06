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

namespace Azure.ResourceManager.AppPlatform.Models
{
    internal partial class ServiceVnetAddons : IUtf8JsonSerializable, IModelJsonSerializable<ServiceVnetAddons>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ServiceVnetAddons>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ServiceVnetAddons>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceVnetAddons>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IsLogStreamPublicEndpoint))
            {
                writer.WritePropertyName("logStreamPublicEndpoint"u8);
                writer.WriteBooleanValue(IsLogStreamPublicEndpoint.Value);
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

        internal static ServiceVnetAddons DeserializeServiceVnetAddons(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> logStreamPublicEndpoint = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("logStreamPublicEndpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logStreamPublicEndpoint = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ServiceVnetAddons(Optional.ToNullable(logStreamPublicEndpoint), rawData);
        }

        ServiceVnetAddons IModelJsonSerializable<ServiceVnetAddons>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceVnetAddons>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceVnetAddons(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ServiceVnetAddons>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceVnetAddons>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ServiceVnetAddons IModelSerializable<ServiceVnetAddons>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceVnetAddons>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeServiceVnetAddons(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ServiceVnetAddons"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ServiceVnetAddons"/> to convert. </param>
        public static implicit operator RequestContent(ServiceVnetAddons model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ServiceVnetAddons"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ServiceVnetAddons(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeServiceVnetAddons(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
