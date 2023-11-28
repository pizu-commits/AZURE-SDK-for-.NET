// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Recovery plan test failover input. </summary>
    public partial class RecoveryPlanTestFailoverContent
    {
        /// <summary> Initializes a new instance of <see cref="RecoveryPlanTestFailoverContent"/>. </summary>
        /// <param name="properties"> The recovery plan test failover input properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public RecoveryPlanTestFailoverContent(RecoveryPlanTestFailoverProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> The recovery plan test failover input properties. </summary>
        public RecoveryPlanTestFailoverProperties Properties { get; }
    }
}
