// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    [PersistableModelProxy(typeof(UnknownChannel))]
    public partial class BotChannelProperties : IUtf8JsonSerializable, IJsonModel<BotChannelProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BotChannelProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BotChannelProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BotChannelProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BotChannelProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("channelName"u8);
            writer.WriteStringValue(ChannelName);
            if (Optional.IsDefined(ETag))
            {
                if (ETag != null)
                {
                    writer.WritePropertyName("etag"u8);
                    writer.WriteStringValue(ETag.Value.ToString());
                }
                else
                {
                    writer.WriteNull("etag");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        BotChannelProperties IJsonModel<BotChannelProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BotChannelProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BotChannelProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBotChannelProperties(document.RootElement, options);
        }

        internal static BotChannelProperties DeserializeBotChannelProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("channelName", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AcsChatChannel": return AcsChatChannel.DeserializeAcsChatChannel(element, options);
                    case "AlexaChannel": return AlexaChannel.DeserializeAlexaChannel(element, options);
                    case "DirectLineChannel": return DirectLineChannel.DeserializeDirectLineChannel(element, options);
                    case "DirectLineSpeechChannel": return DirectLineSpeechChannel.DeserializeDirectLineSpeechChannel(element, options);
                    case "EmailChannel": return EmailChannel.DeserializeEmailChannel(element, options);
                    case "FacebookChannel": return FacebookChannel.DeserializeFacebookChannel(element, options);
                    case "KikChannel": return KikChannel.DeserializeKikChannel(element, options);
                    case "LineChannel": return LineChannel.DeserializeLineChannel(element, options);
                    case "M365Extensions": return M365Extensions.DeserializeM365Extensions(element, options);
                    case "MsTeamsChannel": return MsTeamsChannel.DeserializeMsTeamsChannel(element, options);
                    case "Omnichannel": return Omnichannel.DeserializeOmnichannel(element, options);
                    case "OutlookChannel": return OutlookChannel.DeserializeOutlookChannel(element, options);
                    case "SearchAssistant": return SearchAssistant.DeserializeSearchAssistant(element, options);
                    case "SkypeChannel": return SkypeChannel.DeserializeSkypeChannel(element, options);
                    case "SlackChannel": return SlackChannel.DeserializeSlackChannel(element, options);
                    case "SmsChannel": return SmsChannel.DeserializeSmsChannel(element, options);
                    case "TelegramChannel": return TelegramChannel.DeserializeTelegramChannel(element, options);
                    case "TelephonyChannel": return TelephonyChannel.DeserializeTelephonyChannel(element, options);
                    case "WebChatChannel": return WebChatChannel.DeserializeWebChatChannel(element, options);
                }
            }
            return UnknownChannel.DeserializeUnknownChannel(element, options);
        }

        BinaryData IPersistableModel<BotChannelProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BotChannelProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BotChannelProperties)} does not support writing '{options.Format}' format.");
            }
        }

        BotChannelProperties IPersistableModel<BotChannelProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BotChannelProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBotChannelProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BotChannelProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BotChannelProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
