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

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class KubernetesClusterExtensionScope : IUtf8JsonSerializable, IJsonModel<KubernetesClusterExtensionScope>, IPersistableModel<KubernetesClusterExtensionScope>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KubernetesClusterExtensionScope>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KubernetesClusterExtensionScope>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesClusterExtensionScope>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesClusterExtensionScope)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Cluster))
            {
                if (Cluster != null)
                {
                    writer.WritePropertyName("cluster"u8);
                    writer.WriteObjectValue(Cluster);
                }
                else
                {
                    writer.WriteNull("cluster");
                }
            }
            if (Optional.IsDefined(Namespace))
            {
                if (Namespace != null)
                {
                    writer.WritePropertyName("namespace"u8);
                    writer.WriteObjectValue(Namespace);
                }
                else
                {
                    writer.WriteNull("namespace");
                }
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

        KubernetesClusterExtensionScope IJsonModel<KubernetesClusterExtensionScope>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesClusterExtensionScope>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesClusterExtensionScope)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesClusterExtensionScope(document.RootElement, options);
        }

        internal static KubernetesClusterExtensionScope DeserializeKubernetesClusterExtensionScope(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ScopeCluster> cluster = default;
            Optional<ScopeNamespace> @namespace = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cluster"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cluster = null;
                        continue;
                    }
                    cluster = ScopeCluster.DeserializeScopeCluster(property.Value);
                    continue;
                }
                if (property.NameEquals("namespace"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        @namespace = null;
                        continue;
                    }
                    @namespace = ScopeNamespace.DeserializeScopeNamespace(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KubernetesClusterExtensionScope(cluster.Value, @namespace.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Cluster))
            {
                builder.Append("  cluster:");
                AppendChildObject(builder, Cluster, options, 2);
            }

            if (Optional.IsDefined(Namespace))
            {
                builder.Append("  namespace:");
                AppendChildObject(builder, Namespace, options, 2);
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

        BinaryData IPersistableModel<KubernetesClusterExtensionScope>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesClusterExtensionScope>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(KubernetesClusterExtensionScope)} does not support '{options.Format}' format.");
            }
        }

        KubernetesClusterExtensionScope IPersistableModel<KubernetesClusterExtensionScope>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesClusterExtensionScope>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKubernetesClusterExtensionScope(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(KubernetesClusterExtensionScope)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<KubernetesClusterExtensionScope>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
