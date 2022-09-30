// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceStorageAccessInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(StorageType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(StorageType.Value.ToSerialString());
            }
            if (Optional.IsDefined(AccountName))
            {
                writer.WritePropertyName("accountName");
                writer.WriteStringValue(AccountName);
            }
            if (Optional.IsDefined(ShareName))
            {
                writer.WritePropertyName("shareName");
                writer.WriteStringValue(ShareName);
            }
            if (Optional.IsDefined(AccessKey))
            {
                writer.WritePropertyName("accessKey");
                writer.WriteStringValue(AccessKey);
            }
            if (Optional.IsDefined(MountPath))
            {
                writer.WritePropertyName("mountPath");
                writer.WriteStringValue(MountPath);
            }
            writer.WriteEndObject();
        }

        internal static AppServiceStorageAccessInfo DeserializeAppServiceStorageAccessInfo(JsonElement element)
        {
            Optional<AppServiceStorageType> type = default;
            Optional<string> accountName = default;
            Optional<string> shareName = default;
            Optional<string> accessKey = default;
            Optional<string> mountPath = default;
            Optional<AppServiceStorageAccountState> state = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = property.Value.GetString().ToAppServiceStorageType();
                    continue;
                }
                if (property.NameEquals("accountName"))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("shareName"))
                {
                    shareName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessKey"))
                {
                    accessKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mountPath"))
                {
                    mountPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    state = property.Value.GetString().ToAppServiceStorageAccountState();
                    continue;
                }
            }
            return new AppServiceStorageAccessInfo(Optional.ToNullable(type), accountName.Value, shareName.Value, accessKey.Value, mountPath.Value, Optional.ToNullable(state));
        }
    }
}
