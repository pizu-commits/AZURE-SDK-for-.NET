// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Media.VideoAnalyzer.Edge;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class UnsecuredEndpoint : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("@type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Credentials))
            {
                writer.WritePropertyName("credentials"u8);
                writer.WriteObjectValue(Credentials);
            }
            writer.WritePropertyName("url"u8);
            writer.WriteStringValue(Url);
            writer.WriteEndObject();
        }

        internal static UnsecuredEndpoint DeserializeUnsecuredEndpoint(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            CredentialsBase credentials = default;
            string url = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("credentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    credentials = CredentialsBase.DeserializeCredentialsBase(property.Value);
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    url = property.Value.GetString();
                    continue;
                }
            }
            return new UnsecuredEndpoint(type, credentials, url);
        }
    }
}
