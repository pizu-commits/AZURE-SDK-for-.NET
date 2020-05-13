// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class SnapshotSku : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name.Value.ToString());
            }
            if (Tier != null)
            {
                writer.WritePropertyName("tier");
                writer.WriteStringValue(Tier);
            }
            writer.WriteEndObject();
        }

        internal static SnapshotSku DeserializeSnapshotSku(JsonElement element)
        {
            SnapshotStorageAccountTypes? name = default;
            string tier = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = new SnapshotStorageAccountTypes(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tier = property.Value.GetString();
                    continue;
                }
            }
            return new SnapshotSku(name, tier);
        }
    }
}
