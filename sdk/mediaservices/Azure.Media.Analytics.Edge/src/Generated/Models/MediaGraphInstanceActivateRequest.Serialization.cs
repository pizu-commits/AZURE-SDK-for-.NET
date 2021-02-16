// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.Analytics.Edge.Models
{
    public partial class MediaGraphInstanceActivateRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("@apiVersion");
                writer.WriteStringValue(ApiVersion);
            }
            writer.WriteEndObject();
        }

        internal static MediaGraphInstanceActivateRequest DeserializeMediaGraphInstanceActivateRequest(JsonElement element)
        {
            string name = default;
            string methodName = default;
            Optional<string> apiVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("methodName"))
                {
                    methodName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@apiVersion"))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
            }
            return new MediaGraphInstanceActivateRequest(methodName, apiVersion.Value, name);
        }
    }
}
