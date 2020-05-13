// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Resources.Models
{
    public partial class ScriptStatus : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (ContainerInstanceId != null)
            {
                writer.WritePropertyName("containerInstanceId");
                writer.WriteStringValue(ContainerInstanceId);
            }
            if (StorageAccountId != null)
            {
                writer.WritePropertyName("storageAccountId");
                writer.WriteStringValue(StorageAccountId);
            }
            if (StartTime != null)
            {
                writer.WritePropertyName("startTime");
                writer.WriteStringValue(StartTime.Value, "O");
            }
            if (EndTime != null)
            {
                writer.WritePropertyName("endTime");
                writer.WriteStringValue(EndTime.Value, "O");
            }
            if (ExpirationTime != null)
            {
                writer.WritePropertyName("expirationTime");
                writer.WriteStringValue(ExpirationTime.Value, "O");
            }
            if (Error != null)
            {
                writer.WritePropertyName("error");
                writer.WriteObjectValue(Error);
            }
            writer.WriteEndObject();
        }

        internal static ScriptStatus DeserializeScriptStatus(JsonElement element)
        {
            string containerInstanceId = default;
            string storageAccountId = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? endTime = default;
            DateTimeOffset? expirationTime = default;
            ErrorResponse error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("containerInstanceId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containerInstanceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageAccountId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expirationTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expirationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = ErrorResponse.DeserializeErrorResponse(property.Value);
                    continue;
                }
            }
            return new ScriptStatus(containerInstanceId, storageAccountId, startTime, endTime, expirationTime, error);
        }
    }
}
