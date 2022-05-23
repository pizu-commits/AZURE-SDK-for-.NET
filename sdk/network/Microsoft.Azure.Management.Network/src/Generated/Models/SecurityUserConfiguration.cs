// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines the security user configuration
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SecurityUserConfiguration : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the SecurityUserConfiguration class.
        /// </summary>
        public SecurityUserConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SecurityUserConfiguration class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="description">A description of the security user
        /// configuration.</param>
        /// <param name="deleteExistingNSGs">Flag if need to delete existing
        /// network security groups. Possible values include: 'False',
        /// 'True'</param>
        /// <param name="provisioningState">The provisioning state of the
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'</param>
        /// <param name="systemData">The system metadata related to this
        /// resource.</param>
        public SecurityUserConfiguration(string id = default(string), string name = default(string), string type = default(string), string etag = default(string), string description = default(string), string deleteExistingNSGs = default(string), string provisioningState = default(string), SystemData systemData = default(SystemData))
            : base(id, name, type, etag)
        {
            Description = description;
            DeleteExistingNSGs = deleteExistingNSGs;
            ProvisioningState = provisioningState;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a description of the security user configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets flag if need to delete existing network security
        /// groups. Possible values include: 'False', 'True'
        /// </summary>
        [JsonProperty(PropertyName = "properties.deleteExistingNSGs")]
        public string DeleteExistingNSGs { get; set; }

        /// <summary>
        /// Gets the provisioning state of the resource. Possible values
        /// include: 'Succeeded', 'Updating', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the system metadata related to this resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

    }
}
