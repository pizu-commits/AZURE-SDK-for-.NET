﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Core.Serialization;
using Azure.Messaging.EventGrid.Models;

namespace Azure.Messaging.EventGrid
{
    /// <summary> Properties of an event published to an Event Grid topic using the EventGrid Schema. </summary>
    public class EventGridEvent
    {
        /// <summary> Initializes a new instance of EventGridEvent. </summary>
        /// <param name="subject"> A resource path relative to the topic path. </param>
        /// <param name="data"> Event data specific to the event type. </param>
        /// <param name="eventType"> The type of the event that occurred. </param>
        /// <param name="dataVersion"> The schema version of the data object. </param>
        public EventGridEvent(object data, string subject, string eventType, string dataVersion)
        {
            Argument.AssertNotNull(subject, nameof(subject));
            Argument.AssertNotNull(data, nameof(data));
            Argument.AssertNotNull(eventType, nameof(eventType));
            Argument.AssertNotNull(dataVersion, nameof(dataVersion));

            Subject = subject;
            Data = data;
            EventType = eventType;
            DataVersion = dataVersion;
        }

        /// <summary> Initializes a new instance of EventGridEvent. </summary>
        /// <param name="subject"> A resource path relative to the topic path. </param>
        /// <param name="data"> Event data specific to the event type. </param>
        /// <param name="eventType"> The type of the event that occurred. </param>
        /// <param name="dataVersion"> The schema version of the data object. </param>
        public EventGridEvent(BinaryData data, string subject, string eventType, string dataVersion)
        {
            Argument.AssertNotNull(subject, nameof(subject));
            Argument.AssertNotNull(eventType, nameof(eventType));
            Argument.AssertNotNull(dataVersion, nameof(dataVersion));

            Subject = subject;
            Data = data;
            EventType = eventType;
            DataVersion = dataVersion;
        }

        internal EventGridEvent()
        {
        }

        /// <summary> An unique identifier for the event. </summary>
        public string Id { get; set; } = Guid.NewGuid().ToString();

        /// <summary> The resource path of the event source. </summary>
        public string Topic { get; set; }

        /// <summary> A resource path relative to the topic path. </summary>
        public string Subject { get; set; }

        /// <summary> The type of the event that occurred. </summary>
        public string EventType { get; set; }

        /// <summary> The time (in UTC) the event was generated. </summary>
        public DateTimeOffset EventTime { get; set; } = DateTimeOffset.UtcNow;

        /// <summary> The schema version of the data object. </summary>
        public string DataVersion { get; set; }

        /// <summary> Event data specific to the event type. </summary>
        internal object Data { get; set; }

        /// <summary> Serialized event data specific to the event type. </summary>
        internal JsonElement SerializedData { get; set; }

        /// <summary> Indicates whether event was created from the Parse() method. </summary>
        private bool CreatedFromParse { get; set; } = false;

        /// <summary>
        /// Parses JSON encoded events and returns an array of events encoded in the EventGridEvent schema.
        /// </summary>
        /// <param name="requestContent"> The JSON encoded representation of either a single event or an array or events, encoded in the EventGridEvent schema. </param>
        /// <returns> A list of EventGridEvents. </returns>
        public static EventGridEvent[] Parse(BinaryData requestContent)
            => Parse(requestContent.ToString());

        /// <summary>
        /// Parses JSON encoded events and returns an array of events encoded in the EventGridEvent schema.
        /// </summary>
        /// <param name="requestContent"> The JSON encoded representation of either a single event or an array or events, encoded in the EventGridEvent schema. </param>
        /// <returns> A list of EventGridEvents. </returns>
        public static EventGridEvent[] Parse(string requestContent)
        {
            List<EventGridEventInternal> egEventsInternal = new List<EventGridEventInternal>();
            List<EventGridEvent> egEvents = new List<EventGridEvent>();
            JsonDocument requestDocument;
            using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(requestContent)))
            {
                requestDocument = JsonDocument.Parse(stream);
            }

            // Parse JsonElement into separate events, deserialize event envelope properties
            if (requestDocument.RootElement.ValueKind == JsonValueKind.Object)
            {
                egEventsInternal.Add(EventGridEventInternal.DeserializeEventGridEventInternal(requestDocument.RootElement));
            }
            else if (requestDocument.RootElement.ValueKind == JsonValueKind.Array)
            {
                foreach (JsonElement property in requestDocument.RootElement.EnumerateArray())
                {
                    egEventsInternal.Add(EventGridEventInternal.DeserializeEventGridEventInternal(property));
                }
            }

