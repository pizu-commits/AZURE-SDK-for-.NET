// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Peering.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The properties that define a direct peering.
    /// </summary>
    public partial class PeeringPropertiesDirect
    {
        /// <summary>
        /// Initializes a new instance of the PeeringPropertiesDirect class.
        /// </summary>
        public PeeringPropertiesDirect()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PeeringPropertiesDirect class.
        /// </summary>
        /// <param name="connections">The set of connections that constitute a
        /// direct peering.</param>
        /// <param name="peerAsn">The Autonomous System Number (ASN) associated
        /// with the peering.</param>
        /// <param name="useForPeeringService">The flag that indicates whether
        /// or not the peering is used for peering service.</param>
        public PeeringPropertiesDirect(IList<DirectConnection> connections = default(IList<DirectConnection>), int? peerAsn = default(int?), bool? useForPeeringService = default(bool?))
        {
            Connections = connections;
            PeerAsn = peerAsn;
            UseForPeeringService = useForPeeringService;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the set of connections that constitute a direct
        /// peering.
        /// </summary>
        [JsonProperty(PropertyName = "connections")]
        public IList<DirectConnection> Connections { get; set; }

        /// <summary>
        /// Gets or sets the Autonomous System Number (ASN) associated with the
        /// peering.
        /// </summary>
        [JsonProperty(PropertyName = "peerAsn")]
        public int? PeerAsn { get; set; }

        /// <summary>
        /// Gets or sets the flag that indicates whether or not the peering is
        /// used for peering service.
        /// </summary>
        [JsonProperty(PropertyName = "useForPeeringService")]
        public bool? UseForPeeringService { get; set; }

    }
}
