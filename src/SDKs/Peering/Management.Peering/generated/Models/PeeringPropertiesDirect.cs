// <auto-generated>
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
    /// The peering properties direct class.
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
        /// <param name="connections">Gets or sets the list of peering
        /// connections.</param>
        /// <param name="useForPeeringService">Gets or sets a value indicating
        /// whether or not to use this for partner peering service.</param>
        public PeeringPropertiesDirect(IList<DirectConnection> connections = default(IList<DirectConnection>), bool? useForPeeringService = default(bool?))
        {
            Connections = connections;
            UseForPeeringService = useForPeeringService;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of peering connections.
        /// </summary>
        [JsonProperty(PropertyName = "connections")]
        public IList<DirectConnection> Connections { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not to use this for
        /// partner peering service.
        /// </summary>
        [JsonProperty(PropertyName = "useForPeeringService")]
        public bool? UseForPeeringService { get; set; }

    }
}
