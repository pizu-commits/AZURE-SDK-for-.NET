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

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing a collection of <see cref="AutomationWatcherResource" /> and their operations.
    /// Each <see cref="AutomationWatcherResource" /> in the collection will belong to the same instance of <see cref="AutomationAccountResource" />.
    /// To get an <see cref="AutomationWatcherCollection" /> instance call the GetAutomationWatchers method from an instance of <see cref="AutomationAccountResource" />.
    /// </summary>
    public partial class AutomationWatcherCollection : ArmCollection, IEnumerable<AutomationWatcherResource>, IAsyncEnumerable<AutomationWatcherResource>
    {
        private readonly ClientDiagnostics _automationWatcherWatcherClientDiagnostics;
        private readonly WatcherRestOperations _automationWatcherWatcherRestClient;

        /// <summary> Initializes a new instance of the <see cref="AutomationWatcherCollection"/> class for mocking. </summary>
        protected AutomationWatcherCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutomationWatcherCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AutomationWatcherCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _automationWatcherWatcherClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automation", AutomationWatcherResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AutomationWatcherResource.ResourceType, out string automationWatcherWatcherApiVersion);
            _automationWatcherWatcherRestClient = new WatcherRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automationWatcherWatcherApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AutomationAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AutomationAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create the watcher identified by watcher name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/watchers/{watcherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Watcher_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="watcherName"> The watcher name. </param>
        /// <param name="data"> The create or update parameters for watcher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="watcherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="watcherName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AutomationWatcherResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string watcherName, AutomationWatcherData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(watcherName, nameof(watcherName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _automationWatcherWatcherClientDiagnostics.CreateScope("AutomationWatcherCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _automationWatcherWatcherRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, watcherName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AutomationArmOperation<AutomationWatcherResource>(Response.FromValue(new AutomationWatcherResource(Client, response), response.GetRawResponse()));
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
        /// Create the watcher identified by watcher name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/watchers/{watcherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Watcher_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="watcherName"> The watcher name. </param>
        /// <param name="data"> The create or update parameters for watcher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="watcherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="watcherName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AutomationWatcherResource> CreateOrUpdate(WaitUntil waitUntil, string watcherName, AutomationWatcherData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(watcherName, nameof(watcherName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _automationWatcherWatcherClientDiagnostics.CreateScope("AutomationWatcherCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _automationWatcherWatcherRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, watcherName, data, cancellationToken);
                var operation = new AutomationArmOperation<AutomationWatcherResource>(Response.FromValue(new AutomationWatcherResource(Client, response), response.GetRawResponse()));
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
        /// Retrieve the watcher identified by watcher name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/watchers/{watcherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Watcher_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="watcherName"> The watcher name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="watcherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="watcherName"/> is null. </exception>
        public virtual async Task<Response<AutomationWatcherResource>> GetAsync(string watcherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(watcherName, nameof(watcherName));

            using var scope = _automationWatcherWatcherClientDiagnostics.CreateScope("AutomationWatcherCollection.Get");
            scope.Start();
            try
            {
                var response = await _automationWatcherWatcherRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, watcherName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationWatcherResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the watcher identified by watcher name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/watchers/{watcherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Watcher_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="watcherName"> The watcher name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="watcherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="watcherName"/> is null. </exception>
        public virtual Response<AutomationWatcherResource> Get(string watcherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(watcherName, nameof(watcherName));

            using var scope = _automationWatcherWatcherClientDiagnostics.CreateScope("AutomationWatcherCollection.Get");
            scope.Start();
            try
            {
                var response = _automationWatcherWatcherRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, watcherName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationWatcherResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a list of watchers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/watchers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Watcher_ListByAutomationAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutomationWatcherResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutomationWatcherResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automationWatcherWatcherRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _automationWatcherWatcherRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new AutomationWatcherResource(Client, AutomationWatcherData.DeserializeAutomationWatcherData(e)), _automationWatcherWatcherClientDiagnostics, Pipeline, "AutomationWatcherCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of watchers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/watchers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Watcher_ListByAutomationAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutomationWatcherResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutomationWatcherResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automationWatcherWatcherRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _automationWatcherWatcherRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new AutomationWatcherResource(Client, AutomationWatcherData.DeserializeAutomationWatcherData(e)), _automationWatcherWatcherClientDiagnostics, Pipeline, "AutomationWatcherCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/watchers/{watcherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Watcher_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="watcherName"> The watcher name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="watcherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="watcherName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string watcherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(watcherName, nameof(watcherName));

            using var scope = _automationWatcherWatcherClientDiagnostics.CreateScope("AutomationWatcherCollection.Exists");
            scope.Start();
            try
            {
                var response = await _automationWatcherWatcherRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, watcherName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/watchers/{watcherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Watcher_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="watcherName"> The watcher name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="watcherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="watcherName"/> is null. </exception>
        public virtual Response<bool> Exists(string watcherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(watcherName, nameof(watcherName));

            using var scope = _automationWatcherWatcherClientDiagnostics.CreateScope("AutomationWatcherCollection.Exists");
            scope.Start();
            try
            {
                var response = _automationWatcherWatcherRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, watcherName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/watchers/{watcherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Watcher_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="watcherName"> The watcher name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="watcherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="watcherName"/> is null. </exception>
        public virtual async Task<NullableResponse<AutomationWatcherResource>> GetIfExistsAsync(string watcherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(watcherName, nameof(watcherName));

            using var scope = _automationWatcherWatcherClientDiagnostics.CreateScope("AutomationWatcherCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _automationWatcherWatcherRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, watcherName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AutomationWatcherResource>(response.GetRawResponse());
                return Response.FromValue(new AutomationWatcherResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/watchers/{watcherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Watcher_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="watcherName"> The watcher name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="watcherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="watcherName"/> is null. </exception>
        public virtual NullableResponse<AutomationWatcherResource> GetIfExists(string watcherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(watcherName, nameof(watcherName));

            using var scope = _automationWatcherWatcherClientDiagnostics.CreateScope("AutomationWatcherCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _automationWatcherWatcherRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, watcherName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AutomationWatcherResource>(response.GetRawResponse());
                return Response.FromValue(new AutomationWatcherResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AutomationWatcherResource> IEnumerable<AutomationWatcherResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AutomationWatcherResource> IAsyncEnumerable<AutomationWatcherResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
