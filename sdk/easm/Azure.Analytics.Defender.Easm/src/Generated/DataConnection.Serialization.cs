// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    [PersistableModelProxy(typeof(UnknownDataConnection))]
    public partial class DataConnection : IUtf8JsonSerializable, IJsonModel<DataConnection>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataConnection>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataConnection>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataConnection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataConnection)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind);
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Content))
            {
                writer.WritePropertyName("content"u8);
                writer.WriteStringValue(Content.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedDate))
            {
                writer.WritePropertyName("createdDate"u8);
                writer.WriteStringValue(CreatedDate.Value, "O");
            }
            if (Optional.IsDefined(Frequency))
            {
                writer.WritePropertyName("frequency"u8);
                writer.WriteStringValue(Frequency.Value.ToString());
            }
            if (Optional.IsDefined(FrequencyOffset))
            {
                writer.WritePropertyName("frequencyOffset"u8);
                writer.WriteNumberValue(FrequencyOffset.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(UpdatedDate))
            {
                writer.WritePropertyName("updatedDate"u8);
                writer.WriteStringValue(UpdatedDate.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(UserUpdatedAt))
            {
                writer.WritePropertyName("userUpdatedAt"u8);
                writer.WriteStringValue(UserUpdatedAt.Value, "O");
            }
            if (Optional.IsDefined(Active))
            {
                writer.WritePropertyName("active"u8);
                writer.WriteBooleanValue(Active.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(InactiveMessage))
            {
                writer.WritePropertyName("inactiveMessage"u8);
                writer.WriteStringValue(InactiveMessage);
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

        DataConnection IJsonModel<DataConnection>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataConnection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataConnection)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataConnection(document.RootElement, options);
        }

        internal static DataConnection DeserializeDataConnection(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "azureDataExplorer": return AzureDataExplorerDataConnection.DeserializeAzureDataExplorerDataConnection(element, options);
                    case "logAnalytics": return LogAnalyticsDataConnection.DeserializeLogAnalyticsDataConnection(element, options);
                }
            }
            return UnknownDataConnection.DeserializeUnknownDataConnection(element, options);
        }

        BinaryData IPersistableModel<DataConnection>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataConnection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataConnection)} does not support '{options.Format}' format.");
            }
        }

        DataConnection IPersistableModel<DataConnection>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataConnection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataConnection(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataConnection)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataConnection>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DataConnection FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDataConnection(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
