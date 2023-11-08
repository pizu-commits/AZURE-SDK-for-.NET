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

namespace Azure.ResourceManager.Compute.Models
{
    public partial class RollingUpgradePolicy : IUtf8JsonSerializable, IJsonModel<RollingUpgradePolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RollingUpgradePolicy>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<RollingUpgradePolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MaxBatchInstancePercent))
            {
                writer.WritePropertyName("maxBatchInstancePercent"u8);
                writer.WriteNumberValue(MaxBatchInstancePercent.Value);
            }
            if (Optional.IsDefined(MaxUnhealthyInstancePercent))
            {
                writer.WritePropertyName("maxUnhealthyInstancePercent"u8);
                writer.WriteNumberValue(MaxUnhealthyInstancePercent.Value);
            }
            if (Optional.IsDefined(MaxUnhealthyUpgradedInstancePercent))
            {
                writer.WritePropertyName("maxUnhealthyUpgradedInstancePercent"u8);
                writer.WriteNumberValue(MaxUnhealthyUpgradedInstancePercent.Value);
            }
            if (Optional.IsDefined(PauseTimeBetweenBatches))
            {
                writer.WritePropertyName("pauseTimeBetweenBatches"u8);
                writer.WriteStringValue(PauseTimeBetweenBatches);
            }
            if (Optional.IsDefined(EnableCrossZoneUpgrade))
            {
                writer.WritePropertyName("enableCrossZoneUpgrade"u8);
                writer.WriteBooleanValue(EnableCrossZoneUpgrade.Value);
            }
            if (Optional.IsDefined(PrioritizeUnhealthyInstances))
            {
                writer.WritePropertyName("prioritizeUnhealthyInstances"u8);
                writer.WriteBooleanValue(PrioritizeUnhealthyInstances.Value);
            }
            if (Optional.IsDefined(RollbackFailedInstancesOnPolicyBreach))
            {
                writer.WritePropertyName("rollbackFailedInstancesOnPolicyBreach"u8);
                writer.WriteBooleanValue(RollbackFailedInstancesOnPolicyBreach.Value);
            }
            if (Optional.IsDefined(IsMaxSurgeEnabled))
            {
                writer.WritePropertyName("maxSurge"u8);
                writer.WriteBooleanValue(IsMaxSurgeEnabled.Value);
            }
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

        RollingUpgradePolicy IJsonModel<RollingUpgradePolicy>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RollingUpgradePolicy)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRollingUpgradePolicy(document.RootElement, options);
        }

        internal static RollingUpgradePolicy DeserializeRollingUpgradePolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> maxBatchInstancePercent = default;
            Optional<int> maxUnhealthyInstancePercent = default;
            Optional<int> maxUnhealthyUpgradedInstancePercent = default;
            Optional<string> pauseTimeBetweenBatches = default;
            Optional<bool> enableCrossZoneUpgrade = default;
            Optional<bool> prioritizeUnhealthyInstances = default;
            Optional<bool> rollbackFailedInstancesOnPolicyBreach = default;
            Optional<bool> maxSurge = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxBatchInstancePercent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxBatchInstancePercent = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxUnhealthyInstancePercent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxUnhealthyInstancePercent = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxUnhealthyUpgradedInstancePercent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxUnhealthyUpgradedInstancePercent = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("pauseTimeBetweenBatches"u8))
                {
                    pauseTimeBetweenBatches = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enableCrossZoneUpgrade"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableCrossZoneUpgrade = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("prioritizeUnhealthyInstances"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    prioritizeUnhealthyInstances = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("rollbackFailedInstancesOnPolicyBreach"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rollbackFailedInstancesOnPolicyBreach = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("maxSurge"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxSurge = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RollingUpgradePolicy(Optional.ToNullable(maxBatchInstancePercent), Optional.ToNullable(maxUnhealthyInstancePercent), Optional.ToNullable(maxUnhealthyUpgradedInstancePercent), pauseTimeBetweenBatches.Value, Optional.ToNullable(enableCrossZoneUpgrade), Optional.ToNullable(prioritizeUnhealthyInstances), Optional.ToNullable(rollbackFailedInstancesOnPolicyBreach), Optional.ToNullable(maxSurge), serializedAdditionalRawData);
        }

        BinaryData IModel<RollingUpgradePolicy>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RollingUpgradePolicy)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RollingUpgradePolicy IModel<RollingUpgradePolicy>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RollingUpgradePolicy)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeRollingUpgradePolicy(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<RollingUpgradePolicy>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
