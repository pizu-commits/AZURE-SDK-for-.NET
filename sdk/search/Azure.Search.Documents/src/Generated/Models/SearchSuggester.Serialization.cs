// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchSuggester : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("searchMode");
            writer.WriteStringValue(SearchMode);
            if (SourceFields.Any())
            {
                writer.WritePropertyName("sourceFields");
                writer.WriteStartArray();
                foreach (var item in SourceFields)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            else
            {
                writer.WriteNull("sourceFields");
            }
            writer.WriteEndObject();
        }

        internal static SearchSuggester DeserializeSearchSuggester(JsonElement element)
        {
            string name = default;
            string searchMode = default;
            IList<string> sourceFields = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("searchMode"))
                {
                    searchMode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceFields"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    sourceFields = array;
                    continue;
                }
            }
            return new SearchSuggester(name, searchMode, sourceFields);
        }
    }
}
