// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataFactory;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Request to remove a node.
    /// </summary>
    public partial class IntegrationRuntimeRemoveNodeRequest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// IntegrationRuntimeRemoveNodeRequest class.
        /// </summary>
        public IntegrationRuntimeRemoveNodeRequest()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// IntegrationRuntimeRemoveNodeRequest class.
        /// </summary>
        /// <param name="nodeName">The name of the node to be removed.</param>
        public IntegrationRuntimeRemoveNodeRequest(string nodeName = default(string))
        {
            NodeName = nodeName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the node to be removed.
        /// </summary>
        [JsonProperty(PropertyName = "nodeName")]
        public string NodeName { get; set; }

    }
}
