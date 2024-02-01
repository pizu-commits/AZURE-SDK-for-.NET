// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class AppServicePlanData : IUtf8JsonSerializable, IJsonModel<AppServicePlanData>, IPersistableModel<AppServicePlanData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppServicePlanData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppServicePlanData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServicePlanData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServicePlanData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation"u8);
                JsonSerializer.Serialize(writer, ExtendedLocation);
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(WorkerTierName))
            {
                writer.WritePropertyName("workerTierName"u8);
                writer.WriteStringValue(WorkerTierName);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(Subscription))
            {
                writer.WritePropertyName("subscription"u8);
                writer.WriteStringValue(Subscription);
            }
            if (Optional.IsDefined(HostingEnvironmentProfile))
            {
                if (HostingEnvironmentProfile != null)
                {
                    writer.WritePropertyName("hostingEnvironmentProfile"u8);
                    writer.WriteObjectValue(HostingEnvironmentProfile);
                }
                else
                {
                    writer.WriteNull("hostingEnvironmentProfile");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(MaximumNumberOfWorkers))
            {
                writer.WritePropertyName("maximumNumberOfWorkers"u8);
                writer.WriteNumberValue(MaximumNumberOfWorkers.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(GeoRegion))
            {
                writer.WritePropertyName("geoRegion"u8);
                writer.WriteStringValue(GeoRegion);
            }
            if (Optional.IsDefined(IsPerSiteScaling))
            {
                writer.WritePropertyName("perSiteScaling"u8);
                writer.WriteBooleanValue(IsPerSiteScaling.Value);
            }
            if (Optional.IsDefined(IsElasticScaleEnabled))
            {
                writer.WritePropertyName("elasticScaleEnabled"u8);
                writer.WriteBooleanValue(IsElasticScaleEnabled.Value);
            }
            if (Optional.IsDefined(MaximumElasticWorkerCount))
            {
                writer.WritePropertyName("maximumElasticWorkerCount"u8);
                writer.WriteNumberValue(MaximumElasticWorkerCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NumberOfSites))
            {
                writer.WritePropertyName("numberOfSites"u8);
                writer.WriteNumberValue(NumberOfSites.Value);
            }
            if (Optional.IsDefined(IsSpot))
            {
                writer.WritePropertyName("isSpot"u8);
                writer.WriteBooleanValue(IsSpot.Value);
            }
            if (Optional.IsDefined(SpotExpireOn))
            {
                if (SpotExpireOn != null)
                {
                    writer.WritePropertyName("spotExpirationTime"u8);
                    writer.WriteStringValue(SpotExpireOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("spotExpirationTime");
                }
            }
            if (Optional.IsDefined(FreeOfferExpireOn))
            {
                if (FreeOfferExpireOn != null)
                {
                    writer.WritePropertyName("freeOfferExpirationTime"u8);
                    writer.WriteStringValue(FreeOfferExpireOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("freeOfferExpirationTime");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceGroup))
            {
                writer.WritePropertyName("resourceGroup"u8);
                writer.WriteStringValue(ResourceGroup);
            }
            if (Optional.IsDefined(IsReserved))
            {
                writer.WritePropertyName("reserved"u8);
                writer.WriteBooleanValue(IsReserved.Value);
            }
            if (Optional.IsDefined(IsXenon))
            {
                writer.WritePropertyName("isXenon"u8);
                writer.WriteBooleanValue(IsXenon.Value);
            }
            if (Optional.IsDefined(IsHyperV))
            {
                writer.WritePropertyName("hyperV"u8);
                writer.WriteBooleanValue(IsHyperV.Value);
            }
            if (Optional.IsDefined(TargetWorkerCount))
            {
                writer.WritePropertyName("targetWorkerCount"u8);
                writer.WriteNumberValue(TargetWorkerCount.Value);
            }
            if (Optional.IsDefined(TargetWorkerSizeId))
            {
                writer.WritePropertyName("targetWorkerSizeId"u8);
                writer.WriteNumberValue(TargetWorkerSizeId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToSerialString());
            }
            if (Optional.IsDefined(KubeEnvironmentProfile))
            {
                if (KubeEnvironmentProfile != null)
                {
                    writer.WritePropertyName("kubeEnvironmentProfile"u8);
                    writer.WriteObjectValue(KubeEnvironmentProfile);
                }
                else
                {
                    writer.WriteNull("kubeEnvironmentProfile");
                }
            }
            if (Optional.IsDefined(IsZoneRedundant))
            {
                writer.WritePropertyName("zoneRedundant"u8);
                writer.WriteBooleanValue(IsZoneRedundant.Value);
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

        AppServicePlanData IJsonModel<AppServicePlanData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServicePlanData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServicePlanData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServicePlanData(document.RootElement, options);
        }

        internal static AppServicePlanData DeserializeAppServicePlanData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AppServiceSkuDescription> sku = default;
            Optional<ExtendedLocation> extendedLocation = default;
            Optional<string> kind = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> workerTierName = default;
            Optional<AppServicePlanStatus> status = default;
            Optional<string> subscription = default;
            Optional<HostingEnvironmentProfile> hostingEnvironmentProfile = default;
            Optional<int> maximumNumberOfWorkers = default;
            Optional<string> geoRegion = default;
            Optional<bool> perSiteScaling = default;
            Optional<bool> elasticScaleEnabled = default;
            Optional<int> maximumElasticWorkerCount = default;
            Optional<int> numberOfSites = default;
            Optional<bool> isSpot = default;
            Optional<DateTimeOffset?> spotExpirationTime = default;
            Optional<DateTimeOffset?> freeOfferExpirationTime = default;
            Optional<string> resourceGroup = default;
            Optional<bool> reserved = default;
            Optional<bool> isXenon = default;
            Optional<bool> hyperV = default;
            Optional<int> targetWorkerCount = default;
            Optional<int> targetWorkerSizeId = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<KubeEnvironmentProfile> kubeEnvironmentProfile = default;
            Optional<bool> zoneRedundant = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = AppServiceSkuDescription.DeserializeAppServiceSkuDescription(property.Value);
                    continue;
                }
                if (property.NameEquals("extendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedLocation = JsonSerializer.Deserialize<ExtendedLocation>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("workerTierName"u8))
                        {
                            workerTierName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = property0.Value.GetString().ToAppServicePlanStatus();
                            continue;
                        }
                        if (property0.NameEquals("subscription"u8))
                        {
                            subscription = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostingEnvironmentProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                hostingEnvironmentProfile = null;
                                continue;
                            }
                            hostingEnvironmentProfile = HostingEnvironmentProfile.DeserializeHostingEnvironmentProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("maximumNumberOfWorkers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maximumNumberOfWorkers = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("geoRegion"u8))
                        {
                            geoRegion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("perSiteScaling"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            perSiteScaling = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("elasticScaleEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            elasticScaleEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("maximumElasticWorkerCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maximumElasticWorkerCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("numberOfSites"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfSites = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("isSpot"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isSpot = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("spotExpirationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                spotExpirationTime = null;
                                continue;
                            }
                            spotExpirationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("freeOfferExpirationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                freeOfferExpirationTime = null;
                                continue;
                            }
                            freeOfferExpirationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("resourceGroup"u8))
                        {
                            resourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("reserved"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reserved = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isXenon"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isXenon = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("hyperV"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hyperV = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("targetWorkerCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetWorkerCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("targetWorkerSizeId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetWorkerSizeId = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("kubeEnvironmentProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                kubeEnvironmentProfile = null;
                                continue;
                            }
                            kubeEnvironmentProfile = KubeEnvironmentProfile.DeserializeKubeEnvironmentProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("zoneRedundant"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            zoneRedundant = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppServicePlanData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, sku.Value, extendedLocation, workerTierName.Value, Optional.ToNullable(status), subscription.Value, hostingEnvironmentProfile.Value, Optional.ToNullable(maximumNumberOfWorkers), geoRegion.Value, Optional.ToNullable(perSiteScaling), Optional.ToNullable(elasticScaleEnabled), Optional.ToNullable(maximumElasticWorkerCount), Optional.ToNullable(numberOfSites), Optional.ToNullable(isSpot), Optional.ToNullable(spotExpirationTime), Optional.ToNullable(freeOfferExpirationTime), resourceGroup.Value, Optional.ToNullable(reserved), Optional.ToNullable(isXenon), Optional.ToNullable(hyperV), Optional.ToNullable(targetWorkerCount), Optional.ToNullable(targetWorkerSizeId), Optional.ToNullable(provisioningState), kubeEnvironmentProfile.Value, Optional.ToNullable(zoneRedundant), kind.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Sku))
            {
                builder.Append("  sku:");
                AppendChildObject(builder, Sku, options, 2);
            }

            if (Optional.IsDefined(ExtendedLocation))
            {
                builder.Append("  extendedLocation:");
                AppendChildObject(builder, ExtendedLocation, options, 2);
            }

            if (Optional.IsDefined(WorkerTierName))
            {
                builder.Append("  workerTierName:");
                builder.AppendLine($" '{WorkerTierName}'");
            }

            if (Optional.IsDefined(Status))
            {
                builder.Append("  status:");
                builder.AppendLine($" '{Status.ToString()}'");
            }

            if (Optional.IsDefined(Subscription))
            {
                builder.Append("  subscription:");
                builder.AppendLine($" '{Subscription}'");
            }

            if (Optional.IsDefined(HostingEnvironmentProfile))
            {
                builder.Append("  hostingEnvironmentProfile:");
                AppendChildObject(builder, HostingEnvironmentProfile, options, 2);
            }

            if (Optional.IsDefined(MaximumNumberOfWorkers))
            {
                builder.Append("  maximumNumberOfWorkers:");
                builder.AppendLine($" '{MaximumNumberOfWorkers.Value.ToString()}'");
            }

            if (Optional.IsDefined(GeoRegion))
            {
                builder.Append("  geoRegion:");
                builder.AppendLine($" '{GeoRegion}'");
            }

            if (Optional.IsDefined(IsPerSiteScaling))
            {
                builder.Append("  perSiteScaling:");
                var boolValue = IsPerSiteScaling.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(IsElasticScaleEnabled))
            {
                builder.Append("  elasticScaleEnabled:");
                var boolValue = IsElasticScaleEnabled.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(MaximumElasticWorkerCount))
            {
                builder.Append("  maximumElasticWorkerCount:");
                builder.AppendLine($" '{MaximumElasticWorkerCount.Value.ToString()}'");
            }

            if (Optional.IsDefined(NumberOfSites))
            {
                builder.Append("  numberOfSites:");
                builder.AppendLine($" '{NumberOfSites.Value.ToString()}'");
            }

            if (Optional.IsDefined(IsSpot))
            {
                builder.Append("  isSpot:");
                var boolValue = IsSpot.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(SpotExpireOn))
            {
                builder.Append("  spotExpirationTime:");
                builder.AppendLine($" '{SpotExpireOn.Value.ToString()}'");
            }

            if (Optional.IsDefined(FreeOfferExpireOn))
            {
                builder.Append("  freeOfferExpirationTime:");
                builder.AppendLine($" '{FreeOfferExpireOn.Value.ToString()}'");
            }

            if (Optional.IsDefined(ResourceGroup))
            {
                builder.Append("  resourceGroup:");
                builder.AppendLine($" '{ResourceGroup}'");
            }

            if (Optional.IsDefined(IsReserved))
            {
                builder.Append("  reserved:");
                var boolValue = IsReserved.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(IsXenon))
            {
                builder.Append("  isXenon:");
                var boolValue = IsXenon.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(IsHyperV))
            {
                builder.Append("  hyperV:");
                var boolValue = IsHyperV.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(TargetWorkerCount))
            {
                builder.Append("  targetWorkerCount:");
                builder.AppendLine($" '{TargetWorkerCount.Value.ToString()}'");
            }

            if (Optional.IsDefined(TargetWorkerSizeId))
            {
                builder.Append("  targetWorkerSizeId:");
                builder.AppendLine($" '{TargetWorkerSizeId.Value.ToString()}'");
            }

            if (Optional.IsDefined(ProvisioningState))
            {
                builder.Append("  provisioningState:");
                builder.AppendLine($" '{ProvisioningState.ToString()}'");
            }

            if (Optional.IsDefined(KubeEnvironmentProfile))
            {
                builder.Append("  kubeEnvironmentProfile:");
                AppendChildObject(builder, KubeEnvironmentProfile, options, 2);
            }

            if (Optional.IsDefined(IsZoneRedundant))
            {
                builder.Append("  zoneRedundant:");
                var boolValue = IsZoneRedundant.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(Kind))
            {
                builder.Append("  kind:");
                builder.AppendLine($" '{Kind}'");
            }

            if (Optional.IsCollectionDefined(Tags))
            {
                builder.Append("  tags:");
                builder.AppendLine(" {");
                foreach (var item in Tags)
                {
                    builder.Append($"    {item.Key}: ");
                    if (item.Value == null)
                    {
                        builder.Append("null");
                        continue;
                    }
                    builder.AppendLine($" '{item.Value}'");
                }
                builder.AppendLine("  }");
            }

            if (Optional.IsDefined(Location))
            {
                builder.Append("  location:");
                builder.AppendLine($" '{Location.ToString()}'");
            }

            if (Optional.IsDefined(Id))
            {
                builder.Append("  id:");
                builder.AppendLine($" '{Id.ToString()}'");
            }

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                builder.AppendLine($" '{Name}'");
            }

            if (Optional.IsDefined(ResourceType))
            {
                builder.Append("  type:");
                builder.AppendLine($" '{ResourceType.ToString()}'");
            }

            if (Optional.IsDefined(SystemData))
            {
                builder.Append("  systemData:");
                builder.AppendLine($" '{SystemData.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                stringBuilder.AppendLine($"{indent}{line}");
            }
        }

        BinaryData IPersistableModel<AppServicePlanData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServicePlanData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AppServicePlanData)} does not support '{options.Format}' format.");
            }
        }

        AppServicePlanData IPersistableModel<AppServicePlanData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServicePlanData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppServicePlanData(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(AppServicePlanData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppServicePlanData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
