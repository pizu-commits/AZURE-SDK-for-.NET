// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateOracleAzureDBPostgreSqlSyncTaskInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("selectedDatabases");
            writer.WriteStartArray();
            foreach (var item in SelectedDatabases)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("targetConnectionInfo");
            writer.WriteObjectValue(TargetConnectionInfo);
            writer.WritePropertyName("sourceConnectionInfo");
            writer.WriteObjectValue(SourceConnectionInfo);
            writer.WriteEndObject();
        }

        internal static MigrateOracleAzureDBPostgreSqlSyncTaskInput DeserializeMigrateOracleAzureDBPostgreSqlSyncTaskInput(JsonElement element)
        {
            IList<MigrateOracleAzureDBPostgreSqlSyncDatabaseInput> selectedDatabases = default;
            PostgreSqlConnectionInfo targetConnectionInfo = default;
            OracleConnectionInfo sourceConnectionInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("selectedDatabases"))
                {
                    List<MigrateOracleAzureDBPostgreSqlSyncDatabaseInput> array = new List<MigrateOracleAzureDBPostgreSqlSyncDatabaseInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MigrateOracleAzureDBPostgreSqlSyncDatabaseInput.DeserializeMigrateOracleAzureDBPostgreSqlSyncDatabaseInput(item));
                    }
                    selectedDatabases = array;
                    continue;
                }
                if (property.NameEquals("targetConnectionInfo"))
                {
                    targetConnectionInfo = PostgreSqlConnectionInfo.DeserializePostgreSqlConnectionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("sourceConnectionInfo"))
                {
                    sourceConnectionInfo = OracleConnectionInfo.DeserializeOracleConnectionInfo(property.Value);
                    continue;
                }
            }
            return new MigrateOracleAzureDBPostgreSqlSyncTaskInput(selectedDatabases, targetConnectionInfo, sourceConnectionInfo);
        }
    }
}
