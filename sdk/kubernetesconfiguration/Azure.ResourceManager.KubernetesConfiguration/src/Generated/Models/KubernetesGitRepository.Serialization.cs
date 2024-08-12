// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class KubernetesGitRepository : IUtf8JsonSerializable, IJsonModel<KubernetesGitRepository>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KubernetesGitRepository>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<KubernetesGitRepository>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesGitRepository>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesGitRepository)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Uri))
            {
                if (Uri != null)
                {
                    writer.WritePropertyName("url"u8);
                    writer.WriteStringValue(Uri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("url");
                }
            }
            if (Optional.IsDefined(TimeoutInSeconds))
            {
                if (TimeoutInSeconds != null)
                {
                    writer.WritePropertyName("timeoutInSeconds"u8);
                    writer.WriteNumberValue(TimeoutInSeconds.Value);
                }
                else
                {
                    writer.WriteNull("timeoutInSeconds");
                }
            }
            if (Optional.IsDefined(SyncIntervalInSeconds))
            {
                if (SyncIntervalInSeconds != null)
                {
                    writer.WritePropertyName("syncIntervalInSeconds"u8);
                    writer.WriteNumberValue(SyncIntervalInSeconds.Value);
                }
                else
                {
                    writer.WriteNull("syncIntervalInSeconds");
                }
            }
            if (Optional.IsDefined(RepositoryRef))
            {
                if (RepositoryRef != null)
                {
                    writer.WritePropertyName("repositoryRef"u8);
                    writer.WriteObjectValue(RepositoryRef, options);
                }
                else
                {
                    writer.WriteNull("repositoryRef");
                }
            }
            if (Optional.IsDefined(SshKnownHosts))
            {
                if (SshKnownHosts != null)
                {
                    writer.WritePropertyName("sshKnownHosts"u8);
                    writer.WriteStringValue(SshKnownHosts);
                }
                else
                {
                    writer.WriteNull("sshKnownHosts");
                }
            }
            if (Optional.IsDefined(HttpsUser))
            {
                if (HttpsUser != null)
                {
                    writer.WritePropertyName("httpsUser"u8);
                    writer.WriteStringValue(HttpsUser);
                }
                else
                {
                    writer.WriteNull("httpsUser");
                }
            }
            if (Optional.IsDefined(HttpsCACert))
            {
                if (HttpsCACert != null)
                {
                    writer.WritePropertyName("httpsCACert"u8);
                    writer.WriteStringValue(HttpsCACert);
                }
                else
                {
                    writer.WriteNull("httpsCACert");
                }
            }
            if (Optional.IsDefined(LocalAuthRef))
            {
                if (LocalAuthRef != null)
                {
                    writer.WritePropertyName("localAuthRef"u8);
                    writer.WriteStringValue(LocalAuthRef);
                }
                else
                {
                    writer.WriteNull("localAuthRef");
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

        KubernetesGitRepository IJsonModel<KubernetesGitRepository>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesGitRepository>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesGitRepository)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesGitRepository(document.RootElement, options);
        }

        internal static KubernetesGitRepository DeserializeKubernetesGitRepository(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri url = default;
            long? timeoutInSeconds = default;
            long? syncIntervalInSeconds = default;
            KubernetesGitRepositoryRef repositoryRef = default;
            string sshKnownHosts = default;
            string httpsUser = default;
            string httpsCACert = default;
            string localAuthRef = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        url = null;
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timeoutInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        timeoutInSeconds = null;
                        continue;
                    }
                    timeoutInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("syncIntervalInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        syncIntervalInSeconds = null;
                        continue;
                    }
                    syncIntervalInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("repositoryRef"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        repositoryRef = null;
                        continue;
                    }
                    repositoryRef = KubernetesGitRepositoryRef.DeserializeKubernetesGitRepositoryRef(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sshKnownHosts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sshKnownHosts = null;
                        continue;
                    }
                    sshKnownHosts = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpsUser"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        httpsUser = null;
                        continue;
                    }
                    httpsUser = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpsCACert"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        httpsCACert = null;
                        continue;
                    }
                    httpsCACert = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("localAuthRef"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        localAuthRef = null;
                        continue;
                    }
                    localAuthRef = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new KubernetesGitRepository(
                url,
                timeoutInSeconds,
                syncIntervalInSeconds,
                repositoryRef,
                sshKnownHosts,
                httpsUser,
                httpsCACert,
                localAuthRef,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<KubernetesGitRepository>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesGitRepository>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KubernetesGitRepository)} does not support writing '{options.Format}' format.");
            }
        }

        KubernetesGitRepository IPersistableModel<KubernetesGitRepository>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesGitRepository>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKubernetesGitRepository(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KubernetesGitRepository)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<KubernetesGitRepository>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
