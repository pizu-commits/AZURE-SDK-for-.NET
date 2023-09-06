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

namespace Azure.ResourceManager.BotService.Models
{
    public partial class MsTeamsChannelProperties : IUtf8JsonSerializable, IModelJsonSerializable<MsTeamsChannelProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MsTeamsChannelProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MsTeamsChannelProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MsTeamsChannelProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IsCallingEnabled))
            {
                writer.WritePropertyName("enableCalling"u8);
                writer.WriteBooleanValue(IsCallingEnabled.Value);
            }
            if (Optional.IsDefined(CallingWebhook))
            {
                writer.WritePropertyName("callingWebhook"u8);
                writer.WriteStringValue(CallingWebhook);
            }
            writer.WritePropertyName("isEnabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            if (Optional.IsDefined(IncomingCallRoute))
            {
                writer.WritePropertyName("incomingCallRoute"u8);
                writer.WriteStringValue(IncomingCallRoute);
            }
            if (Optional.IsDefined(DeploymentEnvironment))
            {
                writer.WritePropertyName("deploymentEnvironment"u8);
                writer.WriteStringValue(DeploymentEnvironment);
            }
            if (Optional.IsDefined(AcceptedTerms))
            {
                if (AcceptedTerms != null)
                {
                    writer.WritePropertyName("acceptedTerms"u8);
                    writer.WriteBooleanValue(AcceptedTerms.Value);
                }
                else
                {
                    writer.WriteNull("acceptedTerms");
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

        internal static MsTeamsChannelProperties DeserializeMsTeamsChannelProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enableCalling = default;
            Optional<string> callingWebhook = default;
            bool isEnabled = default;
            Optional<string> incomingCallRoute = default;
            Optional<string> deploymentEnvironment = default;
            Optional<bool?> acceptedTerms = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enableCalling"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableCalling = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("callingWebhook"u8))
                {
                    callingWebhook = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isEnabled"u8))
                {
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("incomingCallRoute"u8))
                {
                    incomingCallRoute = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deploymentEnvironment"u8))
                {
                    deploymentEnvironment = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("acceptedTerms"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        acceptedTerms = null;
                        continue;
                    }
                    acceptedTerms = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MsTeamsChannelProperties(Optional.ToNullable(enableCalling), callingWebhook.Value, isEnabled, incomingCallRoute.Value, deploymentEnvironment.Value, Optional.ToNullable(acceptedTerms), rawData);
        }

        MsTeamsChannelProperties IModelJsonSerializable<MsTeamsChannelProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MsTeamsChannelProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMsTeamsChannelProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MsTeamsChannelProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MsTeamsChannelProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MsTeamsChannelProperties IModelSerializable<MsTeamsChannelProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MsTeamsChannelProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMsTeamsChannelProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MsTeamsChannelProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MsTeamsChannelProperties"/> to convert. </param>
        public static implicit operator RequestContent(MsTeamsChannelProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MsTeamsChannelProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MsTeamsChannelProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMsTeamsChannelProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
