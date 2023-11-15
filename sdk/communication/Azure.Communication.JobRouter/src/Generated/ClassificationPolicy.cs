// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    /// <summary> A container for the rules that govern how jobs are classified. </summary>
    public partial class ClassificationPolicy
    {
        /// <summary> Initializes a new instance of ClassificationPolicy. </summary>
        internal ClassificationPolicy()
        {
            QueueSelectorAttachments = new ChangeTrackingList<QueueSelectorAttachment>();
            WorkerSelectorAttachments = new ChangeTrackingList<WorkerSelectorAttachment>();
        }

        /// <summary> Initializes a new instance of ClassificationPolicy. </summary>
        /// <param name="etag"> The entity tag for this resource. </param>
        /// <param name="id"> Id of a classification policy. </param>
        /// <param name="name"> Friendly name of this policy. </param>
        /// <param name="fallbackQueueId"> Id of a fallback queue to select if queue selector attachments doesn't find a match. </param>
        /// <param name="queueSelectorAttachments"> Queue selector attachments used to resolve a queue for a job. </param>
        /// <param name="prioritizationRule"> A rule to determine a priority score for a job. </param>
        /// <param name="workerSelectorAttachments"> Worker selector attachments used to attach worker selectors to a job. </param>
        internal ClassificationPolicy(string etag, string id, string name, string fallbackQueueId, IList<QueueSelectorAttachment> queueSelectorAttachments, RouterRule prioritizationRule, IList<WorkerSelectorAttachment> workerSelectorAttachments)
        {
            _etag = etag;
            Id = id;
            Name = name;
            FallbackQueueId = fallbackQueueId;
            QueueSelectorAttachments = queueSelectorAttachments;
            PrioritizationRule = prioritizationRule;
            WorkerSelectorAttachments = workerSelectorAttachments;
        }
        /// <summary> Id of a classification policy. </summary>
        public string Id { get; }
    }
}
