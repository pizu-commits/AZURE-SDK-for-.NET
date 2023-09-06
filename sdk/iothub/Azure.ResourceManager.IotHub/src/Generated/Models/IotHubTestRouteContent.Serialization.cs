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
    public partial class IotHubTestRouteContent : IUtf8JsonSerializable, IModelJsonSerializable<IotHubTestRouteContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IotHubTestRouteContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IotHubTestRouteContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotHubTestRouteContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                if (Message is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RoutingMessage>)Message).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("route"u8);
            if (Route is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<RoutingRuleProperties>)Route).Serialize(writer, options);
            }
            if (Optional.IsDefined(Twin))
            {
                writer.WritePropertyName("twin"u8);
                if (Twin is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RoutingTwin>)Twin).Serialize(writer, options);
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

        internal static IotHubTestRouteContent DeserializeIotHubTestRouteContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<RoutingMessage> message = default;
            RoutingRuleProperties route = default;
            Optional<RoutingTwin> twin = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("message"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    message = RoutingMessage.DeserializeRoutingMessage(property.Value);
                    continue;
                }
                if (property.NameEquals("route"u8))
                {
                    route = RoutingRuleProperties.DeserializeRoutingRuleProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("twin"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    twin = RoutingTwin.DeserializeRoutingTwin(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IotHubTestRouteContent(message.Value, route, twin.Value, rawData);
        }

        IotHubTestRouteContent IModelJsonSerializable<IotHubTestRouteContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotHubTestRouteContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIotHubTestRouteContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IotHubTestRouteContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotHubTestRouteContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IotHubTestRouteContent IModelSerializable<IotHubTestRouteContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotHubTestRouteContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIotHubTestRouteContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="IotHubTestRouteContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="IotHubTestRouteContent"/> to convert. </param>
        public static implicit operator RequestContent(IotHubTestRouteContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="IotHubTestRouteContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator IotHubTestRouteContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIotHubTestRouteContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
