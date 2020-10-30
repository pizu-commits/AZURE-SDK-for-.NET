// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Security.Attestation.Models
{
    public partial class TpmAttestationResponse
    {
        internal static TpmAttestationResponse DeserializeTpmAttestationResponse(JsonElement element)
        {
            Optional<byte[]> data = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("data"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    data = property.Value.GetBytesFromBase64("U");
                    continue;
                }
            }
            return new TpmAttestationResponse(data.Value);
        }
    }
}
