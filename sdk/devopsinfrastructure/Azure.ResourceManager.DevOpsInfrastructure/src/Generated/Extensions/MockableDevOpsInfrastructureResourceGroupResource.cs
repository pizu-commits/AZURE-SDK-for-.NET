// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.DevOpsInfrastructure.Models;

namespace Azure.ResourceManager.DevOpsInfrastructure.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableDevOpsInfrastructureResourceGroupResource : ArmResource
    {
        private ClientDiagnostics _imageVersionsClientDiagnostics;
        private ImageVersionsRestOperations _imageVersionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableDevOpsInfrastructureResourceGroupResource"/> class for mocking. </summary>
        protected MockableDevOpsInfrastructureResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableDevOpsInfrastructureResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableDevOpsInfrastructureResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ImageVersionsClientDiagnostics => _imageVersionsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DevOpsInfrastructure", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ImageVersionsRestOperations ImageVersionsRestClient => _imageVersionsRestClient ??= new ImageVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of DevOpsPoolResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DevOpsPoolResources and their operations over a DevOpsPoolResource. </returns>
        public virtual DevOpsPoolCollection GetDevOpsPools()
        {
            return GetCachedClient(client => new DevOpsPoolCollection(client, Id));
        }

        /// <summary>
        /// Get a Pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/pools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-04-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="poolName"> Name of the pool. It needs to be globally unique. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DevOpsPoolResource>> GetDevOpsPoolAsync(string poolName, CancellationToken cancellationToken = default)
        {
            return await GetDevOpsPools().GetAsync(poolName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/pools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-04-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="poolName"> Name of the pool. It needs to be globally unique. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<DevOpsPoolResource> GetDevOpsPool(string poolName, CancellationToken cancellationToken = default)
        {
            return GetDevOpsPools().Get(poolName, cancellationToken);
        }

        /// <summary>
        /// List ImageVersion resources by Image
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/images/{imageName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImageVersion_ListByImage</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-04-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="imageName"> Name of the image. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        /// <returns> An async collection of <see cref="DevOpsImageVersion"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DevOpsImageVersion> GetImageVersionsByImageAsync(string imageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(imageName, nameof(imageName));

            HttpMessage FirstPageRequest(int? pageSizeHint) => ImageVersionsRestClient.CreateListByImageRequest(Id.SubscriptionId, Id.ResourceGroupName, imageName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ImageVersionsRestClient.CreateListByImageNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, imageName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => DevOpsImageVersion.DeserializeDevOpsImageVersion(e), ImageVersionsClientDiagnostics, Pipeline, "MockableDevOpsInfrastructureResourceGroupResource.GetImageVersionsByImage", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List ImageVersion resources by Image
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/images/{imageName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImageVersion_ListByImage</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-04-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="imageName"> Name of the image. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        /// <returns> A collection of <see cref="DevOpsImageVersion"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DevOpsImageVersion> GetImageVersionsByImage(string imageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(imageName, nameof(imageName));

            HttpMessage FirstPageRequest(int? pageSizeHint) => ImageVersionsRestClient.CreateListByImageRequest(Id.SubscriptionId, Id.ResourceGroupName, imageName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ImageVersionsRestClient.CreateListByImageNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, imageName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => DevOpsImageVersion.DeserializeDevOpsImageVersion(e), ImageVersionsClientDiagnostics, Pipeline, "MockableDevOpsInfrastructureResourceGroupResource.GetImageVersionsByImage", "value", "nextLink", cancellationToken);
        }
    }
}
