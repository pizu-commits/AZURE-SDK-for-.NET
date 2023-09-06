// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Health.Insights.ClinicalMatching
{
    public partial class ClinicalTrialDetails : IUtf8JsonSerializable, IModelJsonSerializable<ClinicalTrialDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ClinicalTrialDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ClinicalTrialDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            if (Optional.IsDefined(EligibilityCriteriaText))
            {
                writer.WritePropertyName("eligibilityCriteriaText"u8);
                writer.WriteStringValue(EligibilityCriteriaText);
            }
            if (Optional.IsDefined(Demographics))
            {
                writer.WritePropertyName("demographics"u8);
                if (Demographics is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ClinicalTrialDemographics>)Demographics).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("metadata"u8);
            if (Metadata is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<ClinicalTrialMetadata>)Metadata).Serialize(writer, options);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static ClinicalTrialDetails DeserializeClinicalTrialDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            Optional<string> eligibilityCriteriaText = default;
            Optional<ClinicalTrialDemographics> demographics = default;
            ClinicalTrialMetadata metadata = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eligibilityCriteriaText"u8))
                {
                    eligibilityCriteriaText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("demographics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    demographics = ClinicalTrialDemographics.DeserializeClinicalTrialDemographics(property.Value);
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    metadata = ClinicalTrialMetadata.DeserializeClinicalTrialMetadata(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ClinicalTrialDetails(id, eligibilityCriteriaText.Value, demographics.Value, metadata, rawData);
        }

        ClinicalTrialDetails IModelJsonSerializable<ClinicalTrialDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeClinicalTrialDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ClinicalTrialDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ClinicalTrialDetails IModelSerializable<ClinicalTrialDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeClinicalTrialDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ClinicalTrialDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ClinicalTrialDetails"/> to convert. </param>
        public static implicit operator RequestContent(ClinicalTrialDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ClinicalTrialDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ClinicalTrialDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeClinicalTrialDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
