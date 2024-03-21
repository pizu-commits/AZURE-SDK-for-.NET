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

namespace Azure.ResourceManager.WorkloadMonitor
{
    /// <summary>
    /// A class representing a collection of <see cref="HealthMonitorResource"/> and their operations.
    /// Each <see cref="HealthMonitorResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="HealthMonitorCollection"/> instance call the GetHealthMonitors method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class HealthMonitorCollection : ArmCollection, IEnumerable<HealthMonitorResource>, IAsyncEnumerable<HealthMonitorResource>
    {
        private readonly ClientDiagnostics _healthMonitorClientDiagnostics;
        private readonly HealthMonitorsRestOperations _healthMonitorRestClient;
        private readonly string _providerName;
        private readonly string _resourceCollectionName;
        private readonly string _resourceName;

        /// <summary> Initializes a new instance of the <see cref="HealthMonitorCollection"/> class for mocking. </summary>
        protected HealthMonitorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HealthMonitorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="providerName"> The provider name (ex: Microsoft.Compute for virtual machines). </param>
        /// <param name="resourceCollectionName"> The resource collection name (ex: virtualMachines for virtual machines). </param>
        /// <param name="resourceName"> The name of the virtual machine. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/>, <paramref name="resourceCollectionName"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/>, <paramref name="resourceCollectionName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        internal HealthMonitorCollection(ArmClient client, ResourceIdentifier id, string providerName, string resourceCollectionName, string resourceName) : base(client, id)
        {
            _providerName = providerName;
            _resourceCollectionName = resourceCollectionName;
            _resourceName = resourceName;
            _healthMonitorClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.WorkloadMonitor", HealthMonitorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HealthMonitorResource.ResourceType, out string healthMonitorApiVersion);
            _healthMonitorRestClient = new HealthMonitorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, healthMonitorApiVersion);
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
        /// Get the current health status of a monitor of a virtual machine. Optional parameter: $expand (retrieve the monitor's evidence and configuration).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{providerName}/{resourceCollectionName}/{resourceName}/providers/Microsoft.WorkloadMonitor/monitors/{monitorId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HealthMonitors_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HealthMonitorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="monitorId"> The monitor Id of the virtual machine. </param>
        /// <param name="expand"> Optionally expand the monitor’s evidence and/or configuration. Example: $expand=evidence,configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="monitorId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorId"/> is null. </exception>
        public virtual async Task<Response<HealthMonitorResource>> GetAsync(string monitorId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(monitorId, nameof(monitorId));

            using var scope = _healthMonitorClientDiagnostics.CreateScope("HealthMonitorCollection.Get");
            scope.Start();
            try
            {
                var response = await _healthMonitorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _providerName, _resourceCollectionName, _resourceName, monitorId, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HealthMonitorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the current health status of a monitor of a virtual machine. Optional parameter: $expand (retrieve the monitor's evidence and configuration).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{providerName}/{resourceCollectionName}/{resourceName}/providers/Microsoft.WorkloadMonitor/monitors/{monitorId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HealthMonitors_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HealthMonitorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="monitorId"> The monitor Id of the virtual machine. </param>
        /// <param name="expand"> Optionally expand the monitor’s evidence and/or configuration. Example: $expand=evidence,configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="monitorId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorId"/> is null. </exception>
        public virtual Response<HealthMonitorResource> Get(string monitorId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(monitorId, nameof(monitorId));

            using var scope = _healthMonitorClientDiagnostics.CreateScope("HealthMonitorCollection.Get");
            scope.Start();
            try
            {
                var response = _healthMonitorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _providerName, _resourceCollectionName, _resourceName, monitorId, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HealthMonitorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the current health status of all monitors of a virtual machine. Optional parameters: $expand (retrieve the monitor's evidence and configuration) and $filter (filter by monitor name).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{providerName}/{resourceCollectionName}/{resourceName}/providers/Microsoft.WorkloadMonitor/monitors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HealthMonitors_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HealthMonitorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Optionally filter by monitor name. Example: $filter=monitorName eq 'logical-disks|C:|disk-free-space-mb.'. </param>
        /// <param name="expand"> Optionally expand the monitor’s evidence and/or configuration. Example: $expand=evidence,configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HealthMonitorResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HealthMonitorResource> GetAllAsync(string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _healthMonitorRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _providerName, _resourceCollectionName, _resourceName, filter, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _healthMonitorRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _providerName, _resourceCollectionName, _resourceName, filter, expand);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new HealthMonitorResource(Client, HealthMonitorData.DeserializeHealthMonitorData(e)), _healthMonitorClientDiagnostics, Pipeline, "HealthMonitorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the current health status of all monitors of a virtual machine. Optional parameters: $expand (retrieve the monitor's evidence and configuration) and $filter (filter by monitor name).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{providerName}/{resourceCollectionName}/{resourceName}/providers/Microsoft.WorkloadMonitor/monitors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HealthMonitors_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HealthMonitorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Optionally filter by monitor name. Example: $filter=monitorName eq 'logical-disks|C:|disk-free-space-mb.'. </param>
        /// <param name="expand"> Optionally expand the monitor’s evidence and/or configuration. Example: $expand=evidence,configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HealthMonitorResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HealthMonitorResource> GetAll(string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _healthMonitorRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _providerName, _resourceCollectionName, _resourceName, filter, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _healthMonitorRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _providerName, _resourceCollectionName, _resourceName, filter, expand);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new HealthMonitorResource(Client, HealthMonitorData.DeserializeHealthMonitorData(e)), _healthMonitorClientDiagnostics, Pipeline, "HealthMonitorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{providerName}/{resourceCollectionName}/{resourceName}/providers/Microsoft.WorkloadMonitor/monitors/{monitorId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HealthMonitors_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HealthMonitorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="monitorId"> The monitor Id of the virtual machine. </param>
        /// <param name="expand"> Optionally expand the monitor’s evidence and/or configuration. Example: $expand=evidence,configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="monitorId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string monitorId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(monitorId, nameof(monitorId));

            using var scope = _healthMonitorClientDiagnostics.CreateScope("HealthMonitorCollection.Exists");
            scope.Start();
            try
            {
                var response = await _healthMonitorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _providerName, _resourceCollectionName, _resourceName, monitorId, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{providerName}/{resourceCollectionName}/{resourceName}/providers/Microsoft.WorkloadMonitor/monitors/{monitorId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HealthMonitors_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HealthMonitorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="monitorId"> The monitor Id of the virtual machine. </param>
        /// <param name="expand"> Optionally expand the monitor’s evidence and/or configuration. Example: $expand=evidence,configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="monitorId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorId"/> is null. </exception>
        public virtual Response<bool> Exists(string monitorId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(monitorId, nameof(monitorId));

            using var scope = _healthMonitorClientDiagnostics.CreateScope("HealthMonitorCollection.Exists");
            scope.Start();
            try
            {
                var response = _healthMonitorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _providerName, _resourceCollectionName, _resourceName, monitorId, expand, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{providerName}/{resourceCollectionName}/{resourceName}/providers/Microsoft.WorkloadMonitor/monitors/{monitorId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HealthMonitors_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HealthMonitorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="monitorId"> The monitor Id of the virtual machine. </param>
        /// <param name="expand"> Optionally expand the monitor’s evidence and/or configuration. Example: $expand=evidence,configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="monitorId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorId"/> is null. </exception>
        public virtual async Task<NullableResponse<HealthMonitorResource>> GetIfExistsAsync(string monitorId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(monitorId, nameof(monitorId));

            using var scope = _healthMonitorClientDiagnostics.CreateScope("HealthMonitorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _healthMonitorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _providerName, _resourceCollectionName, _resourceName, monitorId, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<HealthMonitorResource>(response.GetRawResponse());
                return Response.FromValue(new HealthMonitorResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{providerName}/{resourceCollectionName}/{resourceName}/providers/Microsoft.WorkloadMonitor/monitors/{monitorId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HealthMonitors_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HealthMonitorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="monitorId"> The monitor Id of the virtual machine. </param>
        /// <param name="expand"> Optionally expand the monitor’s evidence and/or configuration. Example: $expand=evidence,configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="monitorId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorId"/> is null. </exception>
        public virtual NullableResponse<HealthMonitorResource> GetIfExists(string monitorId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(monitorId, nameof(monitorId));

            using var scope = _healthMonitorClientDiagnostics.CreateScope("HealthMonitorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _healthMonitorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _providerName, _resourceCollectionName, _resourceName, monitorId, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<HealthMonitorResource>(response.GetRawResponse());
                return Response.FromValue(new HealthMonitorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HealthMonitorResource> IEnumerable<HealthMonitorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HealthMonitorResource> IAsyncEnumerable<HealthMonitorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
