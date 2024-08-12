// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Security.Attestation
{
    internal partial class JsonWebKeySet
    {
        internal static JsonWebKeySet DeserializeJsonWebKeySet(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<JsonWebKey> keys = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<JsonWebKey> array = new List<JsonWebKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonWebKey.DeserializeJsonWebKey(item));
                    }
                    keys = array;
                    continue;
                }
            }
            return new JsonWebKeySet(keys ?? new ChangeTrackingList<JsonWebKey>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static JsonWebKeySet FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeJsonWebKeySet(document.RootElement);
        }
    }
}
