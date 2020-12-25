// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.Models
{
    /// <summary> Properties of an event published to an Event Grid topic using the CloudEvent 1.0 Schema. </summary>
    internal partial class CloudEventInternal : IDictionary<string, object>
    {
        /// <summary> Initializes a new instance of CloudEventInternal. </summary>
        /// <param name="id"> An identifier for the event. The combination of id and source must be unique for each distinct event. </param>
        /// <param name="source"> Identifies the context in which an event happened. The combination of id and source must be unique for each distinct event. </param>
        /// <param name="type"> Type of event related to the originating occurrence. </param>
        /// <param name="specversion"> The version of the CloudEvents specification which the event uses. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="source"/>, <paramref name="type"/>, or <paramref name="specversion"/> is null. </exception>
        public CloudEventInternal(string id, string source, string type, string specversion)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }
            if (specversion == null)
            {
                throw new ArgumentNullException(nameof(specversion));
            }

            Id = id;
            Source = source;
            Type = type;
            Specversion = specversion;
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of CloudEventInternal. </summary>
        /// <param name="id"> An identifier for the event. The combination of id and source must be unique for each distinct event. </param>
        /// <param name="source"> Identifies the context in which an event happened. The combination of id and source must be unique for each distinct event. </param>
        /// <param name="data"> Event data specific to the event type. </param>
        /// <param name="dataBase64"> Event data specific to the event type, encoded as a base64 string. </param>
        /// <param name="type"> Type of event related to the originating occurrence. </param>
        /// <param name="time"> The time (in UTC) the event was generated, in RFC3339 format. </param>
        /// <param name="specversion"> The version of the CloudEvents specification which the event uses. </param>
        /// <param name="dataschema"> Identifies the schema that data adheres to. </param>
        /// <param name="datacontenttype"> Content type of data value. </param>
        /// <param name="subject"> This describes the subject of the event in the context of the event producer (identified by source). </param>
        /// <param name="additionalProperties"> . </param>
        internal CloudEventInternal(string id, string source, JsonElement data, byte[] dataBase64, string type, DateTimeOffset? time, string specversion, string dataschema, string datacontenttype, string subject, IDictionary<string, object> additionalProperties)
        {
            Id = id;
            Source = source;
            Data = data;
            DataBase64 = dataBase64;
            Type = type;
            Time = time;
            Specversion = specversion;
            Dataschema = dataschema;
            Datacontenttype = datacontenttype;
            Subject = subject;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> An identifier for the event. The combination of id and source must be unique for each distinct event. </summary>
        public string Id { get; set; }
        /// <summary> Identifies the context in which an event happened. The combination of id and source must be unique for each distinct event. </summary>
        public string Source { get; set; }
        /// <summary> Event data specific to the event type, encoded as a base64 string. </summary>
        public byte[] DataBase64 { get; set; }
        /// <summary> Type of event related to the originating occurrence. </summary>
        public string Type { get; set; }
        /// <summary> The time (in UTC) the event was generated, in RFC3339 format. </summary>
        public DateTimeOffset? Time { get; set; }
        /// <summary> The version of the CloudEvents specification which the event uses. </summary>
        public string Specversion { get; set; }
        /// <summary> Identifies the schema that data adheres to. </summary>
        public string Dataschema { get; set; }
        /// <summary> Content type of data value. </summary>
        public string Datacontenttype { get; set; }
        /// <summary> This describes the subject of the event in the context of the event producer (identified by source). </summary>
        public string Subject { get; set; }
        internal IDictionary<string, object> AdditionalProperties { get; }
        /// <inheritdoc />
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        public bool TryGetValue(string key, out object value) => AdditionalProperties.TryGetValue(key, out value);
        /// <inheritdoc />
        public bool ContainsKey(string key) => AdditionalProperties.ContainsKey(key);
        /// <inheritdoc />
        public ICollection<string> Keys => AdditionalProperties.Keys;
        /// <inheritdoc />
        public ICollection<object> Values => AdditionalProperties.Values;
        /// <inheritdoc cref="ICollection{T}.Count"/>
        int ICollection<KeyValuePair<string, object>>.Count => AdditionalProperties.Count;
        /// <inheritdoc />
        public void Add(string key, object value) => AdditionalProperties.Add(key, value);
        /// <inheritdoc />
        public bool Remove(string key) => AdditionalProperties.Remove(key);
        /// <inheritdoc cref="ICollection{T}.IsReadOnly"/>
        bool ICollection<KeyValuePair<string, object>>.IsReadOnly => AdditionalProperties.IsReadOnly;
        /// <inheritdoc cref="ICollection{T}.Add"/>
        void ICollection<KeyValuePair<string, object>>.Add(KeyValuePair<string, object> value) => AdditionalProperties.Add(value);
        /// <inheritdoc cref="ICollection{T}.Remove"/>
        bool ICollection<KeyValuePair<string, object>>.Remove(KeyValuePair<string, object> value) => AdditionalProperties.Remove(value);
        /// <inheritdoc cref="ICollection{T}.Contains"/>
        bool ICollection<KeyValuePair<string, object>>.Contains(KeyValuePair<string, object> value) => AdditionalProperties.Contains(value);
        /// <inheritdoc cref="ICollection{T}.CopyTo"/>
        void ICollection<KeyValuePair<string, object>>.CopyTo(KeyValuePair<string, object>[] destination, int offset) => AdditionalProperties.CopyTo(destination, offset);
        /// <inheritdoc cref="ICollection{T}.Clear"/>
        void ICollection<KeyValuePair<string, object>>.Clear() => AdditionalProperties.Clear();
        /// <inheritdoc />
        public object this[string key]
        {
            get => AdditionalProperties[key];
            set => AdditionalProperties[key] = value;
        }
    }
}
