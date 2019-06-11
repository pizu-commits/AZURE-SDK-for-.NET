﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.Messaging.EventHubs.Core
{
    /// <summary>
    ///   Provides an abstraction for generalizing an Event Receiver so that a dedicated instance may provide operations
    ///   for a specific transport, such as AMQP or JMS.  It is intended that the public <see cref="EventReceiver" /> employ
    ///   a transport receiver via containment and delegate operations to it rather than understanding protocol-specific details
    ///   for different transports.
    /// </summary>
    ///
    internal abstract class TransportEventReceiver
    {
        /// <summary>
        ///   Receives a bach of <see cref="EventData" /> from the the Event Hub partition.
        /// </summary>
        ///
        /// <param name="maximumMessageCount">The maximum number of messages to receive in this batch.</param>
        /// <param name="maximumWaitTime">The maximum amount of time to wait to build up the requested message count for the batch; if not specified, the default wait time specified when the receiver was created will be used.</param>
        /// <param name="cancellationToken">An optional <see cref="CancellationToken"/> instance to signal the request to cancel the operation.</param>
        ///
        /// <returns>The batch of <see cref="EventData" /> from the Event Hub partition this receiver is associated with.  If no events are present, an empty enumerable is returned.</returns>
        ///
        public abstract Task<IEnumerable<EventData>> ReceiveAsync(int maximumMessageCount,
                                                                  TimeSpan? maximumWaitTime,
                                                                  CancellationToken cancellationToken);

        /// <summary>
        ///   Closes the connection to the transport sender instance.
        /// </summary>
        ///
        /// <param name="cancellationToken">An optional <see cref="CancellationToken"/> instance to signal the request to cancel the operation.</param>
        ///
        public abstract Task CloseAsync(CancellationToken cancellationToken);
    }
}
