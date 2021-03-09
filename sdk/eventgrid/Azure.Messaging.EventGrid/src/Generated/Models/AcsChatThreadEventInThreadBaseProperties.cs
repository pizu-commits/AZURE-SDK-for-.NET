// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of common properties of all chat thread events. </summary>
    public partial class AcsChatThreadEventInThreadBaseProperties : AcsChatEventInThreadBaseProperties
    {
        /// <summary> Initializes a new instance of AcsChatThreadEventInThreadBaseProperties. </summary>
        internal AcsChatThreadEventInThreadBaseProperties()
        {
        }

        /// <summary> Initializes a new instance of AcsChatThreadEventInThreadBaseProperties. </summary>
        /// <param name="threadId"> The chat thread id. </param>
        /// <param name="createTime"> The original creation time of the thread. </param>
        /// <param name="version"> The version of the thread. </param>
        internal AcsChatThreadEventInThreadBaseProperties(string threadId, DateTimeOffset? createTime, long? version) : base(threadId)
        {
            CreateTime = createTime;
            Version = version;
        }

        /// <summary> The original creation time of the thread. </summary>
        public DateTimeOffset? CreateTime { get; }
        /// <summary> The version of the thread. </summary>
        public long? Version { get; }
    }
}
