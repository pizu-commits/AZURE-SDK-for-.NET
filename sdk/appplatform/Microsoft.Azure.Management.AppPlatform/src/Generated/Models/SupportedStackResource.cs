// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Supported stack resource payload
    /// </summary>
    public partial class SupportedStackResource : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the SupportedStackResource class.
        /// </summary>
        public SupportedStackResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SupportedStackResource class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the
        /// resource.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        public SupportedStackResource(string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), SupportedStackResourceProperties properties = default(SupportedStackResourceProperties))
            : base(id, name, type, systemData)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public SupportedStackResourceProperties Properties { get; set; }

    }
}
