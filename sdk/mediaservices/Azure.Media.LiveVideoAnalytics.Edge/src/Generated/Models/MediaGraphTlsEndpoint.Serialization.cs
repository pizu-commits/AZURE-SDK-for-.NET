// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.LiveVideoAnalytics.Edge.Models
{
    public partial class MediaGraphTlsEndpoint : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TrustedCertificates))
            {
                writer.WritePropertyName("trustedCertificates");
                writer.WriteObjectValue(TrustedCertificates);
            }
            if (Optional.IsDefined(ValidationOptions))
            {
                writer.WritePropertyName("validationOptions");
                writer.WriteObjectValue(ValidationOptions);
            }
            writer.WritePropertyName("@type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Credentials))
            {
                writer.WritePropertyName("credentials");
                writer.WriteObjectValue(Credentials);
            }
            writer.WritePropertyName("url");
            writer.WriteStringValue(Url);
            writer.WriteEndObject();
        }

        internal static MediaGraphTlsEndpoint DeserializeMediaGraphTlsEndpoint(JsonElement element)
        {
            Optional<MediaGraphCertificateSource> trustedCertificates = default;
            Optional<MediaGraphTlsValidationOptions> validationOptions = default;
            string type = default;
            Optional<MediaGraphCredentials> credentials = default;
            string url = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("trustedCertificates"))
                {
                    trustedCertificates = MediaGraphCertificateSource.DeserializeMediaGraphCertificateSource(property.Value);
                    continue;
                }
                if (property.NameEquals("validationOptions"))
                {
                    validationOptions = MediaGraphTlsValidationOptions.DeserializeMediaGraphTlsValidationOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("@type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("credentials"))
                {
                    credentials = MediaGraphCredentials.DeserializeMediaGraphCredentials(property.Value);
                    continue;
                }
                if (property.NameEquals("url"))
                {
                    url = property.Value.GetString();
                    continue;
                }
            }
            return new MediaGraphTlsEndpoint(type, credentials.Value, url, trustedCertificates.Value, validationOptions.Value);
        }
    }
}
