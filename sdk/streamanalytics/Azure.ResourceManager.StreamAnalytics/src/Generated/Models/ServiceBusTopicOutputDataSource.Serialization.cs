// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class ServiceBusTopicOutputDataSource : IUtf8JsonSerializable, IJsonModel<ServiceBusTopicOutputDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceBusTopicOutputDataSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceBusTopicOutputDataSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusTopicOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceBusTopicOutputDataSource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(OutputDataSourceType);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ServiceBusNamespace))
            {
                writer.WritePropertyName("serviceBusNamespace"u8);
                writer.WriteStringValue(ServiceBusNamespace);
            }
            if (Optional.IsDefined(SharedAccessPolicyName))
            {
                writer.WritePropertyName("sharedAccessPolicyName"u8);
                writer.WriteStringValue(SharedAccessPolicyName);
            }
            if (Optional.IsDefined(SharedAccessPolicyKey))
            {
                writer.WritePropertyName("sharedAccessPolicyKey"u8);
                writer.WriteStringValue(SharedAccessPolicyKey);
            }
            if (Optional.IsDefined(AuthenticationMode))
            {
                writer.WritePropertyName("authenticationMode"u8);
                writer.WriteStringValue(AuthenticationMode.Value.ToString());
            }
            if (Optional.IsDefined(TopicName))
            {
                writer.WritePropertyName("topicName"u8);
                writer.WriteStringValue(TopicName);
            }
            if (Optional.IsCollectionDefined(PropertyColumns))
            {
                writer.WritePropertyName("propertyColumns"u8);
                writer.WriteStartArray();
                foreach (var item in PropertyColumns)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SystemPropertyColumns))
            {
                writer.WritePropertyName("systemPropertyColumns"u8);
                writer.WriteStartObject();
                foreach (var item in SystemPropertyColumns)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
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

        ServiceBusTopicOutputDataSource IJsonModel<ServiceBusTopicOutputDataSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusTopicOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceBusTopicOutputDataSource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceBusTopicOutputDataSource(document.RootElement, options);
        }

        internal static ServiceBusTopicOutputDataSource DeserializeServiceBusTopicOutputDataSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<string> serviceBusNamespace = default;
            Optional<string> sharedAccessPolicyName = default;
            Optional<string> sharedAccessPolicyKey = default;
            Optional<StreamAnalyticsAuthenticationMode> authenticationMode = default;
            Optional<string> topicName = default;
            Optional<IList<string>> propertyColumns = default;
            Optional<IDictionary<string, string>> systemPropertyColumns = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("serviceBusNamespace"u8))
                        {
                            serviceBusNamespace = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sharedAccessPolicyName"u8))
                        {
                            sharedAccessPolicyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sharedAccessPolicyKey"u8))
                        {
                            sharedAccessPolicyKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authenticationMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authenticationMode = new StreamAnalyticsAuthenticationMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("topicName"u8))
                        {
                            topicName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("propertyColumns"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            propertyColumns = array;
                            continue;
                        }
                        if (property0.NameEquals("systemPropertyColumns"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            systemPropertyColumns = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServiceBusTopicOutputDataSource(type, serializedAdditionalRawData, serviceBusNamespace.Value, sharedAccessPolicyName.Value, sharedAccessPolicyKey.Value, Optional.ToNullable(authenticationMode), topicName.Value, Optional.ToList(propertyColumns), Optional.ToDictionary(systemPropertyColumns));
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(OutputDataSourceType))
            {
                builder.Append("  type:");
                builder.AppendLine($" '{OutputDataSourceType}'");
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            if (Optional.IsDefined(ServiceBusNamespace))
            {
                builder.Append("    serviceBusNamespace:");
                builder.AppendLine($" '{ServiceBusNamespace}'");
            }

            if (Optional.IsDefined(SharedAccessPolicyName))
            {
                builder.Append("    sharedAccessPolicyName:");
                builder.AppendLine($" '{SharedAccessPolicyName}'");
            }

            if (Optional.IsDefined(SharedAccessPolicyKey))
            {
                builder.Append("    sharedAccessPolicyKey:");
                builder.AppendLine($" '{SharedAccessPolicyKey}'");
            }

            if (Optional.IsDefined(AuthenticationMode))
            {
                builder.Append("    authenticationMode:");
                builder.AppendLine($" '{AuthenticationMode.ToString()}'");
            }

            if (Optional.IsDefined(TopicName))
            {
                builder.Append("    topicName:");
                builder.AppendLine($" '{TopicName}'");
            }

            if (Optional.IsCollectionDefined(PropertyColumns))
            {
                if (PropertyColumns.Any())
                {
                    builder.Append("    propertyColumns:");
                    builder.AppendLine(" [");
                    foreach (var item in PropertyColumns)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($"      '{item}'");
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (Optional.IsCollectionDefined(SystemPropertyColumns))
            {
                if (SystemPropertyColumns.Any())
                {
                    builder.Append("    systemPropertyColumns:");
                    builder.AppendLine(" {");
                    foreach (var item in SystemPropertyColumns)
                    {
                        builder.Append($"        {item.Key}: ");
                        if (item.Value == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($" '{item.Value}'");
                    }
                    builder.AppendLine("    }");
                }
            }

            builder.AppendLine("  }");
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

        BinaryData IPersistableModel<ServiceBusTopicOutputDataSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusTopicOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ServiceBusTopicOutputDataSource)} does not support '{options.Format}' format.");
            }
        }

        ServiceBusTopicOutputDataSource IPersistableModel<ServiceBusTopicOutputDataSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusTopicOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceBusTopicOutputDataSource(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ServiceBusTopicOutputDataSource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceBusTopicOutputDataSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
