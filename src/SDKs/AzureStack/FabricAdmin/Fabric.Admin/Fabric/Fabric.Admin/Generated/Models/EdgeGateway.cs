// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.AzureStack.Management.Fabric.Admin.Models
{
    using Microsoft.AzureStack;
    using Microsoft.AzureStack.Management;
    using Microsoft.AzureStack.Management.Fabric;
    using Microsoft.AzureStack.Management.Fabric.Admin;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// This resource represents a gateway, which provides the configuration
    /// needed to provide gateway services to virtual networks.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class EdgeGateway : Resource
    {
        /// <summary>
        /// Initializes a new instance of the EdgeGateway class.
        /// </summary>
        public EdgeGateway()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EdgeGateway class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">Region Location of resource.</param>
        /// <param name="tags">List of key value pairs.</param>
        /// <param name="state">The current state of the edge gateway.</param>
        /// <param name="totalCapacity">The total network capacity.</param>
        /// <param name="availableCapacity">The available network
        /// capacity.</param>
        /// <param name="numberOfConnections">The current number of
        /// connections.</param>
        public EdgeGateway(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string state = default(string), long? totalCapacity = default(long?), long? availableCapacity = default(long?), int? numberOfConnections = default(int?))
            : base(id, name, type, location, tags)
        {
            State = state;
            TotalCapacity = totalCapacity;
            AvailableCapacity = availableCapacity;
            NumberOfConnections = numberOfConnections;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the current state of the edge gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the total network capacity.
        /// </summary>
        [JsonProperty(PropertyName = "properties.totalCapacity")]
        public long? TotalCapacity { get; set; }

        /// <summary>
        /// Gets or sets the available network capacity.
        /// </summary>
        [JsonProperty(PropertyName = "properties.availableCapacity")]
        public long? AvailableCapacity { get; set; }

        /// <summary>
        /// Gets or sets the current number of connections.
        /// </summary>
        [JsonProperty(PropertyName = "properties.numberOfConnections")]
        public int? NumberOfConnections { get; set; }

    }
}
