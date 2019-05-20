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
    /// Represents an operation that can be performed on the service.
    /// </summary>
    public partial class Operation
    {
        /// <summary>
        /// Initializes a new instance of the Operation class.
        /// </summary>
        public Operation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Operation class.
        /// </summary>
        /// <param name="name">The name of the operation.</param>
        /// <param name="display">The display name of the operation.</param>
        /// <param name="origin">The origin of the operation.</param>
        /// <param name="properties">The properties of the operation.</param>
        public Operation(string name = default(string), OperationDetail display = default(OperationDetail), string origin = default(string), object properties = default(object))
        {
            Name = name;
            Display = display;
            Origin = origin;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the display name of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "display")]
        public OperationDetail Display { get; set; }

        /// <summary>
        /// Gets or sets the origin of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "origin")]
        public string Origin { get; set; }

        /// <summary>
        /// Gets or sets the properties of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public object Properties { get; set; }

    }
}
