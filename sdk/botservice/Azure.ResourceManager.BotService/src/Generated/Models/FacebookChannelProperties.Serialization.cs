// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    public partial class FacebookChannelProperties : IUtf8JsonSerializable, IJsonModel<FacebookChannelProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FacebookChannelProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<FacebookChannelProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(VerifyToken))
                {
                    writer.WritePropertyName("verifyToken"u8);
                    writer.WriteStringValue(VerifyToken);
                }
            }
            if (Optional.IsCollectionDefined(Pages))
            {
                writer.WritePropertyName("pages"u8);
                writer.WriteStartArray();
                foreach (var item in Pages)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("appId"u8);
            writer.WriteStringValue(AppId);
            if (Optional.IsDefined(AppSecret))
            {
                writer.WritePropertyName("appSecret"u8);
                writer.WriteStringValue(AppSecret);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(CallbackUri))
                {
                    writer.WritePropertyName("callbackUrl"u8);
                    writer.WriteStringValue(CallbackUri.AbsoluteUri);
                }
            }
            writer.WritePropertyName("isEnabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        FacebookChannelProperties IJsonModel<FacebookChannelProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FacebookChannelProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFacebookChannelProperties(document.RootElement, options);
        }

        internal static FacebookChannelProperties DeserializeFacebookChannelProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> verifyToken = default;
            Optional<IList<FacebookPage>> pages = default;
            string appId = default;
            Optional<string> appSecret = default;
            Optional<Uri> callbackUrl = default;
            bool isEnabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("verifyToken"u8))
                {
                    verifyToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pages"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FacebookPage> array = new List<FacebookPage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FacebookPage.DeserializeFacebookPage(item));
                    }
                    pages = array;
                    continue;
                }
                if (property.NameEquals("appId"u8))
                {
                    appId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appSecret"u8))
                {
                    appSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("callbackUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    callbackUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isEnabled"u8))
                {
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FacebookChannelProperties(verifyToken.Value, Optional.ToList(pages), appId, appSecret.Value, callbackUrl.Value, isEnabled, serializedAdditionalRawData);
        }

        BinaryData IModel<FacebookChannelProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FacebookChannelProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        FacebookChannelProperties IModel<FacebookChannelProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FacebookChannelProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeFacebookChannelProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<FacebookChannelProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
