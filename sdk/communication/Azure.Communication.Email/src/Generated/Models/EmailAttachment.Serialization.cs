// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Email
{
    public partial class EmailAttachment : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("contentType"u8);
            writer.WriteStringValue(ContentType);
            writer.WritePropertyName("contentInBase64"u8);
            writer.WriteBase64StringValue(Content, "D");
            writer.WriteEndObject();
        }
    }
}
