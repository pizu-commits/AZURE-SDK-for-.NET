// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> Hybrid Connection limits contract. This is used to return the plan limits of Hybrid Connections. </summary>
    public partial class HybridConnectionLimits : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of HybridConnectionLimits. </summary>
        public HybridConnectionLimits()
        {
        }

        /// <summary> Initializes a new instance of HybridConnectionLimits. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource Name. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="current"> The current number of Hybrid Connections. </param>
        /// <param name="maximum"> The maximum number of Hybrid Connections allowed. </param>
        internal HybridConnectionLimits(string id, string name, string kind, string type, int? current, int? maximum) : base(id, name, kind, type)
        {
            Current = current;
            Maximum = maximum;
        }

        /// <summary> The current number of Hybrid Connections. </summary>
        public int? Current { get; }
        /// <summary> The maximum number of Hybrid Connections allowed. </summary>
        public int? Maximum { get; }
    }
}
