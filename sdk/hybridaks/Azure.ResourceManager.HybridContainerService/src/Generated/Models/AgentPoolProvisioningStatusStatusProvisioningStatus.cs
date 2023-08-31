// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> Contains Provisioning errors. </summary>
    public partial class AgentPoolProvisioningStatusStatusProvisioningStatus
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AgentPoolProvisioningStatusStatusProvisioningStatus"/>. </summary>
        public AgentPoolProvisioningStatusStatusProvisioningStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AgentPoolProvisioningStatusStatusProvisioningStatus"/>. </summary>
        /// <param name="error"></param>
        /// <param name="operationId"></param>
        /// <param name="phase"> Phase represents the current phase of cluster actuation. E.g. Pending, Running, Terminating, Failed etc. </param>
        /// <param name="status"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AgentPoolProvisioningStatusStatusProvisioningStatus(AgentPoolProvisioningStatusError error, string operationId, string phase, string status, Dictionary<string, BinaryData> rawData)
        {
            Error = error;
            OperationId = operationId;
            Phase = phase;
            Status = status;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the error. </summary>
        public AgentPoolProvisioningStatusError Error { get; set; }
        /// <summary> Gets or sets the operation id. </summary>
        public string OperationId { get; set; }
        /// <summary> Phase represents the current phase of cluster actuation. E.g. Pending, Running, Terminating, Failed etc. </summary>
        public string Phase { get; set; }
        /// <summary> Gets or sets the status. </summary>
        public string Status { get; set; }
    }
}
