// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The UnknownWebhook. </summary>
    internal partial class UnknownWebhook : MachineLearningWebhook
    {
        /// <summary> Initializes a new instance of <see cref="UnknownWebhook"/>. </summary>
        /// <param name="eventType"> Send callback on a specified notification event. </param>
        /// <param name="webhookType"> [Required] Specifies the type of service to send a callback. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownWebhook(string eventType, MachineLearningWebhookType webhookType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(eventType, webhookType, serializedAdditionalRawData)
        {
            WebhookType = webhookType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownWebhook"/> for deserialization. </summary>
        internal UnknownWebhook()
        {
        }
    }
}
