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
    /// The peering location properties class.
    /// </summary>
    public partial class PeeringLocationPropertiesDirect
    {
        /// <summary>
        /// Initializes a new instance of the PeeringLocationPropertiesDirect
        /// class.
        /// </summary>
        public PeeringLocationPropertiesDirect()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PeeringLocationPropertiesDirect
        /// class.
        /// </summary>
        /// <param name="peeringFacilities">Gets or sets the peering facilities
        /// available at the location.</param>
        /// <param name="bandwidthOffers">Gets or sets the bandwidth offers
        /// available at the location.</param>
        public PeeringLocationPropertiesDirect(IList<DirectPeeringFacility> peeringFacilities = default(IList<DirectPeeringFacility>), IList<PeeringBandwidthOffer> bandwidthOffers = default(IList<PeeringBandwidthOffer>))
        {
            PeeringFacilities = peeringFacilities;
            BandwidthOffers = bandwidthOffers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the peering facilities available at the location.
        /// </summary>
        [JsonProperty(PropertyName = "peeringFacilities")]
        public IList<DirectPeeringFacility> PeeringFacilities { get; set; }

        /// <summary>
        /// Gets or sets the bandwidth offers available at the location.
        /// </summary>
        [JsonProperty(PropertyName = "bandwidthOffers")]
        public IList<PeeringBandwidthOffer> BandwidthOffers { get; set; }

    }
}
