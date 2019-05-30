// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Live Event endpoint.
    /// </summary>
    public partial class LiveEventEndpoint
    {
        /// <summary>
        /// Initializes a new instance of the LiveEventEndpoint class.
        /// </summary>
        public LiveEventEndpoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LiveEventEndpoint class.
        /// </summary>
        /// <param name="protocol">The endpoint protocol.</param>
        /// <param name="url">The endpoint URL.</param>
        public LiveEventEndpoint(string protocol = default(string), string url = default(string))
        {
            Protocol = protocol;
            Url = url;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the endpoint protocol.
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets the endpoint URL.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

    }
}
