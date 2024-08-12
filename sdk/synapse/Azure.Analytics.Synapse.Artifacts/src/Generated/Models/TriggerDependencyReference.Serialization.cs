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
    [JsonConverter(typeof(TriggerDependencyReferenceConverter))]
    public partial class TriggerDependencyReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("referenceTrigger"u8);
            writer.WriteObjectValue(ReferenceTrigger);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }

        internal static TriggerDependencyReference DeserializeTriggerDependencyReference(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "TumblingWindowTriggerDependencyReference": return TumblingWindowTriggerDependencyReference.DeserializeTumblingWindowTriggerDependencyReference(element);
                }
            }
            TriggerReference referenceTrigger = default;
            string type = "TriggerDependencyReference";
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("referenceTrigger"u8))
                {
                    referenceTrigger = TriggerReference.DeserializeTriggerReference(property.Value);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new TriggerDependencyReference(type, referenceTrigger);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new TriggerDependencyReference FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTriggerDependencyReference(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class TriggerDependencyReferenceConverter : JsonConverter<TriggerDependencyReference>
        {
            public override void Write(Utf8JsonWriter writer, TriggerDependencyReference model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override TriggerDependencyReference Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTriggerDependencyReference(document.RootElement);
            }
        }
    }
}
