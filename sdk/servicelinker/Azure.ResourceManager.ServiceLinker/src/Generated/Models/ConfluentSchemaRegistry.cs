// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary> The service properties when target service type is ConfluentSchemaRegistry. </summary>
    internal partial class ConfluentSchemaRegistry : TargetServiceBase
    {
        /// <summary> Initializes a new instance of ConfluentSchemaRegistry. </summary>
        public ConfluentSchemaRegistry()
        {
            ServiceType = TargetServiceType.ConfluentSchemaRegistry;
        }

        /// <summary> Initializes a new instance of ConfluentSchemaRegistry. </summary>
        /// <param name="serviceType"> The target service type. </param>
        /// <param name="endpoint"> The endpoint of service. </param>
        internal ConfluentSchemaRegistry(TargetServiceType serviceType, string endpoint) : base(serviceType)
        {
            Endpoint = endpoint;
            ServiceType = serviceType;
        }

        /// <summary> The endpoint of service. </summary>
        public string Endpoint { get; set; }
    }
}
