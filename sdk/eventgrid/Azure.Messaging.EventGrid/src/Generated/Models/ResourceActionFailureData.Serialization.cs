// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.Models
{
    public partial class ResourceActionFailureData
    {
        internal static ResourceActionFailureData DeserializeResourceActionFailureData(JsonElement element)
        {
            string tenantId = default;
            string subscriptionId = default;
            string resourceGroup = default;
            string resourceProvider = default;
            string resourceUri = default;
            string operationName = default;
            string status = default;
            string authorization = default;
            string claims = default;
            string correlationId = default;
            string httpRequest = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tenantId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroup"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceProvider"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceProvider = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authorization"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authorization = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("claims"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    claims = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpRequest"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    httpRequest = property.Value.GetString();
                    continue;
                }
            }
            return new ResourceActionFailureData(tenantId, subscriptionId, resourceGroup, resourceProvider, resourceUri, operationName, status, authorization, claims, correlationId, httpRequest);
        }
    }
}
