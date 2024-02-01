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

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class HybridComputeProductFeature : IUtf8JsonSerializable, IJsonModel<HybridComputeProductFeature>, IPersistableModel<HybridComputeProductFeature>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HybridComputeProductFeature>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HybridComputeProductFeature>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeProductFeature>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridComputeProductFeature)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(SubscriptionStatus))
            {
                writer.WritePropertyName("subscriptionStatus"u8);
                writer.WriteStringValue(SubscriptionStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(BillingStartOn))
            {
                writer.WritePropertyName("billingStartDate"u8);
                writer.WriteStringValue(BillingStartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(EnrollmentOn))
            {
                writer.WritePropertyName("enrollmentDate"u8);
                writer.WriteStringValue(EnrollmentOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(DisenrollmentOn))
            {
                writer.WritePropertyName("disenrollmentDate"u8);
                writer.WriteStringValue(DisenrollmentOn.Value, "O");
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

        HybridComputeProductFeature IJsonModel<HybridComputeProductFeature>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeProductFeature>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridComputeProductFeature)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHybridComputeProductFeature(document.RootElement, options);
        }

        internal static HybridComputeProductFeature DeserializeHybridComputeProductFeature(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<LicenseProfileSubscriptionStatus> subscriptionStatus = default;
            Optional<DateTimeOffset> billingStartDate = default;
            Optional<DateTimeOffset> enrollmentDate = default;
            Optional<DateTimeOffset> disenrollmentDate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subscriptionStatus = new LicenseProfileSubscriptionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("billingStartDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingStartDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("enrollmentDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enrollmentDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("disenrollmentDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disenrollmentDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HybridComputeProductFeature(name.Value, Optional.ToNullable(subscriptionStatus), Optional.ToNullable(billingStartDate), Optional.ToNullable(enrollmentDate), Optional.ToNullable(disenrollmentDate), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                builder.AppendLine($" '{Name}'");
            }

            if (Optional.IsDefined(SubscriptionStatus))
            {
                builder.Append("  subscriptionStatus:");
                builder.AppendLine($" '{SubscriptionStatus.ToString()}'");
            }

            if (Optional.IsDefined(BillingStartOn))
            {
                builder.Append("  billingStartDate:");
                builder.AppendLine($" '{BillingStartOn.Value.ToString()}'");
            }

            if (Optional.IsDefined(EnrollmentOn))
            {
                builder.Append("  enrollmentDate:");
                builder.AppendLine($" '{EnrollmentOn.Value.ToString()}'");
            }

            if (Optional.IsDefined(DisenrollmentOn))
            {
                builder.Append("  disenrollmentDate:");
                builder.AppendLine($" '{DisenrollmentOn.Value.ToString()}'");
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

        BinaryData IPersistableModel<HybridComputeProductFeature>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeProductFeature>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(HybridComputeProductFeature)} does not support '{options.Format}' format.");
            }
        }

        HybridComputeProductFeature IPersistableModel<HybridComputeProductFeature>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeProductFeature>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHybridComputeProductFeature(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(HybridComputeProductFeature)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HybridComputeProductFeature>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
