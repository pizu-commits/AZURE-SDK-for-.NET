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

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class UriFileNameMatchCondition : IUtf8JsonSerializable, IModelJsonSerializable<UriFileNameMatchCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<UriFileNameMatchCondition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<UriFileNameMatchCondition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UriFileNameMatchCondition>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("typeName"u8);
            writer.WriteStringValue(ConditionType.ToString());
            writer.WritePropertyName("operator"u8);
            writer.WriteStringValue(UriFileNameOperator.ToString());
            if (Optional.IsDefined(NegateCondition))
            {
                writer.WritePropertyName("negateCondition"u8);
                writer.WriteBooleanValue(NegateCondition.Value);
            }
            if (Optional.IsCollectionDefined(MatchValues))
            {
                writer.WritePropertyName("matchValues"u8);
                writer.WriteStartArray();
                foreach (var item in MatchValues)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Transforms))
            {
                writer.WritePropertyName("transforms"u8);
                writer.WriteStartArray();
                foreach (var item in Transforms)
                {
                    writer.WriteStringValue(item.ToString());
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

        internal static UriFileNameMatchCondition DeserializeUriFileNameMatchCondition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            UriFileNameMatchConditionType typeName = default;
            UriFileNameOperator @operator = default;
            Optional<bool> negateCondition = default;
            Optional<IList<string>> matchValues = default;
            Optional<IList<PreTransformCategory>> transforms = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("typeName"u8))
                {
                    typeName = new UriFileNameMatchConditionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("operator"u8))
                {
                    @operator = new UriFileNameOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("negateCondition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    negateCondition = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("matchValues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    matchValues = array;
                    continue;
                }
                if (property.NameEquals("transforms"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PreTransformCategory> array = new List<PreTransformCategory>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new PreTransformCategory(item.GetString()));
                    }
                    transforms = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UriFileNameMatchCondition(typeName, @operator, Optional.ToNullable(negateCondition), Optional.ToList(matchValues), Optional.ToList(transforms), rawData);
        }

        UriFileNameMatchCondition IModelJsonSerializable<UriFileNameMatchCondition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UriFileNameMatchCondition>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUriFileNameMatchCondition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<UriFileNameMatchCondition>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UriFileNameMatchCondition>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        UriFileNameMatchCondition IModelSerializable<UriFileNameMatchCondition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UriFileNameMatchCondition>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeUriFileNameMatchCondition(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="UriFileNameMatchCondition"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="UriFileNameMatchCondition"/> to convert. </param>
        public static implicit operator RequestContent(UriFileNameMatchCondition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="UriFileNameMatchCondition"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator UriFileNameMatchCondition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeUriFileNameMatchCondition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
