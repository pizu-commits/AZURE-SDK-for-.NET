// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryJobEntity : IUtf8JsonSerializable, IJsonModel<SiteRecoveryJobEntity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryJobEntity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SiteRecoveryJobEntity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryJobEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryJobEntity)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(JobId))
            {
                writer.WritePropertyName("jobId"u8);
                writer.WriteStringValue(JobId);
            }
            if (Optional.IsDefined(JobFriendlyName))
            {
                writer.WritePropertyName("jobFriendlyName"u8);
                writer.WriteStringValue(JobFriendlyName);
            }
            if (Optional.IsDefined(TargetObjectId))
            {
                writer.WritePropertyName("targetObjectId"u8);
                writer.WriteStringValue(TargetObjectId);
            }
            if (Optional.IsDefined(TargetObjectName))
            {
                writer.WritePropertyName("targetObjectName"u8);
                writer.WriteStringValue(TargetObjectName);
            }
            if (Optional.IsDefined(TargetInstanceType))
            {
                writer.WritePropertyName("targetInstanceType"u8);
                writer.WriteStringValue(TargetInstanceType);
            }
            if (Optional.IsDefined(JobScenarioName))
            {
                writer.WritePropertyName("jobScenarioName"u8);
                writer.WriteStringValue(JobScenarioName);
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

        SiteRecoveryJobEntity IJsonModel<SiteRecoveryJobEntity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryJobEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryJobEntity)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryJobEntity(document.RootElement, options);
        }

        internal static SiteRecoveryJobEntity DeserializeSiteRecoveryJobEntity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier jobId = default;
            string jobFriendlyName = default;
            string targetObjectId = default;
            string targetObjectName = default;
            string targetInstanceType = default;
            string jobScenarioName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("jobFriendlyName"u8))
                {
                    jobFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetObjectId"u8))
                {
                    targetObjectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetObjectName"u8))
                {
                    targetObjectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetInstanceType"u8))
                {
                    targetInstanceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobScenarioName"u8))
                {
                    jobScenarioName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SiteRecoveryJobEntity(
                jobId,
                jobFriendlyName,
                targetObjectId,
                targetObjectName,
                targetInstanceType,
                jobScenarioName,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SiteRecoveryJobEntity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryJobEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryJobEntity)} does not support '{options.Format}' format.");
            }
        }

        SiteRecoveryJobEntity IPersistableModel<SiteRecoveryJobEntity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryJobEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryJobEntity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryJobEntity)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryJobEntity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
