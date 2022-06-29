// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class DeployerVmPackages : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("url");
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            if (Optional.IsDefined(StorageAccountId))
            {
                writer.WritePropertyName("storageAccountId");
                writer.WriteStringValue(StorageAccountId);
            }
            writer.WriteEndObject();
        }

        internal static DeployerVmPackages DeserializeDeployerVmPackages(JsonElement element)
        {
            Optional<Uri> url = default;
            Optional<string> storageAccountId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        url = null;
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountId"))
                {
                    storageAccountId = property.Value.GetString();
                    continue;
                }
            }
            return new DeployerVmPackages(url.Value, storageAccountId.Value);
        }
    }
}
