// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableApiManagementResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableApiManagementResourceGroupResource"/> class for mocking. </summary>
        protected MockableApiManagementResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableApiManagementResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableApiManagementResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ApiManagementServiceResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ApiManagementServiceResources and their operations over a ApiManagementServiceResource. </returns>
        public virtual ApiManagementServiceCollection GetApiManagementServices()
        {
            return GetCachedClient(client => new ApiManagementServiceCollection(client, Id));
        }

        /// <summary>
        /// Gets an API Management service resource description.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiManagementService_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceName"> The name of the API Management service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ApiManagementServiceResource>> GetApiManagementServiceAsync(string serviceName, CancellationToken cancellationToken = default)
        {
            return await GetApiManagementServices().GetAsync(serviceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an API Management service resource description.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiManagementService_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceName"> The name of the API Management service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ApiManagementServiceResource> GetApiManagementService(string serviceName, CancellationToken cancellationToken = default)
        {
            return GetApiManagementServices().Get(serviceName, cancellationToken);
        }
    }
}
