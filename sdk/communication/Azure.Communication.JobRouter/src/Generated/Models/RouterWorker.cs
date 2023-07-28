// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Communication.JobRouter;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> An entity for jobs to be routed to. </summary>
    public partial class RouterWorker
    {
        /// <summary> Initializes a new instance of RouterWorker. </summary>
        /// <param name="id"></param>
        /// <param name="state"> The current state of the worker. </param>
        /// <param name="queueAssignments"> The queue(s) that this worker can receive work from. </param>
        /// <param name="totalCapacity"> The total capacity score this worker has to manage multiple concurrent jobs. </param>
        /// <param name="labels"> A set of key/value pairs that are identifying attributes used by the rules engines to make decisions. </param>
        /// <param name="tags"> A set of non-identifying attributes attached to this worker. </param>
        /// <param name="channelConfigurations"> The channel(s) this worker can handle and their impact on the workers capacity. </param>
        /// <param name="offers"> A list of active offers issued to this worker. </param>
        /// <param name="assignedJobs"> A list of assigned jobs attached to this worker. </param>
        /// <param name="loadRatio"> A value indicating the workers capacity. A value of '1' means all capacity is consumed. A value of '0' means no capacity is currently consumed. </param>
        /// <param name="availableForOffers"> A flag indicating this worker is open to receive offers or not. </param>
        internal RouterWorker(string id, RouterWorkerState? state, IDictionary<string, object> queueAssignments, int? totalCapacity, IDictionary<string, object> labels, IDictionary<string, object> tags, IDictionary<string, ChannelConfiguration> channelConfigurations, IReadOnlyList<RouterJobOffer> offers, IReadOnlyList<RouterWorkerAssignment> assignedJobs, double? loadRatio, bool? availableForOffers)
        {
            Id = id;
            State = state;
            _queueAssignments = queueAssignments;
            TotalCapacity = totalCapacity;
            _labels = labels;
            _tags = tags;
            _channelConfigurations = channelConfigurations;
            Offers = offers;
            AssignedJobs = assignedJobs;
            LoadRatio = loadRatio;
            AvailableForOffers = availableForOffers;
        }

        /// <summary> Gets the id. </summary>
        public string Id { get; }
        /// <summary> The current state of the worker. </summary>
        public RouterWorkerState? State { get; }
        /// <summary> A list of active offers issued to this worker. </summary>
        public IReadOnlyList<RouterJobOffer> Offers { get; }
        /// <summary> A list of assigned jobs attached to this worker. </summary>
        public IReadOnlyList<RouterWorkerAssignment> AssignedJobs { get; }
        /// <summary> A value indicating the workers capacity. A value of '1' means all capacity is consumed. A value of '0' means no capacity is currently consumed. </summary>
        public double? LoadRatio { get; }
    }
}
