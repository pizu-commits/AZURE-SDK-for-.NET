// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedServices.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedServices
{
    /// <summary>
    /// A class representing the ManagedServicesRegistrationAssignment data model.
    /// The registration assignment.
    /// </summary>
    public partial class ManagedServicesRegistrationAssignmentData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ManagedServicesRegistrationAssignmentData"/>. </summary>
        public ManagedServicesRegistrationAssignmentData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedServicesRegistrationAssignmentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The properties of a registration assignment. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedServicesRegistrationAssignmentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ManagedServicesRegistrationAssignmentProperties properties, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> The properties of a registration assignment. </summary>
        public ManagedServicesRegistrationAssignmentProperties Properties { get; set; }
    }
}
