// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the update webhook operation. </summary>
    public partial class AutomationWebhookPatch
    {
        /// <summary> Initializes a new instance of AutomationWebhookPatch. </summary>
        public AutomationWebhookPatch()
        {
            Parameters = new Core.ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Gets or sets the name of the webhook. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the value of the enabled flag of webhook. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> Gets or sets the name of the hybrid worker group the webhook job will run on. </summary>
        public string RunOn { get; set; }
        /// <summary> Gets or sets the parameters of the job. </summary>
        public IDictionary<string, string> Parameters { get; }
        /// <summary> Gets or sets the description of the webhook. </summary>
        public string Description { get; set; }
    }
}
