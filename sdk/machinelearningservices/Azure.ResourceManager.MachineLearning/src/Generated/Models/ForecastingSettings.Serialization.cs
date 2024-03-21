// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ForecastingSettings : IUtf8JsonSerializable, IJsonModel<ForecastingSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ForecastingSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ForecastingSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForecastingSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ForecastingSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CountryOrRegionForHolidays))
            {
                if (CountryOrRegionForHolidays != null)
                {
                    writer.WritePropertyName("countryOrRegionForHolidays"u8);
                    writer.WriteStringValue(CountryOrRegionForHolidays);
                }
                else
                {
                    writer.WriteNull("countryOrRegionForHolidays");
                }
            }
            if (Optional.IsDefined(CvStepSize))
            {
                if (CvStepSize != null)
                {
                    writer.WritePropertyName("cvStepSize"u8);
                    writer.WriteNumberValue(CvStepSize.Value);
                }
                else
                {
                    writer.WriteNull("cvStepSize");
                }
            }
            if (Optional.IsDefined(FeatureLags))
            {
                writer.WritePropertyName("featureLags"u8);
                writer.WriteStringValue(FeatureLags.Value.ToString());
            }
            if (Optional.IsCollectionDefined(FeaturesUnknownAtForecastTime))
            {
                if (FeaturesUnknownAtForecastTime != null)
                {
                    writer.WritePropertyName("featuresUnknownAtForecastTime"u8);
                    writer.WriteStartArray();
                    foreach (var item in FeaturesUnknownAtForecastTime)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("featuresUnknownAtForecastTime");
                }
            }
            if (Optional.IsDefined(ForecastHorizon))
            {
                writer.WritePropertyName("forecastHorizon"u8);
                writer.WriteObjectValue(ForecastHorizon);
            }
            if (Optional.IsDefined(Frequency))
            {
                if (Frequency != null)
                {
                    writer.WritePropertyName("frequency"u8);
                    writer.WriteStringValue(Frequency);
                }
                else
                {
                    writer.WriteNull("frequency");
                }
            }
            if (Optional.IsDefined(Seasonality))
            {
                writer.WritePropertyName("seasonality"u8);
                writer.WriteObjectValue(Seasonality);
            }
            if (Optional.IsDefined(ShortSeriesHandlingConfig))
            {
                writer.WritePropertyName("shortSeriesHandlingConfig"u8);
                writer.WriteStringValue(ShortSeriesHandlingConfig.Value.ToString());
            }
            if (Optional.IsDefined(TargetAggregateFunction))
            {
                writer.WritePropertyName("targetAggregateFunction"u8);
                writer.WriteStringValue(TargetAggregateFunction.Value.ToString());
            }
            if (Optional.IsDefined(TargetLags))
            {
                if (TargetLags != null)
                {
                    writer.WritePropertyName("targetLags"u8);
                    writer.WriteObjectValue(TargetLags);
                }
                else
                {
                    writer.WriteNull("targetLags");
                }
            }
            if (Optional.IsDefined(TargetRollingWindowSize))
            {
                if (TargetRollingWindowSize != null)
                {
                    writer.WritePropertyName("targetRollingWindowSize"u8);
                    writer.WriteObjectValue(TargetRollingWindowSize);
                }
                else
                {
                    writer.WriteNull("targetRollingWindowSize");
                }
            }
            if (Optional.IsDefined(TimeColumnName))
            {
                if (TimeColumnName != null)
                {
                    writer.WritePropertyName("timeColumnName"u8);
                    writer.WriteStringValue(TimeColumnName);
                }
                else
                {
                    writer.WriteNull("timeColumnName");
                }
            }
            if (Optional.IsCollectionDefined(TimeSeriesIdColumnNames))
            {
                if (TimeSeriesIdColumnNames != null)
                {
                    writer.WritePropertyName("timeSeriesIdColumnNames"u8);
                    writer.WriteStartArray();
                    foreach (var item in TimeSeriesIdColumnNames)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("timeSeriesIdColumnNames");
                }
            }
            if (Optional.IsDefined(UseStl))
            {
                writer.WritePropertyName("useStl"u8);
                writer.WriteStringValue(UseStl.Value.ToString());
            }
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

        ForecastingSettings IJsonModel<ForecastingSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForecastingSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ForecastingSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeForecastingSettings(document.RootElement, options);
        }

        internal static ForecastingSettings DeserializeForecastingSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string countryOrRegionForHolidays = default;
            int? cvStepSize = default;
            MachineLearningFeatureLag? featureLags = default;
            IList<string> featuresUnknownAtForecastTime = default;
            ForecastHorizon forecastHorizon = default;
            string frequency = default;
            ForecastingSeasonality seasonality = default;
            MachineLearningShortSeriesHandlingConfiguration? shortSeriesHandlingConfig = default;
            TargetAggregationFunction? targetAggregateFunction = default;
            TargetLags targetLags = default;
            TargetRollingWindowSize targetRollingWindowSize = default;
            string timeColumnName = default;
            IList<string> timeSeriesIdColumnNames = default;
            MachineLearningUseStl? useStl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("countryOrRegionForHolidays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        countryOrRegionForHolidays = null;
                        continue;
                    }
                    countryOrRegionForHolidays = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cvStepSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cvStepSize = null;
                        continue;
                    }
                    cvStepSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("featureLags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    featureLags = new MachineLearningFeatureLag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("featuresUnknownAtForecastTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        featuresUnknownAtForecastTime = null;
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    featuresUnknownAtForecastTime = array;
                    continue;
                }
                if (property.NameEquals("forecastHorizon"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    forecastHorizon = ForecastHorizon.DeserializeForecastHorizon(property.Value, options);
                    continue;
                }
                if (property.NameEquals("frequency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        frequency = null;
                        continue;
                    }
                    frequency = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("seasonality"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    seasonality = ForecastingSeasonality.DeserializeForecastingSeasonality(property.Value, options);
                    continue;
                }
                if (property.NameEquals("shortSeriesHandlingConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shortSeriesHandlingConfig = new MachineLearningShortSeriesHandlingConfiguration(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetAggregateFunction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetAggregateFunction = new TargetAggregationFunction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetLags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        targetLags = null;
                        continue;
                    }
                    targetLags = TargetLags.DeserializeTargetLags(property.Value, options);
                    continue;
                }
                if (property.NameEquals("targetRollingWindowSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        targetRollingWindowSize = null;
                        continue;
                    }
                    targetRollingWindowSize = TargetRollingWindowSize.DeserializeTargetRollingWindowSize(property.Value, options);
                    continue;
                }
                if (property.NameEquals("timeColumnName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        timeColumnName = null;
                        continue;
                    }
                    timeColumnName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeSeriesIdColumnNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        timeSeriesIdColumnNames = null;
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    timeSeriesIdColumnNames = array;
                    continue;
                }
                if (property.NameEquals("useStl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useStl = new MachineLearningUseStl(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ForecastingSettings(
                countryOrRegionForHolidays,
                cvStepSize,
                featureLags,
                featuresUnknownAtForecastTime ?? new ChangeTrackingList<string>(),
                forecastHorizon,
                frequency,
                seasonality,
                shortSeriesHandlingConfig,
                targetAggregateFunction,
                targetLags,
                targetRollingWindowSize,
                timeColumnName,
                timeSeriesIdColumnNames ?? new ChangeTrackingList<string>(),
                useStl,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ForecastingSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForecastingSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ForecastingSettings)} does not support '{options.Format}' format.");
            }
        }

        ForecastingSettings IPersistableModel<ForecastingSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForecastingSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeForecastingSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ForecastingSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ForecastingSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
