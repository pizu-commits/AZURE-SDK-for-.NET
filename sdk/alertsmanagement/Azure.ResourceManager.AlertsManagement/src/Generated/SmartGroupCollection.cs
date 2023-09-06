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
using Azure.ResourceManager.AlertsManagement.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AlertsManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="SmartGroupResource" /> and their operations.
    /// Each <see cref="SmartGroupResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="SmartGroupCollection" /> instance call the GetSmartGroups method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class SmartGroupCollection : ArmCollection, IEnumerable<SmartGroupResource>, IAsyncEnumerable<SmartGroupResource>
    {
        private readonly ClientDiagnostics _smartGroupClientDiagnostics;
        private readonly SmartGroupsRestOperations _smartGroupRestClient;

        /// <summary> Initializes a new instance of the <see cref="SmartGroupCollection"/> class for mocking. </summary>
        protected SmartGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SmartGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SmartGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _smartGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AlertsManagement", SmartGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SmartGroupResource.ResourceType, out string smartGroupApiVersion);
            _smartGroupRestClient = new SmartGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, smartGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get information related to a specific Smart Group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AlertsManagement/smartGroups/{smartGroupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SmartGroups_GetById</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="smartGroupId"> Smart group unique id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SmartGroupResource>> GetAsync(Guid smartGroupId, CancellationToken cancellationToken = default)
        {
            using var scope = _smartGroupClientDiagnostics.CreateScope("SmartGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _smartGroupRestClient.GetByIdAsync(Id.SubscriptionId, smartGroupId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SmartGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get information related to a specific Smart Group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AlertsManagement/smartGroups/{smartGroupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SmartGroups_GetById</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="smartGroupId"> Smart group unique id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SmartGroupResource> Get(Guid smartGroupId, CancellationToken cancellationToken = default)
        {
            using var scope = _smartGroupClientDiagnostics.CreateScope("SmartGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _smartGroupRestClient.GetById(Id.SubscriptionId, smartGroupId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SmartGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the Smart Groups within a specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AlertsManagement/smartGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SmartGroups_GetAll</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SmartGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SmartGroupResource> GetAllAsync(SmartGroupCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new SmartGroupCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _smartGroupRestClient.CreateGetAllRequest(Id.SubscriptionId, options.TargetResource, options.TargetResourceGroup, options.TargetResourceType, options.MonitorService, options.MonitorCondition, options.Severity, options.SmartGroupState, options.TimeRange, options.PageCount, options.SortBy, options.SortOrder);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _smartGroupRestClient.CreateGetAllNextPageRequest(nextLink, Id.SubscriptionId, options.TargetResource, options.TargetResourceGroup, options.TargetResourceType, options.MonitorService, options.MonitorCondition, options.Severity, options.SmartGroupState, options.TimeRange, options.PageCount, options.SortBy, options.SortOrder);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new SmartGroupResource(Client, SmartGroupData.DeserializeSmartGroupData(e)), _smartGroupClientDiagnostics, Pipeline, "SmartGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the Smart Groups within a specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AlertsManagement/smartGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SmartGroups_GetAll</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SmartGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SmartGroupResource> GetAll(SmartGroupCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new SmartGroupCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _smartGroupRestClient.CreateGetAllRequest(Id.SubscriptionId, options.TargetResource, options.TargetResourceGroup, options.TargetResourceType, options.MonitorService, options.MonitorCondition, options.Severity, options.SmartGroupState, options.TimeRange, options.PageCount, options.SortBy, options.SortOrder);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _smartGroupRestClient.CreateGetAllNextPageRequest(nextLink, Id.SubscriptionId, options.TargetResource, options.TargetResourceGroup, options.TargetResourceType, options.MonitorService, options.MonitorCondition, options.Severity, options.SmartGroupState, options.TimeRange, options.PageCount, options.SortBy, options.SortOrder);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new SmartGroupResource(Client, SmartGroupData.DeserializeSmartGroupData(e)), _smartGroupClientDiagnostics, Pipeline, "SmartGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AlertsManagement/smartGroups/{smartGroupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SmartGroups_GetById</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="smartGroupId"> Smart group unique id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(Guid smartGroupId, CancellationToken cancellationToken = default)
        {
            using var scope = _smartGroupClientDiagnostics.CreateScope("SmartGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _smartGroupRestClient.GetByIdAsync(Id.SubscriptionId, smartGroupId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AlertsManagement/smartGroups/{smartGroupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SmartGroups_GetById</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="smartGroupId"> Smart group unique id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(Guid smartGroupId, CancellationToken cancellationToken = default)
        {
            using var scope = _smartGroupClientDiagnostics.CreateScope("SmartGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _smartGroupRestClient.GetById(Id.SubscriptionId, smartGroupId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SmartGroupResource> IEnumerable<SmartGroupResource>.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IAsyncEnumerator<SmartGroupResource> IAsyncEnumerable<SmartGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(options: null, cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
