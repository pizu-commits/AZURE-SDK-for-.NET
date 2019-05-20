// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Reconnect request parameters.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BackendReconnectContract : Resource
    {
        /// <summary>
        /// Initializes a new instance of the BackendReconnectContract class.
        /// </summary>
        public BackendReconnectContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackendReconnectContract class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type for API Management
        /// resource.</param>
        /// <param name="after">Duration in ISO8601 format after which
        /// reconnect will be initiated. Minimum duration of the Reconnect is
        /// PT2M.</param>
        public BackendReconnectContract(string id = default(string), string name = default(string), string type = default(string), System.TimeSpan? after = default(System.TimeSpan?))
            : base(id, name, type)
        {
            After = after;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets duration in ISO8601 format after which reconnect will
        /// be initiated. Minimum duration of the Reconnect is PT2M.
        /// </summary>
        [JsonProperty(PropertyName = "properties.after")]
        public System.TimeSpan? After { get; set; }

    }
}
