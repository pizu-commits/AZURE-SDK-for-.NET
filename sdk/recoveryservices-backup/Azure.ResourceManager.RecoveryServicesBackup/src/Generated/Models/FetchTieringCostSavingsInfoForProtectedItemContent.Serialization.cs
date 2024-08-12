// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class FetchTieringCostSavingsInfoForProtectedItemContent : IUtf8JsonSerializable, IJsonModel<FetchTieringCostSavingsInfoForProtectedItemContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FetchTieringCostSavingsInfoForProtectedItemContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FetchTieringCostSavingsInfoForProtectedItemContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FetchTieringCostSavingsInfoForProtectedItemContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FetchTieringCostSavingsInfoForProtectedItemContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("containerName"u8);
            writer.WriteStringValue(ContainerName);
            writer.WritePropertyName("protectedItemName"u8);
            writer.WriteStringValue(ProtectedItemName);
            writer.WritePropertyName("sourceTierType"u8);
            writer.WriteStringValue(SourceTierType.ToSerialString());
            writer.WritePropertyName("targetTierType"u8);
            writer.WriteStringValue(TargetTierType.ToSerialString());
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        FetchTieringCostSavingsInfoForProtectedItemContent IJsonModel<FetchTieringCostSavingsInfoForProtectedItemContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FetchTieringCostSavingsInfoForProtectedItemContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FetchTieringCostSavingsInfoForProtectedItemContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFetchTieringCostSavingsInfoForProtectedItemContent(document.RootElement, options);
        }

        internal static FetchTieringCostSavingsInfoForProtectedItemContent DeserializeFetchTieringCostSavingsInfoForProtectedItemContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string containerName = default;
            string protectedItemName = default;
            RecoveryPointTierType sourceTierType = default;
            RecoveryPointTierType targetTierType = default;
            string objectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("containerName"u8))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedItemName"u8))
                {
                    protectedItemName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceTierType"u8))
                {
                    sourceTierType = property.Value.GetString().ToRecoveryPointTierType();
                    continue;
                }
                if (property.NameEquals("targetTierType"u8))
                {
                    targetTierType = property.Value.GetString().ToRecoveryPointTierType();
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FetchTieringCostSavingsInfoForProtectedItemContent(
                sourceTierType,
                targetTierType,
                objectType,
                serializedAdditionalRawData,
                containerName,
                protectedItemName);
        }

        BinaryData IPersistableModel<FetchTieringCostSavingsInfoForProtectedItemContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FetchTieringCostSavingsInfoForProtectedItemContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FetchTieringCostSavingsInfoForProtectedItemContent)} does not support writing '{options.Format}' format.");
            }
        }

        FetchTieringCostSavingsInfoForProtectedItemContent IPersistableModel<FetchTieringCostSavingsInfoForProtectedItemContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FetchTieringCostSavingsInfoForProtectedItemContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFetchTieringCostSavingsInfoForProtectedItemContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FetchTieringCostSavingsInfoForProtectedItemContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FetchTieringCostSavingsInfoForProtectedItemContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
