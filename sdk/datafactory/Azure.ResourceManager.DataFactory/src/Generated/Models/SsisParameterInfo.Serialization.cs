// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class SsisParameterInfo : IUtf8JsonSerializable, IJsonModel<SsisParameterInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SsisParameterInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SsisParameterInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SsisParameterInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SsisParameterInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteNumberValue(Id.Value);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(DataType))
            {
                writer.WritePropertyName("dataType"u8);
                writer.WriteStringValue(DataType);
            }
            if (Optional.IsDefined(IsRequired))
            {
                writer.WritePropertyName("required"u8);
                writer.WriteBooleanValue(IsRequired.Value);
            }
            if (Optional.IsDefined(IsSensitive))
            {
                writer.WritePropertyName("sensitive"u8);
                writer.WriteBooleanValue(IsSensitive.Value);
            }
            if (Optional.IsDefined(DesignDefaultValue))
            {
                writer.WritePropertyName("designDefaultValue"u8);
                writer.WriteStringValue(DesignDefaultValue);
            }
            if (Optional.IsDefined(DefaultValue))
            {
                writer.WritePropertyName("defaultValue"u8);
                writer.WriteStringValue(DefaultValue);
            }
            if (Optional.IsDefined(SensitiveDefaultValue))
            {
                writer.WritePropertyName("sensitiveDefaultValue"u8);
                writer.WriteStringValue(SensitiveDefaultValue);
            }
            if (Optional.IsDefined(ValueType))
            {
                writer.WritePropertyName("valueType"u8);
                writer.WriteStringValue(ValueType);
            }
            if (Optional.IsDefined(HasValueSet))
            {
                writer.WritePropertyName("valueSet"u8);
                writer.WriteBooleanValue(HasValueSet.Value);
            }
            if (Optional.IsDefined(Variable))
            {
                writer.WritePropertyName("variable"u8);
                writer.WriteStringValue(Variable);
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

        SsisParameterInfo IJsonModel<SsisParameterInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SsisParameterInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SsisParameterInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSsisParameterInfo(document.RootElement, options);
        }

        internal static SsisParameterInfo DeserializeSsisParameterInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? id = default;
            string name = default;
            string description = default;
            string dataType = default;
            bool? required = default;
            bool? sensitive = default;
            string designDefaultValue = default;
            string defaultValue = default;
            string sensitiveDefaultValue = default;
            string valueType = default;
            bool? valueSet = default;
            string variable = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataType"u8))
                {
                    dataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("required"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    required = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sensitive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sensitive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("designDefaultValue"u8))
                {
                    designDefaultValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultValue"u8))
                {
                    defaultValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sensitiveDefaultValue"u8))
                {
                    sensitiveDefaultValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueType"u8))
                {
                    valueType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueSet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueSet = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("variable"u8))
                {
                    variable = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SsisParameterInfo(
                id,
                name,
                description,
                dataType,
                required,
                sensitive,
                designDefaultValue,
                defaultValue,
                sensitiveDefaultValue,
                valueType,
                valueSet,
                variable,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SsisParameterInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SsisParameterInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SsisParameterInfo)} does not support writing '{options.Format}' format.");
            }
        }

        SsisParameterInfo IPersistableModel<SsisParameterInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SsisParameterInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSsisParameterInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SsisParameterInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SsisParameterInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
