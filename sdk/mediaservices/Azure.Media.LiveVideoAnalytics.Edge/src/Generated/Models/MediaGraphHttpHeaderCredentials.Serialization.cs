// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.LiveVideoAnalytics.Edge.Models
{
    public partial class MediaGraphHttpHeaderCredentials : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("headerName");
            writer.WriteStringValue(HeaderName);
            writer.WritePropertyName("headerValue");
            writer.WriteStringValue(HeaderValue);
            writer.WritePropertyName("@type");
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }

        internal static MediaGraphHttpHeaderCredentials DeserializeMediaGraphHttpHeaderCredentials(JsonElement element)
        {
            string headerName = default;
            string headerValue = default;
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("headerName"))
                {
                    headerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("headerValue"))
                {
                    headerValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new MediaGraphHttpHeaderCredentials(type, headerName, headerValue);
        }
    }
}
