// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class RouterWorker : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(_queueAssignments))
            {
                writer.WritePropertyName("queueAssignments");
                writer.WriteStartObject();
                foreach (var item in _queueAssignments)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(TotalCapacity))
            {
                writer.WritePropertyName("totalCapacity");
                writer.WriteNumberValue(TotalCapacity.Value);
            }
            if (Optional.IsCollectionDefined(_labels))
            {
                writer.WritePropertyName("labels");
                writer.WriteStartObject();
                foreach (var item in _labels)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(_tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in _tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(ChannelConfigurations))
            {
                writer.WritePropertyName("channelConfigurations");
                writer.WriteStartObject();
                foreach (var item in ChannelConfigurations)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(AvailableForOffers))
            {
                writer.WritePropertyName("availableForOffers");
                writer.WriteBooleanValue(AvailableForOffers.Value);
            }
            writer.WriteEndObject();
        }

        internal static RouterWorker DeserializeRouterWorker(JsonElement element)
        {
            Optional<string> id = default;
            Optional<RouterWorkerState> state = default;
            Optional<IDictionary<string, object>> queueAssignments = default;
            Optional<int> totalCapacity = default;
            Optional<IDictionary<string, object>> labels = default;
            Optional<IDictionary<string, object>> tags = default;
            Optional<IDictionary<string, ChannelConfiguration>> channelConfigurations = default;
            Optional<IReadOnlyList<JobOffer>> offers = default;
            Optional<IReadOnlyList<WorkerAssignment>> assignedJobs = default;
            Optional<double> loadRatio = default;
            Optional<bool> availableForOffers = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    state = new RouterWorkerState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("queueAssignments"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetObject());
                    }
                    queueAssignments = dictionary;
                    continue;
                }
                if (property.NameEquals("totalCapacity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalCapacity = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("labels"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetObject());
                    }
                    labels = dictionary;
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetObject());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("channelConfigurations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, ChannelConfiguration> dictionary = new Dictionary<string, ChannelConfiguration>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ChannelConfiguration.DeserializeChannelConfiguration(property0.Value));
                    }
                    channelConfigurations = dictionary;
                    continue;
                }
                if (property.NameEquals("offers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<JobOffer> array = new List<JobOffer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JobOffer.DeserializeJobOffer(item));
                    }
                    offers = array;
                    continue;
                }
                if (property.NameEquals("assignedJobs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<WorkerAssignment> array = new List<WorkerAssignment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WorkerAssignment.DeserializeWorkerAssignment(item));
                    }
                    assignedJobs = array;
                    continue;
                }
                if (property.NameEquals("loadRatio"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    loadRatio = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("availableForOffers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    availableForOffers = property.Value.GetBoolean();
                    continue;
                }
            }
            return new RouterWorker(id.Value, Optional.ToNullable(state), Optional.ToDictionary(queueAssignments), Optional.ToNullable(totalCapacity), Optional.ToDictionary(labels), Optional.ToDictionary(tags), Optional.ToDictionary(channelConfigurations), Optional.ToList(offers), Optional.ToList(assignedJobs), Optional.ToNullable(loadRatio), Optional.ToNullable(availableForOffers));
        }
    }
}
