// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceCertificateProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(KeyVaultId))
            {
                writer.WritePropertyName("keyVaultId");
                writer.WriteStringValue(KeyVaultId);
            }
            if (Optional.IsDefined(KeyVaultSecretName))
            {
                writer.WritePropertyName("keyVaultSecretName");
                writer.WriteStringValue(KeyVaultSecretName);
            }
            writer.WriteEndObject();
        }

        internal static AppServiceCertificateProperties DeserializeAppServiceCertificateProperties(JsonElement element)
        {
            Optional<string> keyVaultId = default;
            Optional<string> keyVaultSecretName = default;
            Optional<KeyVaultSecretStatus> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultId"))
                {
                    keyVaultId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultSecretName"))
                {
                    keyVaultSecretName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = property.Value.GetString().ToKeyVaultSecretStatus();
                    continue;
                }
            }
            return new AppServiceCertificateProperties(keyVaultId.Value, keyVaultSecretName.Value, Optional.ToNullable(provisioningState));
        }
    }
}
