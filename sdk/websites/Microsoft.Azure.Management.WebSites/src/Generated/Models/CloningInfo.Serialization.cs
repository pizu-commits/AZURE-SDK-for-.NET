// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.WebSites.Models
{
    public partial class CloningInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CorrelationId))
            {
                writer.WritePropertyName("correlationId");
                writer.WriteStringValue(CorrelationId.Value);
            }
            if (Optional.IsDefined(Overwrite))
            {
                writer.WritePropertyName("overwrite");
                writer.WriteBooleanValue(Overwrite.Value);
            }
            if (Optional.IsDefined(CloneCustomHostNames))
            {
                writer.WritePropertyName("cloneCustomHostNames");
                writer.WriteBooleanValue(CloneCustomHostNames.Value);
            }
            if (Optional.IsDefined(CloneSourceControl))
            {
                writer.WritePropertyName("cloneSourceControl");
                writer.WriteBooleanValue(CloneSourceControl.Value);
            }
            writer.WritePropertyName("sourceWebAppId");
            writer.WriteStringValue(SourceWebAppId);
            if (Optional.IsDefined(SourceWebAppLocation))
            {
                writer.WritePropertyName("sourceWebAppLocation");
                writer.WriteStringValue(SourceWebAppLocation);
            }
            if (Optional.IsDefined(HostingEnvironment))
            {
                writer.WritePropertyName("hostingEnvironment");
                writer.WriteStringValue(HostingEnvironment);
            }
            if (Optional.IsCollectionDefined(AppSettingsOverrides))
            {
                writer.WritePropertyName("appSettingsOverrides");
                writer.WriteStartObject();
                foreach (var item in AppSettingsOverrides)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ConfigureLoadBalancing))
            {
                writer.WritePropertyName("configureLoadBalancing");
                writer.WriteBooleanValue(ConfigureLoadBalancing.Value);
            }
            if (Optional.IsDefined(TrafficManagerProfileId))
            {
                writer.WritePropertyName("trafficManagerProfileId");
                writer.WriteStringValue(TrafficManagerProfileId);
            }
            if (Optional.IsDefined(TrafficManagerProfileName))
            {
                writer.WritePropertyName("trafficManagerProfileName");
                writer.WriteStringValue(TrafficManagerProfileName);
            }
            writer.WriteEndObject();
        }

        internal static CloningInfo DeserializeCloningInfo(JsonElement element)
        {
            Optional<Guid> correlationId = default;
            Optional<bool> overwrite = default;
            Optional<bool> cloneCustomHostNames = default;
            Optional<bool> cloneSourceControl = default;
            string sourceWebAppId = default;
            Optional<string> sourceWebAppLocation = default;
            Optional<string> hostingEnvironment = default;
            Optional<IDictionary<string, string>> appSettingsOverrides = default;
            Optional<bool> configureLoadBalancing = default;
            Optional<string> trafficManagerProfileId = default;
            Optional<string> trafficManagerProfileName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("correlationId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    correlationId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("overwrite"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    overwrite = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cloneCustomHostNames"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cloneCustomHostNames = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cloneSourceControl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cloneSourceControl = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sourceWebAppId"))
                {
                    sourceWebAppId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceWebAppLocation"))
                {
                    sourceWebAppLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostingEnvironment"))
                {
                    hostingEnvironment = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appSettingsOverrides"))
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
                    appSettingsOverrides = dictionary;
                    continue;
                }
                if (property.NameEquals("configureLoadBalancing"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    configureLoadBalancing = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("trafficManagerProfileId"))
                {
                    trafficManagerProfileId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trafficManagerProfileName"))
                {
                    trafficManagerProfileName = property.Value.GetString();
                    continue;
                }
            }
            return new CloningInfo(Optional.ToNullable(correlationId), Optional.ToNullable(overwrite), Optional.ToNullable(cloneCustomHostNames), Optional.ToNullable(cloneSourceControl), sourceWebAppId, sourceWebAppLocation.Value, hostingEnvironment.Value, Optional.ToDictionary(appSettingsOverrides), Optional.ToNullable(configureLoadBalancing), trafficManagerProfileId.Value, trafficManagerProfileName.Value);
        }
    }
}
