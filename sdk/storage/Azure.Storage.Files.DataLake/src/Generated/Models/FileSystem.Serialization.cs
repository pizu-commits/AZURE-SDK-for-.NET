// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Storage.Files.DataLake.Models
{
    internal partial class FileSystem
    {
        internal static FileSystem DeserializeFileSystem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string lastModified = default;
            string eTag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastModified"u8))
                {
                    lastModified = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eTag"u8))
                {
                    eTag = property.Value.GetString();
                    continue;
                }
            }
            return new FileSystem(name, lastModified, eTag);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static FileSystem FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeFileSystem(document.RootElement);
        }
    }
}
