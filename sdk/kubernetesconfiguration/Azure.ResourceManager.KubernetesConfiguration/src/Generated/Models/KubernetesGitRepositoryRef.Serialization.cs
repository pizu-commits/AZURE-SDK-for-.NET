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
    public partial class KubernetesGitRepositoryRef : IUtf8JsonSerializable, IJsonModel<KubernetesGitRepositoryRef>, IPersistableModel<KubernetesGitRepositoryRef>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KubernetesGitRepositoryRef>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KubernetesGitRepositoryRef>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesGitRepositoryRef>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesGitRepositoryRef)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Branch))
            {
                if (Branch != null)
                {
                    writer.WritePropertyName("branch"u8);
                    writer.WriteStringValue(Branch);
                }
                else
                {
                    writer.WriteNull("branch");
                }
            }
            if (Optional.IsDefined(Tag))
            {
                if (Tag != null)
                {
                    writer.WritePropertyName("tag"u8);
                    writer.WriteStringValue(Tag);
                }
                else
                {
                    writer.WriteNull("tag");
                }
            }
            if (Optional.IsDefined(Semver))
            {
                if (Semver != null)
                {
                    writer.WritePropertyName("semver"u8);
                    writer.WriteStringValue(Semver);
                }
                else
                {
                    writer.WriteNull("semver");
                }
            }
            if (Optional.IsDefined(Commit))
            {
                if (Commit != null)
                {
                    writer.WritePropertyName("commit"u8);
                    writer.WriteStringValue(Commit);
                }
                else
                {
                    writer.WriteNull("commit");
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

        KubernetesGitRepositoryRef IJsonModel<KubernetesGitRepositoryRef>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesGitRepositoryRef>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesGitRepositoryRef)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesGitRepositoryRef(document.RootElement, options);
        }

        internal static KubernetesGitRepositoryRef DeserializeKubernetesGitRepositoryRef(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> branch = default;
            Optional<string> tag = default;
            Optional<string> semver = default;
            Optional<string> commit = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("branch"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        branch = null;
                        continue;
                    }
                    branch = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tag = null;
                        continue;
                    }
                    tag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("semver"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        semver = null;
                        continue;
                    }
                    semver = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("commit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        commit = null;
                        continue;
                    }
                    commit = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KubernetesGitRepositoryRef(branch.Value, tag.Value, semver.Value, commit.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Branch))
            {
                builder.Append("  branch:");
                builder.AppendLine($" '{Branch}'");
            }

            if (Optional.IsDefined(Tag))
            {
                builder.Append("  tag:");
                builder.AppendLine($" '{Tag}'");
            }

            if (Optional.IsDefined(Semver))
            {
                builder.Append("  semver:");
                builder.AppendLine($" '{Semver}'");
            }

            if (Optional.IsDefined(Commit))
            {
                builder.Append("  commit:");
                builder.AppendLine($" '{Commit}'");
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

        BinaryData IPersistableModel<KubernetesGitRepositoryRef>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesGitRepositoryRef>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(KubernetesGitRepositoryRef)} does not support '{options.Format}' format.");
            }
        }

        KubernetesGitRepositoryRef IPersistableModel<KubernetesGitRepositoryRef>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesGitRepositoryRef>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKubernetesGitRepositoryRef(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(KubernetesGitRepositoryRef)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<KubernetesGitRepositoryRef>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
