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
    [JsonConverter(typeof(FormatWriteSettingsConverter))]
    public partial class FormatWriteSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static FormatWriteSettings DeserializeFormatWriteSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AvroWriteSettings": return AvroWriteSettings.DeserializeAvroWriteSettings(element);
                    case "DelimitedTextWriteSettings": return DelimitedTextWriteSettings.DeserializeDelimitedTextWriteSettings(element);
                    case "JsonWriteSettings": return JsonWriteSettings.DeserializeJsonWriteSettings(element);
                    case "OrcWriteSettings": return OrcWriteSettings.DeserializeOrcWriteSettings(element);
                    case "ParquetWriteSettings": return ParquetWriteSettings.DeserializeParquetWriteSettings(element);
                }
            }
            return UnknownFormatWriteSettings.DeserializeUnknownFormatWriteSettings(element);
        }

        internal partial class FormatWriteSettingsConverter : JsonConverter<FormatWriteSettings>
        {
            public override void Write(Utf8JsonWriter writer, FormatWriteSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override FormatWriteSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeFormatWriteSettings(document.RootElement);
            }
        }
    }
}
