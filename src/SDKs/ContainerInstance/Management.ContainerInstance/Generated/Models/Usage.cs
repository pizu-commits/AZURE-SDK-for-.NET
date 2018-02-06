// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerInstance.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A single usage result
    /// </summary>
    public partial class Usage
    {
        /// <summary>
        /// Initializes a new instance of the Usage class.
        /// </summary>
        public Usage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Usage class.
        /// </summary>
        /// <param name="unit">Unit of the usage result</param>
        /// <param name="currentValue">The current usage of the
        /// resource</param>
        /// <param name="limit">The maximum permitted usage of the
        /// resource.</param>
        /// <param name="name">The name object of the resource</param>
        public Usage(string unit = default(string), int? currentValue = default(int?), int? limit = default(int?), UsageName name = default(UsageName))
        {
            Unit = unit;
            CurrentValue = currentValue;
            Limit = limit;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets unit of the usage result
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; private set; }

        /// <summary>
        /// Gets the current usage of the resource
        /// </summary>
        [JsonProperty(PropertyName = "currentValue")]
        public int? CurrentValue { get; private set; }

        /// <summary>
        /// Gets the maximum permitted usage of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public int? Limit { get; private set; }

        /// <summary>
        /// Gets the name object of the resource
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public UsageName Name { get; private set; }

    }
}
