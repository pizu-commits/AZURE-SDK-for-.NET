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
    public partial class RadiologyCodeWithTypes : IUtf8JsonSerializable, IJsonModel<RadiologyCodeWithTypes>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RadiologyCodeWithTypes>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RadiologyCodeWithTypes>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RadiologyCodeWithTypes>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RadiologyCodeWithTypes)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("code"u8);
            writer.WriteObjectValue(Code);
            writer.WritePropertyName("types"u8);
            writer.WriteStartArray();
            foreach (var item in Types)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        RadiologyCodeWithTypes IJsonModel<RadiologyCodeWithTypes>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RadiologyCodeWithTypes>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RadiologyCodeWithTypes)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRadiologyCodeWithTypes(document.RootElement, options);
        }

        internal static RadiologyCodeWithTypes DeserializeRadiologyCodeWithTypes(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FhirR4CodeableConcept code = default;
            IReadOnlyList<FhirR4CodeableConcept> types = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = FhirR4CodeableConcept.DeserializeFhirR4CodeableConcept(property.Value, options);
                    continue;
                }
                if (property.NameEquals("types"u8))
                {
                    List<FhirR4CodeableConcept> array = new List<FhirR4CodeableConcept>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FhirR4CodeableConcept.DeserializeFhirR4CodeableConcept(item, options));
                    }
                    types = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RadiologyCodeWithTypes(code, types, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RadiologyCodeWithTypes>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RadiologyCodeWithTypes>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RadiologyCodeWithTypes)} does not support '{options.Format}' format.");
            }
        }

        RadiologyCodeWithTypes IPersistableModel<RadiologyCodeWithTypes>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RadiologyCodeWithTypes>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRadiologyCodeWithTypes(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RadiologyCodeWithTypes)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RadiologyCodeWithTypes>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RadiologyCodeWithTypes FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRadiologyCodeWithTypes(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
