// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class DefaultRolloutStatus : IUtf8JsonSerializable, IJsonModel<DefaultRolloutStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DefaultRolloutStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DefaultRolloutStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefaultRolloutStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefaultRolloutStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (NextTrafficRegion.HasValue)
            {
                writer.WritePropertyName("nextTrafficRegion"u8);
                writer.WriteStringValue(NextTrafficRegion.Value.ToString());
            }
            if (NextTrafficRegionScheduledOn.HasValue)
            {
                writer.WritePropertyName("nextTrafficRegionScheduledTime"u8);
                writer.WriteStringValue(NextTrafficRegionScheduledOn.Value, "O");
            }
            if (SubscriptionReregistrationResult.HasValue)
            {
                writer.WritePropertyName("subscriptionReregistrationResult"u8);
                writer.WriteStringValue(SubscriptionReregistrationResult.Value.ToString());
            }
            if (!(CompletedRegions is ChangeTrackingList<AzureLocation> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("completedRegions"u8);
                writer.WriteStartArray();
                foreach (var item in CompletedRegions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(FailedOrSkippedRegions is ChangeTrackingDictionary<string, ExtendedErrorInfo> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("failedOrSkippedRegions"u8);
                writer.WriteStartObject();
                foreach (var item in FailedOrSkippedRegions)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
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

        DefaultRolloutStatus IJsonModel<DefaultRolloutStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefaultRolloutStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefaultRolloutStatus)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDefaultRolloutStatus(document.RootElement, options);
        }

        internal static DefaultRolloutStatus DeserializeDefaultRolloutStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<TrafficRegionCategory> nextTrafficRegion = default;
            Optional<DateTimeOffset> nextTrafficRegionScheduledTime = default;
            Optional<SubscriptionReregistrationResult> subscriptionReregistrationResult = default;
            IList<AzureLocation> completedRegions = default;
            Optional<IDictionary<string, ExtendedErrorInfo>> failedOrSkippedRegions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextTrafficRegion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextTrafficRegion = new TrafficRegionCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nextTrafficRegionScheduledTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextTrafficRegionScheduledTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("subscriptionReregistrationResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subscriptionReregistrationResult = new SubscriptionReregistrationResult(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("completedRegions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureLocation> array = new List<AzureLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AzureLocation(item.GetString()));
                    }
                    completedRegions = array;
                    continue;
                }
                if (property.NameEquals("failedOrSkippedRegions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ExtendedErrorInfo> dictionary = new Dictionary<string, ExtendedErrorInfo>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ExtendedErrorInfo.DeserializeExtendedErrorInfo(property0.Value, options));
                    }
                    failedOrSkippedRegions = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DefaultRolloutStatus(completedRegions ?? new ChangeTrackingList<AzureLocation>(), Optional.ToDictionary(failedOrSkippedRegions), serializedAdditionalRawData, Optional.ToNullable(nextTrafficRegion), Optional.ToNullable(nextTrafficRegionScheduledTime), Optional.ToNullable(subscriptionReregistrationResult));
        }

        BinaryData IPersistableModel<DefaultRolloutStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefaultRolloutStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DefaultRolloutStatus)} does not support '{options.Format}' format.");
            }
        }

        DefaultRolloutStatus IPersistableModel<DefaultRolloutStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefaultRolloutStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDefaultRolloutStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DefaultRolloutStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DefaultRolloutStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
