// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayProbeHealthResponseMatch : IUtf8JsonSerializable, IJsonModel<ApplicationGatewayProbeHealthResponseMatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationGatewayProbeHealthResponseMatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApplicationGatewayProbeHealthResponseMatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayProbeHealthResponseMatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationGatewayProbeHealthResponseMatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Body != null)
            {
                writer.WritePropertyName("body"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Body);
#else
                using (JsonDocument document = JsonDocument.Parse(Body))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (!(StatusCodes is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("statusCodes"u8);
                writer.WriteStartArray();
                foreach (var item in StatusCodes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        ApplicationGatewayProbeHealthResponseMatch IJsonModel<ApplicationGatewayProbeHealthResponseMatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayProbeHealthResponseMatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationGatewayProbeHealthResponseMatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationGatewayProbeHealthResponseMatch(document.RootElement, options);
        }

        internal static ApplicationGatewayProbeHealthResponseMatch DeserializeApplicationGatewayProbeHealthResponseMatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BinaryData> body = default;
            IList<string> statusCodes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("body"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    body = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("statusCodes"u8))
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
                    statusCodes = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApplicationGatewayProbeHealthResponseMatch(body.Value, statusCodes ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplicationGatewayProbeHealthResponseMatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayProbeHealthResponseMatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApplicationGatewayProbeHealthResponseMatch)} does not support '{options.Format}' format.");
            }
        }

        ApplicationGatewayProbeHealthResponseMatch IPersistableModel<ApplicationGatewayProbeHealthResponseMatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayProbeHealthResponseMatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApplicationGatewayProbeHealthResponseMatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplicationGatewayProbeHealthResponseMatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationGatewayProbeHealthResponseMatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
