// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Chat
{
    internal partial class ChatAttachmentInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("attachmentType"u8);
            writer.WriteStringValue(AttachmentType.ToString());
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Url))
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(Url.AbsoluteUri);
            }
            if (Optional.IsDefined(PreviewUrl))
            {
                writer.WritePropertyName("previewUrl"u8);
                writer.WriteStringValue(PreviewUrl.AbsoluteUri);
            }
            writer.WriteEndObject();
        }

        internal static ChatAttachmentInternal DeserializeChatAttachmentInternal(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            ChatAttachmentType attachmentType = default;
            string name = default;
            Uri url = default;
            Uri previewUrl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("attachmentType"u8))
                {
                    attachmentType = new ChatAttachmentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("previewUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    previewUrl = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new ChatAttachmentInternal(id, attachmentType, name, url, previewUrl);
        }
    }
}
