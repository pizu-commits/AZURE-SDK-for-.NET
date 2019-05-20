// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DeploymentManager.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The detail about an operation.
    /// </summary>
    public partial class OperationDetail
    {
        /// <summary>
        /// Initializes a new instance of the OperationDetail class.
        /// </summary>
        public OperationDetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationDetail class.
        /// </summary>
        /// <param name="provider">The name of the provider that supports the
        /// operation.</param>
        /// <param name="resource">The resource type on which this operation
        /// can be performed.</param>
        /// <param name="operation">The name of the operation.</param>
        /// <param name="description">The description of the operation.</param>
        public OperationDetail(string provider = default(string), string resource = default(string), string operation = default(string), string description = default(string))
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
        /// Gets or sets the name of the provider that supports the operation.
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets the resource type on which this operation can be
        /// performed.
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; set; }

        /// <summary>
        /// Gets or sets the name of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }

        /// <summary>
        /// Gets or sets the description of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}
