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
    public partial class GitHubAccessTokenResult : IUtf8JsonSerializable, IJsonModel<GitHubAccessTokenResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GitHubAccessTokenResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GitHubAccessTokenResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GitHubAccessTokenResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GitHubAccessTokenResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(GitHubAccessToken))
            {
                writer.WritePropertyName("gitHubAccessToken"u8);
                writer.WriteStringValue(GitHubAccessToken);
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

        GitHubAccessTokenResult IJsonModel<GitHubAccessTokenResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GitHubAccessTokenResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GitHubAccessTokenResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGitHubAccessTokenResult(document.RootElement, options);
        }

        internal static GitHubAccessTokenResult DeserializeGitHubAccessTokenResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string gitHubAccessToken = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("gitHubAccessToken"u8))
                {
                    gitHubAccessToken = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GitHubAccessTokenResult(gitHubAccessToken, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GitHubAccessTokenResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GitHubAccessTokenResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GitHubAccessTokenResult)} does not support '{options.Format}' format.");
            }
        }

        GitHubAccessTokenResult IPersistableModel<GitHubAccessTokenResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GitHubAccessTokenResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGitHubAccessTokenResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GitHubAccessTokenResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GitHubAccessTokenResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
