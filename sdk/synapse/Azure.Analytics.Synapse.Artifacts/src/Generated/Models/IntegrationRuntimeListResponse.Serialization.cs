// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(IntegrationRuntimeListResponseConverter))]
    public partial class IntegrationRuntimeListResponse
    {
        internal static IntegrationRuntimeListResponse DeserializeIntegrationRuntimeListResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<IntegrationRuntimeResource> value = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<IntegrationRuntimeResource> array = new List<IntegrationRuntimeResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IntegrationRuntimeResource.DeserializeIntegrationRuntimeResource(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new IntegrationRuntimeListResponse(value, nextLink);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static IntegrationRuntimeListResponse FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeIntegrationRuntimeListResponse(document.RootElement);
        }

        internal partial class IntegrationRuntimeListResponseConverter : JsonConverter<IntegrationRuntimeListResponse>
        {
            public override void Write(Utf8JsonWriter writer, IntegrationRuntimeListResponse model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override IntegrationRuntimeListResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeIntegrationRuntimeListResponse(document.RootElement);
            }
        }
    }
}
