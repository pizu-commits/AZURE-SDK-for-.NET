// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Network;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The routes table associated with the ExpressRouteCircuit.
    /// </summary>
    public partial class ExpressRouteCircuitRoutesTableSummary
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ExpressRouteCircuitRoutesTableSummary class.
        /// </summary>
        public ExpressRouteCircuitRoutesTableSummary()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ExpressRouteCircuitRoutesTableSummary class.
        /// </summary>
        /// <param name="neighbor">Neighbor</param>
        /// <param name="v">BGP version number spoken to the neighbor.</param>
        /// <param name="asProperty">Autonomous system number.</param>
        /// <param name="upDown">The length of time that the BGP session has
        /// been in the Established state, or the current status if not in the
        /// Established state.</param>
        /// <param name="statePfxRcd">Current state of the BGP session, and the
        /// number of prefixes that have been received from a neighbor or peer
        /// group.</param>
        public ExpressRouteCircuitRoutesTableSummary(string neighbor = default(string), int? v = default(int?), int? asProperty = default(int?), string upDown = default(string), string statePfxRcd = default(string))
        {
            Neighbor = neighbor;
            V = v;
            AsProperty = asProperty;
            UpDown = upDown;
            StatePfxRcd = statePfxRcd;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets neighbor
        /// </summary>
        [JsonProperty(PropertyName = "neighbor")]
        public string Neighbor { get; set; }

        /// <summary>
        /// Gets or sets BGP version number spoken to the neighbor.
        /// </summary>
        [JsonProperty(PropertyName = "v")]
        public int? V { get; set; }

        /// <summary>
        /// Gets or sets autonomous system number.
        /// </summary>
        [JsonProperty(PropertyName = "as")]
        public int? AsProperty { get; set; }

        /// <summary>
        /// Gets or sets the length of time that the BGP session has been in
        /// the Established state, or the current status if not in the
        /// Established state.
        /// </summary>
        [JsonProperty(PropertyName = "upDown")]
        public string UpDown { get; set; }

        /// <summary>
        /// Gets or sets current state of the BGP session, and the number of
        /// prefixes that have been received from a neighbor or peer group.
        /// </summary>
        [JsonProperty(PropertyName = "statePfxRcd")]
        public string StatePfxRcd { get; set; }

    }
}
