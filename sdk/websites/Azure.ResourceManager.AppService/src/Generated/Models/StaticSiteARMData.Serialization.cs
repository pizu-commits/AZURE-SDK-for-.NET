// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class StaticSiteARMData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(RepositoryUri))
            {
                writer.WritePropertyName("repositoryUrl");
                writer.WriteStringValue(RepositoryUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Branch))
            {
                writer.WritePropertyName("branch");
                writer.WriteStringValue(Branch);
            }
            if (Optional.IsDefined(RepositoryToken))
            {
                writer.WritePropertyName("repositoryToken");
                writer.WriteStringValue(RepositoryToken);
            }
            if (Optional.IsDefined(BuildProperties))
            {
                writer.WritePropertyName("buildProperties");
                writer.WriteObjectValue(BuildProperties);
            }
            if (Optional.IsDefined(StagingEnvironmentPolicy))
            {
                writer.WritePropertyName("stagingEnvironmentPolicy");
                writer.WriteStringValue(StagingEnvironmentPolicy.Value.ToSerialString());
            }
            if (Optional.IsDefined(AllowConfigFileUpdates))
            {
                writer.WritePropertyName("allowConfigFileUpdates");
                writer.WriteBooleanValue(AllowConfigFileUpdates.Value);
            }
            if (Optional.IsDefined(TemplateProperties))
            {
                writer.WritePropertyName("templateProperties");
                writer.WriteObjectValue(TemplateProperties);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static StaticSiteARMData DeserializeStaticSiteARMData(JsonElement element)
        {
            Optional<SkuDescription> sku = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<string> kind = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> defaultHostname = default;
            Optional<Uri> repositoryUrl = default;
            Optional<string> branch = default;
            Optional<IReadOnlyList<string>> customDomains = default;
            Optional<string> repositoryToken = default;
            Optional<StaticSiteBuildProperties> buildProperties = default;
            Optional<IReadOnlyList<ResponseMessageEnvelope>> privateEndpointConnections = default;
            Optional<StagingEnvironmentPolicy> stagingEnvironmentPolicy = default;
            Optional<bool> allowConfigFileUpdates = default;
            Optional<StaticSiteTemplate> templateProperties = default;
            Optional<string> contentDistributionEndpoint = default;
            Optional<string> keyVaultReferenceIdentity = default;
            Optional<IReadOnlyList<StaticSiteUserProvidedFunctionApp>> userProvidedFunctionApps = default;
            Optional<string> provider = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = SkuDescription.DeserializeSkuDescription(property.Value);
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
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
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
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
                        if (property0.NameEquals("defaultHostname"))
                        {
                            defaultHostname = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("repositoryUrl"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                repositoryUrl = null;
                                continue;
                            }
                            repositoryUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("branch"))
                        {
                            branch = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("customDomains"))
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
                            customDomains = array;
                            continue;
                        }
                        if (property0.NameEquals("repositoryToken"))
                        {
                            repositoryToken = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("buildProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            buildProperties = StaticSiteBuildProperties.DeserializeStaticSiteBuildProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ResponseMessageEnvelope> array = new List<ResponseMessageEnvelope>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ResponseMessageEnvelope.DeserializeResponseMessageEnvelope(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("stagingEnvironmentPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            stagingEnvironmentPolicy = property0.Value.GetString().ToStagingEnvironmentPolicy();
                            continue;
                        }
                        if (property0.NameEquals("allowConfigFileUpdates"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            allowConfigFileUpdates = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("templateProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            templateProperties = StaticSiteTemplate.DeserializeStaticSiteTemplate(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("contentDistributionEndpoint"))
                        {
                            contentDistributionEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("keyVaultReferenceIdentity"))
                        {
                            keyVaultReferenceIdentity = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("userProvidedFunctionApps"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<StaticSiteUserProvidedFunctionApp> array = new List<StaticSiteUserProvidedFunctionApp>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StaticSiteUserProvidedFunctionApp.DeserializeStaticSiteUserProvidedFunctionApp(item));
                            }
                            userProvidedFunctionApps = array;
                            continue;
                        }
                        if (property0.NameEquals("provider"))
                        {
                            provider = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new StaticSiteARMData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, sku.Value, identity, defaultHostname.Value, repositoryUrl.Value, branch.Value, Optional.ToList(customDomains), repositoryToken.Value, buildProperties.Value, Optional.ToList(privateEndpointConnections), Optional.ToNullable(stagingEnvironmentPolicy), Optional.ToNullable(allowConfigFileUpdates), templateProperties.Value, contentDistributionEndpoint.Value, keyVaultReferenceIdentity.Value, Optional.ToList(userProvidedFunctionApps), provider.Value, kind.Value);
        }
    }
}
