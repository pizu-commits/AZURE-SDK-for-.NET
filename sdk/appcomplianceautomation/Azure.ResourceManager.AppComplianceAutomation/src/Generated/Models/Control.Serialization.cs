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

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    public partial class Control : IUtf8JsonSerializable, IModelJsonSerializable<Control>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<Control>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<Control>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<Control>(this, options.Format);

            writer.WriteStartObject();
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

        internal static Control DeserializeControl(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> controlId = default;
            Optional<string> controlShortName = default;
            Optional<string> controlFullName = default;
            Optional<ControlType> controlType = default;
            Optional<string> controlDescription = default;
            Optional<string> controlDescriptionHyperLink = default;
            Optional<ControlStatus> controlStatus = default;
            Optional<IReadOnlyList<Assessment>> assessments = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("controlId"u8))
                {
                    controlId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("controlShortName"u8))
                {
                    controlShortName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("controlFullName"u8))
                {
                    controlFullName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("controlType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    controlType = new ControlType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("controlDescription"u8))
                {
                    controlDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("controlDescriptionHyperLink"u8))
                {
                    controlDescriptionHyperLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("controlStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    controlStatus = new ControlStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("assessments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Assessment> array = new List<Assessment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Assessment.DeserializeAssessment(item));
                    }
                    assessments = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new Control(controlId.Value, controlShortName.Value, controlFullName.Value, Optional.ToNullable(controlType), controlDescription.Value, controlDescriptionHyperLink.Value, Optional.ToNullable(controlStatus), Optional.ToList(assessments), rawData);
        }

        Control IModelJsonSerializable<Control>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<Control>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeControl(doc.RootElement, options);
        }

        BinaryData IModelSerializable<Control>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<Control>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        Control IModelSerializable<Control>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<Control>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeControl(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="Control"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="Control"/> to convert. </param>
        public static implicit operator RequestContent(Control model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="Control"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator Control(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeControl(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
