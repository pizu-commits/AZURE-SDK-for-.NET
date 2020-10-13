// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class StorageDirectoryRenamedEventData
    {
        internal static StorageDirectoryRenamedEventData DeserializeStorageDirectoryRenamedEventData(JsonElement element)
        {
            Optional<string> api = default;
            Optional<string> clientRequestId = default;
            Optional<string> requestId = default;
            Optional<string> sourceUrl = default;
            Optional<string> destinationUrl = default;
            Optional<string> sequencer = default;
            Optional<string> identity = default;
            Optional<object> storageDiagnostics = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("api"))
                {
                    api = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientRequestId"))
                {
                    clientRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestId"))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceUrl"))
                {
                    sourceUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationUrl"))
                {
                    destinationUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sequencer"))
                {
                    sequencer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    identity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageDiagnostics"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    storageDiagnostics = property.Value.GetObject();
                    continue;
                }
            }
            return new StorageDirectoryRenamedEventData(api.Value, clientRequestId.Value, requestId.Value, sourceUrl.Value, destinationUrl.Value, sequencer.Value, identity.Value, storageDiagnostics.Value);
        }
    }
}
