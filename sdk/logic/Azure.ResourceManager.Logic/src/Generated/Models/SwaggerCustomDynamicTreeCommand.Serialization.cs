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

namespace Azure.ResourceManager.Logic.Models
{
    public partial class SwaggerCustomDynamicTreeCommand : IUtf8JsonSerializable, IJsonModel<SwaggerCustomDynamicTreeCommand>, IPersistableModel<SwaggerCustomDynamicTreeCommand>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SwaggerCustomDynamicTreeCommand>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SwaggerCustomDynamicTreeCommand>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SwaggerCustomDynamicTreeCommand>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SwaggerCustomDynamicTreeCommand)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(OperationId))
            {
                writer.WritePropertyName("operationId"u8);
                writer.WriteStringValue(OperationId);
            }
            if (Optional.IsDefined(ItemsPath))
            {
                writer.WritePropertyName("itemsPath"u8);
                writer.WriteStringValue(ItemsPath);
            }
            if (Optional.IsDefined(ItemValuePath))
            {
                writer.WritePropertyName("itemValuePath"u8);
                writer.WriteStringValue(ItemValuePath);
            }
            if (Optional.IsDefined(ItemTitlePath))
            {
                writer.WritePropertyName("itemTitlePath"u8);
                writer.WriteStringValue(ItemTitlePath);
            }
            if (Optional.IsDefined(ItemFullTitlePath))
            {
                writer.WritePropertyName("itemFullTitlePath"u8);
                writer.WriteStringValue(ItemFullTitlePath);
            }
            if (Optional.IsDefined(ItemIsParent))
            {
                writer.WritePropertyName("itemIsParent"u8);
                writer.WriteStringValue(ItemIsParent);
            }
            if (Optional.IsDefined(SelectableFilter))
            {
                writer.WritePropertyName("selectableFilter"u8);
                writer.WriteStringValue(SelectableFilter);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
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

        SwaggerCustomDynamicTreeCommand IJsonModel<SwaggerCustomDynamicTreeCommand>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SwaggerCustomDynamicTreeCommand>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SwaggerCustomDynamicTreeCommand)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSwaggerCustomDynamicTreeCommand(document.RootElement, options);
        }

        internal static SwaggerCustomDynamicTreeCommand DeserializeSwaggerCustomDynamicTreeCommand(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> operationId = default;
            Optional<string> itemsPath = default;
            Optional<string> itemValuePath = default;
            Optional<string> itemTitlePath = default;
            Optional<string> itemFullTitlePath = default;
            Optional<string> itemIsParent = default;
            Optional<string> selectableFilter = default;
            Optional<IDictionary<string, SwaggerCustomDynamicTreeParameterInfo>> parameters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("itemsPath"u8))
                {
                    itemsPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("itemValuePath"u8))
                {
                    itemValuePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("itemTitlePath"u8))
                {
                    itemTitlePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("itemFullTitlePath"u8))
                {
                    itemFullTitlePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("itemIsParent"u8))
                {
                    itemIsParent = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("selectableFilter"u8))
                {
                    selectableFilter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, SwaggerCustomDynamicTreeParameterInfo> dictionary = new Dictionary<string, SwaggerCustomDynamicTreeParameterInfo>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, SwaggerCustomDynamicTreeParameterInfo.DeserializeSwaggerCustomDynamicTreeParameterInfo(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SwaggerCustomDynamicTreeCommand(operationId.Value, itemsPath.Value, itemValuePath.Value, itemTitlePath.Value, itemFullTitlePath.Value, itemIsParent.Value, selectableFilter.Value, Optional.ToDictionary(parameters), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(OperationId))
            {
                builder.Append("  operationId:");
                builder.AppendLine($" '{OperationId}'");
            }

            if (Optional.IsDefined(ItemsPath))
            {
                builder.Append("  itemsPath:");
                builder.AppendLine($" '{ItemsPath}'");
            }

            if (Optional.IsDefined(ItemValuePath))
            {
                builder.Append("  itemValuePath:");
                builder.AppendLine($" '{ItemValuePath}'");
            }

            if (Optional.IsDefined(ItemTitlePath))
            {
                builder.Append("  itemTitlePath:");
                builder.AppendLine($" '{ItemTitlePath}'");
            }

            if (Optional.IsDefined(ItemFullTitlePath))
            {
                builder.Append("  itemFullTitlePath:");
                builder.AppendLine($" '{ItemFullTitlePath}'");
            }

            if (Optional.IsDefined(ItemIsParent))
            {
                builder.Append("  itemIsParent:");
                builder.AppendLine($" '{ItemIsParent}'");
            }

            if (Optional.IsDefined(SelectableFilter))
            {
                builder.Append("  selectableFilter:");
                builder.AppendLine($" '{SelectableFilter}'");
            }

            if (Optional.IsCollectionDefined(Parameters))
            {
                builder.Append("  parameters:");
                builder.AppendLine(" {");
                foreach (var item in Parameters)
                {
                    builder.Append($"    {item.Key}: ");

                    AppendChildObject(builder, item.Value, options, 4);
                }
                builder.AppendLine("  }");
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

        BinaryData IPersistableModel<SwaggerCustomDynamicTreeCommand>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SwaggerCustomDynamicTreeCommand>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SwaggerCustomDynamicTreeCommand)} does not support '{options.Format}' format.");
            }
        }

        SwaggerCustomDynamicTreeCommand IPersistableModel<SwaggerCustomDynamicTreeCommand>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SwaggerCustomDynamicTreeCommand>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSwaggerCustomDynamicTreeCommand(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SwaggerCustomDynamicTreeCommand)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SwaggerCustomDynamicTreeCommand>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
