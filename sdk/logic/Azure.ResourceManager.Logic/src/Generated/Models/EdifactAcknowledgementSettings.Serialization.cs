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

namespace Azure.ResourceManager.Logic.Models
{
    public partial class EdifactAcknowledgementSettings : IUtf8JsonSerializable, IModelJsonSerializable<EdifactAcknowledgementSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EdifactAcknowledgementSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EdifactAcknowledgementSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("needTechnicalAcknowledgement"u8);
            writer.WriteBooleanValue(NeedTechnicalAcknowledgement);
            writer.WritePropertyName("batchTechnicalAcknowledgements"u8);
            writer.WriteBooleanValue(BatchTechnicalAcknowledgement);
            writer.WritePropertyName("needFunctionalAcknowledgement"u8);
            writer.WriteBooleanValue(NeedFunctionalAcknowledgement);
            writer.WritePropertyName("batchFunctionalAcknowledgements"u8);
            writer.WriteBooleanValue(BatchFunctionalAcknowledgement);
            writer.WritePropertyName("needLoopForValidMessages"u8);
            writer.WriteBooleanValue(NeedLoopForValidMessages);
            writer.WritePropertyName("sendSynchronousAcknowledgement"u8);
            writer.WriteBooleanValue(SendSynchronousAcknowledgement);
            if (Optional.IsDefined(AcknowledgementControlNumberPrefix))
            {
                writer.WritePropertyName("acknowledgementControlNumberPrefix"u8);
                writer.WriteStringValue(AcknowledgementControlNumberPrefix);
            }
            if (Optional.IsDefined(AcknowledgementControlNumberSuffix))
            {
                writer.WritePropertyName("acknowledgementControlNumberSuffix"u8);
                writer.WriteStringValue(AcknowledgementControlNumberSuffix);
            }
            writer.WritePropertyName("acknowledgementControlNumberLowerBound"u8);
            writer.WriteNumberValue(AcknowledgementControlNumberLowerBound);
            writer.WritePropertyName("acknowledgementControlNumberUpperBound"u8);
            writer.WriteNumberValue(AcknowledgementControlNumberUpperBound);
            writer.WritePropertyName("rolloverAcknowledgementControlNumber"u8);
            writer.WriteBooleanValue(RolloverAcknowledgementControlNumber);
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

        internal static EdifactAcknowledgementSettings DeserializeEdifactAcknowledgementSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool needTechnicalAcknowledgement = default;
            bool batchTechnicalAcknowledgements = default;
            bool needFunctionalAcknowledgement = default;
            bool batchFunctionalAcknowledgements = default;
            bool needLoopForValidMessages = default;
            bool sendSynchronousAcknowledgement = default;
            Optional<string> acknowledgementControlNumberPrefix = default;
            Optional<string> acknowledgementControlNumberSuffix = default;
            int acknowledgementControlNumberLowerBound = default;
            int acknowledgementControlNumberUpperBound = default;
            bool rolloverAcknowledgementControlNumber = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("needTechnicalAcknowledgement"u8))
                {
                    needTechnicalAcknowledgement = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("batchTechnicalAcknowledgements"u8))
                {
                    batchTechnicalAcknowledgements = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("needFunctionalAcknowledgement"u8))
                {
                    needFunctionalAcknowledgement = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("batchFunctionalAcknowledgements"u8))
                {
                    batchFunctionalAcknowledgements = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("needLoopForValidMessages"u8))
                {
                    needLoopForValidMessages = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sendSynchronousAcknowledgement"u8))
                {
                    sendSynchronousAcknowledgement = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("acknowledgementControlNumberPrefix"u8))
                {
                    acknowledgementControlNumberPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("acknowledgementControlNumberSuffix"u8))
                {
                    acknowledgementControlNumberSuffix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("acknowledgementControlNumberLowerBound"u8))
                {
                    acknowledgementControlNumberLowerBound = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("acknowledgementControlNumberUpperBound"u8))
                {
                    acknowledgementControlNumberUpperBound = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rolloverAcknowledgementControlNumber"u8))
                {
                    rolloverAcknowledgementControlNumber = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new EdifactAcknowledgementSettings(needTechnicalAcknowledgement, batchTechnicalAcknowledgements, needFunctionalAcknowledgement, batchFunctionalAcknowledgements, needLoopForValidMessages, sendSynchronousAcknowledgement, acknowledgementControlNumberPrefix.Value, acknowledgementControlNumberSuffix.Value, acknowledgementControlNumberLowerBound, acknowledgementControlNumberUpperBound, rolloverAcknowledgementControlNumber, rawData);
        }

        EdifactAcknowledgementSettings IModelJsonSerializable<EdifactAcknowledgementSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEdifactAcknowledgementSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EdifactAcknowledgementSettings>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EdifactAcknowledgementSettings IModelSerializable<EdifactAcknowledgementSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEdifactAcknowledgementSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="EdifactAcknowledgementSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="EdifactAcknowledgementSettings"/> to convert. </param>
        public static implicit operator RequestContent(EdifactAcknowledgementSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="EdifactAcknowledgementSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator EdifactAcknowledgementSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEdifactAcknowledgementSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
