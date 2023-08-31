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

namespace Azure.ResourceManager.IotCentral.Models
{
    public partial class IotCentralNetworkRuleSets : IUtf8JsonSerializable, IModelJsonSerializable<IotCentralNetworkRuleSets>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IotCentralNetworkRuleSets>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IotCentralNetworkRuleSets>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ApplyToDevices))
            {
                writer.WritePropertyName("applyToDevices"u8);
                writer.WriteBooleanValue(ApplyToDevices.Value);
            }
            if (Optional.IsDefined(ApplyToIotCentral))
            {
                writer.WritePropertyName("applyToIoTCentral"u8);
                writer.WriteBooleanValue(ApplyToIotCentral.Value);
            }
            if (Optional.IsDefined(DefaultAction))
            {
                writer.WritePropertyName("defaultAction"u8);
                writer.WriteStringValue(DefaultAction.Value.ToString());
            }
            if (Optional.IsCollectionDefined(IPRules))
            {
                writer.WritePropertyName("ipRules"u8);
                writer.WriteStartArray();
                foreach (var item in IPRules)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<IotCentralNetworkRuleSetIPRule>)item).Serialize(writer, options);
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

        internal static IotCentralNetworkRuleSets DeserializeIotCentralNetworkRuleSets(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> applyToDevices = default;
            Optional<bool> applyToIoTCentral = default;
            Optional<IotCentralNetworkAction> defaultAction = default;
            Optional<IList<IotCentralNetworkRuleSetIPRule>> ipRules = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("applyToDevices"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applyToDevices = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("applyToIoTCentral"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applyToIoTCentral = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("defaultAction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultAction = new IotCentralNetworkAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IotCentralNetworkRuleSetIPRule> array = new List<IotCentralNetworkRuleSetIPRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotCentralNetworkRuleSetIPRule.DeserializeIotCentralNetworkRuleSetIPRule(item));
                    }
                    ipRules = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IotCentralNetworkRuleSets(Optional.ToNullable(applyToDevices), Optional.ToNullable(applyToIoTCentral), Optional.ToNullable(defaultAction), Optional.ToList(ipRules), rawData);
        }

        IotCentralNetworkRuleSets IModelJsonSerializable<IotCentralNetworkRuleSets>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIotCentralNetworkRuleSets(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IotCentralNetworkRuleSets>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IotCentralNetworkRuleSets IModelSerializable<IotCentralNetworkRuleSets>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIotCentralNetworkRuleSets(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="IotCentralNetworkRuleSets"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="IotCentralNetworkRuleSets"/> to convert. </param>
        public static implicit operator RequestContent(IotCentralNetworkRuleSets model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="IotCentralNetworkRuleSets"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator IotCentralNetworkRuleSets(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIotCentralNetworkRuleSets(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
