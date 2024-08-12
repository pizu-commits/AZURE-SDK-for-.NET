// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    public partial class HealthcareApisServiceAcrConfiguration : IUtf8JsonSerializable, IJsonModel<HealthcareApisServiceAcrConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HealthcareApisServiceAcrConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HealthcareApisServiceAcrConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareApisServiceAcrConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HealthcareApisServiceAcrConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(LoginServers))
            {
                writer.WritePropertyName("loginServers"u8);
                writer.WriteStartArray();
                foreach (var item in LoginServers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(OciArtifacts))
            {
                writer.WritePropertyName("ociArtifacts"u8);
                writer.WriteStartArray();
                foreach (var item in OciArtifacts)
                {
                    writer.WriteObjectValue(item, options);
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

        HealthcareApisServiceAcrConfiguration IJsonModel<HealthcareApisServiceAcrConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareApisServiceAcrConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HealthcareApisServiceAcrConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHealthcareApisServiceAcrConfiguration(document.RootElement, options);
        }

        internal static HealthcareApisServiceAcrConfiguration DeserializeHealthcareApisServiceAcrConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> loginServers = default;
            IList<HealthcareApisServiceOciArtifactEntry> ociArtifacts = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("loginServers"u8))
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
                    loginServers = array;
                    continue;
                }
                if (property.NameEquals("ociArtifacts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HealthcareApisServiceOciArtifactEntry> array = new List<HealthcareApisServiceOciArtifactEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthcareApisServiceOciArtifactEntry.DeserializeHealthcareApisServiceOciArtifactEntry(item, options));
                    }
                    ociArtifacts = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HealthcareApisServiceAcrConfiguration(loginServers ?? new ChangeTrackingList<string>(), ociArtifacts ?? new ChangeTrackingList<HealthcareApisServiceOciArtifactEntry>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HealthcareApisServiceAcrConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareApisServiceAcrConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HealthcareApisServiceAcrConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        HealthcareApisServiceAcrConfiguration IPersistableModel<HealthcareApisServiceAcrConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareApisServiceAcrConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHealthcareApisServiceAcrConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HealthcareApisServiceAcrConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HealthcareApisServiceAcrConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
