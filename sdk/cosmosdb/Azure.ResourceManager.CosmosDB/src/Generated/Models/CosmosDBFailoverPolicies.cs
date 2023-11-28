// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The list of new failover policies for the failover priority change. </summary>
    public partial class CosmosDBFailoverPolicies
    {
        /// <summary> Initializes a new instance of <see cref="CosmosDBFailoverPolicies"/>. </summary>
        /// <param name="failoverPolicies"> List of failover policies. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverPolicies"/> is null. </exception>
        public CosmosDBFailoverPolicies(IEnumerable<CosmosDBFailoverPolicy> failoverPolicies)
        {
            Argument.AssertNotNull(failoverPolicies, nameof(failoverPolicies));

            FailoverPolicies = failoverPolicies.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBFailoverPolicies"/>. </summary>
        /// <param name="failoverPolicies"> List of failover policies. </param>
        internal CosmosDBFailoverPolicies(IList<CosmosDBFailoverPolicy> failoverPolicies)
        {
            FailoverPolicies = failoverPolicies;
        }

        /// <summary> List of failover policies. </summary>
        public IList<CosmosDBFailoverPolicy> FailoverPolicies { get; }
    }
}
