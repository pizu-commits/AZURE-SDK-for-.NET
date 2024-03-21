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
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.MobileNetwork
{
    /// <summary>
    /// A class representing a collection of <see cref="MobileNetworkSimGroupResource"/> and their operations.
    /// Each <see cref="MobileNetworkSimGroupResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="MobileNetworkSimGroupCollection"/> instance call the GetMobileNetworkSimGroups method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class MobileNetworkSimGroupCollection : ArmCollection, IEnumerable<MobileNetworkSimGroupResource>, IAsyncEnumerable<MobileNetworkSimGroupResource>
    {
        private readonly ClientDiagnostics _mobileNetworkSimGroupSimGroupsClientDiagnostics;
        private readonly SimGroupsRestOperations _mobileNetworkSimGroupSimGroupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MobileNetworkSimGroupCollection"/> class for mocking. </summary>
        protected MobileNetworkSimGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MobileNetworkSimGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MobileNetworkSimGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mobileNetworkSimGroupSimGroupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MobileNetwork", MobileNetworkSimGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MobileNetworkSimGroupResource.ResourceType, out string mobileNetworkSimGroupSimGroupsApiVersion);
            _mobileNetworkSimGroupSimGroupsRestClient = new SimGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mobileNetworkSimGroupSimGroupsApiVersion);
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
        /// Creates or updates a SIM group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/simGroups/{simGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimGroups_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MobileNetworkSimGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="simGroupName"> The name of the SIM Group. </param>
        /// <param name="data"> Parameters supplied to the create or update SIM group operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="simGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="simGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MobileNetworkSimGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string simGroupName, MobileNetworkSimGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(simGroupName, nameof(simGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mobileNetworkSimGroupSimGroupsClientDiagnostics.CreateScope("MobileNetworkSimGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _mobileNetworkSimGroupSimGroupsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, simGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MobileNetworkArmOperation<MobileNetworkSimGroupResource>(new MobileNetworkSimGroupOperationSource(Client), _mobileNetworkSimGroupSimGroupsClientDiagnostics, Pipeline, _mobileNetworkSimGroupSimGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, simGroupName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a SIM group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/simGroups/{simGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimGroups_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MobileNetworkSimGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="simGroupName"> The name of the SIM Group. </param>
        /// <param name="data"> Parameters supplied to the create or update SIM group operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="simGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="simGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MobileNetworkSimGroupResource> CreateOrUpdate(WaitUntil waitUntil, string simGroupName, MobileNetworkSimGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(simGroupName, nameof(simGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mobileNetworkSimGroupSimGroupsClientDiagnostics.CreateScope("MobileNetworkSimGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _mobileNetworkSimGroupSimGroupsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, simGroupName, data, cancellationToken);
                var operation = new MobileNetworkArmOperation<MobileNetworkSimGroupResource>(new MobileNetworkSimGroupOperationSource(Client), _mobileNetworkSimGroupSimGroupsClientDiagnostics, Pipeline, _mobileNetworkSimGroupSimGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, simGroupName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets information about the specified SIM group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/simGroups/{simGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MobileNetworkSimGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="simGroupName"> The name of the SIM Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="simGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="simGroupName"/> is null. </exception>
        public virtual async Task<Response<MobileNetworkSimGroupResource>> GetAsync(string simGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(simGroupName, nameof(simGroupName));

            using var scope = _mobileNetworkSimGroupSimGroupsClientDiagnostics.CreateScope("MobileNetworkSimGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _mobileNetworkSimGroupSimGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, simGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MobileNetworkSimGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified SIM group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/simGroups/{simGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MobileNetworkSimGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="simGroupName"> The name of the SIM Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="simGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="simGroupName"/> is null. </exception>
        public virtual Response<MobileNetworkSimGroupResource> Get(string simGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(simGroupName, nameof(simGroupName));

            using var scope = _mobileNetworkSimGroupSimGroupsClientDiagnostics.CreateScope("MobileNetworkSimGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _mobileNetworkSimGroupSimGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, simGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MobileNetworkSimGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the SIM groups in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/simGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimGroups_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MobileNetworkSimGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MobileNetworkSimGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MobileNetworkSimGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mobileNetworkSimGroupSimGroupsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mobileNetworkSimGroupSimGroupsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MobileNetworkSimGroupResource(Client, MobileNetworkSimGroupData.DeserializeMobileNetworkSimGroupData(e)), _mobileNetworkSimGroupSimGroupsClientDiagnostics, Pipeline, "MobileNetworkSimGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the SIM groups in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/simGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimGroups_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MobileNetworkSimGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MobileNetworkSimGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MobileNetworkSimGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mobileNetworkSimGroupSimGroupsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mobileNetworkSimGroupSimGroupsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MobileNetworkSimGroupResource(Client, MobileNetworkSimGroupData.DeserializeMobileNetworkSimGroupData(e)), _mobileNetworkSimGroupSimGroupsClientDiagnostics, Pipeline, "MobileNetworkSimGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/simGroups/{simGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MobileNetworkSimGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="simGroupName"> The name of the SIM Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="simGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="simGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string simGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(simGroupName, nameof(simGroupName));

            using var scope = _mobileNetworkSimGroupSimGroupsClientDiagnostics.CreateScope("MobileNetworkSimGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _mobileNetworkSimGroupSimGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, simGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/simGroups/{simGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MobileNetworkSimGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="simGroupName"> The name of the SIM Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="simGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="simGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string simGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(simGroupName, nameof(simGroupName));

            using var scope = _mobileNetworkSimGroupSimGroupsClientDiagnostics.CreateScope("MobileNetworkSimGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _mobileNetworkSimGroupSimGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, simGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/simGroups/{simGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MobileNetworkSimGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="simGroupName"> The name of the SIM Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="simGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="simGroupName"/> is null. </exception>
        public virtual async Task<NullableResponse<MobileNetworkSimGroupResource>> GetIfExistsAsync(string simGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(simGroupName, nameof(simGroupName));

            using var scope = _mobileNetworkSimGroupSimGroupsClientDiagnostics.CreateScope("MobileNetworkSimGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _mobileNetworkSimGroupSimGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, simGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MobileNetworkSimGroupResource>(response.GetRawResponse());
                return Response.FromValue(new MobileNetworkSimGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/simGroups/{simGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MobileNetworkSimGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="simGroupName"> The name of the SIM Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="simGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="simGroupName"/> is null. </exception>
        public virtual NullableResponse<MobileNetworkSimGroupResource> GetIfExists(string simGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(simGroupName, nameof(simGroupName));

            using var scope = _mobileNetworkSimGroupSimGroupsClientDiagnostics.CreateScope("MobileNetworkSimGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _mobileNetworkSimGroupSimGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, simGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MobileNetworkSimGroupResource>(response.GetRawResponse());
                return Response.FromValue(new MobileNetworkSimGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MobileNetworkSimGroupResource> IEnumerable<MobileNetworkSimGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MobileNetworkSimGroupResource> IAsyncEnumerable<MobileNetworkSimGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
