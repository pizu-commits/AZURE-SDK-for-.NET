// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class PatchableOrderItemResourceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ForwardAddress))
            {
                writer.WritePropertyName("forwardAddress");
                writer.WriteObjectValue(ForwardAddress);
            }
            if (Optional.IsDefined(Preferences))
            {
                writer.WritePropertyName("preferences");
                writer.WriteObjectValue(Preferences);
            }
            if (Optional.IsCollectionDefined(NotificationEmailList))
            {
                writer.WritePropertyName("notificationEmailList");
                writer.WriteStartArray();
                foreach (var item in NotificationEmailList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
