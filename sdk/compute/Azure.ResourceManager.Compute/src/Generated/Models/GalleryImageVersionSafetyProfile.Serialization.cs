// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class GalleryImageVersionSafetyProfile : IUtf8JsonSerializable, IJsonModel<GalleryImageVersionSafetyProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GalleryImageVersionSafetyProfile>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<GalleryImageVersionSafetyProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(IsReportedForPolicyViolation))
                {
                    writer.WritePropertyName("reportedForPolicyViolation"u8);
                    writer.WriteBooleanValue(IsReportedForPolicyViolation.Value);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(PolicyViolations))
                {
                    writer.WritePropertyName("policyViolations"u8);
                    writer.WriteStartArray();
                    foreach (var item in PolicyViolations)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (Optional.IsDefined(AllowDeletionOfReplicatedLocations))
            {
                writer.WritePropertyName("allowDeletionOfReplicatedLocations"u8);
                writer.WriteBooleanValue(AllowDeletionOfReplicatedLocations.Value);
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        GalleryImageVersionSafetyProfile IJsonModel<GalleryImageVersionSafetyProfile>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(GalleryImageVersionSafetyProfile)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGalleryImageVersionSafetyProfile(document.RootElement, options);
        }

        internal static GalleryImageVersionSafetyProfile DeserializeGalleryImageVersionSafetyProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> reportedForPolicyViolation = default;
            Optional<IReadOnlyList<GalleryImageVersionPolicyViolation>> policyViolations = default;
            Optional<bool> allowDeletionOfReplicatedLocations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("reportedForPolicyViolation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reportedForPolicyViolation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("policyViolations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<GalleryImageVersionPolicyViolation> array = new List<GalleryImageVersionPolicyViolation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GalleryImageVersionPolicyViolation.DeserializeGalleryImageVersionPolicyViolation(item));
                    }
                    policyViolations = array;
                    continue;
                }
                if (property.NameEquals("allowDeletionOfReplicatedLocations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowDeletionOfReplicatedLocations = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GalleryImageVersionSafetyProfile(Optional.ToNullable(allowDeletionOfReplicatedLocations), serializedAdditionalRawData, Optional.ToNullable(reportedForPolicyViolation), Optional.ToList(policyViolations));
        }

        BinaryData IModel<GalleryImageVersionSafetyProfile>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(GalleryImageVersionSafetyProfile)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        GalleryImageVersionSafetyProfile IModel<GalleryImageVersionSafetyProfile>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(GalleryImageVersionSafetyProfile)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeGalleryImageVersionSafetyProfile(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<GalleryImageVersionSafetyProfile>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
