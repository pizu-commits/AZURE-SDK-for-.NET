// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;

namespace Azure.AI.OpenAI
{
    internal partial class UnknownOnYourDataVectorizationSource
    {
        internal static UnknownOnYourDataVectorizationSource DeserializeUnknownOnYourDataVectorizationSource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OnYourDataVectorizationSourceType type = "Unknown";
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new OnYourDataVectorizationSourceType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownOnYourDataVectorizationSource(type);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static UnknownOnYourDataVectorizationSource FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeUnknownOnYourDataVectorizationSource(document.RootElement);
        }
    }
}
