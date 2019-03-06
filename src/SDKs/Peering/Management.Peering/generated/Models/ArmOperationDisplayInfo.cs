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
    /// The ARM operation display information class.
    /// </summary>
    public partial class ArmOperationDisplayInfo
    {
        /// <summary>
        /// Initializes a new instance of the ArmOperationDisplayInfo class.
        /// </summary>
        public ArmOperationDisplayInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ArmOperationDisplayInfo class.
        /// </summary>
        /// <param name="provider">Gets or sets the provider.</param>
        /// <param name="resource">Gets or sets the resource.</param>
        /// <param name="operation">Gets or sets the operation.</param>
        /// <param name="description">Gets or sets the description.</param>
        public ArmOperationDisplayInfo(string provider = default(string), string resource = default(string), string operation = default(string), string description = default(string))
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets the resource.
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; set; }

        /// <summary>
        /// Gets or sets the operation.
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}
