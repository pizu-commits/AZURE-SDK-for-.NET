// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Read-only endpoint of the failover group instance. </summary>
    internal partial class FailoverGroupReadOnlyEndpoint
    {
        /// <summary> Initializes a new instance of FailoverGroupReadOnlyEndpoint. </summary>
        public FailoverGroupReadOnlyEndpoint()
        {
        }

        /// <summary> Initializes a new instance of FailoverGroupReadOnlyEndpoint. </summary>
        /// <param name="failoverPolicy"> Failover policy of the read-only endpoint for the failover group. </param>
        internal FailoverGroupReadOnlyEndpoint(ReadOnlyEndpointFailoverPolicy? failoverPolicy)
        {
            FailoverPolicy = failoverPolicy;
        }

        /// <summary> Failover policy of the read-only endpoint for the failover group. </summary>
        public ReadOnlyEndpointFailoverPolicy? FailoverPolicy { get; set; }
    }
}
