// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class AcsRouterWorkerUpdatedEventData : IUtf8JsonSerializable, IJsonModel<AcsRouterWorkerUpdatedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AcsRouterWorkerUpdatedEventData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AcsRouterWorkerUpdatedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsRouterWorkerUpdatedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AcsRouterWorkerUpdatedEventData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(WorkerId))
            {
                writer.WritePropertyName("workerId"u8);
                writer.WriteStringValue(WorkerId);
            }
            writer.WritePropertyName("queueAssignments"u8);
            writer.WriteStartArray();
            foreach (var item in QueueAssignments)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("channelConfigurations"u8);
            writer.WriteStartArray();
            foreach (var item in ChannelConfigurations)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(TotalCapacity))
            {
                writer.WritePropertyName("totalCapacity"u8);
                writer.WriteNumberValue(TotalCapacity.Value);
            }
            writer.WritePropertyName("labels"u8);
            writer.WriteStartObject();
            foreach (var item in Labels)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("tags"u8);
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("updatedWorkerProperties"u8);
            writer.WriteStartArray();
            foreach (var item in UpdatedWorkerProperties)
            {
                writer.WriteStringValue(item.ToString());
            }
            writer.WriteEndArray();
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

        AcsRouterWorkerUpdatedEventData IJsonModel<AcsRouterWorkerUpdatedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsRouterWorkerUpdatedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AcsRouterWorkerUpdatedEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAcsRouterWorkerUpdatedEventData(document.RootElement, options);
        }

        internal static AcsRouterWorkerUpdatedEventData DeserializeAcsRouterWorkerUpdatedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string workerId = default;
            IReadOnlyList<AcsRouterQueueDetails> queueAssignments = default;
            IReadOnlyList<AcsRouterChannelConfiguration> channelConfigurations = default;
            int? totalCapacity = default;
            IReadOnlyDictionary<string, string> labels = default;
            IReadOnlyDictionary<string, string> tags = default;
            IReadOnlyList<AcsRouterUpdatedWorkerProperty> updatedWorkerProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("workerId"u8))
                {
                    workerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queueAssignments"u8))
                {
                    List<AcsRouterQueueDetails> array = new List<AcsRouterQueueDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AcsRouterQueueDetails.DeserializeAcsRouterQueueDetails(item, options));
                    }
                    queueAssignments = array;
                    continue;
                }
                if (property.NameEquals("channelConfigurations"u8))
                {
                    List<AcsRouterChannelConfiguration> array = new List<AcsRouterChannelConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AcsRouterChannelConfiguration.DeserializeAcsRouterChannelConfiguration(item, options));
                    }
                    channelConfigurations = array;
                    continue;
                }
                if (property.NameEquals("totalCapacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalCapacity = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("labels"u8))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    labels = dictionary;
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("updatedWorkerProperties"u8))
                {
                    List<AcsRouterUpdatedWorkerProperty> array = new List<AcsRouterUpdatedWorkerProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AcsRouterUpdatedWorkerProperty(item.GetString()));
                    }
                    updatedWorkerProperties = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AcsRouterWorkerUpdatedEventData(
                workerId,
                queueAssignments,
                channelConfigurations,
                totalCapacity,
                labels,
                tags,
                updatedWorkerProperties,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AcsRouterWorkerUpdatedEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsRouterWorkerUpdatedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AcsRouterWorkerUpdatedEventData)} does not support writing '{options.Format}' format.");
            }
        }

        AcsRouterWorkerUpdatedEventData IPersistableModel<AcsRouterWorkerUpdatedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsRouterWorkerUpdatedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAcsRouterWorkerUpdatedEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AcsRouterWorkerUpdatedEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AcsRouterWorkerUpdatedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AcsRouterWorkerUpdatedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAcsRouterWorkerUpdatedEventData(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
