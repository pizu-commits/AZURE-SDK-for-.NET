// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class BareMetalMachineCommandSpecification : IUtf8JsonSerializable, IJsonModel<BareMetalMachineCommandSpecification>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BareMetalMachineCommandSpecification>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BareMetalMachineCommandSpecification>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BareMetalMachineCommandSpecification>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BareMetalMachineCommandSpecification)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Arguments))
            {
                writer.WritePropertyName("arguments"u8);
                writer.WriteStartArray();
                foreach (var item in Arguments)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("command"u8);
            writer.WriteStringValue(Command);
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
        }

        BareMetalMachineCommandSpecification IJsonModel<BareMetalMachineCommandSpecification>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BareMetalMachineCommandSpecification>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BareMetalMachineCommandSpecification)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBareMetalMachineCommandSpecification(document.RootElement, options);
        }

        internal static BareMetalMachineCommandSpecification DeserializeBareMetalMachineCommandSpecification(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> arguments = default;
            string command = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("arguments"u8))
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
                    arguments = array;
                    continue;
                }
                if (property.NameEquals("command"u8))
                {
                    command = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BareMetalMachineCommandSpecification(arguments ?? new ChangeTrackingList<string>(), command, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BareMetalMachineCommandSpecification>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BareMetalMachineCommandSpecification>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BareMetalMachineCommandSpecification)} does not support writing '{options.Format}' format.");
            }
        }

        BareMetalMachineCommandSpecification IPersistableModel<BareMetalMachineCommandSpecification>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BareMetalMachineCommandSpecification>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBareMetalMachineCommandSpecification(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BareMetalMachineCommandSpecification)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BareMetalMachineCommandSpecification>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
