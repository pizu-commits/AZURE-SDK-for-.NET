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
    public partial class AppInstanceTcpSocketAction : IUtf8JsonSerializable, IModelJsonSerializable<AppInstanceTcpSocketAction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AppInstanceTcpSocketAction>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AppInstanceTcpSocketAction>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppInstanceTcpSocketAction>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ProbeActionType.ToString());
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

        internal static AppInstanceTcpSocketAction DeserializeAppInstanceTcpSocketAction(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ProbeActionType type = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new ProbeActionType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AppInstanceTcpSocketAction(type, rawData);
        }

        AppInstanceTcpSocketAction IModelJsonSerializable<AppInstanceTcpSocketAction>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppInstanceTcpSocketAction>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAppInstanceTcpSocketAction(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AppInstanceTcpSocketAction>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppInstanceTcpSocketAction>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AppInstanceTcpSocketAction IModelSerializable<AppInstanceTcpSocketAction>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppInstanceTcpSocketAction>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAppInstanceTcpSocketAction(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AppInstanceTcpSocketAction"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AppInstanceTcpSocketAction"/> to convert. </param>
        public static implicit operator RequestContent(AppInstanceTcpSocketAction model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AppInstanceTcpSocketAction"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AppInstanceTcpSocketAction(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAppInstanceTcpSocketAction(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
