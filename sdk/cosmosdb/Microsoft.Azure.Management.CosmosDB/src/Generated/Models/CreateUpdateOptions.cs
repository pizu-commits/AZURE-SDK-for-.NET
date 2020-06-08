// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// CreateUpdateOptions are a list of key-value pairs that describe the
    /// resource. Supported keys are "If-Match", "If-None-Match",
    /// "Session-Token" and "Throughput"
    /// </summary>
    public partial class CreateUpdateOptions
    {
        /// <summary>
        /// Initializes a new instance of the CreateUpdateOptions class.
        /// </summary>
        public CreateUpdateOptions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreateUpdateOptions class.
        /// </summary>
        /// <param name="throughput">Request Units per second. For example,
        /// "throughput": 10000.</param>
        /// <param name="autoscaleSettings">Specifies the Autoscale
        /// settings.</param>
        public CreateUpdateOptions(int? throughput = default(int?), AutoscaleSettings autoscaleSettings = default(AutoscaleSettings))
        {
            Throughput = throughput;
            AutoscaleSettings = autoscaleSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets request Units per second. For example, "throughput":
        /// 10000.
        /// </summary>
        [JsonProperty(PropertyName = "throughput")]
        public int? Throughput { get; set; }

        /// <summary>
        /// Gets or sets specifies the Autoscale settings.
        /// </summary>
        [JsonProperty(PropertyName = "autoscaleSettings")]
        public AutoscaleSettings AutoscaleSettings { get; set; }

    }
}
