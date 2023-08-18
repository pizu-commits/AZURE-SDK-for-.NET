// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Cdn
{
    /// <summary>
    /// A class representing a collection of <see cref="ProfileResource" /> and their operations.
    /// Each <see cref="ProfileResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="ProfileCollection" /> instance call the GetProfiles method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ProfileCollection : ArmCollection, IEnumerable<ProfileResource>, IAsyncEnumerable<ProfileResource>
    {
        private readonly ClientDiagnostics _profileClientDiagnostics;
        private readonly ProfilesRestOperations _profileRestClient;

        /// <summary> Initializes a new instance of the <see cref="ProfileCollection"/> class for mocking. </summary>
        protected ProfileCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ProfileCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ProfileCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _profileClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Cdn", ProfileResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ProfileResource.ResourceType, out string profileApiVersion);
            _profileRestClient = new ProfilesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, profileApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new Azure Front Door Standard or Azure Front Door Premium or CDN profile with a profile name under the specified subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium or CDN profile which is unique within the resource group. </param>
        /// <param name="data"> Profile properties needed to create a new profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ProfileResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string profileName, ProfileData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _profileClientDiagnostics.CreateScope("ProfileCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _profileRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, profileName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CdnArmOperation<ProfileResource>(new ProfileOperationSource(Client), _profileClientDiagnostics, Pipeline, _profileRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, profileName, data).Request, response, Core.OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a new Azure Front Door Standard or Azure Front Door Premium or CDN profile with a profile name under the specified subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium or CDN profile which is unique within the resource group. </param>
        /// <param name="data"> Profile properties needed to create a new profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ProfileResource> CreateOrUpdate(WaitUntil waitUntil, string profileName, ProfileData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _profileClientDiagnostics.CreateScope("ProfileCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _profileRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, profileName, data, cancellationToken);
                var operation = new CdnArmOperation<ProfileResource>(new ProfileOperationSource(Client), _profileClientDiagnostics, Pipeline, _profileRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, profileName, data).Request, response, Core.OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an Azure Front Door Standard or Azure Front Door Premium or CDN profile with the specified profile name under the specified subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium or CDN profile which is unique within the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        public virtual async Task<Response<ProfileResource>> GetAsync(string profileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));

            using var scope = _profileClientDiagnostics.CreateScope("ProfileCollection.Get");
            scope.Start();
            try
            {
                var response = await _profileRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, profileName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an Azure Front Door Standard or Azure Front Door Premium or CDN profile with the specified profile name under the specified subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium or CDN profile which is unique within the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        public virtual Response<ProfileResource> Get(string profileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));

            using var scope = _profileClientDiagnostics.CreateScope("ProfileCollection.Get");
            scope.Start();
            try
            {
                var response = _profileRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, profileName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the Azure Front Door Standard, Azure Front Door Premium, and CDN profiles within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProfileResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ProfileResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _profileRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _profileRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ProfileResource(Client, ProfileData.DeserializeProfileData(e)), _profileClientDiagnostics, Pipeline, "ProfileCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the Azure Front Door Standard, Azure Front Door Premium, and CDN profiles within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProfileResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ProfileResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _profileRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _profileRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ProfileResource(Client, ProfileData.DeserializeProfileData(e)), _profileClientDiagnostics, Pipeline, "ProfileCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium or CDN profile which is unique within the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string profileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));

            using var scope = _profileClientDiagnostics.CreateScope("ProfileCollection.Exists");
            scope.Start();
            try
            {
                var response = await _profileRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, profileName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium or CDN profile which is unique within the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        public virtual Response<bool> Exists(string profileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));

            using var scope = _profileClientDiagnostics.CreateScope("ProfileCollection.Exists");
            scope.Start();
            try
            {
                var response = _profileRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, profileName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ProfileResource> IEnumerable<ProfileResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ProfileResource> IAsyncEnumerable<ProfileResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
