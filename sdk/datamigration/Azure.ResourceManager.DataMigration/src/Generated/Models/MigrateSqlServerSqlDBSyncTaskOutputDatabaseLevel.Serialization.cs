// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateSqlServerSqlDBSyncTaskOutputDatabaseLevel
    {
        internal static MigrateSqlServerSqlDBSyncTaskOutputDatabaseLevel DeserializeMigrateSqlServerSqlDBSyncTaskOutputDatabaseLevel(JsonElement element)
        {
            Optional<string> databaseName = default;
            Optional<DateTimeOffset> startedOn = default;
            Optional<DateTimeOffset> endedOn = default;
            Optional<SyncDatabaseMigrationReportingState> migrationState = default;
            Optional<long> incomingChanges = default;
            Optional<long> appliedChanges = default;
            Optional<long> cdcInsertCounter = default;
            Optional<long> cdcDeleteCounter = default;
            Optional<long> cdcUpdateCounter = default;
            Optional<long> fullLoadCompletedTables = default;
            Optional<long> fullLoadLoadingTables = default;
            Optional<long> fullLoadQueuedTables = default;
            Optional<long> fullLoadErroredTables = default;
            Optional<bool> initializationCompleted = default;
            Optional<long> latency = default;
            Optional<string> id = default;
            string resultType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databaseName"))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startedOn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endedOn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("migrationState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    migrationState = new SyncDatabaseMigrationReportingState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("incomingChanges"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    incomingChanges = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("appliedChanges"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    appliedChanges = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("cdcInsertCounter"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cdcInsertCounter = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("cdcDeleteCounter"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cdcDeleteCounter = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("cdcUpdateCounter"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cdcUpdateCounter = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("fullLoadCompletedTables"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fullLoadCompletedTables = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("fullLoadLoadingTables"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fullLoadLoadingTables = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("fullLoadQueuedTables"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fullLoadQueuedTables = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("fullLoadErroredTables"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fullLoadErroredTables = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("initializationCompleted"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    initializationCompleted = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("latency"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    latency = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
            }
            return new MigrateSqlServerSqlDBSyncTaskOutputDatabaseLevel(id.Value, resultType, databaseName.Value, Optional.ToNullable(startedOn), Optional.ToNullable(endedOn), Optional.ToNullable(migrationState), Optional.ToNullable(incomingChanges), Optional.ToNullable(appliedChanges), Optional.ToNullable(cdcInsertCounter), Optional.ToNullable(cdcDeleteCounter), Optional.ToNullable(cdcUpdateCounter), Optional.ToNullable(fullLoadCompletedTables), Optional.ToNullable(fullLoadLoadingTables), Optional.ToNullable(fullLoadQueuedTables), Optional.ToNullable(fullLoadErroredTables), Optional.ToNullable(initializationCompleted), Optional.ToNullable(latency));
        }
    }
}
