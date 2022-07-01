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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Resource to redistribute throughput for Azure Cosmos DB resource
    /// </summary>
    public partial class RedistributeThroughputPropertiesResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RedistributeThroughputPropertiesResource class.
        /// </summary>
        public RedistributeThroughputPropertiesResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RedistributeThroughputPropertiesResource class.
        /// </summary>
        /// <param name="throughputPolicy">ThroughputPolicy to apply for
        /// throughput redistribution. Possible values include: 'none',
        /// 'equal', 'custom'</param>
        /// <param name="targetPhysicalPartitionThroughputInfo">Array of
        /// PhysicalPartitionThroughputInfoResource objects.</param>
        /// <param name="sourcePhysicalPartitionThroughputInfo">Array of
        /// PhysicalPartitionThroughputInfoResource objects.</param>
        public RedistributeThroughputPropertiesResource(string throughputPolicy, IList<PhysicalPartitionThroughputInfoResource> targetPhysicalPartitionThroughputInfo, IList<PhysicalPartitionThroughputInfoResource> sourcePhysicalPartitionThroughputInfo)
        {
            ThroughputPolicy = throughputPolicy;
            TargetPhysicalPartitionThroughputInfo = targetPhysicalPartitionThroughputInfo;
            SourcePhysicalPartitionThroughputInfo = sourcePhysicalPartitionThroughputInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets throughputPolicy to apply for throughput
        /// redistribution. Possible values include: 'none', 'equal', 'custom'
        /// </summary>
        [JsonProperty(PropertyName = "throughputPolicy")]
        public string ThroughputPolicy { get; set; }

        /// <summary>
        /// Gets or sets array of PhysicalPartitionThroughputInfoResource
        /// objects.
        /// </summary>
        [JsonProperty(PropertyName = "targetPhysicalPartitionThroughputInfo")]
        public IList<PhysicalPartitionThroughputInfoResource> TargetPhysicalPartitionThroughputInfo { get; set; }

        /// <summary>
        /// Gets or sets array of PhysicalPartitionThroughputInfoResource
        /// objects.
        /// </summary>
        [JsonProperty(PropertyName = "sourcePhysicalPartitionThroughputInfo")]
        public IList<PhysicalPartitionThroughputInfoResource> SourcePhysicalPartitionThroughputInfo { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ThroughputPolicy == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ThroughputPolicy");
            }
            if (TargetPhysicalPartitionThroughputInfo == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetPhysicalPartitionThroughputInfo");
            }
            if (SourcePhysicalPartitionThroughputInfo == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SourcePhysicalPartitionThroughputInfo");
            }
            if (TargetPhysicalPartitionThroughputInfo != null)
            {
                foreach (var element in TargetPhysicalPartitionThroughputInfo)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (SourcePhysicalPartitionThroughputInfo != null)
            {
                foreach (var element1 in SourcePhysicalPartitionThroughputInfo)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
