// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using Azure.Communication.JobRouter;
using Azure.Core;

namespace Azure.Communication.SkillsRegistry
{
    /// <summary>
    /// Options for escalating a job from an intent.
    /// </summary>
    public class EscalateOptions
    {
        /// <summary>
        /// Public constructor.
        /// </summary>
        /// <param name="jobId"> The Id of the Job. </param>
        /// <param name="intentId"> The Id of the Intent. </param>
        /// <param name="channelId"> The Id of the Channel. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="intentId"/> is null. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="channelId"/> is null. </exception>
        public EscalateOptions(string jobId, string intentId, string channelId)
        {
            Argument.AssertNotNullOrWhiteSpace(jobId, nameof(jobId));
            Argument.AssertNotNullOrWhiteSpace(intentId, nameof(intentId));
            Argument.AssertNotNullOrWhiteSpace(channelId, nameof(channelId));

            JobId = jobId;
            IntentId = intentId;
            ChannelId = channelId;
        }

        /// <summary>
        /// The Id of the job to be created
        /// </summary>
        public string JobId { get; }

        /// <summary>
        /// The intent Id associated with the conversation
        /// </summary>
        public string IntentId { get; }

        /// <summary>
        /// The channel Id of the job to be created
        /// </summary>
        public string ChannelId { get; }

        /// <summary>
        /// A set of parameter results from an intent
        /// </summary>
        public IDictionary<string, LabelValue> Parameters { get; } = new Dictionary<string, LabelValue>();
    }
}
