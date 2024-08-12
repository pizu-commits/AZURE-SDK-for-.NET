// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Search.Documents.Models;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class ScoringFunction : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            writer.WritePropertyName("fieldName"u8);
            writer.WriteStringValue(FieldName);
            writer.WritePropertyName("boost"u8);
            writer.WriteNumberValue(Boost);
            if (Optional.IsDefined(Interpolation))
            {
                writer.WritePropertyName("interpolation"u8);
                writer.WriteStringValue(Interpolation.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        internal static ScoringFunction DeserializeScoringFunction(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "distance": return DistanceScoringFunction.DeserializeDistanceScoringFunction(element);
                    case "freshness": return FreshnessScoringFunction.DeserializeFreshnessScoringFunction(element);
                    case "magnitude": return MagnitudeScoringFunction.DeserializeMagnitudeScoringFunction(element);
                    case "tag": return TagScoringFunction.DeserializeTagScoringFunction(element);
                }
            }
            return UnknownScoringFunction.DeserializeUnknownScoringFunction(element);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ScoringFunction FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeScoringFunction(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
