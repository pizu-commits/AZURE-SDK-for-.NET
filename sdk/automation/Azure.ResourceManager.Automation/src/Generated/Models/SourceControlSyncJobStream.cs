// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Definition of the source control sync job stream. </summary>
    public partial class SourceControlSyncJobStream
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SourceControlSyncJobStream"/>. </summary>
        internal SourceControlSyncJobStream()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SourceControlSyncJobStream"/>. </summary>
        /// <param name="id"> Resource id. </param>
        /// <param name="sourceControlSyncJobStreamId"> The sync job stream id. </param>
        /// <param name="summary"> The summary of the sync job stream. </param>
        /// <param name="time"> The time of the sync job stream. </param>
        /// <param name="streamType"> The type of the sync job stream. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SourceControlSyncJobStream(ResourceIdentifier id, string sourceControlSyncJobStreamId, string summary, DateTimeOffset? time, SourceControlStreamType? streamType, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            SourceControlSyncJobStreamId = sourceControlSyncJobStreamId;
            Summary = summary;
            Time = time;
            StreamType = streamType;
            _rawData = rawData;
        }

        /// <summary> Resource id. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> The sync job stream id. </summary>
        public string SourceControlSyncJobStreamId { get; }
        /// <summary> The summary of the sync job stream. </summary>
        public string Summary { get; }
        /// <summary> The time of the sync job stream. </summary>
        public DateTimeOffset? Time { get; }
        /// <summary> The type of the sync job stream. </summary>
        public SourceControlStreamType? StreamType { get; }
    }
}
