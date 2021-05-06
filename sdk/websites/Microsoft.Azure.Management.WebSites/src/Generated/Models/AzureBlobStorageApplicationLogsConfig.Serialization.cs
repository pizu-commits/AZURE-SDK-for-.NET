// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.WebSites.Models
{
    public partial class AzureBlobStorageApplicationLogsConfig : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Level))
            {
                writer.WritePropertyName("level");
                writer.WriteStringValue(Level.Value.ToSerialString());
            }
            if (Optional.IsDefined(SasUrl))
            {
                writer.WritePropertyName("sasUrl");
                writer.WriteStringValue(SasUrl);
            }
            if (Optional.IsDefined(RetentionInDays))
            {
                writer.WritePropertyName("retentionInDays");
                writer.WriteNumberValue(RetentionInDays.Value);
            }
            writer.WriteEndObject();
        }

        internal static AzureBlobStorageApplicationLogsConfig DeserializeAzureBlobStorageApplicationLogsConfig(JsonElement element)
        {
            Optional<LogLevel> level = default;
            Optional<string> sasUrl = default;
            Optional<int> retentionInDays = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("level"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    level = property.Value.GetString().ToLogLevel();
                    continue;
                }
                if (property.NameEquals("sasUrl"))
                {
                    sasUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("retentionInDays"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    retentionInDays = property.Value.GetInt32();
                    continue;
                }
            }
            return new AzureBlobStorageApplicationLogsConfig(Optional.ToNullable(level), sasUrl.Value, Optional.ToNullable(retentionInDays));
        }
    }
}
