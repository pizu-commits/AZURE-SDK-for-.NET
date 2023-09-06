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

namespace Azure.ResourceManager.Logic.Models
{
    public partial class AS2ProtocolSettings : IUtf8JsonSerializable, IModelJsonSerializable<AS2ProtocolSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AS2ProtocolSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AS2ProtocolSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AS2ProtocolSettings>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("messageConnectionSettings"u8);
            if (MessageConnectionSettings is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<AS2MessageConnectionSettings>)MessageConnectionSettings).Serialize(writer, options);
            }
            writer.WritePropertyName("acknowledgementConnectionSettings"u8);
            if (AcknowledgementConnectionSettings is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<AS2AcknowledgementConnectionSettings>)AcknowledgementConnectionSettings).Serialize(writer, options);
            }
            writer.WritePropertyName("mdnSettings"u8);
            if (MdnSettings is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<AS2MdnSettings>)MdnSettings).Serialize(writer, options);
            }
            writer.WritePropertyName("securitySettings"u8);
            if (SecuritySettings is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<AS2SecuritySettings>)SecuritySettings).Serialize(writer, options);
            }
            writer.WritePropertyName("validationSettings"u8);
            if (ValidationSettings is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<AS2ValidationSettings>)ValidationSettings).Serialize(writer, options);
            }
            writer.WritePropertyName("envelopeSettings"u8);
            if (EnvelopeSettings is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<AS2EnvelopeSettings>)EnvelopeSettings).Serialize(writer, options);
            }
            writer.WritePropertyName("errorSettings"u8);
            if (ErrorSettings is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<AS2ErrorSettings>)ErrorSettings).Serialize(writer, options);
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

        internal static AS2ProtocolSettings DeserializeAS2ProtocolSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AS2MessageConnectionSettings messageConnectionSettings = default;
            AS2AcknowledgementConnectionSettings acknowledgementConnectionSettings = default;
            AS2MdnSettings mdnSettings = default;
            AS2SecuritySettings securitySettings = default;
            AS2ValidationSettings validationSettings = default;
            AS2EnvelopeSettings envelopeSettings = default;
            AS2ErrorSettings errorSettings = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("messageConnectionSettings"u8))
                {
                    messageConnectionSettings = AS2MessageConnectionSettings.DeserializeAS2MessageConnectionSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("acknowledgementConnectionSettings"u8))
                {
                    acknowledgementConnectionSettings = AS2AcknowledgementConnectionSettings.DeserializeAS2AcknowledgementConnectionSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("mdnSettings"u8))
                {
                    mdnSettings = AS2MdnSettings.DeserializeAS2MdnSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("securitySettings"u8))
                {
                    securitySettings = AS2SecuritySettings.DeserializeAS2SecuritySettings(property.Value);
                    continue;
                }
                if (property.NameEquals("validationSettings"u8))
                {
                    validationSettings = AS2ValidationSettings.DeserializeAS2ValidationSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("envelopeSettings"u8))
                {
                    envelopeSettings = AS2EnvelopeSettings.DeserializeAS2EnvelopeSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("errorSettings"u8))
                {
                    errorSettings = AS2ErrorSettings.DeserializeAS2ErrorSettings(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AS2ProtocolSettings(messageConnectionSettings, acknowledgementConnectionSettings, mdnSettings, securitySettings, validationSettings, envelopeSettings, errorSettings, rawData);
        }

        AS2ProtocolSettings IModelJsonSerializable<AS2ProtocolSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AS2ProtocolSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAS2ProtocolSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AS2ProtocolSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AS2ProtocolSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AS2ProtocolSettings IModelSerializable<AS2ProtocolSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AS2ProtocolSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAS2ProtocolSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AS2ProtocolSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AS2ProtocolSettings"/> to convert. </param>
        public static implicit operator RequestContent(AS2ProtocolSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AS2ProtocolSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AS2ProtocolSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAS2ProtocolSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
