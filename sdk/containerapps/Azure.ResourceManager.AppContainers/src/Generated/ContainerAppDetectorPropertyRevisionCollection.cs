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

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerAppDetectorPropertyRevisionResource"/> and their operations.
    /// Each <see cref="ContainerAppDetectorPropertyRevisionResource"/> in the collection will belong to the same instance of <see cref="ContainerAppResource"/>.
    /// To get a <see cref="ContainerAppDetectorPropertyRevisionCollection"/> instance call the GetContainerAppDetectorPropertyRevisions method from an instance of <see cref="ContainerAppResource"/>.
    /// </summary>
    public partial class ContainerAppDetectorPropertyRevisionCollection : ArmCollection, IEnumerable<ContainerAppDetectorPropertyRevisionResource>, IAsyncEnumerable<ContainerAppDetectorPropertyRevisionResource>
    {
        private readonly ClientDiagnostics _containerAppDetectorPropertyRevisionContainerAppsDiagnosticsClientDiagnostics;
        private readonly ContainerAppsDiagnosticsRestOperations _containerAppDetectorPropertyRevisionContainerAppsDiagnosticsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerAppDetectorPropertyRevisionCollection"/> class for mocking. </summary>
        protected ContainerAppDetectorPropertyRevisionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerAppDetectorPropertyRevisionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerAppDetectorPropertyRevisionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerAppDetectorPropertyRevisionContainerAppsDiagnosticsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppContainers", ContainerAppDetectorPropertyRevisionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerAppDetectorPropertyRevisionResource.ResourceType, out string containerAppDetectorPropertyRevisionContainerAppsDiagnosticsApiVersion);
            _containerAppDetectorPropertyRevisionContainerAppsDiagnosticsRestClient = new ContainerAppsDiagnosticsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerAppDetectorPropertyRevisionContainerAppsDiagnosticsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ContainerAppResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ContainerAppResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a revision of a Container App.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/detectorProperties/revisionsApi/revisions/{revisionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsDiagnostics_GetRevision</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppDetectorPropertyRevisionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="revisionName"> Name of the Container App Revision. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="revisionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="revisionName"/> is null. </exception>
        public virtual async Task<Response<ContainerAppDetectorPropertyRevisionResource>> GetAsync(string revisionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(revisionName, nameof(revisionName));

            using var scope = _containerAppDetectorPropertyRevisionContainerAppsDiagnosticsClientDiagnostics.CreateScope("ContainerAppDetectorPropertyRevisionCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerAppDetectorPropertyRevisionContainerAppsDiagnosticsRestClient.GetRevisionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, revisionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppDetectorPropertyRevisionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a revision of a Container App.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/detectorProperties/revisionsApi/revisions/{revisionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsDiagnostics_GetRevision</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppDetectorPropertyRevisionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="revisionName"> Name of the Container App Revision. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="revisionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="revisionName"/> is null. </exception>
        public virtual Response<ContainerAppDetectorPropertyRevisionResource> Get(string revisionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(revisionName, nameof(revisionName));

            using var scope = _containerAppDetectorPropertyRevisionContainerAppsDiagnosticsClientDiagnostics.CreateScope("ContainerAppDetectorPropertyRevisionCollection.Get");
            scope.Start();
            try
            {
                var response = _containerAppDetectorPropertyRevisionContainerAppsDiagnosticsRestClient.GetRevision(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, revisionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppDetectorPropertyRevisionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the Revisions for a given Container App.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/detectorProperties/revisionsApi/revisions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsDiagnostics_ListRevisions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppDetectorPropertyRevisionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerAppDetectorPropertyRevisionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerAppDetectorPropertyRevisionResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerAppDetectorPropertyRevisionContainerAppsDiagnosticsRestClient.CreateListRevisionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerAppDetectorPropertyRevisionContainerAppsDiagnosticsRestClient.CreateListRevisionsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ContainerAppDetectorPropertyRevisionResource(Client, ContainerAppRevisionData.DeserializeContainerAppRevisionData(e)), _containerAppDetectorPropertyRevisionContainerAppsDiagnosticsClientDiagnostics, Pipeline, "ContainerAppDetectorPropertyRevisionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the Revisions for a given Container App.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/detectorProperties/revisionsApi/revisions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsDiagnostics_ListRevisions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppDetectorPropertyRevisionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerAppDetectorPropertyRevisionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerAppDetectorPropertyRevisionResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerAppDetectorPropertyRevisionContainerAppsDiagnosticsRestClient.CreateListRevisionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerAppDetectorPropertyRevisionContainerAppsDiagnosticsRestClient.CreateListRevisionsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ContainerAppDetectorPropertyRevisionResource(Client, ContainerAppRevisionData.DeserializeContainerAppRevisionData(e)), _containerAppDetectorPropertyRevisionContainerAppsDiagnosticsClientDiagnostics, Pipeline, "ContainerAppDetectorPropertyRevisionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/detectorProperties/revisionsApi/revisions/{revisionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsDiagnostics_GetRevision</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppDetectorPropertyRevisionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="revisionName"> Name of the Container App Revision. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="revisionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="revisionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string revisionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(revisionName, nameof(revisionName));

            using var scope = _containerAppDetectorPropertyRevisionContainerAppsDiagnosticsClientDiagnostics.CreateScope("ContainerAppDetectorPropertyRevisionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerAppDetectorPropertyRevisionContainerAppsDiagnosticsRestClient.GetRevisionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, revisionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/detectorProperties/revisionsApi/revisions/{revisionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsDiagnostics_GetRevision</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppDetectorPropertyRevisionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="revisionName"> Name of the Container App Revision. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="revisionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="revisionName"/> is null. </exception>
        public virtual Response<bool> Exists(string revisionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(revisionName, nameof(revisionName));

            using var scope = _containerAppDetectorPropertyRevisionContainerAppsDiagnosticsClientDiagnostics.CreateScope("ContainerAppDetectorPropertyRevisionCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerAppDetectorPropertyRevisionContainerAppsDiagnosticsRestClient.GetRevision(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, revisionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/detectorProperties/revisionsApi/revisions/{revisionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsDiagnostics_GetRevision</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppDetectorPropertyRevisionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="revisionName"> Name of the Container App Revision. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="revisionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="revisionName"/> is null. </exception>
        public virtual async Task<NullableResponse<ContainerAppDetectorPropertyRevisionResource>> GetIfExistsAsync(string revisionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(revisionName, nameof(revisionName));

            using var scope = _containerAppDetectorPropertyRevisionContainerAppsDiagnosticsClientDiagnostics.CreateScope("ContainerAppDetectorPropertyRevisionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _containerAppDetectorPropertyRevisionContainerAppsDiagnosticsRestClient.GetRevisionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, revisionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ContainerAppDetectorPropertyRevisionResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerAppDetectorPropertyRevisionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/detectorProperties/revisionsApi/revisions/{revisionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsDiagnostics_GetRevision</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppDetectorPropertyRevisionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="revisionName"> Name of the Container App Revision. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="revisionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="revisionName"/> is null. </exception>
        public virtual NullableResponse<ContainerAppDetectorPropertyRevisionResource> GetIfExists(string revisionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(revisionName, nameof(revisionName));

            using var scope = _containerAppDetectorPropertyRevisionContainerAppsDiagnosticsClientDiagnostics.CreateScope("ContainerAppDetectorPropertyRevisionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _containerAppDetectorPropertyRevisionContainerAppsDiagnosticsRestClient.GetRevision(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, revisionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ContainerAppDetectorPropertyRevisionResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerAppDetectorPropertyRevisionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerAppDetectorPropertyRevisionResource> IEnumerable<ContainerAppDetectorPropertyRevisionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerAppDetectorPropertyRevisionResource> IAsyncEnumerable<ContainerAppDetectorPropertyRevisionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
