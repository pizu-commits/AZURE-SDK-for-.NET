// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Identity.Models
{
    internal partial class CommunicationIdentityAccessTokenRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("scopes"u8);
            writer.WriteStartArray();
            foreach (var item in Scopes)
            {
                writer.WriteStringValue(item.ToString());
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(ExpiresInMinutes))
            {
                writer.WritePropertyName("expiresInMinutes"u8);
                writer.WriteNumberValue(ExpiresInMinutes.Value);
            }
            writer.WriteEndObject();
        }
    }
}
