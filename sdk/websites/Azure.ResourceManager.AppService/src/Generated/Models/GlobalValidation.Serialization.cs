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
    public partial class GlobalValidation : IUtf8JsonSerializable, IJsonModel<GlobalValidation>, IPersistableModel<GlobalValidation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GlobalValidation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GlobalValidation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GlobalValidation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GlobalValidation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsAuthenticationRequired))
            {
                writer.WritePropertyName("requireAuthentication"u8);
                writer.WriteBooleanValue(IsAuthenticationRequired.Value);
            }
            if (Optional.IsDefined(UnauthenticatedClientAction))
            {
                writer.WritePropertyName("unauthenticatedClientAction"u8);
                writer.WriteStringValue(UnauthenticatedClientAction.Value.ToSerialString());
            }
            if (Optional.IsDefined(RedirectToProvider))
            {
                writer.WritePropertyName("redirectToProvider"u8);
                writer.WriteStringValue(RedirectToProvider);
            }
            if (Optional.IsCollectionDefined(ExcludedPaths))
            {
                writer.WritePropertyName("excludedPaths"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedPaths)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        GlobalValidation IJsonModel<GlobalValidation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GlobalValidation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GlobalValidation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGlobalValidation(document.RootElement, options);
        }

        internal static GlobalValidation DeserializeGlobalValidation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> requireAuthentication = default;
            Optional<UnauthenticatedClientActionV2> unauthenticatedClientAction = default;
            Optional<string> redirectToProvider = default;
            Optional<IList<string>> excludedPaths = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requireAuthentication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requireAuthentication = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("unauthenticatedClientAction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unauthenticatedClientAction = property.Value.GetString().ToUnauthenticatedClientActionV2();
                    continue;
                }
                if (property.NameEquals("redirectToProvider"u8))
                {
                    redirectToProvider = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("excludedPaths"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    excludedPaths = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GlobalValidation(Optional.ToNullable(requireAuthentication), Optional.ToNullable(unauthenticatedClientAction), redirectToProvider.Value, Optional.ToList(excludedPaths), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(IsAuthenticationRequired))
            {
                builder.Append("  requireAuthentication:");
                var boolValue = IsAuthenticationRequired.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(UnauthenticatedClientAction))
            {
                builder.Append("  unauthenticatedClientAction:");
                builder.AppendLine($" '{UnauthenticatedClientAction.ToString()}'");
            }

            if (Optional.IsDefined(RedirectToProvider))
            {
                builder.Append("  redirectToProvider:");
                builder.AppendLine($" '{RedirectToProvider}'");
            }

            if (Optional.IsCollectionDefined(ExcludedPaths))
            {
                builder.Append("  excludedPaths:");
                builder.AppendLine(" [");
                foreach (var item in ExcludedPaths)
                {
                    if (item == null)
                    {
                        builder.Append("null");
                        continue;
                    }
                    builder.AppendLine($"    '{item}'");
                }
                builder.AppendLine("  ]");
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

        BinaryData IPersistableModel<GlobalValidation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GlobalValidation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(GlobalValidation)} does not support '{options.Format}' format.");
            }
        }

        GlobalValidation IPersistableModel<GlobalValidation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GlobalValidation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGlobalValidation(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(GlobalValidation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GlobalValidation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
