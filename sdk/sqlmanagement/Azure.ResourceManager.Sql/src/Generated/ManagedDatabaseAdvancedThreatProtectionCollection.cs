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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="ManagedDatabaseAdvancedThreatProtectionResource"/> and their operations.
    /// Each <see cref="ManagedDatabaseAdvancedThreatProtectionResource"/> in the collection will belong to the same instance of <see cref="ManagedDatabaseResource"/>.
    /// To get a <see cref="ManagedDatabaseAdvancedThreatProtectionCollection"/> instance call the GetManagedDatabaseAdvancedThreatProtections method from an instance of <see cref="ManagedDatabaseResource"/>.
    /// </summary>
    public partial class ManagedDatabaseAdvancedThreatProtectionCollection : ArmCollection, IEnumerable<ManagedDatabaseAdvancedThreatProtectionResource>, IAsyncEnumerable<ManagedDatabaseAdvancedThreatProtectionResource>
    {
        private readonly ClientDiagnostics _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsClientDiagnostics;
        private readonly ManagedDatabaseAdvancedThreatProtectionSettingsRestOperations _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedDatabaseAdvancedThreatProtectionCollection"/> class for mocking. </summary>
        protected ManagedDatabaseAdvancedThreatProtectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedDatabaseAdvancedThreatProtectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagedDatabaseAdvancedThreatProtectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ManagedDatabaseAdvancedThreatProtectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ManagedDatabaseAdvancedThreatProtectionResource.ResourceType, out string managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsApiVersion);
            _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsRestClient = new ManagedDatabaseAdvancedThreatProtectionSettingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedDatabaseResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedDatabaseResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a managed database's Advanced Threat Protection state.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedDatabaseAdvancedThreatProtectionSettings_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedDatabaseAdvancedThreatProtectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="advancedThreatProtectionName"> The name of the Advanced Threat Protection state. </param>
        /// <param name="data"> The managed database Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagedDatabaseAdvancedThreatProtectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, AdvancedThreatProtectionName advancedThreatProtectionName, ManagedDatabaseAdvancedThreatProtectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ManagedDatabaseAdvancedThreatProtectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, advancedThreatProtectionName, data, cancellationToken).ConfigureAwait(false);
                var uri = _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, advancedThreatProtectionName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SqlArmOperation<ManagedDatabaseAdvancedThreatProtectionResource>(Response.FromValue(new ManagedDatabaseAdvancedThreatProtectionResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Creates or updates a managed database's Advanced Threat Protection state.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedDatabaseAdvancedThreatProtectionSettings_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedDatabaseAdvancedThreatProtectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="advancedThreatProtectionName"> The name of the Advanced Threat Protection state. </param>
        /// <param name="data"> The managed database Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ManagedDatabaseAdvancedThreatProtectionResource> CreateOrUpdate(WaitUntil waitUntil, AdvancedThreatProtectionName advancedThreatProtectionName, ManagedDatabaseAdvancedThreatProtectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ManagedDatabaseAdvancedThreatProtectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, advancedThreatProtectionName, data, cancellationToken);
                var uri = _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, advancedThreatProtectionName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SqlArmOperation<ManagedDatabaseAdvancedThreatProtectionResource>(Response.FromValue(new ManagedDatabaseAdvancedThreatProtectionResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Gets a managed database's Advanced Threat Protection state.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedDatabaseAdvancedThreatProtectionSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedDatabaseAdvancedThreatProtectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="advancedThreatProtectionName"> The name of the Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedDatabaseAdvancedThreatProtectionResource>> GetAsync(AdvancedThreatProtectionName advancedThreatProtectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ManagedDatabaseAdvancedThreatProtectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, advancedThreatProtectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedDatabaseAdvancedThreatProtectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a managed database's Advanced Threat Protection state.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedDatabaseAdvancedThreatProtectionSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedDatabaseAdvancedThreatProtectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="advancedThreatProtectionName"> The name of the Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedDatabaseAdvancedThreatProtectionResource> Get(AdvancedThreatProtectionName advancedThreatProtectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ManagedDatabaseAdvancedThreatProtectionCollection.Get");
            scope.Start();
            try
            {
                var response = _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, advancedThreatProtectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedDatabaseAdvancedThreatProtectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of managed database's Advanced Threat Protection states.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/advancedThreatProtectionSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedDatabaseAdvancedThreatProtectionSettings_ListByDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedDatabaseAdvancedThreatProtectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedDatabaseAdvancedThreatProtectionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedDatabaseAdvancedThreatProtectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsRestClient.CreateListByDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsRestClient.CreateListByDatabaseNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ManagedDatabaseAdvancedThreatProtectionResource(Client, ManagedDatabaseAdvancedThreatProtectionData.DeserializeManagedDatabaseAdvancedThreatProtectionData(e)), _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsClientDiagnostics, Pipeline, "ManagedDatabaseAdvancedThreatProtectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of managed database's Advanced Threat Protection states.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/advancedThreatProtectionSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedDatabaseAdvancedThreatProtectionSettings_ListByDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedDatabaseAdvancedThreatProtectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedDatabaseAdvancedThreatProtectionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedDatabaseAdvancedThreatProtectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsRestClient.CreateListByDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsRestClient.CreateListByDatabaseNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ManagedDatabaseAdvancedThreatProtectionResource(Client, ManagedDatabaseAdvancedThreatProtectionData.DeserializeManagedDatabaseAdvancedThreatProtectionData(e)), _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsClientDiagnostics, Pipeline, "ManagedDatabaseAdvancedThreatProtectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedDatabaseAdvancedThreatProtectionSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedDatabaseAdvancedThreatProtectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="advancedThreatProtectionName"> The name of the Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(AdvancedThreatProtectionName advancedThreatProtectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ManagedDatabaseAdvancedThreatProtectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, advancedThreatProtectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedDatabaseAdvancedThreatProtectionSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedDatabaseAdvancedThreatProtectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="advancedThreatProtectionName"> The name of the Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(AdvancedThreatProtectionName advancedThreatProtectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ManagedDatabaseAdvancedThreatProtectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, advancedThreatProtectionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedDatabaseAdvancedThreatProtectionSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedDatabaseAdvancedThreatProtectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="advancedThreatProtectionName"> The name of the Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<ManagedDatabaseAdvancedThreatProtectionResource>> GetIfExistsAsync(AdvancedThreatProtectionName advancedThreatProtectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ManagedDatabaseAdvancedThreatProtectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, advancedThreatProtectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ManagedDatabaseAdvancedThreatProtectionResource>(response.GetRawResponse());
                return Response.FromValue(new ManagedDatabaseAdvancedThreatProtectionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedDatabaseAdvancedThreatProtectionSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedDatabaseAdvancedThreatProtectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="advancedThreatProtectionName"> The name of the Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<ManagedDatabaseAdvancedThreatProtectionResource> GetIfExists(AdvancedThreatProtectionName advancedThreatProtectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ManagedDatabaseAdvancedThreatProtectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, advancedThreatProtectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ManagedDatabaseAdvancedThreatProtectionResource>(response.GetRawResponse());
                return Response.FromValue(new ManagedDatabaseAdvancedThreatProtectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagedDatabaseAdvancedThreatProtectionResource> IEnumerable<ManagedDatabaseAdvancedThreatProtectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedDatabaseAdvancedThreatProtectionResource> IAsyncEnumerable<ManagedDatabaseAdvancedThreatProtectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
