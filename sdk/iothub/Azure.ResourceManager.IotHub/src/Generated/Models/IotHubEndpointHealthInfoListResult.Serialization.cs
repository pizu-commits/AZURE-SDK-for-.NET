// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    internal partial class IotHubEndpointHealthInfoListResult : IUtf8JsonSerializable, IJsonModel<IotHubEndpointHealthInfoListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotHubEndpointHealthInfoListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IotHubEndpointHealthInfoListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubEndpointHealthInfoListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubEndpointHealthInfoListResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        IotHubEndpointHealthInfoListResult IJsonModel<IotHubEndpointHealthInfoListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubEndpointHealthInfoListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubEndpointHealthInfoListResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotHubEndpointHealthInfoListResult(document.RootElement, options);
        }

        internal static IotHubEndpointHealthInfoListResult DeserializeIotHubEndpointHealthInfoListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<IotHubEndpointHealthInfo> value = default;
            string nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IotHubEndpointHealthInfo> array = new List<IotHubEndpointHealthInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotHubEndpointHealthInfo.DeserializeIotHubEndpointHealthInfo(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IotHubEndpointHealthInfoListResult(value ?? new ChangeTrackingList<IotHubEndpointHealthInfo>(), nextLink, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotHubEndpointHealthInfoListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubEndpointHealthInfoListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IotHubEndpointHealthInfoListResult)} does not support '{options.Format}' format.");
            }
        }

        IotHubEndpointHealthInfoListResult IPersistableModel<IotHubEndpointHealthInfoListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubEndpointHealthInfoListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIotHubEndpointHealthInfoListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IotHubEndpointHealthInfoListResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IotHubEndpointHealthInfoListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
