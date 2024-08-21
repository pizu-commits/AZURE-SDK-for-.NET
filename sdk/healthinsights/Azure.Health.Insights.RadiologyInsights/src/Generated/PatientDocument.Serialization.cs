// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Health.Insights.RadiologyInsights
{
    public partial class PatientDocument : IUtf8JsonSerializable, IJsonModel<PatientDocument>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PatientDocument>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PatientDocument>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PatientDocument>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PatientDocument)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
            if (Optional.IsDefined(ClinicalType))
            {
                writer.WritePropertyName("clinicalType"u8);
                writer.WriteStringValue(ClinicalType.Value.ToString());
            }
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            if (Optional.IsDefined(Language))
            {
                writer.WritePropertyName("language"u8);
                writer.WriteStringValue(Language);
            }
            if (Optional.IsDefined(CreatedAt))
            {
                writer.WritePropertyName("createdAt"u8);
                writer.WriteStringValue(CreatedAt.Value, "O");
            }
            if (Optional.IsCollectionDefined(Authors))
            {
                writer.WritePropertyName("authors"u8);
                writer.WriteStartArray();
                foreach (var item in Authors)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SpecialtyType))
            {
                writer.WritePropertyName("specialtyType"u8);
                writer.WriteStringValue(SpecialtyType.Value.ToString());
            }
            if (Optional.IsDefined(AdministrativeMetadata))
            {
                writer.WritePropertyName("administrativeMetadata"u8);
                writer.WriteObjectValue(AdministrativeMetadata, options);
            }
            writer.WritePropertyName("content"u8);
            writer.WriteObjectValue(Content, options);
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

        PatientDocument IJsonModel<PatientDocument>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PatientDocument>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PatientDocument)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePatientDocument(document.RootElement, options);
        }

        internal static PatientDocument DeserializePatientDocument(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ClinicalDocumentContentType type = default;
            ClinicalDocumentType? clinicalType = default;
            string id = default;
            string language = default;
            DateTimeOffset? createdAt = default;
            IList<ClinicalDocumentAuthor> authors = default;
            SpecialtyType? specialtyType = default;
            DocumentAdministrativeMetadata administrativeMetadata = default;
            ClinicalDocumentContent content = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new ClinicalDocumentContentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("clinicalType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clinicalType = new ClinicalDocumentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("language"u8))
                {
                    language = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("authors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ClinicalDocumentAuthor> array = new List<ClinicalDocumentAuthor>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ClinicalDocumentAuthor.DeserializeClinicalDocumentAuthor(item, options));
                    }
                    authors = array;
                    continue;
                }
                if (property.NameEquals("specialtyType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    specialtyType = new SpecialtyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("administrativeMetadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    administrativeMetadata = DocumentAdministrativeMetadata.DeserializeDocumentAdministrativeMetadata(property.Value, options);
                    continue;
                }
                if (property.NameEquals("content"u8))
                {
                    content = ClinicalDocumentContent.DeserializeClinicalDocumentContent(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PatientDocument(
                type,
                clinicalType,
                id,
                language,
                createdAt,
                authors ?? new ChangeTrackingList<ClinicalDocumentAuthor>(),
                specialtyType,
                administrativeMetadata,
                content,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PatientDocument>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PatientDocument>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PatientDocument)} does not support writing '{options.Format}' format.");
            }
        }

        PatientDocument IPersistableModel<PatientDocument>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PatientDocument>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePatientDocument(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PatientDocument)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PatientDocument>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static PatientDocument FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializePatientDocument(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
