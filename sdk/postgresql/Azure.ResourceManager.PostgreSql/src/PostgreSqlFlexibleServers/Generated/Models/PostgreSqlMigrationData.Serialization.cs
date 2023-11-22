// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PostgreSql.FlexibleServers.Models;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers
{
    public partial class PostgreSqlMigrationData : IUtf8JsonSerializable, IJsonModel<PostgreSqlMigrationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PostgreSqlMigrationData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PostgreSqlMigrationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlMigrationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PostgreSqlMigrationData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
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
            if (options.Format != "W" && Optional.IsDefined(MigrationId))
            {
                writer.WritePropertyName("migrationId"u8);
                writer.WriteStringValue(MigrationId);
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentStatus))
            {
                writer.WritePropertyName("currentStatus"u8);
                writer.WriteObjectValue(CurrentStatus);
            }
            if (Optional.IsDefined(MigrationMode))
            {
                writer.WritePropertyName("migrationMode"u8);
                writer.WriteStringValue(MigrationMode.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(SourceDbServerMetadata))
            {
                writer.WritePropertyName("sourceDbServerMetadata"u8);
                writer.WriteObjectValue(SourceDbServerMetadata);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetDbServerMetadata))
            {
                writer.WritePropertyName("targetDbServerMetadata"u8);
                writer.WriteObjectValue(TargetDbServerMetadata);
            }
            if (Optional.IsDefined(SourceDbServerResourceId))
            {
                writer.WritePropertyName("sourceDbServerResourceId"u8);
                writer.WriteStringValue(SourceDbServerResourceId);
            }
            if (Optional.IsDefined(SourceDbServerFullyQualifiedDomainName))
            {
                writer.WritePropertyName("sourceDbServerFullyQualifiedDomainName"u8);
                writer.WriteStringValue(SourceDbServerFullyQualifiedDomainName);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetDbServerResourceId))
            {
                writer.WritePropertyName("targetDbServerResourceId"u8);
                writer.WriteStringValue(TargetDbServerResourceId);
            }
            if (Optional.IsDefined(TargetDbServerFullyQualifiedDomainName))
            {
                writer.WritePropertyName("targetDbServerFullyQualifiedDomainName"u8);
                writer.WriteStringValue(TargetDbServerFullyQualifiedDomainName);
            }
            if (Optional.IsDefined(SecretParameters))
            {
                writer.WritePropertyName("secretParameters"u8);
                writer.WriteObjectValue(SecretParameters);
            }
            if (Optional.IsCollectionDefined(DbsToMigrate))
            {
                writer.WritePropertyName("dbsToMigrate"u8);
                writer.WriteStartArray();
                foreach (var item in DbsToMigrate)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SetupLogicalReplicationOnSourceDbIfNeeded))
            {
                writer.WritePropertyName("setupLogicalReplicationOnSourceDbIfNeeded"u8);
                writer.WriteStringValue(SetupLogicalReplicationOnSourceDbIfNeeded.Value.ToString());
            }
            if (Optional.IsDefined(OverwriteDbsInTarget))
            {
                writer.WritePropertyName("overwriteDbsInTarget"u8);
                writer.WriteStringValue(OverwriteDbsInTarget.Value.ToString());
            }
            if (Optional.IsDefined(MigrationWindowStartTimeInUtc))
            {
                writer.WritePropertyName("migrationWindowStartTimeInUtc"u8);
                writer.WriteStringValue(MigrationWindowStartTimeInUtc.Value, "O");
            }
            if (Optional.IsDefined(MigrationWindowEndTimeInUtc))
            {
                writer.WritePropertyName("migrationWindowEndTimeInUtc"u8);
                writer.WriteStringValue(MigrationWindowEndTimeInUtc.Value, "O");
            }
            if (Optional.IsDefined(StartDataMigration))
            {
                writer.WritePropertyName("startDataMigration"u8);
                writer.WriteStringValue(StartDataMigration.Value.ToString());
            }
            if (Optional.IsDefined(TriggerCutover))
            {
                writer.WritePropertyName("triggerCutover"u8);
                writer.WriteStringValue(TriggerCutover.Value.ToString());
            }
            if (Optional.IsCollectionDefined(DbsToTriggerCutoverOn))
            {
                writer.WritePropertyName("dbsToTriggerCutoverOn"u8);
                writer.WriteStartArray();
                foreach (var item in DbsToTriggerCutoverOn)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Cancel))
            {
                writer.WritePropertyName("cancel"u8);
                writer.WriteStringValue(Cancel.Value.ToString());
            }
            if (Optional.IsCollectionDefined(DbsToCancelMigrationOn))
            {
                writer.WritePropertyName("dbsToCancelMigrationOn"u8);
                writer.WriteStartArray();
                foreach (var item in DbsToCancelMigrationOn)
                {
                    writer.WriteStringValue(item);
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

        PostgreSqlMigrationData IJsonModel<PostgreSqlMigrationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlMigrationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PostgreSqlMigrationData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlMigrationData(document.RootElement, options);
        }

        internal static PostgreSqlMigrationData DeserializePostgreSqlMigrationData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> migrationId = default;
            Optional<PostgreSqlMigrationStatus> currentStatus = default;
            Optional<PostgreSqlMigrationMode> migrationMode = default;
            Optional<PostgreSqlServerMetadata> sourceDbServerMetadata = default;
            Optional<PostgreSqlServerMetadata> targetDbServerMetadata = default;
            Optional<ResourceIdentifier> sourceDbServerResourceId = default;
            Optional<string> sourceDbServerFullyQualifiedDomainName = default;
            Optional<ResourceIdentifier> targetDbServerResourceId = default;
            Optional<string> targetDbServerFullyQualifiedDomainName = default;
            Optional<PostgreSqlMigrationSecretParameters> secretParameters = default;
            Optional<IList<string>> dbsToMigrate = default;
            Optional<PostgreSqlMigrationLogicalReplicationOnSourceDb> setupLogicalReplicationOnSourceDbIfNeeded = default;
            Optional<PostgreSqlMigrationOverwriteDbsInTarget> overwriteDbsInTarget = default;
            Optional<DateTimeOffset> migrationWindowStartTimeInUtc = default;
            Optional<DateTimeOffset> migrationWindowEndTimeInUtc = default;
            Optional<PostgreSqlMigrationStartDataMigration> startDataMigration = default;
            Optional<PostgreSqlMigrationTriggerCutover> triggerCutover = default;
            Optional<IList<string>> dbsToTriggerCutoverOn = default;
            Optional<PostgreSqlMigrationCancel> cancel = default;
            Optional<IList<string>> dbsToCancelMigrationOn = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("migrationId"u8))
                        {
                            migrationId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("currentStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentStatus = PostgreSqlMigrationStatus.DeserializePostgreSqlMigrationStatus(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("migrationMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            migrationMode = new PostgreSqlMigrationMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sourceDbServerMetadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceDbServerMetadata = PostgreSqlServerMetadata.DeserializePostgreSqlServerMetadata(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("targetDbServerMetadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetDbServerMetadata = PostgreSqlServerMetadata.DeserializePostgreSqlServerMetadata(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sourceDbServerResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceDbServerResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sourceDbServerFullyQualifiedDomainName"u8))
                        {
                            sourceDbServerFullyQualifiedDomainName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetDbServerResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetDbServerResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("targetDbServerFullyQualifiedDomainName"u8))
                        {
                            targetDbServerFullyQualifiedDomainName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("secretParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            secretParameters = PostgreSqlMigrationSecretParameters.DeserializePostgreSqlMigrationSecretParameters(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dbsToMigrate"u8))
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
                            dbsToMigrate = array;
                            continue;
                        }
                        if (property0.NameEquals("setupLogicalReplicationOnSourceDbIfNeeded"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            setupLogicalReplicationOnSourceDbIfNeeded = new PostgreSqlMigrationLogicalReplicationOnSourceDb(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("overwriteDbsInTarget"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            overwriteDbsInTarget = new PostgreSqlMigrationOverwriteDbsInTarget(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("migrationWindowStartTimeInUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            migrationWindowStartTimeInUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("migrationWindowEndTimeInUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            migrationWindowEndTimeInUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("startDataMigration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startDataMigration = new PostgreSqlMigrationStartDataMigration(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("triggerCutover"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            triggerCutover = new PostgreSqlMigrationTriggerCutover(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dbsToTriggerCutoverOn"u8))
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
                            dbsToTriggerCutoverOn = array;
                            continue;
                        }
                        if (property0.NameEquals("cancel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cancel = new PostgreSqlMigrationCancel(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dbsToCancelMigrationOn"u8))
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
                            dbsToCancelMigrationOn = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PostgreSqlMigrationData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, migrationId.Value, currentStatus.Value, Optional.ToNullable(migrationMode), sourceDbServerMetadata.Value, targetDbServerMetadata.Value, sourceDbServerResourceId.Value, sourceDbServerFullyQualifiedDomainName.Value, targetDbServerResourceId.Value, targetDbServerFullyQualifiedDomainName.Value, secretParameters.Value, Optional.ToList(dbsToMigrate), Optional.ToNullable(setupLogicalReplicationOnSourceDbIfNeeded), Optional.ToNullable(overwriteDbsInTarget), Optional.ToNullable(migrationWindowStartTimeInUtc), Optional.ToNullable(migrationWindowEndTimeInUtc), Optional.ToNullable(startDataMigration), Optional.ToNullable(triggerCutover), Optional.ToList(dbsToTriggerCutoverOn), Optional.ToNullable(cancel), Optional.ToList(dbsToCancelMigrationOn), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PostgreSqlMigrationData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlMigrationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(PostgreSqlMigrationData)} does not support '{options.Format}' format.");
            }
        }

        PostgreSqlMigrationData IPersistableModel<PostgreSqlMigrationData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlMigrationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePostgreSqlMigrationData(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(PostgreSqlMigrationData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PostgreSqlMigrationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
