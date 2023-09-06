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

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    public partial class ApplicationInsightsComponentFeatureCapabilities : IUtf8JsonSerializable, IModelJsonSerializable<ApplicationInsightsComponentFeatureCapabilities>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ApplicationInsightsComponentFeatureCapabilities>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ApplicationInsightsComponentFeatureCapabilities>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApplicationInsightsComponentFeatureCapabilities>(this, options.Format);

            writer.WriteStartObject();
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

        internal static ApplicationInsightsComponentFeatureCapabilities DeserializeApplicationInsightsComponentFeatureCapabilities(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> supportExportData = default;
            Optional<string> burstThrottlePolicy = default;
            Optional<string> metadataClass = default;
            Optional<bool> liveStreamMetrics = default;
            Optional<bool> applicationMap = default;
            Optional<bool> workItemIntegration = default;
            Optional<bool> powerBIIntegration = default;
            Optional<bool> openSchema = default;
            Optional<bool> proactiveDetection = default;
            Optional<bool> analyticsIntegration = default;
            Optional<bool> multipleStepWebTest = default;
            Optional<string> apiAccessLevel = default;
            Optional<string> trackingType = default;
            Optional<float> dailyCap = default;
            Optional<float> dailyCapResetTime = default;
            Optional<float> throttleRate = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("SupportExportData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportExportData = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("BurstThrottlePolicy"u8))
                {
                    burstThrottlePolicy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("MetadataClass"u8))
                {
                    metadataClass = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("LiveStreamMetrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    liveStreamMetrics = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ApplicationMap"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applicationMap = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("WorkItemIntegration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workItemIntegration = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("PowerBIIntegration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    powerBIIntegration = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("OpenSchema"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    openSchema = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ProactiveDetection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    proactiveDetection = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("AnalyticsIntegration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    analyticsIntegration = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("MultipleStepWebTest"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    multipleStepWebTest = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ApiAccessLevel"u8))
                {
                    apiAccessLevel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("TrackingType"u8))
                {
                    trackingType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("DailyCap"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dailyCap = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("DailyCapResetTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dailyCapResetTime = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("ThrottleRate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    throttleRate = property.Value.GetSingle();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ApplicationInsightsComponentFeatureCapabilities(Optional.ToNullable(supportExportData), burstThrottlePolicy.Value, metadataClass.Value, Optional.ToNullable(liveStreamMetrics), Optional.ToNullable(applicationMap), Optional.ToNullable(workItemIntegration), Optional.ToNullable(powerBIIntegration), Optional.ToNullable(openSchema), Optional.ToNullable(proactiveDetection), Optional.ToNullable(analyticsIntegration), Optional.ToNullable(multipleStepWebTest), apiAccessLevel.Value, trackingType.Value, Optional.ToNullable(dailyCap), Optional.ToNullable(dailyCapResetTime), Optional.ToNullable(throttleRate), rawData);
        }

        ApplicationInsightsComponentFeatureCapabilities IModelJsonSerializable<ApplicationInsightsComponentFeatureCapabilities>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApplicationInsightsComponentFeatureCapabilities>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationInsightsComponentFeatureCapabilities(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ApplicationInsightsComponentFeatureCapabilities>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApplicationInsightsComponentFeatureCapabilities>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ApplicationInsightsComponentFeatureCapabilities IModelSerializable<ApplicationInsightsComponentFeatureCapabilities>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApplicationInsightsComponentFeatureCapabilities>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeApplicationInsightsComponentFeatureCapabilities(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ApplicationInsightsComponentFeatureCapabilities"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ApplicationInsightsComponentFeatureCapabilities"/> to convert. </param>
        public static implicit operator RequestContent(ApplicationInsightsComponentFeatureCapabilities model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ApplicationInsightsComponentFeatureCapabilities"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ApplicationInsightsComponentFeatureCapabilities(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeApplicationInsightsComponentFeatureCapabilities(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
