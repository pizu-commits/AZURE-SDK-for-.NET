// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> Request payload for creating or updating a Classification Policy. </summary>
    internal partial class UpsertClassificationPolicyRequest
    {
        /// <summary> Initializes a new instance of UpsertClassificationPolicyRequest. </summary>
        /// <param name="id"> Unique identifier of this policy. Required upon policy creation or updating a classification policy. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public UpsertClassificationPolicyRequest(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            Id = id;
            WorkerSelectors = new ChangeTrackingList<LabelSelectorAttachment>();
        }

        /// <summary> Unique identifier of this policy. Required upon policy creation or updating a classification policy. </summary>
        public string Id { get; }
        /// <summary> Friendly name of this policy. </summary>
        public string Name { get; set; }
        /// <summary> The fallback queue to select if the queue selector doesn&apos;t find a match. </summary>
        public string FallbackQueueId { get; set; }
        /// <summary> The queue selector to select a queue for a given job. </summary>
        public QueueSelector QueueSelector { get; set; }
        /// <summary> The rule to determine a priority score for a given job. </summary>
        public RouterRule PrioritizationRule { get; set; }
    }
}
