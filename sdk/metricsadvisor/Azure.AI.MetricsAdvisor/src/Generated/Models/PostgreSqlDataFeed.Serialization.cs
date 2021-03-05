// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class PostgreSqlDataFeed : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DataSourceParameter))
            {
                writer.WritePropertyName("dataSourceParameter");
                writer.WriteObjectValue(DataSourceParameter);
            }
            writer.WritePropertyName("dataSourceType");
            writer.WriteStringValue(DataSourceType.ToString());
            writer.WritePropertyName("dataFeedName");
            writer.WriteStringValue(DataFeedName);
            if (Optional.IsDefined(DataFeedDescription))
            {
                writer.WritePropertyName("dataFeedDescription");
                writer.WriteStringValue(DataFeedDescription);
            }
            writer.WritePropertyName("granularityName");
            writer.WriteStringValue(GranularityName.ToString());
            if (Optional.IsDefined(GranularityAmount))
            {
                if (GranularityAmount != null)
                {
                    writer.WritePropertyName("granularityAmount");
                    writer.WriteNumberValue(GranularityAmount.Value);
                }
                else
                {
                    writer.WriteNull("granularityAmount");
                }
            }
            writer.WritePropertyName("metrics");
            writer.WriteStartArray();
            foreach (var item in Metrics)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(Dimension))
            {
                writer.WritePropertyName("dimension");
                writer.WriteStartArray();
                foreach (var item in Dimension)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TimestampColumn))
            {
                writer.WritePropertyName("timestampColumn");
                writer.WriteStringValue(TimestampColumn);
            }
            writer.WritePropertyName("dataStartFrom");
            writer.WriteStringValue(DataStartFrom, "O");
            if (Optional.IsDefined(StartOffsetInSeconds))
            {
                writer.WritePropertyName("startOffsetInSeconds");
                writer.WriteNumberValue(StartOffsetInSeconds.Value);
            }
            if (Optional.IsDefined(MaxConcurrency))
            {
                writer.WritePropertyName("maxConcurrency");
                writer.WriteNumberValue(MaxConcurrency.Value);
            }
            if (Optional.IsDefined(MinRetryIntervalInSeconds))
            {
                writer.WritePropertyName("minRetryIntervalInSeconds");
                writer.WriteNumberValue(MinRetryIntervalInSeconds.Value);
            }
            if (Optional.IsDefined(StopRetryAfterInSeconds))
            {
                writer.WritePropertyName("stopRetryAfterInSeconds");
                writer.WriteNumberValue(StopRetryAfterInSeconds.Value);
            }
            if (Optional.IsDefined(NeedRollup))
            {
                writer.WritePropertyName("needRollup");
                writer.WriteStringValue(NeedRollup.Value.ToString());
            }
            if (Optional.IsDefined(RollUpMethod))
            {
                writer.WritePropertyName("rollUpMethod");
                writer.WriteStringValue(RollUpMethod.Value.ToString());
            }
            if (Optional.IsCollectionDefined(RollUpColumns))
            {
                writer.WritePropertyName("rollUpColumns");
                writer.WriteStartArray();
                foreach (var item in RollUpColumns)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AllUpIdentification))
            {
                writer.WritePropertyName("allUpIdentification");
                writer.WriteStringValue(AllUpIdentification);
            }
            if (Optional.IsDefined(FillMissingPointType))
            {
                writer.WritePropertyName("fillMissingPointType");
                writer.WriteStringValue(FillMissingPointType.Value.ToString());
            }
            if (Optional.IsDefined(FillMissingPointValue))
            {
                writer.WritePropertyName("fillMissingPointValue");
                writer.WriteNumberValue(FillMissingPointValue.Value);
            }
            if (Optional.IsDefined(ViewMode))
            {
                writer.WritePropertyName("viewMode");
                writer.WriteStringValue(ViewMode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Admins))
            {
                writer.WritePropertyName("admins");
                writer.WriteStartArray();
                foreach (var item in Admins)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Viewers))
            {
                writer.WritePropertyName("viewers");
                writer.WriteStartArray();
                foreach (var item in Viewers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ActionLinkTemplate))
            {
                writer.WritePropertyName("actionLinkTemplate");
                writer.WriteStringValue(ActionLinkTemplate);
            }
            writer.WriteEndObject();
        }

        internal static PostgreSqlDataFeed DeserializePostgreSqlDataFeed(JsonElement element)
        {
            Optional<SqlSourceParameter> dataSourceParameter = default;
            DataFeedSourceType dataSourceType = default;
            Optional<string> dataFeedId = default;
            string dataFeedName = default;
            Optional<string> dataFeedDescription = default;
            DataFeedGranularityType granularityName = default;
            Optional<int?> granularityAmount = default;
            IList<DataFeedMetric> metrics = default;
            Optional<IList<DataFeedDimension>> dimension = default;
            Optional<string> timestampColumn = default;
            DateTimeOffset dataStartFrom = default;
            Optional<long> startOffsetInSeconds = default;
            Optional<int> maxConcurrency = default;
            Optional<long> minRetryIntervalInSeconds = default;
            Optional<long> stopRetryAfterInSeconds = default;
            Optional<DataFeedRollupType> needRollup = default;
            Optional<RollUpMethod> rollUpMethod = default;
            Optional<IList<string>> rollUpColumns = default;
            Optional<string> allUpIdentification = default;
            Optional<DataFeedMissingDataPointFillType> fillMissingPointType = default;
            Optional<double> fillMissingPointValue = default;
            Optional<DataFeedAccessMode> viewMode = default;
            Optional<IList<string>> admins = default;
            Optional<IList<string>> viewers = default;
            Optional<bool> isAdmin = default;
            Optional<string> creator = default;
            Optional<EntityStatus> status = default;
            Optional<DateTimeOffset> createdTime = default;
            Optional<string> actionLinkTemplate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataSourceParameter"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dataSourceParameter = SqlSourceParameter.DeserializeSqlSourceParameter(property.Value);
                    continue;
                }
                if (property.NameEquals("dataSourceType"))
                {
                    dataSourceType = new DataFeedSourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataFeedId"))
                {
                    dataFeedId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataFeedName"))
                {
                    dataFeedName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataFeedDescription"))
                {
                    dataFeedDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("granularityName"))
                {
                    granularityName = new DataFeedGranularityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("granularityAmount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        granularityAmount = null;
                        continue;
                    }
                    granularityAmount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("metrics"))
                {
                    List<DataFeedMetric> array = new List<DataFeedMetric>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataFeedMetric.DeserializeDataFeedMetric(item));
                    }
                    metrics = array;
                    continue;
                }
                if (property.NameEquals("dimension"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DataFeedDimension> array = new List<DataFeedDimension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataFeedDimension.DeserializeDataFeedDimension(item));
                    }
                    dimension = array;
                    continue;
                }
                if (property.NameEquals("timestampColumn"))
                {
                    timestampColumn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataStartFrom"))
                {
                    dataStartFrom = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startOffsetInSeconds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startOffsetInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maxConcurrency"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxConcurrency = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minRetryIntervalInSeconds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minRetryIntervalInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("stopRetryAfterInSeconds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    stopRetryAfterInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("needRollup"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    needRollup = new DataFeedRollupType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rollUpMethod"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rollUpMethod = new RollUpMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rollUpColumns"))
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
                    rollUpColumns = array;
                    continue;
                }
                if (property.NameEquals("allUpIdentification"))
                {
                    allUpIdentification = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fillMissingPointType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fillMissingPointType = new DataFeedMissingDataPointFillType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fillMissingPointValue"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fillMissingPointValue = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("viewMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    viewMode = new DataFeedAccessMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("admins"))
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
                    admins = array;
                    continue;
                }
                if (property.NameEquals("viewers"))
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
                    viewers = array;
                    continue;
                }
                if (property.NameEquals("isAdmin"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isAdmin = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("creator"))
                {
                    creator = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new EntityStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createdTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("actionLinkTemplate"))
                {
                    actionLinkTemplate = property.Value.GetString();
                    continue;
                }
            }
            return new PostgreSqlDataFeed(dataSourceType, dataFeedId.Value, dataFeedName, dataFeedDescription.Value, granularityName, Optional.ToNullable(granularityAmount), metrics, Optional.ToList(dimension), timestampColumn.Value, dataStartFrom, Optional.ToNullable(startOffsetInSeconds), Optional.ToNullable(maxConcurrency), Optional.ToNullable(minRetryIntervalInSeconds), Optional.ToNullable(stopRetryAfterInSeconds), Optional.ToNullable(needRollup), Optional.ToNullable(rollUpMethod), Optional.ToList(rollUpColumns), allUpIdentification.Value, Optional.ToNullable(fillMissingPointType), Optional.ToNullable(fillMissingPointValue), Optional.ToNullable(viewMode), Optional.ToList(admins), Optional.ToList(viewers), Optional.ToNullable(isAdmin), creator.Value, Optional.ToNullable(status), Optional.ToNullable(createdTime), actionLinkTemplate.Value, dataSourceParameter.Value);
        }
    }
}
