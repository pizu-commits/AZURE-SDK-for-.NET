// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class ResourceType
    {
        internal static ResourceType DeserializeResourceType(JsonElement element)
        {
            Optional<string> name = default;
            Optional<RoutingType> routingType = default;
            Optional<ResourceValidation> resourceValidation = default;
            Optional<IReadOnlyList<string>> allowedUnauthorizedActions = default;
            Optional<IReadOnlyList<AuthorizationActionMapping>> authorizationActionMappings = default;
            Optional<IReadOnlyList<LinkedAccessCheck>> linkedAccessChecks = default;
            Optional<string> defaultApiVersion = default;
            Optional<IReadOnlyList<LoggingRule>> loggingRules = default;
            Optional<IReadOnlyList<ThrottlingRule>> throttlingRules = default;
            Optional<IReadOnlyList<ResourceProviderEndpoint>> endpoints = default;
            Optional<ResourceTypeMarketplaceType> marketplaceType = default;
            Optional<ResourceTypeIdentityManagement> identityManagement = default;
            Optional<BinaryData> metadata = default;
            Optional<IReadOnlyList<string>> requiredFeatures = default;
            Optional<ResourceTypeFeaturesRule> featuresRule = default;
            Optional<IReadOnlyList<SubscriptionStateRule>> subscriptionStateRules = default;
            Optional<IReadOnlyList<ServiceTreeInfo>> serviceTreeInfos = default;
            Optional<ResourceTypeRequestHeaderOptions> requestHeaderOptions = default;
            Optional<string> skuLink = default;
            Optional<IReadOnlyList<string>> disallowedActionVerbs = default;
            Optional<ResourceTypeTemplateDeploymentPolicy> templateDeploymentPolicy = default;
            Optional<IReadOnlyList<ExtendedLocationOptions>> extendedLocations = default;
            Optional<IReadOnlyList<LinkedOperationRule>> linkedOperationRules = default;
            Optional<ManifestResourceDeletionPolicy> resourceDeletionPolicy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("routingType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    routingType = new RoutingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceValidation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resourceValidation = new ResourceValidation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("allowedUnauthorizedActions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedUnauthorizedActions = array;
                    continue;
                }
                if (property.NameEquals("authorizationActionMappings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AuthorizationActionMapping> array = new List<AuthorizationActionMapping>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AuthorizationActionMapping.DeserializeAuthorizationActionMapping(item));
                    }
                    authorizationActionMappings = array;
                    continue;
                }
                if (property.NameEquals("linkedAccessChecks"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<LinkedAccessCheck> array = new List<LinkedAccessCheck>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LinkedAccessCheck.DeserializeLinkedAccessCheck(item));
                    }
                    linkedAccessChecks = array;
                    continue;
                }
                if (property.NameEquals("defaultApiVersion"))
                {
                    defaultApiVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("loggingRules"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<LoggingRule> array = new List<LoggingRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LoggingRule.DeserializeLoggingRule(item));
                    }
                    loggingRules = array;
                    continue;
                }
                if (property.NameEquals("throttlingRules"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ThrottlingRule> array = new List<ThrottlingRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ThrottlingRule.DeserializeThrottlingRule(item));
                    }
                    throttlingRules = array;
                    continue;
                }
                if (property.NameEquals("endpoints"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ResourceProviderEndpoint> array = new List<ResourceProviderEndpoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceProviderEndpoint.DeserializeResourceProviderEndpoint(item));
                    }
                    endpoints = array;
                    continue;
                }
                if (property.NameEquals("marketplaceType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    marketplaceType = new ResourceTypeMarketplaceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identityManagement"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identityManagement = ResourceTypeIdentityManagement.DeserializeResourceTypeIdentityManagement(property.Value);
                    continue;
                }
                if (property.NameEquals("metadata"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    metadata = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("requiredFeatures"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    requiredFeatures = array;
                    continue;
                }
                if (property.NameEquals("featuresRule"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    featuresRule = ResourceTypeFeaturesRule.DeserializeResourceTypeFeaturesRule(property.Value);
                    continue;
                }
                if (property.NameEquals("subscriptionStateRules"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SubscriptionStateRule> array = new List<SubscriptionStateRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SubscriptionStateRule.DeserializeSubscriptionStateRule(item));
                    }
                    subscriptionStateRules = array;
                    continue;
                }
                if (property.NameEquals("serviceTreeInfos"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ServiceTreeInfo> array = new List<ServiceTreeInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceTreeInfo.DeserializeServiceTreeInfo(item));
                    }
                    serviceTreeInfos = array;
                    continue;
                }
                if (property.NameEquals("requestHeaderOptions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    requestHeaderOptions = ResourceTypeRequestHeaderOptions.DeserializeResourceTypeRequestHeaderOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("skuLink"))
                {
                    skuLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("disallowedActionVerbs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    disallowedActionVerbs = array;
                    continue;
                }
                if (property.NameEquals("templateDeploymentPolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    templateDeploymentPolicy = ResourceTypeTemplateDeploymentPolicy.DeserializeResourceTypeTemplateDeploymentPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("extendedLocations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ExtendedLocationOptions> array = new List<ExtendedLocationOptions>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExtendedLocationOptions.DeserializeExtendedLocationOptions(item));
                    }
                    extendedLocations = array;
                    continue;
                }
                if (property.NameEquals("linkedOperationRules"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<LinkedOperationRule> array = new List<LinkedOperationRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LinkedOperationRule.DeserializeLinkedOperationRule(item));
                    }
                    linkedOperationRules = array;
                    continue;
                }
                if (property.NameEquals("resourceDeletionPolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resourceDeletionPolicy = new ManifestResourceDeletionPolicy(property.Value.GetString());
                    continue;
                }
            }
            return new ResourceType(name.Value, Optional.ToNullable(routingType), Optional.ToNullable(resourceValidation), Optional.ToList(allowedUnauthorizedActions), Optional.ToList(authorizationActionMappings), Optional.ToList(linkedAccessChecks), defaultApiVersion.Value, Optional.ToList(loggingRules), Optional.ToList(throttlingRules), Optional.ToList(endpoints), Optional.ToNullable(marketplaceType), identityManagement.Value, metadata.Value, Optional.ToList(requiredFeatures), featuresRule.Value, Optional.ToList(subscriptionStateRules), Optional.ToList(serviceTreeInfos), requestHeaderOptions.Value, skuLink.Value, Optional.ToList(disallowedActionVerbs), templateDeploymentPolicy.Value, Optional.ToList(extendedLocations), Optional.ToList(linkedOperationRules), Optional.ToNullable(resourceDeletionPolicy));
        }
    }
}
