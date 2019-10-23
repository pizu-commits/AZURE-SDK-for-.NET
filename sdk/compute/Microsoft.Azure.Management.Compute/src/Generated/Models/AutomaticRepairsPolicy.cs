// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Specifies the configuration parameters for automatic repairs on the
    /// virtual machine scale set.
    /// </summary>
    public partial class AutomaticRepairsPolicy
    {
        /// <summary>
        /// Initializes a new instance of the AutomaticRepairsPolicy class.
        /// </summary>
        public AutomaticRepairsPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutomaticRepairsPolicy class.
        /// </summary>
        /// <param name="enabled">Specifies whether automatic repairs should be
        /// enabled on the virtual machine scale set. The default value is
        /// false.</param>
        /// <param name="gracePeriod">The amount of time for which automatic
        /// repairs are suspended due to a state change on VM. The grace time
        /// starts after the state change has completed. This helps avoid
        /// premature or accidental repairs. The time duration should be
        /// specified in ISO 8601 format. The default value is 5 minutes
        /// (PT5M).</param>
        /// <param name="maxInstanceRepairsPercent">The percentage (capacity of
        /// scaleset) of virtual machines that will be simultaneously repaired.
        /// The default value is 20%.</param>
        public AutomaticRepairsPolicy(bool? enabled = default(bool?), string gracePeriod = default(string), int? maxInstanceRepairsPercent = default(int?))
        {
            Enabled = enabled;
            GracePeriod = gracePeriod;
            MaxInstanceRepairsPercent = maxInstanceRepairsPercent;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies whether automatic repairs should be enabled
        /// on the virtual machine scale set. The default value is false.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets the amount of time for which automatic repairs are
        /// suspended due to a state change on VM. The grace time starts after
        /// the state change has completed. This helps avoid premature or
        /// accidental repairs. The time duration should be specified in ISO
        /// 8601 format. The default value is 5 minutes (PT5M).
        /// </summary>
        [JsonProperty(PropertyName = "gracePeriod")]
        public string GracePeriod { get; set; }

        /// <summary>
        /// Gets or sets the percentage (capacity of scaleset) of virtual
        /// machines that will be simultaneously repaired. The default value is
        /// 20%.
        /// </summary>
        [JsonProperty(PropertyName = "maxInstanceRepairsPercent")]
        public int? MaxInstanceRepairsPercent { get; set; }

    }
}
