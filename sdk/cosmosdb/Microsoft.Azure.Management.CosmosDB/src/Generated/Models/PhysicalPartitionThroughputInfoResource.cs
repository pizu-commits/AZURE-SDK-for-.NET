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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// PhysicalPartitionThroughputInfo object
    /// </summary>
    public partial class PhysicalPartitionThroughputInfoResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PhysicalPartitionThroughputInfoResource class.
        /// </summary>
        public PhysicalPartitionThroughputInfoResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PhysicalPartitionThroughputInfoResource class.
        /// </summary>
        /// <param name="id">Id of a physical partition</param>
        /// <param name="throughput">Throughput of a physical partition</param>
        public PhysicalPartitionThroughputInfoResource(string id, double? throughput = default(double?))
        {
            Id = id;
            Throughput = throughput;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of a physical partition
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets throughput of a physical partition
        /// </summary>
        [JsonProperty(PropertyName = "throughput")]
        public double? Throughput { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
        }
    }
}
