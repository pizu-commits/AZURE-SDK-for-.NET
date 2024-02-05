// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class RampUpRule : IUtf8JsonSerializable, IJsonModel<RampUpRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RampUpRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RampUpRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RampUpRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RampUpRule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ActionHostName))
            {
                writer.WritePropertyName("actionHostName"u8);
                writer.WriteStringValue(ActionHostName);
            }
            if (Optional.IsDefined(ReroutePercentage))
            {
                writer.WritePropertyName("reroutePercentage"u8);
                writer.WriteNumberValue(ReroutePercentage.Value);
            }
            if (Optional.IsDefined(ChangeStep))
            {
                writer.WritePropertyName("changeStep"u8);
                writer.WriteNumberValue(ChangeStep.Value);
            }
            if (Optional.IsDefined(ChangeIntervalInMinutes))
            {
                writer.WritePropertyName("changeIntervalInMinutes"u8);
                writer.WriteNumberValue(ChangeIntervalInMinutes.Value);
            }
            if (Optional.IsDefined(MinReroutePercentage))
            {
                writer.WritePropertyName("minReroutePercentage"u8);
                writer.WriteNumberValue(MinReroutePercentage.Value);
            }
            if (Optional.IsDefined(MaxReroutePercentage))
            {
                writer.WritePropertyName("maxReroutePercentage"u8);
                writer.WriteNumberValue(MaxReroutePercentage.Value);
            }
            if (Optional.IsDefined(ChangeDecisionCallbackUri))
            {
                writer.WritePropertyName("changeDecisionCallbackUrl"u8);
                writer.WriteStringValue(ChangeDecisionCallbackUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        RampUpRule IJsonModel<RampUpRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RampUpRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RampUpRule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRampUpRule(document.RootElement, options);
        }

        internal static RampUpRule DeserializeRampUpRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> actionHostName = default;
            Optional<double> reroutePercentage = default;
            Optional<double> changeStep = default;
            Optional<int> changeIntervalInMinutes = default;
            Optional<double> minReroutePercentage = default;
            Optional<double> maxReroutePercentage = default;
            Optional<Uri> changeDecisionCallbackUrl = default;
            Optional<string> name = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionHostName"u8))
                {
                    actionHostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reroutePercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reroutePercentage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("changeStep"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    changeStep = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("changeIntervalInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    changeIntervalInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minReroutePercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minReroutePercentage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("maxReroutePercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxReroutePercentage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("changeDecisionCallbackUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    changeDecisionCallbackUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RampUpRule(actionHostName.Value, Optional.ToNullable(reroutePercentage), Optional.ToNullable(changeStep), Optional.ToNullable(changeIntervalInMinutes), Optional.ToNullable(minReroutePercentage), Optional.ToNullable(maxReroutePercentage), changeDecisionCallbackUrl.Value, name.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(ActionHostName))
            {
                builder.Append("  actionHostName:");
                builder.AppendLine($" '{ActionHostName}'");
            }

            if (Optional.IsDefined(ReroutePercentage))
            {
                builder.Append("  reroutePercentage:");
                builder.AppendLine($" '{ReroutePercentage.Value.ToString()}'");
            }

            if (Optional.IsDefined(ChangeStep))
            {
                builder.Append("  changeStep:");
                builder.AppendLine($" '{ChangeStep.Value.ToString()}'");
            }

            if (Optional.IsDefined(ChangeIntervalInMinutes))
            {
                builder.Append("  changeIntervalInMinutes:");
                builder.AppendLine($" {ChangeIntervalInMinutes.Value}");
            }

            if (Optional.IsDefined(MinReroutePercentage))
            {
                builder.Append("  minReroutePercentage:");
                builder.AppendLine($" '{MinReroutePercentage.Value.ToString()}'");
            }

            if (Optional.IsDefined(MaxReroutePercentage))
            {
                builder.Append("  maxReroutePercentage:");
                builder.AppendLine($" '{MaxReroutePercentage.Value.ToString()}'");
            }

            if (Optional.IsDefined(ChangeDecisionCallbackUri))
            {
                builder.Append("  changeDecisionCallbackUrl:");
                builder.AppendLine($" '{ChangeDecisionCallbackUri.AbsoluteUri}'");
            }

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                builder.AppendLine($" '{Name}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<RampUpRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RampUpRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(RampUpRule)} does not support '{options.Format}' format.");
            }
        }

        RampUpRule IPersistableModel<RampUpRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RampUpRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRampUpRule(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(RampUpRule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RampUpRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
