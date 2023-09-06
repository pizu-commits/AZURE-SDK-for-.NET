// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> Contains Provisioning errors. </summary>
    public partial class ProvisionedClustersCommonPropertiesStatusProvisioningStatus
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ProvisionedClustersCommonPropertiesStatusProvisioningStatus"/>. </summary>
        internal ProvisionedClustersCommonPropertiesStatusProvisioningStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProvisionedClustersCommonPropertiesStatusProvisioningStatus"/>. </summary>
        /// <param name="error"></param>
        /// <param name="operationId"></param>
        /// <param name="phase"> Phase represents the current phase of cluster actuation. E.g. Pending, Running, Terminating, Failed etc. </param>
        /// <param name="status"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ProvisionedClustersCommonPropertiesStatusProvisioningStatus(ProvisionedClustersCommonPropertiesStatusProvisioningStatusError error, string operationId, string phase, string status, Dictionary<string, BinaryData> rawData)
        {
            Error = error;
            OperationId = operationId;
            Phase = phase;
            Status = status;
            _rawData = rawData;
        }

        /// <summary> Gets the error. </summary>
        public ProvisionedClustersCommonPropertiesStatusProvisioningStatusError Error { get; }
        /// <summary> Gets the operation id. </summary>
        public string OperationId { get; }
        /// <summary> Phase represents the current phase of cluster actuation. E.g. Pending, Running, Terminating, Failed etc. </summary>
        public string Phase { get; }
        /// <summary> Gets the status. </summary>
        public string Status { get; }
    }
}
