﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Messaging.EventHubs.Processor
{
    /// <summary>
    ///   TODO.
    /// </summary>
    ///
    public class PartitionContext
    {
        /// <summary>
        ///   TODO.
        /// </summary>
        ///
        public string PartitionId { get; }

        /// <summary>
        ///   The path of the specific Event Hub that the client is connected to, relative
        ///   to the Event Hubs namespace that contains it.
        /// </summary>
        ///
        public string EventHubName { get; }

        /// <summary>
        ///   TODO.
        /// </summary>
        ///
        public string ConsumerGroup { get; }

        /// <summary>
        ///   TODO.
        /// </summary>
        ///
        internal PartitionContext(string partitionId,
                                  string eventHubName,
                                  string consumerGroup)
        {
            PartitionId = partitionId;
            EventHubName = eventHubName;
            ConsumerGroup = consumerGroup;
        }
    }
}
