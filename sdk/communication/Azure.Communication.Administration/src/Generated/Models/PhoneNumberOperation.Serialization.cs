// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Administration.Models
{
    internal partial class PhoneNumberOperation
    {
        internal static PhoneNumberOperation DeserializePhoneNumberOperation(JsonElement element)
        {
            PhoneNumberOperationStatusCodes status = default;
            string id = default;
            OperationKind kind = default;
            DateTimeOffset createdDateTime = default;
            DateTimeOffset lastActionDateTime = default;
            Optional<string> resourceLocation = default;
            Optional<CommunicationError> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString().ToPhoneNumberOperationStatusCodes();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = new OperationKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createdDateTime"))
                {
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastActionDateTime"))
                {
                    lastActionDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("resourceLocation"))
                {
                    resourceLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        error = null;
                        continue;
                    }
                    error = CommunicationError.DeserializeCommunicationError(property.Value);
                    continue;
                }
            }
            return new PhoneNumberOperation(status, id, kind, createdDateTime, lastActionDateTime, resourceLocation.Value, error.Value);
        }
    }
}
