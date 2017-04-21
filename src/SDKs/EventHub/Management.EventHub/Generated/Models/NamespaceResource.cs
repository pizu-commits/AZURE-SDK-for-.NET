// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.EventHub.Models
{
    using Azure;
    using Management;
    using EventHub;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Single Namespace item in List or Get Operation
    /// </summary>
    [JsonTransformation]
    public partial class NamespaceResource : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the NamespaceResource class.
        /// </summary>
        public NamespaceResource() { }

        /// <summary>
        /// Initializes a new instance of the NamespaceResource class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="status">State of the Namespace. Possible values
        /// include: 'Unknown', 'Creating', 'Created', 'Activating',
        /// 'Enabling', 'Active', 'Disabling', 'Disabled', 'SoftDeleting',
        /// 'SoftDeleted', 'Removing', 'Removed', 'Failed'</param>
        /// <param name="provisioningState">Provisioning state of the
        /// Namespace.</param>
        /// <param name="createdAt">The time the Namespace was created.</param>
        /// <param name="updatedAt">The time the Namespace was updated.</param>
        /// <param name="serviceBusEndpoint">Endpoint you can use to perform
        /// Service Bus operations.</param>
        /// <param name="metricId">Identifier for Azure Insights
        /// metrics</param>
        /// <param name="enabled">Specifies whether this instance is
        /// enabled.</param>
        public NamespaceResource(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Sku sku = default(Sku), NamespaceState? status = default(NamespaceState?), string provisioningState = default(string), System.DateTime? createdAt = default(System.DateTime?), System.DateTime? updatedAt = default(System.DateTime?), string serviceBusEndpoint = default(string), string metricId = default(string), bool? enabled = default(bool?))
            : base(location, id, name, type, tags)
        {
            Sku = sku;
            Status = status;
            ProvisioningState = provisioningState;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            ServiceBusEndpoint = serviceBusEndpoint;
            MetricId = metricId;
            Enabled = enabled;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets state of the Namespace. Possible values include:
        /// 'Unknown', 'Creating', 'Created', 'Activating', 'Enabling',
        /// 'Active', 'Disabling', 'Disabled', 'SoftDeleting', 'SoftDeleted',
        /// 'Removing', 'Removed', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public NamespaceState? Status { get; set; }

        /// <summary>
        /// Gets or sets provisioning state of the Namespace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the time the Namespace was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdAt")]
        public System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the time the Namespace was updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.updatedAt")]
        public System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets endpoint you can use to perform Service Bus
        /// operations.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceBusEndpoint")]
        public string ServiceBusEndpoint { get; set; }

        /// <summary>
        /// Gets identifier for Azure Insights metrics
        /// </summary>
        [JsonProperty(PropertyName = "properties.metricId")]
        public string MetricId { get; protected set; }

        /// <summary>
        /// Gets or sets specifies whether this instance is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}