            foreach (EventGridEventInternal egEventInternal in egEventsInternal)
            {
                EventGridEvent egEvent = new EventGridEvent()
                {
                    Subject = egEventInternal.Subject,
                    EventType = egEventInternal.EventType,
                    DataVersion = egEventInternal.DataVersion,
                    Id = egEventInternal.Id,
                    EventTime = egEventInternal.EventTime,
                    SerializedData = egEventInternal.Data,
                    CreatedFromParse = true
                };

                // Try to eagerly deserialize if system event data
                if (SystemEventTypeMappings.SystemEventDeserializers.TryGetValue(egEventInternal.EventType, out Func<JsonElement, object> systemDeserializationFunction))
                {
                    egEvent.Data = systemDeserializationFunction(egEventInternal.Data);
                }
                egEvents.Add(egEvent);
            }

            return egEvents.ToArray();
        }

        /// <summary>
        /// Deserializes the event payload into a specified event type.
        /// </summary>
        /// <typeparam name="T"> Describing the type of the event. </typeparam>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> Deserialized payload of the event. </returns>
        public T GetData<T>(CancellationToken cancellationToken = default)
            => GetDataInternal<T>(new JsonObjectSerializer(), false, cancellationToken).EnsureCompleted();

        /// <summary>
        /// Deserializes the event payload into a specified event type.
        /// </summary>
        /// <typeparam name="T"> Describing the type of the event. </typeparam>
        /// <param name="serializer"> Custom serializer used to deserialize the payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> Deserialized payload of the event. </returns>
        public async Task<T> GetDataAsync<T>(ObjectSerializer serializer, CancellationToken cancellationToken = default)
            => await GetDataInternal<T>(serializer, true, cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Deserializes the event payload into a specified event type.
        /// </summary>
        /// <typeparam name="T"> Describing the type of the event. </typeparam>
        /// <param name="serializer"> Custom serializer used to deserialize the payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="InvalidOperationException"> Event was not created from EventGridEvent.Parse(). </exception>
        /// <returns> Deserialized payload of the event. </returns>
        public T GetData<T>(ObjectSerializer serializer, CancellationToken cancellationToken = default)
            => GetDataInternal<T>(serializer, false, cancellationToken).EnsureCompleted();

        private async Task<T> GetDataInternal<T>(ObjectSerializer serializer, bool async, CancellationToken cancellationToken = default)
        {
            if (!CreatedFromParse)
            {
                throw new InvalidOperationException("Cannot call GetData<T>() method if event was not created from EventGridEvent.Parse()");
            }

            Argument.AssertNotNull(serializer, nameof(serializer));

            if (Data != null)
            {
                return (T)Data;
            }
            else
            {
                // Reserialize JsonElement to stream
                using (MemoryStream dataStream = SerializePayloadToStream(SerializedData, new JsonObjectSerializer(), cancellationToken))
                {
                    if (async)
                    {
                        return (T)await serializer.DeserializeAsync(dataStream, typeof(T), cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        return (T)serializer.Deserialize(dataStream, typeof(T), cancellationToken);
                    }
                }
            }
        }

        /// <summary>
        /// Deserializes the event payload into a system event type or
        /// returns the payload of the event wrapped as BinaryData. Using BinaryData,
        /// one can deserialize the payload into rich data, or access the raw JSON data using ToString().
        /// </summary>
        /// <returns>
        /// Deserialized payload of the event.
        /// Returns BinaryData for unknown event types.
        /// </returns>
        public object GetData()
        {
            if (Data != null)
            {
                return Data;
            }

            // Reserialize JsonElement to stream
            return BinaryData.FromStream(SerializePayloadToStream(SerializedData, new JsonObjectSerializer()));
        }

        private static MemoryStream SerializePayloadToStream(object payload, ObjectSerializer serializer, CancellationToken cancellationToken = default)
        {
            MemoryStream dataStream = new MemoryStream();
            serializer.Serialize(dataStream, payload, payload.GetType(), cancellationToken);
            dataStream.Position = 0;
            return dataStream;
        }
    }
}
