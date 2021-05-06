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
    public partial class DetectorAbnormalTimePeriod : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(StartTime))
            {
                writer.WritePropertyName("startTime");
                writer.WriteStringValue(StartTime.Value, "O");
            }
            if (Optional.IsDefined(EndTime))
            {
                writer.WritePropertyName("endTime");
                writer.WriteStringValue(EndTime.Value, "O");
            }
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message");
                writer.WriteStringValue(Message);
            }
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source");
                writer.WriteStringValue(Source);
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority");
                writer.WriteNumberValue(Priority.Value);
            }
            if (Optional.IsCollectionDefined(MetaData))
            {
                writer.WritePropertyName("metaData");
                writer.WriteStartArray();
                foreach (var item in MetaData)
                {
                    writer.WriteStartArray();
                    foreach (var item0 in item)
                    {
                        writer.WriteObjectValue(item0);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(Solutions))
            {
                writer.WritePropertyName("solutions");
                writer.WriteStartArray();
                foreach (var item in Solutions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static DetectorAbnormalTimePeriod DeserializeDetectorAbnormalTimePeriod(JsonElement element)
        {
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<string> message = default;
            Optional<string> source = default;
            Optional<double> priority = default;
            Optional<IList<IList<NameValuePair>>> metaData = default;
            Optional<IssueType> type = default;
            Optional<IList<Solution>> solutions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("priority"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    priority = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("metaData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IList<NameValuePair>> array = new List<IList<NameValuePair>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        List<NameValuePair> array0 = new List<NameValuePair>();
                        foreach (var item0 in item.EnumerateArray())
                        {
                            array0.Add(NameValuePair.DeserializeNameValuePair(item0));
                        }
                        array.Add(array0);
                    }
                    metaData = array;
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = property.Value.GetString().ToIssueType();
                    continue;
                }
                if (property.NameEquals("solutions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Solution> array = new List<Solution>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Solution.DeserializeSolution(item));
                    }
                    solutions = array;
                    continue;
                }
            }
            return new DetectorAbnormalTimePeriod(Optional.ToNullable(startTime), Optional.ToNullable(endTime), message.Value, source.Value, Optional.ToNullable(priority), Optional.ToList(metaData), Optional.ToNullable(type), Optional.ToList(solutions));
        }
    }
}
