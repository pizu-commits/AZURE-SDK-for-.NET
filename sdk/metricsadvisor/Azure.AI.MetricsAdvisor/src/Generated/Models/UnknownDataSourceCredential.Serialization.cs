// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class UnknownDataSourceCredential
    {
        internal static UnknownDataSourceCredential DeserializeUnknownDataSourceCredential(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataSourceCredentialKind dataSourceCredentialType = "Unknown";
            Optional<string> dataSourceCredentialId = default;
            string dataSourceCredentialName = default;
            Optional<string> dataSourceCredentialDescription = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataSourceCredentialType"u8))
                {
                    dataSourceCredentialType = new DataSourceCredentialKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataSourceCredentialId"u8))
                {
                    dataSourceCredentialId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSourceCredentialName"u8))
                {
                    dataSourceCredentialName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSourceCredentialDescription"u8))
                {
                    dataSourceCredentialDescription = property.Value.GetString();
                    continue;
                }
            }
            return new UnknownDataSourceCredential(dataSourceCredentialType, dataSourceCredentialId.Value, dataSourceCredentialName, dataSourceCredentialDescription.Value);
        }
    }
}
