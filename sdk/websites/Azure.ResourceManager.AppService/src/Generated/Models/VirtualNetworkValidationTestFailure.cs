// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> A class that describes a test that failed during NSG and UDR validation. </summary>
    public partial class VirtualNetworkValidationTestFailure : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkValidationTestFailure"/>. </summary>
        public VirtualNetworkValidationTestFailure()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkValidationTestFailure"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="testName"> The name of the test that failed. </param>
        /// <param name="details"> The details of what caused the failure, e.g. the blocking rule name, etc. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualNetworkValidationTestFailure(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string testName, string details, string kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            TestName = testName;
            Details = details;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the test that failed. </summary>
        public string TestName { get; set; }
        /// <summary> The details of what caused the failure, e.g. the blocking rule name, etc. </summary>
        public string Details { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
