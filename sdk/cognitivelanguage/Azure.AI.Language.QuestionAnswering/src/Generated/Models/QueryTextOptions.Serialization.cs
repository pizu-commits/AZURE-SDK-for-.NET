// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.QuestionAnswering
{
    public partial class QueryTextOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("question");
            writer.WriteStringValue(Question);
            writer.WritePropertyName("records");
            writer.WriteStartArray();
            foreach (var item in Records)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Language))
            {
                writer.WritePropertyName("language");
                writer.WriteStringValue(Language);
            }
            if (Optional.IsDefined(StringIndexType))
            {
                writer.WritePropertyName("stringIndexType");
                writer.WriteStringValue(StringIndexType.Value.ToString());
            }
            writer.WriteEndObject();
        }
    }
}
