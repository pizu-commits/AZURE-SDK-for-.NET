// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Xml;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class ContentKeyPolicyPlayReadyPlayRight : IUtf8JsonSerializable, IJsonModel<ContentKeyPolicyPlayReadyPlayRight>, IPersistableModel<ContentKeyPolicyPlayReadyPlayRight>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContentKeyPolicyPlayReadyPlayRight>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContentKeyPolicyPlayReadyPlayRight>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyPlayReadyPlayRight>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyPlayReadyPlayRight)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FirstPlayExpiration))
            {
                writer.WritePropertyName("firstPlayExpiration"u8);
                writer.WriteStringValue(FirstPlayExpiration.Value, "P");
            }
            if (Optional.IsDefined(ScmsRestriction))
            {
                writer.WritePropertyName("scmsRestriction"u8);
                writer.WriteNumberValue(ScmsRestriction.Value);
            }
            if (Optional.IsDefined(AgcAndColorStripeRestriction))
            {
                writer.WritePropertyName("agcAndColorStripeRestriction"u8);
                writer.WriteNumberValue(AgcAndColorStripeRestriction.Value);
            }
            if (Optional.IsDefined(ExplicitAnalogTelevisionOutputRestriction))
            {
                writer.WritePropertyName("explicitAnalogTelevisionOutputRestriction"u8);
                writer.WriteObjectValue(ExplicitAnalogTelevisionOutputRestriction);
            }
            writer.WritePropertyName("digitalVideoOnlyContentRestriction"u8);
            writer.WriteBooleanValue(HasDigitalVideoOnlyContentRestriction);
            writer.WritePropertyName("imageConstraintForAnalogComponentVideoRestriction"u8);
            writer.WriteBooleanValue(HasImageConstraintForAnalogComponentVideoRestriction);
            writer.WritePropertyName("imageConstraintForAnalogComputerMonitorRestriction"u8);
            writer.WriteBooleanValue(HasImageConstraintForAnalogComputerMonitorRestriction);
            writer.WritePropertyName("allowPassingVideoContentToUnknownOutput"u8);
            writer.WriteStringValue(AllowPassingVideoContentToUnknownOutput.ToString());
            if (Optional.IsDefined(UncompressedDigitalVideoOutputProtectionLevel))
            {
                writer.WritePropertyName("uncompressedDigitalVideoOpl"u8);
                writer.WriteNumberValue(UncompressedDigitalVideoOutputProtectionLevel.Value);
            }
            if (Optional.IsDefined(CompressedDigitalVideoOutputProtectionLevel))
            {
                writer.WritePropertyName("compressedDigitalVideoOpl"u8);
                writer.WriteNumberValue(CompressedDigitalVideoOutputProtectionLevel.Value);
            }
            if (Optional.IsDefined(AnalogVideoOutputProtectionLevel))
            {
                writer.WritePropertyName("analogVideoOpl"u8);
                writer.WriteNumberValue(AnalogVideoOutputProtectionLevel.Value);
            }
            if (Optional.IsDefined(CompressedDigitalAudioOutputProtectionLevel))
            {
                writer.WritePropertyName("compressedDigitalAudioOpl"u8);
                writer.WriteNumberValue(CompressedDigitalAudioOutputProtectionLevel.Value);
            }
            if (Optional.IsDefined(UncompressedDigitalAudioOutputProtectionLevel))
            {
                writer.WritePropertyName("uncompressedDigitalAudioOpl"u8);
                writer.WriteNumberValue(UncompressedDigitalAudioOutputProtectionLevel.Value);
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

        ContentKeyPolicyPlayReadyPlayRight IJsonModel<ContentKeyPolicyPlayReadyPlayRight>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyPlayReadyPlayRight>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyPlayReadyPlayRight)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContentKeyPolicyPlayReadyPlayRight(document.RootElement, options);
        }

        internal static ContentKeyPolicyPlayReadyPlayRight DeserializeContentKeyPolicyPlayReadyPlayRight(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<TimeSpan> firstPlayExpiration = default;
            Optional<int> scmsRestriction = default;
            Optional<int> agcAndColorStripeRestriction = default;
            Optional<ContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction> explicitAnalogTelevisionOutputRestriction = default;
            bool digitalVideoOnlyContentRestriction = default;
            bool imageConstraintForAnalogComponentVideoRestriction = default;
            bool imageConstraintForAnalogComputerMonitorRestriction = default;
            ContentKeyPolicyPlayReadyUnknownOutputPassingOption allowPassingVideoContentToUnknownOutput = default;
            Optional<int> uncompressedDigitalVideoOpl = default;
            Optional<int> compressedDigitalVideoOpl = default;
            Optional<int> analogVideoOpl = default;
            Optional<int> compressedDigitalAudioOpl = default;
            Optional<int> uncompressedDigitalAudioOpl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("firstPlayExpiration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firstPlayExpiration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("scmsRestriction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scmsRestriction = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("agcAndColorStripeRestriction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agcAndColorStripeRestriction = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("explicitAnalogTelevisionOutputRestriction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    explicitAnalogTelevisionOutputRestriction = ContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction.DeserializeContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction(property.Value);
                    continue;
                }
                if (property.NameEquals("digitalVideoOnlyContentRestriction"u8))
                {
                    digitalVideoOnlyContentRestriction = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("imageConstraintForAnalogComponentVideoRestriction"u8))
                {
                    imageConstraintForAnalogComponentVideoRestriction = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("imageConstraintForAnalogComputerMonitorRestriction"u8))
                {
                    imageConstraintForAnalogComputerMonitorRestriction = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowPassingVideoContentToUnknownOutput"u8))
                {
                    allowPassingVideoContentToUnknownOutput = new ContentKeyPolicyPlayReadyUnknownOutputPassingOption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("uncompressedDigitalVideoOpl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uncompressedDigitalVideoOpl = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("compressedDigitalVideoOpl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    compressedDigitalVideoOpl = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("analogVideoOpl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    analogVideoOpl = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("compressedDigitalAudioOpl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    compressedDigitalAudioOpl = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("uncompressedDigitalAudioOpl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uncompressedDigitalAudioOpl = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContentKeyPolicyPlayReadyPlayRight(Optional.ToNullable(firstPlayExpiration), Optional.ToNullable(scmsRestriction), Optional.ToNullable(agcAndColorStripeRestriction), explicitAnalogTelevisionOutputRestriction.Value, digitalVideoOnlyContentRestriction, imageConstraintForAnalogComponentVideoRestriction, imageConstraintForAnalogComputerMonitorRestriction, allowPassingVideoContentToUnknownOutput, Optional.ToNullable(uncompressedDigitalVideoOpl), Optional.ToNullable(compressedDigitalVideoOpl), Optional.ToNullable(analogVideoOpl), Optional.ToNullable(compressedDigitalAudioOpl), Optional.ToNullable(uncompressedDigitalAudioOpl), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(FirstPlayExpiration))
            {
                builder.Append("  firstPlayExpiration:");
                var formattedTimeSpan = XmlConvert.ToString(FirstPlayExpiration.Value);
                builder.AppendLine($" '{formattedTimeSpan}'");
            }

            if (Optional.IsDefined(ScmsRestriction))
            {
                builder.Append("  scmsRestriction:");
                builder.AppendLine($" '{ScmsRestriction.Value.ToString()}'");
            }

            if (Optional.IsDefined(AgcAndColorStripeRestriction))
            {
                builder.Append("  agcAndColorStripeRestriction:");
                builder.AppendLine($" '{AgcAndColorStripeRestriction.Value.ToString()}'");
            }

            if (Optional.IsDefined(ExplicitAnalogTelevisionOutputRestriction))
            {
                builder.Append("  explicitAnalogTelevisionOutputRestriction:");
                AppendChildObject(builder, ExplicitAnalogTelevisionOutputRestriction, options, 2);
            }

            if (Optional.IsDefined(HasDigitalVideoOnlyContentRestriction))
            {
                builder.Append("  digitalVideoOnlyContentRestriction:");
                var boolValue = HasDigitalVideoOnlyContentRestriction == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(HasImageConstraintForAnalogComponentVideoRestriction))
            {
                builder.Append("  imageConstraintForAnalogComponentVideoRestriction:");
                var boolValue = HasImageConstraintForAnalogComponentVideoRestriction == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(HasImageConstraintForAnalogComputerMonitorRestriction))
            {
                builder.Append("  imageConstraintForAnalogComputerMonitorRestriction:");
                var boolValue = HasImageConstraintForAnalogComputerMonitorRestriction == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(AllowPassingVideoContentToUnknownOutput))
            {
                builder.Append("  allowPassingVideoContentToUnknownOutput:");
                builder.AppendLine($" '{AllowPassingVideoContentToUnknownOutput.ToString()}'");
            }

            if (Optional.IsDefined(UncompressedDigitalVideoOutputProtectionLevel))
            {
                builder.Append("  uncompressedDigitalVideoOpl:");
                builder.AppendLine($" '{UncompressedDigitalVideoOutputProtectionLevel.Value.ToString()}'");
            }

            if (Optional.IsDefined(CompressedDigitalVideoOutputProtectionLevel))
            {
                builder.Append("  compressedDigitalVideoOpl:");
                builder.AppendLine($" '{CompressedDigitalVideoOutputProtectionLevel.Value.ToString()}'");
            }

            if (Optional.IsDefined(AnalogVideoOutputProtectionLevel))
            {
                builder.Append("  analogVideoOpl:");
                builder.AppendLine($" '{AnalogVideoOutputProtectionLevel.Value.ToString()}'");
            }

            if (Optional.IsDefined(CompressedDigitalAudioOutputProtectionLevel))
            {
                builder.Append("  compressedDigitalAudioOpl:");
                builder.AppendLine($" '{CompressedDigitalAudioOutputProtectionLevel.Value.ToString()}'");
            }

            if (Optional.IsDefined(UncompressedDigitalAudioOutputProtectionLevel))
            {
                builder.Append("  uncompressedDigitalAudioOpl:");
                builder.AppendLine($" '{UncompressedDigitalAudioOutputProtectionLevel.Value.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                stringBuilder.AppendLine($"{indent}{line}");
            }
        }

        BinaryData IPersistableModel<ContentKeyPolicyPlayReadyPlayRight>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyPlayReadyPlayRight>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContentKeyPolicyPlayReadyPlayRight)} does not support '{options.Format}' format.");
            }
        }

        ContentKeyPolicyPlayReadyPlayRight IPersistableModel<ContentKeyPolicyPlayReadyPlayRight>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyPlayReadyPlayRight>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContentKeyPolicyPlayReadyPlayRight(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ContentKeyPolicyPlayReadyPlayRight)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContentKeyPolicyPlayReadyPlayRight>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
