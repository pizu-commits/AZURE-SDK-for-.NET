// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn
{
    public partial class AfdRouteData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(CustomDomains))
            {
                writer.WritePropertyName("customDomains");
                writer.WriteStartArray();
                foreach (var item in CustomDomains)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OriginGroup))
            {
                writer.WritePropertyName("originGroup");
                JsonSerializer.Serialize(writer, OriginGroup);
            }
            if (Optional.IsDefined(OriginPath))
            {
                writer.WritePropertyName("originPath");
                writer.WriteStringValue(OriginPath);
            }
            if (Optional.IsCollectionDefined(RuleSets))
            {
                writer.WritePropertyName("ruleSets");
                writer.WriteStartArray();
                foreach (var item in RuleSets)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SupportedProtocols))
            {
                writer.WritePropertyName("supportedProtocols");
                writer.WriteStartArray();
                foreach (var item in SupportedProtocols)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PatternsToMatch))
            {
                writer.WritePropertyName("patternsToMatch");
                writer.WriteStartArray();
                foreach (var item in PatternsToMatch)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CompressionSettings))
            {
                writer.WritePropertyName("compressionSettings");
                writer.WriteObjectValue(CompressionSettings);
            }
            if (Optional.IsDefined(QueryStringCachingBehavior))
            {
                writer.WritePropertyName("queryStringCachingBehavior");
                writer.WriteStringValue(QueryStringCachingBehavior.Value.ToSerialString());
            }
            if (Optional.IsDefined(ForwardingProtocol))
            {
                writer.WritePropertyName("forwardingProtocol");
                writer.WriteStringValue(ForwardingProtocol.Value.ToString());
            }
            if (Optional.IsDefined(LinkToDefaultDomain))
            {
                writer.WritePropertyName("linkToDefaultDomain");
                writer.WriteStringValue(LinkToDefaultDomain.Value.ToString());
            }
            if (Optional.IsDefined(HttpsRedirect))
            {
                writer.WritePropertyName("httpsRedirect");
                writer.WriteStringValue(HttpsRedirect.Value.ToString());
            }
            if (Optional.IsDefined(EnabledState))
            {
                writer.WritePropertyName("enabledState");
                writer.WriteStringValue(EnabledState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AfdRouteData DeserializeAfdRouteData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<IList<WritableSubResource>> customDomains = default;
            Optional<WritableSubResource> originGroup = default;
            Optional<string> originPath = default;
            Optional<IList<WritableSubResource>> ruleSets = default;
            Optional<IList<AfdEndpointProtocols>> supportedProtocols = default;
            Optional<IList<string>> patternsToMatch = default;
            Optional<object> compressionSettings = default;
            Optional<AfdQueryStringCachingBehavior> queryStringCachingBehavior = default;
            Optional<ForwardingProtocol> forwardingProtocol = default;
            Optional<LinkToDefaultDomain> linkToDefaultDomain = default;
            Optional<HttpsRedirect> httpsRedirect = default;
            Optional<EnabledState> enabledState = default;
            Optional<AfdProvisioningState> provisioningState = default;
            Optional<DeploymentStatus> deploymentStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("customDomains"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.ToString()));
                            }
                            customDomains = array;
                            continue;
                        }
                        if (property0.NameEquals("originGroup"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            originGroup = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("originPath"))
                        {
                            originPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ruleSets"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.ToString()));
                            }
                            ruleSets = array;
                            continue;
                        }
                        if (property0.NameEquals("supportedProtocols"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<AfdEndpointProtocols> array = new List<AfdEndpointProtocols>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new AfdEndpointProtocols(item.GetString()));
                            }
                            supportedProtocols = array;
                            continue;
                        }
                        if (property0.NameEquals("patternsToMatch"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            patternsToMatch = array;
                            continue;
                        }
                        if (property0.NameEquals("compressionSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            compressionSettings = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("queryStringCachingBehavior"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            queryStringCachingBehavior = property0.Value.GetString().ToAfdQueryStringCachingBehavior();
                            continue;
                        }
                        if (property0.NameEquals("forwardingProtocol"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            forwardingProtocol = new ForwardingProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("linkToDefaultDomain"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            linkToDefaultDomain = new LinkToDefaultDomain(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("httpsRedirect"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            httpsRedirect = new HttpsRedirect(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enabledState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enabledState = new EnabledState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new AfdProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("deploymentStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            deploymentStatus = new DeploymentStatus(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AfdRouteData(id, name, type, systemData, Optional.ToList(customDomains), originGroup, originPath.Value, Optional.ToList(ruleSets), Optional.ToList(supportedProtocols), Optional.ToList(patternsToMatch), compressionSettings.Value, Optional.ToNullable(queryStringCachingBehavior), Optional.ToNullable(forwardingProtocol), Optional.ToNullable(linkToDefaultDomain), Optional.ToNullable(httpsRedirect), Optional.ToNullable(enabledState), Optional.ToNullable(provisioningState), Optional.ToNullable(deploymentStatus));
        }
    }
}
