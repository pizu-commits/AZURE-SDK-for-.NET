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
    /// The peering SKU class.
    /// </summary>
    public partial class PeeringSku
    {
        /// <summary>
        /// Initializes a new instance of the PeeringSku class.
        /// </summary>
        public PeeringSku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PeeringSku class.
        /// </summary>
        /// <param name="name">Gets or sets the peering SKU name. Possible
        /// values include: 'Basic_Exchange_Free', 'Basic_Direct_Free',
        /// 'Premium_Direct_Free', 'Premium_Partner_Metered',
        /// 'Premium_Exchange_Metered'</param>
        /// <param name="tier">Gets or sets the peering SKU tier. Possible
        /// values include: 'Basic', 'Premium'</param>
        /// <param name="family">Gets or sets the peering SKU family. Possible
        /// values include: 'Direct', 'Exchange', 'Partner'</param>
        /// <param name="size">Gets or sets the peering SKU size. Possible
        /// values include: 'Free', 'Metered', 'Unlimited'</param>
        public PeeringSku(string name = default(string), string tier = default(string), string family = default(string), string size = default(string))
        {
            Name = name;
            Tier = tier;
            Family = family;
            Size = size;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the peering SKU name. Possible values include:
        /// 'Basic_Exchange_Free', 'Basic_Direct_Free', 'Premium_Direct_Free',
        /// 'Premium_Partner_Metered', 'Premium_Exchange_Metered'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the peering SKU tier. Possible values include:
        /// 'Basic', 'Premium'
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

        /// <summary>
        /// Gets or sets the peering SKU family. Possible values include:
        /// 'Direct', 'Exchange', 'Partner'
        /// </summary>
        [JsonProperty(PropertyName = "family")]
        public string Family { get; set; }

        /// <summary>
        /// Gets or sets the peering SKU size. Possible values include: 'Free',
        /// 'Metered', 'Unlimited'
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public string Size { get; set; }

    }
}
