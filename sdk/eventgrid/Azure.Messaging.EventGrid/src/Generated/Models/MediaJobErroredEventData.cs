// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.Models
{
    /// <summary> Job error state event data. </summary>
    public partial class MediaJobErroredEventData : MediaJobStateChangeEventData
    {
        /// <summary> Initializes a new instance of MediaJobErroredEventData. </summary>
        internal MediaJobErroredEventData()
        {
        }

        /// <summary> Initializes a new instance of MediaJobErroredEventData. </summary>
        /// <param name="previousState"> The previous state of the Job. </param>
        /// <param name="state"> The new state of the Job. </param>
        /// <param name="correlationData"> Gets the Job correlation data. </param>
        /// <param name="outputs"> Gets the Job outputs. </param>
        internal MediaJobErroredEventData(MediaJobState? previousState, MediaJobState? state, IReadOnlyDictionary<string, string> correlationData, IReadOnlyList<MediaJobOutput> outputs) : base(previousState, state, correlationData)
        {
            Outputs = outputs;
        }

        /// <summary> Gets the Job outputs. </summary>
        public IReadOnlyList<MediaJobOutput> Outputs { get; }
    }
}
