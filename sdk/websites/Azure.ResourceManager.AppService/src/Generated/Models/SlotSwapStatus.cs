// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The status of the last successful slot swap operation. </summary>
    public partial class SlotSwapStatus
    {
        /// <summary> Initializes a new instance of <see cref="SlotSwapStatus"/>. </summary>
        internal SlotSwapStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SlotSwapStatus"/>. </summary>
        /// <param name="timestampUtc"> The time the last successful slot swap completed. </param>
        /// <param name="sourceSlotName"> The source slot of the last swap operation. </param>
        /// <param name="destinationSlotName"> The destination slot of the last swap operation. </param>
        internal SlotSwapStatus(DateTimeOffset? timestampUtc, string sourceSlotName, string destinationSlotName)
        {
            TimestampUtc = timestampUtc;
            SourceSlotName = sourceSlotName;
            DestinationSlotName = destinationSlotName;
        }

        /// <summary> The time the last successful slot swap completed. </summary>
        public DateTimeOffset? TimestampUtc { get; }
        /// <summary> The source slot of the last swap operation. </summary>
        public string SourceSlotName { get; }
        /// <summary> The destination slot of the last swap operation. </summary>
        public string DestinationSlotName { get; }
    }
}
