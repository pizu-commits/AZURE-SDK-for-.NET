// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.LoadTesting.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmLoadTestingModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="LoadTesting.LoadTestingQuotaData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="limit"> Current quota limit of the quota bucket. </param>
        /// <param name="usage"> Current quota usage of the quota bucket. </param>
        /// <param name="provisioningState"> Resource provisioning state. </param>
        /// <returns> A new <see cref="LoadTesting.LoadTestingQuotaData"/> instance for mocking. </returns>
        public static LoadTestingQuotaData LoadTestingQuotaData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, int? limit = null, int? usage = null, LoadTestingProvisioningState? provisioningState = null)
        {
            return new LoadTestingQuotaData(
                id,
                name,
                resourceType,
                systemData,
                limit,
                usage,
                provisioningState,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.LoadTestingQuotaBucketContent"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="currentUsage"> Current quota usage of the quota bucket. </param>
        /// <param name="currentQuota"> Current quota limit of the quota bucket. </param>
        /// <param name="newQuota"> New quota limit of the quota bucket. </param>
        /// <param name="dimensions"> Dimensions for new quota request. </param>
        /// <returns> A new <see cref="Models.LoadTestingQuotaBucketContent"/> instance for mocking. </returns>
        public static LoadTestingQuotaBucketContent LoadTestingQuotaBucketContent(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, int? currentUsage = null, int? currentQuota = null, int? newQuota = null, LoadTestingQuotaBucketDimensions dimensions = null)
        {
            return new LoadTestingQuotaBucketContent(
                id,
                name,
                resourceType,
                systemData,
                currentUsage,
                currentQuota,
                newQuota,
                dimensions,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.LoadTestingQuotaAvailabilityResult"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="isAvailable"> True/False indicating whether the quota request be granted based on availability. </param>
        /// <param name="availabilityStatus"> Message indicating additional details to add to quota support request. </param>
        /// <returns> A new <see cref="Models.LoadTestingQuotaAvailabilityResult"/> instance for mocking. </returns>
        public static LoadTestingQuotaAvailabilityResult LoadTestingQuotaAvailabilityResult(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, bool? isAvailable = null, string availabilityStatus = null)
        {
            return new LoadTestingQuotaAvailabilityResult(
                id,
                name,
                resourceType,
                systemData,
                isAvailable,
                availabilityStatus,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="LoadTesting.LoadTestingResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The type of identity used for the resource. </param>
        /// <param name="description"> Description of the resource. </param>
        /// <param name="provisioningState"> Resource provisioning state. </param>
        /// <param name="dataPlaneUri"> Resource data plane URI. </param>
        /// <param name="encryption"> CMK Encryption property. </param>
        /// <returns> A new <see cref="LoadTesting.LoadTestingResourceData"/> instance for mocking. </returns>
        public static LoadTestingResourceData LoadTestingResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ManagedServiceIdentity identity = null, string description = null, LoadTestingProvisioningState? provisioningState = null, string dataPlaneUri = null, LoadTestingCmkEncryptionProperties encryption = null)
        {
            tags ??= new Dictionary<string, string>();

            return new LoadTestingResourceData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                identity,
                description,
                provisioningState,
                dataPlaneUri,
                encryption,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.LoadTestingOutboundEnvironmentEndpoint"/>. </summary>
        /// <param name="category"> The type of service that Azure Load Testing connects to. </param>
        /// <param name="endpoints"> The endpoints for this service to which the Batch service makes outbound calls. </param>
        /// <returns> A new <see cref="Models.LoadTestingOutboundEnvironmentEndpoint"/> instance for mocking. </returns>
        public static LoadTestingOutboundEnvironmentEndpoint LoadTestingOutboundEnvironmentEndpoint(string category = null, IEnumerable<LoadTestingEndpointDependency> endpoints = null)
        {
            endpoints ??= new List<LoadTestingEndpointDependency>();

            return new LoadTestingOutboundEnvironmentEndpoint(category, endpoints?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.LoadTestingEndpointDependency"/>. </summary>
        /// <param name="domainName"> The domain name of the dependency. Domain names may be fully qualified or may contain a * wildcard. </param>
        /// <param name="description"> Human-readable supplemental information about the dependency and when it is applicable. </param>
        /// <param name="endpointDetails"> The list of connection details for this endpoint. </param>
        /// <returns> A new <see cref="Models.LoadTestingEndpointDependency"/> instance for mocking. </returns>
        public static LoadTestingEndpointDependency LoadTestingEndpointDependency(string domainName = null, string description = null, IEnumerable<LoadTestingEndpointDetail> endpointDetails = null)
        {
            endpointDetails ??= new List<LoadTestingEndpointDetail>();

            return new LoadTestingEndpointDependency(domainName, description, endpointDetails?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.LoadTestingEndpointDetail"/>. </summary>
        /// <param name="port"> The port an endpoint is connected to. </param>
        /// <returns> A new <see cref="Models.LoadTestingEndpointDetail"/> instance for mocking. </returns>
        public static LoadTestingEndpointDetail LoadTestingEndpointDetail(int? port = null)
        {
            return new LoadTestingEndpointDetail(port, serializedAdditionalRawData: null);
        }
    }
}
