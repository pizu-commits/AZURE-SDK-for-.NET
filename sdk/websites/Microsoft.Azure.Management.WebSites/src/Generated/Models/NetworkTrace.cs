// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Network trace
    /// </summary>
    public partial class NetworkTrace
    {
        /// <summary>
        /// Initializes a new instance of the NetworkTrace class.
        /// </summary>
        public NetworkTrace()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkTrace class.
        /// </summary>
        /// <param name="path">Local file path for the captured network trace
        /// file.</param>
        /// <param name="status">Current status of the network trace operation,
        /// same as Operation.Status (InProgress/Succeeded/Failed).</param>
        /// <param name="message">Detailed message of a network trace
        /// operation, e.g. error message in case of failure.</param>
        public NetworkTrace(string path = default(string), string status = default(string), string message = default(string))
        {
            Path = path;
            Status = status;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets local file path for the captured network trace file.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets current status of the network trace operation, same as
        /// Operation.Status (InProgress/Succeeded/Failed).
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets detailed message of a network trace operation, e.g.
        /// error message in case of failure.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}
