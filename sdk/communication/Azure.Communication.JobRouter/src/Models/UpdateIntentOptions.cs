// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using Azure.Communication.JobRouter;
using Azure.Communication.JobRouter.Models;
using Azure.Core;

namespace Azure.Communication.SkillsRegistry
{
    /// <summary>
    /// Options for updating a intent.
    /// </summary>
    public class UpdateIntentOptions
    {
        /// <summary>
        /// Public constructor.
        /// </summary>
        /// <param name="intentId"> Id of the intent. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="intentId"/> is null. </exception>
        public UpdateIntentOptions(string intentId)
        {
            Argument.AssertNotNullOrWhiteSpace(intentId, nameof(intentId));

            IntentId = intentId;
        }

        /// <summary> The Id of this intent. </summary>
        public string IntentId { get; }

        /// <summary> A set of parameters that associated with this intent. </summary>
        public IDictionary<string, IntentParameter> Parameters { get; } = new Dictionary<string, IntentParameter>();

        /// <summary> The description of this intent. </summary>
        public string? Description { get; set; }

        /// <summary> The queue Id to escalate this conversation to. </summary>
        public string? EscalationQueueId { get; set; }

        /// <summary> Whether or not to analyze the sentiment of the conversation. </summary>
        public bool? AnalyzeSentiment { get; set; }

        /// <summary> Provide a summary of the conversation. </summary>
        public bool? SummarizeConversation { get; set; }

        /// <summary> Detect whether a request to speak to a human occurred. </summary>
        public bool? DetectEscalation { get; set; }
    }
}
