// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    public partial class BulkCollectionsActionContent : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsCollectionDefined(CollectionIds))
            {
                writer.WritePropertyName("collectionIds"u8);
                writer.WriteStartArray();
                foreach (var item in CollectionIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action"u8);
                writer.WriteStringValue(Action);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
