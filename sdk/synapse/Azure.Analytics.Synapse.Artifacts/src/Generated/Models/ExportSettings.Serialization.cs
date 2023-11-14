// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(ExportSettingsConverter))]
    public partial class ExportSettings : IUtf8JsonSerializable, IJsonModel<ExportSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExportSettings>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ExportSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ExportSettings>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ExportSettings>)} interface");
            }

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

        ExportSettings IJsonModel<ExportSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ExportSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExportSettings(document.RootElement, options);
        }

        internal static ExportSettings DeserializeExportSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureDatabricksDeltaLakeExportCommand": return AzureDatabricksDeltaLakeExportCommand.DeserializeAzureDatabricksDeltaLakeExportCommand(element);
                    case "SnowflakeExportCopyCommand": return SnowflakeExportCopyCommand.DeserializeSnowflakeExportCopyCommand(element);
                }
            }
            return UnknownExportSettings.DeserializeUnknownExportSettings(element);
        }

        BinaryData IPersistableModel<ExportSettings>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ExportSettings)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ExportSettings IPersistableModel<ExportSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ExportSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeExportSettings(document.RootElement, options);
        }

        string IPersistableModel<ExportSettings>.GetWireFormat(ModelReaderWriterOptions options) => "J";

        internal partial class ExportSettingsConverter : JsonConverter<ExportSettings>
        {
            public override void Write(Utf8JsonWriter writer, ExportSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ExportSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeExportSettings(document.RootElement);
            }
        }
    }
}
