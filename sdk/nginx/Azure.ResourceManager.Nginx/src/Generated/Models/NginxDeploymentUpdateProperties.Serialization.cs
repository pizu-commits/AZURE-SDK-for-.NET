// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Nginx.Models
{
    public partial class NginxDeploymentUpdateProperties : IUtf8JsonSerializable, IJsonModel<NginxDeploymentUpdateProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NginxDeploymentUpdateProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NginxDeploymentUpdateProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxDeploymentUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NginxDeploymentUpdateProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(EnableDiagnosticsSupport))
            {
                writer.WritePropertyName("enableDiagnosticsSupport"u8);
                writer.WriteBooleanValue(EnableDiagnosticsSupport.Value);
            }
            if (Optional.IsDefined(Logging))
            {
                writer.WritePropertyName("logging"u8);
                writer.WriteObjectValue(Logging);
            }
            if (Optional.IsDefined(ScalingProperties))
            {
                writer.WritePropertyName("scalingProperties"u8);
                writer.WriteObjectValue(ScalingProperties);
            }
            if (Optional.IsDefined(UserProfile))
            {
                writer.WritePropertyName("userProfile"u8);
                writer.WriteObjectValue(UserProfile);
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

        NginxDeploymentUpdateProperties IJsonModel<NginxDeploymentUpdateProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxDeploymentUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NginxDeploymentUpdateProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNginxDeploymentUpdateProperties(document.RootElement, options);
        }

        internal static NginxDeploymentUpdateProperties DeserializeNginxDeploymentUpdateProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? enableDiagnosticsSupport = default;
            NginxLogging logging = default;
            NginxDeploymentScalingProperties scalingProperties = default;
            NginxDeploymentUserProfile userProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enableDiagnosticsSupport"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableDiagnosticsSupport = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("logging"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logging = NginxLogging.DeserializeNginxLogging(property.Value, options);
                    continue;
                }
                if (property.NameEquals("scalingProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scalingProperties = NginxDeploymentScalingProperties.DeserializeNginxDeploymentScalingProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("userProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userProfile = NginxDeploymentUserProfile.DeserializeNginxDeploymentUserProfile(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NginxDeploymentUpdateProperties(enableDiagnosticsSupport, logging, scalingProperties, userProfile, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NginxDeploymentUpdateProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxDeploymentUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NginxDeploymentUpdateProperties)} does not support '{options.Format}' format.");
            }
        }

        NginxDeploymentUpdateProperties IPersistableModel<NginxDeploymentUpdateProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxDeploymentUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNginxDeploymentUpdateProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NginxDeploymentUpdateProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NginxDeploymentUpdateProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
