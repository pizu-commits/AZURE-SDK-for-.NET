// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.NetApp;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Replication properties. </summary>
    public partial class NetAppVolumeReplication
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeReplication"/>. </summary>
        /// <param name="remoteVolumeResourceId"> The resource ID of the remote volume. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="remoteVolumeResourceId"/> is null. </exception>
        internal NetAppVolumeReplication(ResourceIdentifier remoteVolumeResourceId)
        {
            Argument.AssertNotNull(remoteVolumeResourceId, nameof(remoteVolumeResourceId));

            RemoteVolumeResourceId = remoteVolumeResourceId;
        }

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeReplication"/>. </summary>
        /// <param name="endpointType"> Indicates whether the local volume is the source or destination for the Volume Replication. </param>
        /// <param name="replicationSchedule"> Schedule. </param>
        /// <param name="remoteVolumeResourceId"> The resource ID of the remote volume. </param>
        /// <param name="remoteVolumeRegion"> The remote region for the other end of the Volume Replication. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetAppVolumeReplication(NetAppEndpointType? endpointType, NetAppReplicationSchedule? replicationSchedule, ResourceIdentifier remoteVolumeResourceId, string remoteVolumeRegion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EndpointType = endpointType;
            ReplicationSchedule = replicationSchedule;
            RemoteVolumeResourceId = remoteVolumeResourceId;
            RemoteVolumeRegion = remoteVolumeRegion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeReplication"/> for deserialization. </summary>
        internal NetAppVolumeReplication()
        {
        }

        /// <summary> Indicates whether the local volume is the source or destination for the Volume Replication. </summary>
        public NetAppEndpointType? EndpointType { get; }
        /// <summary> Schedule. </summary>
        public NetAppReplicationSchedule? ReplicationSchedule { get; }
        /// <summary> The resource ID of the remote volume. </summary>
        public ResourceIdentifier RemoteVolumeResourceId { get; }
        /// <summary> The remote region for the other end of the Volume Replication. </summary>
        public string RemoteVolumeRegion { get; }
    }
}
