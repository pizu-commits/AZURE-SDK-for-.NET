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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MarketplaceOrdering
{
    public partial class MarketplaceAgreementTermData : IUtf8JsonSerializable, IModelJsonSerializable<MarketplaceAgreementTermData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MarketplaceAgreementTermData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MarketplaceAgreementTermData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Publisher))
            {
                writer.WritePropertyName("publisher"u8);
                writer.WriteStringValue(Publisher);
            }
            if (Optional.IsDefined(Product))
            {
                writer.WritePropertyName("product"u8);
                writer.WriteStringValue(Product);
            }
            if (Optional.IsDefined(Plan))
            {
                writer.WritePropertyName("plan"u8);
                writer.WriteStringValue(Plan);
            }
            if (Optional.IsDefined(LicenseTextLink))
            {
                writer.WritePropertyName("licenseTextLink"u8);
                writer.WriteStringValue(LicenseTextLink.AbsoluteUri);
            }
            if (Optional.IsDefined(PrivacyPolicyLink))
            {
                writer.WritePropertyName("privacyPolicyLink"u8);
                writer.WriteStringValue(PrivacyPolicyLink.AbsoluteUri);
            }
            if (Optional.IsDefined(MarketplaceTermsLink))
            {
                writer.WritePropertyName("marketplaceTermsLink"u8);
                writer.WriteStringValue(MarketplaceTermsLink.AbsoluteUri);
            }
            if (Optional.IsDefined(RetrievedOn))
            {
                writer.WritePropertyName("retrieveDatetime"u8);
                writer.WriteStringValue(RetrievedOn.Value, "O");
            }
            if (Optional.IsDefined(Signature))
            {
                writer.WritePropertyName("signature"u8);
                writer.WriteStringValue(Signature);
            }
            if (Optional.IsDefined(IsAccepted))
            {
                writer.WritePropertyName("accepted"u8);
                writer.WriteBooleanValue(IsAccepted.Value);
            }
            writer.WriteEndObject();
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

        internal static MarketplaceAgreementTermData DeserializeMarketplaceAgreementTermData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> publisher = default;
            Optional<string> product = default;
            Optional<string> plan = default;
            Optional<Uri> licenseTextLink = default;
            Optional<Uri> privacyPolicyLink = default;
            Optional<Uri> marketplaceTermsLink = default;
            Optional<DateTimeOffset> retrieveDatetime = default;
            Optional<string> signature = default;
            Optional<bool> accepted = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("publisher"u8))
                        {
                            publisher = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("product"u8))
                        {
                            product = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("plan"u8))
                        {
                            plan = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("licenseTextLink"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            licenseTextLink = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privacyPolicyLink"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privacyPolicyLink = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("marketplaceTermsLink"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            marketplaceTermsLink = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("retrieveDatetime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            retrieveDatetime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("signature"u8))
                        {
                            signature = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accepted"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accepted = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MarketplaceAgreementTermData(id, name, type, systemData.Value, publisher.Value, product.Value, plan.Value, licenseTextLink.Value, privacyPolicyLink.Value, marketplaceTermsLink.Value, Optional.ToNullable(retrieveDatetime), signature.Value, Optional.ToNullable(accepted), rawData);
        }

        MarketplaceAgreementTermData IModelJsonSerializable<MarketplaceAgreementTermData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMarketplaceAgreementTermData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MarketplaceAgreementTermData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MarketplaceAgreementTermData IModelSerializable<MarketplaceAgreementTermData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMarketplaceAgreementTermData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MarketplaceAgreementTermData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MarketplaceAgreementTermData"/> to convert. </param>
        public static implicit operator RequestContent(MarketplaceAgreementTermData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MarketplaceAgreementTermData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MarketplaceAgreementTermData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMarketplaceAgreementTermData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
