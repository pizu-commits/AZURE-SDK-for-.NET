// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(NotebookParameterConverter))]
    public partial class NotebookParameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Value))
            {
                if (Value != null)
                {
                    writer.WritePropertyName("value"u8);
                    writer.WriteObjectValue<object>(Value);
                }
                else
                {
                    writer.WriteNull("value");
                }
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static NotebookParameter DeserializeNotebookParameter(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            object value = default;
            NotebookParameterType? type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        value = null;
                        continue;
                    }
                    value = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new NotebookParameterType(property.Value.GetString());
                    continue;
                }
            }
            return new NotebookParameter(value, type);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static NotebookParameter FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeNotebookParameter(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class NotebookParameterConverter : JsonConverter<NotebookParameter>
        {
            public override void Write(Utf8JsonWriter writer, NotebookParameter model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override NotebookParameter Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeNotebookParameter(document.RootElement);
            }
        }
    }
}
