// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class ConfigServerGitPatternRepository : IUtf8JsonSerializable, IJsonModel<ConfigServerGitPatternRepository>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConfigServerGitPatternRepository>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConfigServerGitPatternRepository>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigServerGitPatternRepository>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfigServerGitPatternRepository)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsCollectionDefined(Pattern))
            {
                writer.WritePropertyName("pattern"u8);
                writer.WriteStartArray();
                foreach (var item in Pattern)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("uri"u8);
            writer.WriteStringValue(Uri.AbsoluteUri);
            if (Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label"u8);
                writer.WriteStringValue(Label);
            }
            if (Optional.IsCollectionDefined(SearchPaths))
            {
                writer.WritePropertyName("searchPaths"u8);
                writer.WriteStartArray();
                foreach (var item in SearchPaths)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Username))
            {
                writer.WritePropertyName("username"u8);
                writer.WriteStringValue(Username);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            if (Optional.IsDefined(HostKey))
            {
                writer.WritePropertyName("hostKey"u8);
                writer.WriteStringValue(HostKey);
            }
            if (Optional.IsDefined(HostKeyAlgorithm))
            {
                writer.WritePropertyName("hostKeyAlgorithm"u8);
                writer.WriteStringValue(HostKeyAlgorithm);
            }
            if (Optional.IsDefined(PrivateKey))
            {
                writer.WritePropertyName("privateKey"u8);
                writer.WriteStringValue(PrivateKey);
            }
            if (Optional.IsDefined(IsHostKeyCheckingStrict))
            {
                writer.WritePropertyName("strictHostKeyChecking"u8);
                writer.WriteBooleanValue(IsHostKeyCheckingStrict.Value);
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

        ConfigServerGitPatternRepository IJsonModel<ConfigServerGitPatternRepository>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigServerGitPatternRepository>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfigServerGitPatternRepository)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConfigServerGitPatternRepository(document.RootElement, options);
        }

        internal static ConfigServerGitPatternRepository DeserializeConfigServerGitPatternRepository(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            IList<string> pattern = default;
            Uri uri = default;
            string label = default;
            IList<string> searchPaths = default;
            string username = default;
            string password = default;
            string hostKey = default;
            string hostKeyAlgorithm = default;
            string privateKey = default;
            bool? strictHostKeyChecking = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pattern"u8))
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
                    pattern = array;
                    continue;
                }
                if (property.NameEquals("uri"u8))
                {
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("searchPaths"u8))
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
                    searchPaths = array;
                    continue;
                }
                if (property.NameEquals("username"u8))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostKey"u8))
                {
                    hostKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostKeyAlgorithm"u8))
                {
                    hostKeyAlgorithm = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateKey"u8))
                {
                    privateKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("strictHostKeyChecking"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    strictHostKeyChecking = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConfigServerGitPatternRepository(
                name,
                pattern ?? new ChangeTrackingList<string>(),
                uri,
                label,
                searchPaths ?? new ChangeTrackingList<string>(),
                username,
                password,
                hostKey,
                hostKeyAlgorithm,
                privateKey,
                strictHostKeyChecking,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConfigServerGitPatternRepository>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigServerGitPatternRepository>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConfigServerGitPatternRepository)} does not support writing '{options.Format}' format.");
            }
        }

        ConfigServerGitPatternRepository IPersistableModel<ConfigServerGitPatternRepository>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigServerGitPatternRepository>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConfigServerGitPatternRepository(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConfigServerGitPatternRepository)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConfigServerGitPatternRepository>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
