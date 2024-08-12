// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    public partial class BlobFileListContentSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("containerUrl"u8);
            writer.WriteStringValue(ContainerUri.AbsoluteUri);
            writer.WritePropertyName("fileList"u8);
            writer.WriteStringValue(FileList);
            writer.WriteEndObject();
        }

        internal static BlobFileListContentSource DeserializeBlobFileListContentSource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri containerUrl = default;
            string fileList = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("containerUrl"u8))
                {
                    containerUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fileList"u8))
                {
                    fileList = property.Value.GetString();
                    continue;
                }
            }
            return new BlobFileListContentSource(containerUrl, fileList);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static BlobFileListContentSource FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeBlobFileListContentSource(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
