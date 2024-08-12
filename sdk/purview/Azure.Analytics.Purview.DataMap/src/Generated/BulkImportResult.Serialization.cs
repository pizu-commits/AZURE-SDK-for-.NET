// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.DataMap
{
    public partial class BulkImportResult : IUtf8JsonSerializable, IJsonModel<BulkImportResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BulkImportResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BulkImportResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BulkImportResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BulkImportResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(FailedImportInfoList))
            {
                writer.WritePropertyName("failedImportInfoList"u8);
                writer.WriteStartArray();
                foreach (var item in FailedImportInfoList)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SuccessImportInfoList))
            {
                writer.WritePropertyName("successImportInfoList"u8);
                writer.WriteStartArray();
                foreach (var item in SuccessImportInfoList)
                {
                    writer.WriteObjectValue(item, options);
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

        BulkImportResult IJsonModel<BulkImportResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BulkImportResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BulkImportResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBulkImportResult(document.RootElement, options);
        }

        internal static BulkImportResult DeserializeBulkImportResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ImportInfo> failedImportInfoList = default;
            IReadOnlyList<ImportInfo> successImportInfoList = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("failedImportInfoList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ImportInfo> array = new List<ImportInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ImportInfo.DeserializeImportInfo(item, options));
                    }
                    failedImportInfoList = array;
                    continue;
                }
                if (property.NameEquals("successImportInfoList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ImportInfo> array = new List<ImportInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ImportInfo.DeserializeImportInfo(item, options));
                    }
                    successImportInfoList = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BulkImportResult(failedImportInfoList ?? new ChangeTrackingList<ImportInfo>(), successImportInfoList ?? new ChangeTrackingList<ImportInfo>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BulkImportResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BulkImportResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BulkImportResult)} does not support writing '{options.Format}' format.");
            }
        }

        BulkImportResult IPersistableModel<BulkImportResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BulkImportResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBulkImportResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BulkImportResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BulkImportResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static BulkImportResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeBulkImportResult(document.RootElement);
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
