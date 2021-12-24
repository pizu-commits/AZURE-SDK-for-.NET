// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.ConnectedVMware;

namespace Azure.ResourceManager.ConnectedVMware.Models
{
    /// <summary> List of Clusters. </summary>
    internal partial class ClustersList
    {
        /// <summary> Initializes a new instance of ClustersList. </summary>
        /// <param name="value"> Array of Clusters. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ClustersList(IEnumerable<VmwareClusterData> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of ClustersList. </summary>
        /// <param name="nextLink"> Url to follow for getting next page of Clusters. </param>
        /// <param name="value"> Array of Clusters. </param>
        internal ClustersList(string nextLink, IReadOnlyList<VmwareClusterData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> Url to follow for getting next page of Clusters. </summary>
        public string NextLink { get; }
        /// <summary> Array of Clusters. </summary>
        public IReadOnlyList<VmwareClusterData> Value { get; }
    }
}
