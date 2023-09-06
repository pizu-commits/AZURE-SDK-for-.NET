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

namespace Azure.ResourceManager.Hci.Models
{
    public partial class HciUpdateStep : IUtf8JsonSerializable, IModelJsonSerializable<HciUpdateStep>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HciUpdateStep>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HciUpdateStep>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HciUpdateStep>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ErrorMessage))
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(StartTimeUtc))
            {
                writer.WritePropertyName("startTimeUtc"u8);
                writer.WriteStringValue(StartTimeUtc.Value, "O");
            }
            if (Optional.IsDefined(EndTimeUtc))
            {
                writer.WritePropertyName("endTimeUtc"u8);
                writer.WriteStringValue(EndTimeUtc.Value, "O");
            }
            if (Optional.IsDefined(LastUpdatedTimeUtc))
            {
                writer.WritePropertyName("lastUpdatedTimeUtc"u8);
                writer.WriteStringValue(LastUpdatedTimeUtc.Value, "O");
            }
            if (Optional.IsCollectionDefined(Steps))
            {
                writer.WritePropertyName("steps"u8);
                writer.WriteStartArray();
                foreach (var item in Steps)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<HciUpdateStep>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static HciUpdateStep DeserializeHciUpdateStep(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> description = default;
            Optional<string> errorMessage = default;
            Optional<string> status = default;
            Optional<DateTimeOffset> startTimeUtc = default;
            Optional<DateTimeOffset> endTimeUtc = default;
            Optional<DateTimeOffset> lastUpdatedTimeUtc = default;
            Optional<IList<HciUpdateStep>> steps = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTimeUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTimeUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdatedTimeUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdatedTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("steps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HciUpdateStep> array = new List<HciUpdateStep>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeHciUpdateStep(item));
                    }
                    steps = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HciUpdateStep(name.Value, description.Value, errorMessage.Value, status.Value, Optional.ToNullable(startTimeUtc), Optional.ToNullable(endTimeUtc), Optional.ToNullable(lastUpdatedTimeUtc), Optional.ToList(steps), rawData);
        }

        HciUpdateStep IModelJsonSerializable<HciUpdateStep>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HciUpdateStep>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHciUpdateStep(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HciUpdateStep>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HciUpdateStep>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HciUpdateStep IModelSerializable<HciUpdateStep>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HciUpdateStep>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHciUpdateStep(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HciUpdateStep"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HciUpdateStep"/> to convert. </param>
        public static implicit operator RequestContent(HciUpdateStep model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HciUpdateStep"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HciUpdateStep(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHciUpdateStep(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
