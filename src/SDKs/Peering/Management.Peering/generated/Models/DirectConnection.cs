// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Peering.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The peering session configuration class.
    /// </summary>
    public partial class DirectConnection
    {
        /// <summary>
        /// Initializes a new instance of the DirectConnection class.
        /// </summary>
        public DirectConnection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DirectConnection class.
        /// </summary>
        /// <param name="bandwidthInMbps">Gets or sets the bandwidth in
        /// Mbps.</param>
        /// <param name="peeringDBFacilityId">Gets or sets the facility id. Set
        /// by frontend on add. Cannot be updated.</param>
        /// <param name="connectionState">The state of the connection with
        /// Microsoft. Possible values include: 'None', 'PendingApproval',
        /// 'Approved', 'ProvisioningStarted', 'ProvisioningFailed',
        /// 'ProvisioningCompleted', 'Validating', 'Active'</param>
        /// <param name="bgpSession">Gets or sets the BGP session.</param>
        public DirectConnection(int? bandwidthInMbps = default(int?), int? peeringDBFacilityId = default(int?), string connectionState = default(string), BgpSession bgpSession = default(BgpSession))
        {
            BandwidthInMbps = bandwidthInMbps;
            PeeringDBFacilityId = peeringDBFacilityId;
            ConnectionState = connectionState;
            BgpSession = bgpSession;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the bandwidth in Mbps.
        /// </summary>
        [JsonProperty(PropertyName = "bandwidthInMbps")]
        public int? BandwidthInMbps { get; set; }

        /// <summary>
        /// Gets or sets the facility id. Set by frontend on add. Cannot be
        /// updated.
        /// </summary>
        [JsonProperty(PropertyName = "peeringDBFacilityId")]
        public int? PeeringDBFacilityId { get; set; }

        /// <summary>
        /// Gets or sets the state of the connection with Microsoft. Possible
        /// values include: 'None', 'PendingApproval', 'Approved',
        /// 'ProvisioningStarted', 'ProvisioningFailed',
        /// 'ProvisioningCompleted', 'Validating', 'Active'
        /// </summary>
        [JsonProperty(PropertyName = "connectionState")]
        public string ConnectionState { get; set; }

        /// <summary>
        /// Gets or sets the BGP session.
        /// </summary>
        [JsonProperty(PropertyName = "bgpSession")]
        public BgpSession BgpSession { get; set; }

    }
}
