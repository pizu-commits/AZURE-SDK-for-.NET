// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class PlacementPolicyPatch : IUtf8JsonSerializable, IJsonModel<PlacementPolicyPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PlacementPolicyPatch>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PlacementPolicyPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlacementPolicyPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PlacementPolicyPatch)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsCollectionDefined(VmMembers))
            {
                writer.WritePropertyName("vmMembers"u8);
                writer.WriteStartArray();
                foreach (var item in VmMembers)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(HostMembers))
            {
                writer.WritePropertyName("hostMembers"u8);
                writer.WriteStartArray();
                foreach (var item in HostMembers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AffinityStrength))
            {
                writer.WritePropertyName("affinityStrength"u8);
                writer.WriteStringValue(AffinityStrength.Value.ToString());
            }
            if (Optional.IsDefined(AzureHybridBenefitType))
            {
                writer.WritePropertyName("azureHybridBenefitType"u8);
                writer.WriteStringValue(AzureHybridBenefitType.Value.ToString());
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        PlacementPolicyPatch IJsonModel<PlacementPolicyPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlacementPolicyPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PlacementPolicyPatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePlacementPolicyPatch(document.RootElement, options);
        }

        internal static PlacementPolicyPatch DeserializePlacementPolicyPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PlacementPolicyState? state = default;
            IList<ResourceIdentifier> vmMembers = default;
            IList<string> hostMembers = default;
            VmHostPlacementPolicyAffinityStrength? affinityStrength = default;
            AzureHybridBenefitType? azureHybridBenefitType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = new PlacementPolicyState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vmMembers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(new ResourceIdentifier(item.GetString()));
                                }
                            }
                            vmMembers = array;
                            continue;
                        }
                        if (property0.NameEquals("hostMembers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            hostMembers = array;
                            continue;
                        }
                        if (property0.NameEquals("affinityStrength"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            affinityStrength = new VmHostPlacementPolicyAffinityStrength(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("azureHybridBenefitType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureHybridBenefitType = new AzureHybridBenefitType(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PlacementPolicyPatch(
                state,
                vmMembers ?? new ChangeTrackingList<ResourceIdentifier>(),
                hostMembers ?? new ChangeTrackingList<string>(),
                affinityStrength,
                azureHybridBenefitType,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PlacementPolicyPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlacementPolicyPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PlacementPolicyPatch)} does not support writing '{options.Format}' format.");
            }
        }

        PlacementPolicyPatch IPersistableModel<PlacementPolicyPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlacementPolicyPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePlacementPolicyPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PlacementPolicyPatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PlacementPolicyPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
