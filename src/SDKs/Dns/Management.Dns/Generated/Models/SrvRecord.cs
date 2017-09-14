// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Dns.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Dns;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An SRV record.
    /// </summary>
    public partial class SrvRecord
    {
        /// <summary>
        /// Initializes a new instance of the SrvRecord class.
        /// </summary>
        public SrvRecord()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SrvRecord class.
        /// </summary>
        /// <param name="priority">The priority value for this SRV
        /// record.</param>
        /// <param name="weight">The weight value for this SRV record.</param>
        /// <param name="port">The port value for this SRV record.</param>
        /// <param name="target">The target domain name for this SRV
        /// record.</param>
        public SrvRecord(int? priority = default(int?), int? weight = default(int?), int? port = default(int?), string target = default(string))
        {
            Priority = priority;
            Weight = weight;
            Port = port;
            Target = target;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the priority value for this SRV record.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or sets the weight value for this SRV record.
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public int? Weight { get; set; }

        /// <summary>
        /// Gets or sets the port value for this SRV record.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }

        /// <summary>
        /// Gets or sets the target domain name for this SRV record.
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

    }
}
