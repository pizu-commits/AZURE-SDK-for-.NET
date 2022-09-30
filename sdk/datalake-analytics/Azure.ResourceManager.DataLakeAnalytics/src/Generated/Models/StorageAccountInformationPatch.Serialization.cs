// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    public partial class StorageAccountInformationPatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AccessKey))
            {
                writer.WritePropertyName("accessKey");
                writer.WriteStringValue(AccessKey);
            }
            if (Optional.IsDefined(Suffix))
            {
                writer.WritePropertyName("suffix");
                writer.WriteStringValue(Suffix);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
