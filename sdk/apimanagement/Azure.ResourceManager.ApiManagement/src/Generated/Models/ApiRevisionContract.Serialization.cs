// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiRevisionContract
    {
        internal static ApiRevisionContract DeserializeApiRevisionContract(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> apiId = default;
            Core.Optional<string> apiRevision = default;
            Core.Optional<DateTimeOffset> createdDateTime = default;
            Core.Optional<DateTimeOffset> updatedDateTime = default;
            Core.Optional<string> description = default;
            Core.Optional<string> privateUri = default;
            Core.Optional<bool> isOnline = default;
            Core.Optional<bool> isCurrent = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("apiId"u8))
                {
                    apiId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiRevision"u8))
                {
                    apiRevision = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("updatedDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updatedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateUrl"u8))
                {
                    privateUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isOnline"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isOnline = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isCurrent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isCurrent = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ApiRevisionContract(apiId.Value, apiRevision.Value, Core.Optional.ToNullable(createdDateTime), Core.Optional.ToNullable(updatedDateTime), description.Value, privateUri.Value, Core.Optional.ToNullable(isOnline), Core.Optional.ToNullable(isCurrent));
        }
    }
}
