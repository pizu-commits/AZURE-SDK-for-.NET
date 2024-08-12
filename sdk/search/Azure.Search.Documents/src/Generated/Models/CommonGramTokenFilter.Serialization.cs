// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class CommonGramTokenFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("commonWords"u8);
            writer.WriteStartArray();
            foreach (var item in CommonWords)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(IgnoreCase))
            {
                writer.WritePropertyName("ignoreCase"u8);
                writer.WriteBooleanValue(IgnoreCase.Value);
            }
            if (Optional.IsDefined(UseQueryMode))
            {
                writer.WritePropertyName("queryMode"u8);
                writer.WriteBooleanValue(UseQueryMode.Value);
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(ODataType);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static CommonGramTokenFilter DeserializeCommonGramTokenFilter(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> commonWords = default;
            bool? ignoreCase = default;
            bool? queryMode = default;
            string odataType = default;
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("commonWords"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    commonWords = array;
                    continue;
                }
                if (property.NameEquals("ignoreCase"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ignoreCase = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("queryMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryMode = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new CommonGramTokenFilter(odataType, name, commonWords, ignoreCase, queryMode);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new CommonGramTokenFilter FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCommonGramTokenFilter(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
