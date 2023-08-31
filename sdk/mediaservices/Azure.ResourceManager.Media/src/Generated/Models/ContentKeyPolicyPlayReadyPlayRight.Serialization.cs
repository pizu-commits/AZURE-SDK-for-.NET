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

namespace Azure.ResourceManager.Media.Models
{
    public partial class ContentKeyPolicyPlayReadyPlayRight : IUtf8JsonSerializable, IModelJsonSerializable<ContentKeyPolicyPlayReadyPlayRight>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContentKeyPolicyPlayReadyPlayRight>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContentKeyPolicyPlayReadyPlayRight>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(FirstPlayExpiration))
            {
                writer.WritePropertyName("firstPlayExpiration"u8);
                writer.WriteStringValue(FirstPlayExpiration.Value, "P");
            }
            if (Optional.IsDefined(ScmsRestriction))
            {
                writer.WritePropertyName("scmsRestriction"u8);
                writer.WriteNumberValue(ScmsRestriction.Value);
            }
            if (Optional.IsDefined(AgcAndColorStripeRestriction))
            {
                writer.WritePropertyName("agcAndColorStripeRestriction"u8);
                writer.WriteNumberValue(AgcAndColorStripeRestriction.Value);
            }
            if (Optional.IsDefined(ExplicitAnalogTelevisionOutputRestriction))
            {
                writer.WritePropertyName("explicitAnalogTelevisionOutputRestriction"u8);
                if (ExplicitAnalogTelevisionOutputRestriction is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction>)ExplicitAnalogTelevisionOutputRestriction).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("digitalVideoOnlyContentRestriction"u8);
            writer.WriteBooleanValue(HasDigitalVideoOnlyContentRestriction);
            writer.WritePropertyName("imageConstraintForAnalogComponentVideoRestriction"u8);
            writer.WriteBooleanValue(HasImageConstraintForAnalogComponentVideoRestriction);
            writer.WritePropertyName("imageConstraintForAnalogComputerMonitorRestriction"u8);
            writer.WriteBooleanValue(HasImageConstraintForAnalogComputerMonitorRestriction);
            writer.WritePropertyName("allowPassingVideoContentToUnknownOutput"u8);
            writer.WriteStringValue(AllowPassingVideoContentToUnknownOutput.ToString());
            if (Optional.IsDefined(UncompressedDigitalVideoOutputProtectionLevel))
            {
                writer.WritePropertyName("uncompressedDigitalVideoOpl"u8);
                writer.WriteNumberValue(UncompressedDigitalVideoOutputProtectionLevel.Value);
            }
            if (Optional.IsDefined(CompressedDigitalVideoOutputProtectionLevel))
            {
                writer.WritePropertyName("compressedDigitalVideoOpl"u8);
                writer.WriteNumberValue(CompressedDigitalVideoOutputProtectionLevel.Value);
            }
            if (Optional.IsDefined(AnalogVideoOutputProtectionLevel))
            {
                writer.WritePropertyName("analogVideoOpl"u8);
                writer.WriteNumberValue(AnalogVideoOutputProtectionLevel.Value);
            }
            if (Optional.IsDefined(CompressedDigitalAudioOutputProtectionLevel))
            {
                writer.WritePropertyName("compressedDigitalAudioOpl"u8);
                writer.WriteNumberValue(CompressedDigitalAudioOutputProtectionLevel.Value);
            }
            if (Optional.IsDefined(UncompressedDigitalAudioOutputProtectionLevel))
            {
                writer.WritePropertyName("uncompressedDigitalAudioOpl"u8);
                writer.WriteNumberValue(UncompressedDigitalAudioOutputProtectionLevel.Value);
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

        internal static ContentKeyPolicyPlayReadyPlayRight DeserializeContentKeyPolicyPlayReadyPlayRight(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<TimeSpan> firstPlayExpiration = default;
            Optional<int> scmsRestriction = default;
            Optional<int> agcAndColorStripeRestriction = default;
            Optional<ContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction> explicitAnalogTelevisionOutputRestriction = default;
            bool digitalVideoOnlyContentRestriction = default;
            bool imageConstraintForAnalogComponentVideoRestriction = default;
            bool imageConstraintForAnalogComputerMonitorRestriction = default;
            ContentKeyPolicyPlayReadyUnknownOutputPassingOption allowPassingVideoContentToUnknownOutput = default;
            Optional<int> uncompressedDigitalVideoOpl = default;
            Optional<int> compressedDigitalVideoOpl = default;
            Optional<int> analogVideoOpl = default;
            Optional<int> compressedDigitalAudioOpl = default;
            Optional<int> uncompressedDigitalAudioOpl = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("firstPlayExpiration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firstPlayExpiration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("scmsRestriction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scmsRestriction = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("agcAndColorStripeRestriction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agcAndColorStripeRestriction = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("explicitAnalogTelevisionOutputRestriction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    explicitAnalogTelevisionOutputRestriction = ContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction.DeserializeContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction(property.Value);
                    continue;
                }
                if (property.NameEquals("digitalVideoOnlyContentRestriction"u8))
                {
                    digitalVideoOnlyContentRestriction = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("imageConstraintForAnalogComponentVideoRestriction"u8))
                {
                    imageConstraintForAnalogComponentVideoRestriction = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("imageConstraintForAnalogComputerMonitorRestriction"u8))
                {
                    imageConstraintForAnalogComputerMonitorRestriction = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowPassingVideoContentToUnknownOutput"u8))
                {
                    allowPassingVideoContentToUnknownOutput = new ContentKeyPolicyPlayReadyUnknownOutputPassingOption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("uncompressedDigitalVideoOpl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uncompressedDigitalVideoOpl = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("compressedDigitalVideoOpl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    compressedDigitalVideoOpl = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("analogVideoOpl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    analogVideoOpl = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("compressedDigitalAudioOpl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    compressedDigitalAudioOpl = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("uncompressedDigitalAudioOpl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uncompressedDigitalAudioOpl = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContentKeyPolicyPlayReadyPlayRight(Optional.ToNullable(firstPlayExpiration), Optional.ToNullable(scmsRestriction), Optional.ToNullable(agcAndColorStripeRestriction), explicitAnalogTelevisionOutputRestriction.Value, digitalVideoOnlyContentRestriction, imageConstraintForAnalogComponentVideoRestriction, imageConstraintForAnalogComputerMonitorRestriction, allowPassingVideoContentToUnknownOutput, Optional.ToNullable(uncompressedDigitalVideoOpl), Optional.ToNullable(compressedDigitalVideoOpl), Optional.ToNullable(analogVideoOpl), Optional.ToNullable(compressedDigitalAudioOpl), Optional.ToNullable(uncompressedDigitalAudioOpl), rawData);
        }

        ContentKeyPolicyPlayReadyPlayRight IModelJsonSerializable<ContentKeyPolicyPlayReadyPlayRight>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContentKeyPolicyPlayReadyPlayRight(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContentKeyPolicyPlayReadyPlayRight>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContentKeyPolicyPlayReadyPlayRight IModelSerializable<ContentKeyPolicyPlayReadyPlayRight>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContentKeyPolicyPlayReadyPlayRight(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContentKeyPolicyPlayReadyPlayRight"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContentKeyPolicyPlayReadyPlayRight"/> to convert. </param>
        public static implicit operator RequestContent(ContentKeyPolicyPlayReadyPlayRight model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContentKeyPolicyPlayReadyPlayRight"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContentKeyPolicyPlayReadyPlayRight(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContentKeyPolicyPlayReadyPlayRight(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
