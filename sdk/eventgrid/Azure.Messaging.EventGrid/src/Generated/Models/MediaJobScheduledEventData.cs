// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.Models
{
    /// <summary> Job scheduled event data. </summary>
    public partial class MediaJobScheduledEventData : MediaJobStateChangeEventData
    {
        /// <summary> Initializes a new instance of MediaJobScheduledEventData. </summary>
        internal MediaJobScheduledEventData()
        {
        }

        /// <summary> Initializes a new instance of MediaJobScheduledEventData. </summary>
        /// <param name="previousState"> The previous state of the Job. </param>
        /// <param name="state"> The new state of the Job. </param>
        /// <param name="correlationData"> Gets the Job correlation data. </param>
        internal MediaJobScheduledEventData(MediaJobState? previousState, MediaJobState? state, IReadOnlyDictionary<string, string> correlationData) : base(previousState, state, correlationData)
        {
        }
    }
}
