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
    [JsonConverter(typeof(CustomSetupBaseConverter))]
    public partial class CustomSetupBase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }

        internal static CustomSetupBase DeserializeCustomSetupBase(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            return UnknownCustomSetupBase.DeserializeUnknownCustomSetupBase(element);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static CustomSetupBase FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCustomSetupBase(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class CustomSetupBaseConverter : JsonConverter<CustomSetupBase>
        {
            public override void Write(Utf8JsonWriter writer, CustomSetupBase model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override CustomSetupBase Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeCustomSetupBase(document.RootElement);
            }
        }
    }
}
