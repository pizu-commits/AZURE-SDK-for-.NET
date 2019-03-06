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
    /// The peering prefix properties class.
    /// </summary>
    public partial class PeeringPrefixProperties
    {
        /// <summary>
        /// Initializes a new instance of the PeeringPrefixProperties class.
        /// </summary>
        public PeeringPrefixProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PeeringPrefixProperties class.
        /// </summary>
        /// <param name="prefix">Gets or sets the prefix.</param>
        /// <param name="validationState">Gets or sets the prefix validation
        /// state. Possible values include: 'None', 'Invalid', 'Verified',
        /// 'Failed', 'Pending', 'Unknown'</param>
        /// <param name="learnedType">Gets or sets the prefix path. Possible
        /// values include: 'None', 'ViaPartner', 'ViaSession'</param>
        /// <param name="provisioningState">Gets or sets the provisioning
        /// state. Not set by frontend (readonly by user). Possible values
        /// include: 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        public PeeringPrefixProperties(string prefix = default(string), string validationState = default(string), string learnedType = default(string), string provisioningState = default(string))
        {
            Prefix = prefix;
            ValidationState = validationState;
            LearnedType = learnedType;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the prefix.
        /// </summary>
        [JsonProperty(PropertyName = "prefix")]
        public string Prefix { get; set; }

        /// <summary>
        /// Gets or sets the prefix validation state. Possible values include:
        /// 'None', 'Invalid', 'Verified', 'Failed', 'Pending', 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "validationState")]
        public string ValidationState { get; set; }

        /// <summary>
        /// Gets or sets the prefix path. Possible values include: 'None',
        /// 'ViaPartner', 'ViaSession'
        /// </summary>
        [JsonProperty(PropertyName = "learnedType")]
        public string LearnedType { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state. Not set by frontend (readonly
        /// by user). Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; set; }

    }
}
