// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class MicrosoftSecurityIncidentCreationAlertRuleTemplate : IUtf8JsonSerializable, IJsonModel<MicrosoftSecurityIncidentCreationAlertRuleTemplate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MicrosoftSecurityIncidentCreationAlertRuleTemplate>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MicrosoftSecurityIncidentCreationAlertRuleTemplate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MicrosoftSecurityIncidentCreationAlertRuleTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MicrosoftSecurityIncidentCreationAlertRuleTemplate)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AlertRulesCreatedByTemplateCount))
            {
                writer.WritePropertyName("alertRulesCreatedByTemplateCount"u8);
                writer.WriteNumberValue(AlertRulesCreatedByTemplateCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdDateUTC"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastUpdatedOn))
            {
                writer.WritePropertyName("lastUpdatedDateUTC"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsCollectionDefined(RequiredDataConnectors))
            {
                writer.WritePropertyName("requiredDataConnectors"u8);
                writer.WriteStartArray();
                foreach (var item in RequiredDataConnectors)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsCollectionDefined(DisplayNamesFilter))
            {
                writer.WritePropertyName("displayNamesFilter"u8);
                writer.WriteStartArray();
                foreach (var item in DisplayNamesFilter)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DisplayNamesExcludeFilter))
            {
                writer.WritePropertyName("displayNamesExcludeFilter"u8);
                writer.WriteStartArray();
                foreach (var item in DisplayNamesExcludeFilter)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ProductFilter))
            {
                writer.WritePropertyName("productFilter"u8);
                writer.WriteStringValue(ProductFilter.Value.ToString());
            }
            if (Optional.IsCollectionDefined(SeveritiesFilter))
            {
                writer.WritePropertyName("severitiesFilter"u8);
                writer.WriteStartArray();
                foreach (var item in SeveritiesFilter)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        MicrosoftSecurityIncidentCreationAlertRuleTemplate IJsonModel<MicrosoftSecurityIncidentCreationAlertRuleTemplate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MicrosoftSecurityIncidentCreationAlertRuleTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MicrosoftSecurityIncidentCreationAlertRuleTemplate)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMicrosoftSecurityIncidentCreationAlertRuleTemplate(document.RootElement, options);
        }

        internal static MicrosoftSecurityIncidentCreationAlertRuleTemplate DeserializeMicrosoftSecurityIncidentCreationAlertRuleTemplate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AlertRuleKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            int? alertRulesCreatedByTemplateCount = default;
            DateTimeOffset? createdDateUTC = default;
            DateTimeOffset? lastUpdatedDateUTC = default;
            string description = default;
            string displayName = default;
            IList<AlertRuleTemplateDataSource> requiredDataConnectors = default;
            SecurityInsightsAlertRuleTemplateStatus? status = default;
            IList<string> displayNamesFilter = default;
            IList<string> displayNamesExcludeFilter = default;
            MicrosoftSecurityProductName? productFilter = default;
            IList<SecurityInsightsAlertSeverity> severitiesFilter = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new AlertRuleKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("alertRulesCreatedByTemplateCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            alertRulesCreatedByTemplateCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("createdDateUTC"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdDateUTC = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastUpdatedDateUTC"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastUpdatedDateUTC = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("requiredDataConnectors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AlertRuleTemplateDataSource> array = new List<AlertRuleTemplateDataSource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AlertRuleTemplateDataSource.DeserializeAlertRuleTemplateDataSource(item, options));
                            }
                            requiredDataConnectors = array;
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new SecurityInsightsAlertRuleTemplateStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("displayNamesFilter"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            displayNamesFilter = array;
                            continue;
                        }
                        if (property0.NameEquals("displayNamesExcludeFilter"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            displayNamesExcludeFilter = array;
                            continue;
                        }
                        if (property0.NameEquals("productFilter"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            productFilter = new MicrosoftSecurityProductName(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("severitiesFilter"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecurityInsightsAlertSeverity> array = new List<SecurityInsightsAlertSeverity>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new SecurityInsightsAlertSeverity(item.GetString()));
                            }
                            severitiesFilter = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MicrosoftSecurityIncidentCreationAlertRuleTemplate(
                id,
                name,
                type,
                systemData,
                kind,
                serializedAdditionalRawData,
                alertRulesCreatedByTemplateCount,
                createdDateUTC,
                lastUpdatedDateUTC,
                description,
                displayName,
                requiredDataConnectors ?? new ChangeTrackingList<AlertRuleTemplateDataSource>(),
                status,
                displayNamesFilter ?? new ChangeTrackingList<string>(),
                displayNamesExcludeFilter ?? new ChangeTrackingList<string>(),
                productFilter,
                severitiesFilter ?? new ChangeTrackingList<SecurityInsightsAlertSeverity>());
        }

        BinaryData IPersistableModel<MicrosoftSecurityIncidentCreationAlertRuleTemplate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MicrosoftSecurityIncidentCreationAlertRuleTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MicrosoftSecurityIncidentCreationAlertRuleTemplate)} does not support writing '{options.Format}' format.");
            }
        }

        MicrosoftSecurityIncidentCreationAlertRuleTemplate IPersistableModel<MicrosoftSecurityIncidentCreationAlertRuleTemplate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MicrosoftSecurityIncidentCreationAlertRuleTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMicrosoftSecurityIncidentCreationAlertRuleTemplate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MicrosoftSecurityIncidentCreationAlertRuleTemplate)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MicrosoftSecurityIncidentCreationAlertRuleTemplate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
