// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Communication;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Communication.CallingServer
{
    internal partial class RecognizeOptionsInternal : IUtf8JsonSerializable, IModelJsonSerializable<RecognizeOptionsInternal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RecognizeOptionsInternal>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RecognizeOptionsInternal>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RecognizeOptionsInternal>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(InterruptPrompt))
            {
                writer.WritePropertyName("interruptPrompt"u8);
                writer.WriteBooleanValue(InterruptPrompt.Value);
            }
            if (Optional.IsDefined(InitialSilenceTimeoutInSeconds))
            {
                writer.WritePropertyName("initialSilenceTimeoutInSeconds"u8);
                writer.WriteNumberValue(InitialSilenceTimeoutInSeconds.Value);
            }
            writer.WritePropertyName("targetParticipant"u8);
            if (TargetParticipant is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<CommunicationIdentifierModel>)TargetParticipant).Serialize(writer, options);
            }
            if (Optional.IsDefined(DtmfOptions))
            {
                writer.WritePropertyName("dtmfOptions"u8);
                if (DtmfOptions is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DtmfOptionsInternal>)DtmfOptions).Serialize(writer, options);
                }
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

        internal static RecognizeOptionsInternal DeserializeRecognizeOptionsInternal(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> interruptPrompt = default;
            Optional<int> initialSilenceTimeoutInSeconds = default;
            CommunicationIdentifierModel targetParticipant = default;
            Optional<DtmfOptionsInternal> dtmfOptions = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("interruptPrompt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    interruptPrompt = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("initialSilenceTimeoutInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialSilenceTimeoutInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("targetParticipant"u8))
                {
                    targetParticipant = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("dtmfOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dtmfOptions = DtmfOptionsInternal.DeserializeDtmfOptionsInternal(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RecognizeOptionsInternal(Optional.ToNullable(interruptPrompt), Optional.ToNullable(initialSilenceTimeoutInSeconds), targetParticipant, dtmfOptions.Value, rawData);
        }

        RecognizeOptionsInternal IModelJsonSerializable<RecognizeOptionsInternal>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RecognizeOptionsInternal>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRecognizeOptionsInternal(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RecognizeOptionsInternal>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RecognizeOptionsInternal>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RecognizeOptionsInternal IModelSerializable<RecognizeOptionsInternal>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RecognizeOptionsInternal>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRecognizeOptionsInternal(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RecognizeOptionsInternal"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RecognizeOptionsInternal"/> to convert. </param>
        public static implicit operator RequestContent(RecognizeOptionsInternal model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RecognizeOptionsInternal"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RecognizeOptionsInternal(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRecognizeOptionsInternal(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
