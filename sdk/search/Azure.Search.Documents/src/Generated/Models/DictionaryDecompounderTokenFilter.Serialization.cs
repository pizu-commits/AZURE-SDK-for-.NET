// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    public partial class DictionaryDecompounderTokenFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("wordList");
            writer.WriteStartArray();
            foreach (var item in WordList)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (MinWordSize != null)
            {
                writer.WritePropertyName("minWordSize");
                writer.WriteNumberValue(MinWordSize.Value);
            }
            if (MinSubwordSize != null)
            {
                writer.WritePropertyName("minSubwordSize");
                writer.WriteNumberValue(MinSubwordSize.Value);
            }
            if (MaxSubwordSize != null)
            {
                writer.WritePropertyName("maxSubwordSize");
                writer.WriteNumberValue(MaxSubwordSize.Value);
            }
            if (OnlyLongestMatch != null)
            {
                writer.WritePropertyName("onlyLongestMatch");
                writer.WriteBooleanValue(OnlyLongestMatch.Value);
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(ODataType);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static DictionaryDecompounderTokenFilter DeserializeDictionaryDecompounderTokenFilter(JsonElement element)
        {
            IList<string> wordList = default;
            int? minWordSize = default;
            int? minSubwordSize = default;
            int? maxSubwordSize = default;
            bool? onlyLongestMatch = default;
            string odatatype = default;
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("wordList"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    wordList = array;
                    continue;
                }
                if (property.NameEquals("minWordSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minWordSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minSubwordSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minSubwordSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxSubwordSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxSubwordSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("onlyLongestMatch"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onlyLongestMatch = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    odatatype = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new DictionaryDecompounderTokenFilter(odatatype, name, wordList, minWordSize, minSubwordSize, maxSubwordSize, onlyLongestMatch);
        }
    }
}
