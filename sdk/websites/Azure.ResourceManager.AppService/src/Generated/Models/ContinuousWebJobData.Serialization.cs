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
    public partial class ContinuousWebJobData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (Optional.IsDefined(DetailedStatus))
            {
                writer.WritePropertyName("detailed_status");
                writer.WriteStringValue(DetailedStatus);
            }
            if (Optional.IsDefined(LogUrl))
            {
                writer.WritePropertyName("log_url");
                writer.WriteStringValue(LogUrl);
            }
            if (Optional.IsDefined(RunCommand))
            {
                writer.WritePropertyName("run_command");
                writer.WriteStringValue(RunCommand);
            }
            if (Optional.IsDefined(Url))
            {
                writer.WritePropertyName("url");
                writer.WriteStringValue(Url);
            }
            if (Optional.IsDefined(ExtraInfoUrl))
            {
                writer.WritePropertyName("extra_info_url");
                writer.WriteStringValue(ExtraInfoUrl);
            }
            if (Optional.IsDefined(WebJobType))
            {
                writer.WritePropertyName("web_job_type");
                writer.WriteStringValue(WebJobType.Value.ToSerialString());
            }
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error");
                writer.WriteStringValue(Error);
            }
            if (Optional.IsDefined(UsingSdk))
            {
                writer.WritePropertyName("using_sdk");
                writer.WriteBooleanValue(UsingSdk.Value);
            }
            if (Optional.IsCollectionDefined(Settings))
            {
                writer.WritePropertyName("settings");
                writer.WriteStartObject();
                foreach (var item in Settings)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ContinuousWebJobData DeserializeContinuousWebJobData(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<ContinuousWebJobStatus> status = default;
            Optional<string> detailedStatus = default;
            Optional<string> logUrl = default;
            Optional<string> runCommand = default;
            Optional<string> url = default;
            Optional<string> extraInfoUrl = default;
            Optional<WebJobType> webJobType = default;
            Optional<string> error = default;
            Optional<bool> usingSdk = default;
            Optional<IDictionary<string, BinaryData>> settings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("status"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = property0.Value.GetString().ToContinuousWebJobStatus();
                            continue;
                        }
                        if (property0.NameEquals("detailed_status"))
                        {
                            detailedStatus = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("log_url"))
                        {
                            logUrl = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("run_command"))
                        {
                            runCommand = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("url"))
                        {
                            url = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("extra_info_url"))
                        {
                            extraInfoUrl = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("web_job_type"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            webJobType = property0.Value.GetString().ToWebJobType();
                            continue;
                        }
                        if (property0.NameEquals("error"))
                        {
                            error = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("using_sdk"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            usingSdk = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("settings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                            }
                            settings = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ContinuousWebJobData(id, name, type, systemData, kind.Value, Optional.ToNullable(status), detailedStatus.Value, logUrl.Value, runCommand.Value, url.Value, extraInfoUrl.Value, Optional.ToNullable(webJobType), error.Value, Optional.ToNullable(usingSdk), Optional.ToDictionary(settings));
        }
    }
}
