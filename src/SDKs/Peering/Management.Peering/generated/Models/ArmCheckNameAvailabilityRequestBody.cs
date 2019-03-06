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
    /// The ARM subscription class.
    /// </summary>
    public partial class ArmCheckNameAvailabilityRequestBody
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ArmCheckNameAvailabilityRequestBody class.
        /// </summary>
        public ArmCheckNameAvailabilityRequestBody()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ArmCheckNameAvailabilityRequestBody class.
        /// </summary>
        /// <param name="name">Gets or sets the name.</param>
        /// <param name="type">Gets or sets the type.</param>
        public ArmCheckNameAvailabilityRequestBody(string name = default(string), string type = default(string))
        {
            Name = name;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
