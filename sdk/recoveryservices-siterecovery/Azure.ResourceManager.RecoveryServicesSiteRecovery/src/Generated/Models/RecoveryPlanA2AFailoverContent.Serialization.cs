// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class RecoveryPlanA2AFailoverContent : IUtf8JsonSerializable, IJsonModel<RecoveryPlanA2AFailoverContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecoveryPlanA2AFailoverContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RecoveryPlanA2AFailoverContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanA2AFailoverContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryPlanA2AFailoverContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("recoveryPointType"u8);
            writer.WriteStringValue(RecoveryPointType.ToString());
            if (Optional.IsDefined(CloudServiceCreationOption))
            {
                writer.WritePropertyName("cloudServiceCreationOption"u8);
                writer.WriteStringValue(CloudServiceCreationOption);
            }
            if (Optional.IsDefined(MultiVmSyncPointOption))
            {
                writer.WritePropertyName("multiVmSyncPointOption"u8);
                writer.WriteStringValue(MultiVmSyncPointOption.Value.ToString());
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        RecoveryPlanA2AFailoverContent IJsonModel<RecoveryPlanA2AFailoverContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanA2AFailoverContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryPlanA2AFailoverContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryPlanA2AFailoverContent(document.RootElement, options);
        }

        internal static RecoveryPlanA2AFailoverContent DeserializeRecoveryPlanA2AFailoverContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            A2ARpRecoveryPointType recoveryPointType = default;
            string cloudServiceCreationOption = default;
            MultiVmSyncPointOption? multiVmSyncPointOption = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPointType"u8))
                {
                    recoveryPointType = new A2ARpRecoveryPointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cloudServiceCreationOption"u8))
                {
                    cloudServiceCreationOption = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("multiVmSyncPointOption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    multiVmSyncPointOption = new MultiVmSyncPointOption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RecoveryPlanA2AFailoverContent(instanceType, serializedAdditionalRawData, recoveryPointType, cloudServiceCreationOption, multiVmSyncPointOption);
        }

        BinaryData IPersistableModel<RecoveryPlanA2AFailoverContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanA2AFailoverContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RecoveryPlanA2AFailoverContent)} does not support writing '{options.Format}' format.");
            }
        }

        RecoveryPlanA2AFailoverContent IPersistableModel<RecoveryPlanA2AFailoverContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanA2AFailoverContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRecoveryPlanA2AFailoverContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RecoveryPlanA2AFailoverContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecoveryPlanA2AFailoverContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
