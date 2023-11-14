// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Subscription.Models
{
    public partial class TenantPolicyCreateOrUpdateContent : IUtf8JsonSerializable, IJsonModel<TenantPolicyCreateOrUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TenantPolicyCreateOrUpdateContent>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<TenantPolicyCreateOrUpdateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<TenantPolicyCreateOrUpdateContent>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<TenantPolicyCreateOrUpdateContent>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(BlockSubscriptionsLeavingTenant))
            {
                writer.WritePropertyName("blockSubscriptionsLeavingTenant"u8);
                writer.WriteBooleanValue(BlockSubscriptionsLeavingTenant.Value);
            }
            if (Optional.IsDefined(BlockSubscriptionsIntoTenant))
            {
                writer.WritePropertyName("blockSubscriptionsIntoTenant"u8);
                writer.WriteBooleanValue(BlockSubscriptionsIntoTenant.Value);
            }
            if (Optional.IsCollectionDefined(ExemptedPrincipals))
            {
                writer.WritePropertyName("exemptedPrincipals"u8);
                writer.WriteStartArray();
                foreach (var item in ExemptedPrincipals)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        TenantPolicyCreateOrUpdateContent IJsonModel<TenantPolicyCreateOrUpdateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TenantPolicyCreateOrUpdateContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTenantPolicyCreateOrUpdateContent(document.RootElement, options);
        }

        internal static TenantPolicyCreateOrUpdateContent DeserializeTenantPolicyCreateOrUpdateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> blockSubscriptionsLeavingTenant = default;
            Optional<bool> blockSubscriptionsIntoTenant = default;
            Optional<IList<Guid>> exemptedPrincipals = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blockSubscriptionsLeavingTenant"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blockSubscriptionsLeavingTenant = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("blockSubscriptionsIntoTenant"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blockSubscriptionsIntoTenant = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("exemptedPrincipals"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Guid> array = new List<Guid>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetGuid());
                    }
                    exemptedPrincipals = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TenantPolicyCreateOrUpdateContent(Optional.ToNullable(blockSubscriptionsLeavingTenant), Optional.ToNullable(blockSubscriptionsIntoTenant), Optional.ToList(exemptedPrincipals), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TenantPolicyCreateOrUpdateContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TenantPolicyCreateOrUpdateContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        TenantPolicyCreateOrUpdateContent IPersistableModel<TenantPolicyCreateOrUpdateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TenantPolicyCreateOrUpdateContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeTenantPolicyCreateOrUpdateContent(document.RootElement, options);
        }

        string IPersistableModel<TenantPolicyCreateOrUpdateContent>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
