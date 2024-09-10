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

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="SecurityInsightsFileImportResource"/> and their operations.
    /// Each <see cref="SecurityInsightsFileImportResource"/> in the collection will belong to the same instance of <see cref="OperationalInsightsWorkspaceSecurityInsightsResource"/>.
    /// To get a <see cref="SecurityInsightsFileImportCollection"/> instance call the GetSecurityInsightsFileImports method from an instance of <see cref="OperationalInsightsWorkspaceSecurityInsightsResource"/>.
    /// </summary>
    public partial class SecurityInsightsFileImportCollection : ArmCollection, IEnumerable<SecurityInsightsFileImportResource>, IAsyncEnumerable<SecurityInsightsFileImportResource>
    {
        private readonly ClientDiagnostics _securityInsightsFileImportFileImportsClientDiagnostics;
        private readonly FileImportsRestOperations _securityInsightsFileImportFileImportsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SecurityInsightsFileImportCollection"/> class for mocking. </summary>
        protected SecurityInsightsFileImportCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityInsightsFileImportCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SecurityInsightsFileImportCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityInsightsFileImportFileImportsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityInsights", SecurityInsightsFileImportResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SecurityInsightsFileImportResource.ResourceType, out string securityInsightsFileImportFileImportsApiVersion);
            _securityInsightsFileImportFileImportsRestClient = new FileImportsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityInsightsFileImportFileImportsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != OperationalInsightsWorkspaceSecurityInsightsResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, OperationalInsightsWorkspaceSecurityInsightsResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates the file import.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/fileImports/{fileImportId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileImports_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsFileImportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fileImportId"> File import ID. </param>
        /// <param name="data"> The file import. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileImportId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileImportId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SecurityInsightsFileImportResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string fileImportId, SecurityInsightsFileImportData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileImportId, nameof(fileImportId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityInsightsFileImportFileImportsClientDiagnostics.CreateScope("SecurityInsightsFileImportCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _securityInsightsFileImportFileImportsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fileImportId, data, cancellationToken).ConfigureAwait(false);
                var uri = _securityInsightsFileImportFileImportsRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fileImportId, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SecurityInsightsArmOperation<SecurityInsightsFileImportResource>(Response.FromValue(new SecurityInsightsFileImportResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Creates the file import.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/fileImports/{fileImportId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileImports_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsFileImportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fileImportId"> File import ID. </param>
        /// <param name="data"> The file import. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileImportId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileImportId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SecurityInsightsFileImportResource> CreateOrUpdate(WaitUntil waitUntil, string fileImportId, SecurityInsightsFileImportData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileImportId, nameof(fileImportId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityInsightsFileImportFileImportsClientDiagnostics.CreateScope("SecurityInsightsFileImportCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _securityInsightsFileImportFileImportsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fileImportId, data, cancellationToken);
                var uri = _securityInsightsFileImportFileImportsRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fileImportId, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SecurityInsightsArmOperation<SecurityInsightsFileImportResource>(Response.FromValue(new SecurityInsightsFileImportResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Gets a file import.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/fileImports/{fileImportId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileImports_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsFileImportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileImportId"> File import ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileImportId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileImportId"/> is null. </exception>
        public virtual async Task<Response<SecurityInsightsFileImportResource>> GetAsync(string fileImportId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileImportId, nameof(fileImportId));

            using var scope = _securityInsightsFileImportFileImportsClientDiagnostics.CreateScope("SecurityInsightsFileImportCollection.Get");
            scope.Start();
            try
            {
                var response = await _securityInsightsFileImportFileImportsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fileImportId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsFileImportResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a file import.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/fileImports/{fileImportId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileImports_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsFileImportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileImportId"> File import ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileImportId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileImportId"/> is null. </exception>
        public virtual Response<SecurityInsightsFileImportResource> Get(string fileImportId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileImportId, nameof(fileImportId));

            using var scope = _securityInsightsFileImportFileImportsClientDiagnostics.CreateScope("SecurityInsightsFileImportCollection.Get");
            scope.Start();
            try
            {
                var response = _securityInsightsFileImportFileImportsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fileImportId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsFileImportResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all file imports.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/fileImports</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileImports_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsFileImportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Filters the results, based on a Boolean condition. Optional. </param>
        /// <param name="orderBy"> Sorts the results. Optional. </param>
        /// <param name="top"> Returns only the first n results. Optional. </param>
        /// <param name="skipToken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecurityInsightsFileImportResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SecurityInsightsFileImportResource> GetAllAsync(string filter = null, string orderBy = null, int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityInsightsFileImportFileImportsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, orderBy, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityInsightsFileImportFileImportsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, orderBy, top, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SecurityInsightsFileImportResource(Client, SecurityInsightsFileImportData.DeserializeSecurityInsightsFileImportData(e)), _securityInsightsFileImportFileImportsClientDiagnostics, Pipeline, "SecurityInsightsFileImportCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all file imports.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/fileImports</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileImports_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsFileImportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Filters the results, based on a Boolean condition. Optional. </param>
        /// <param name="orderBy"> Sorts the results. Optional. </param>
        /// <param name="top"> Returns only the first n results. Optional. </param>
        /// <param name="skipToken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecurityInsightsFileImportResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SecurityInsightsFileImportResource> GetAll(string filter = null, string orderBy = null, int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityInsightsFileImportFileImportsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, orderBy, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityInsightsFileImportFileImportsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, orderBy, top, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SecurityInsightsFileImportResource(Client, SecurityInsightsFileImportData.DeserializeSecurityInsightsFileImportData(e)), _securityInsightsFileImportFileImportsClientDiagnostics, Pipeline, "SecurityInsightsFileImportCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/fileImports/{fileImportId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileImports_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsFileImportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileImportId"> File import ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileImportId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileImportId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string fileImportId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileImportId, nameof(fileImportId));

            using var scope = _securityInsightsFileImportFileImportsClientDiagnostics.CreateScope("SecurityInsightsFileImportCollection.Exists");
            scope.Start();
            try
            {
                var response = await _securityInsightsFileImportFileImportsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fileImportId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/fileImports/{fileImportId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileImports_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsFileImportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileImportId"> File import ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileImportId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileImportId"/> is null. </exception>
        public virtual Response<bool> Exists(string fileImportId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileImportId, nameof(fileImportId));

            using var scope = _securityInsightsFileImportFileImportsClientDiagnostics.CreateScope("SecurityInsightsFileImportCollection.Exists");
            scope.Start();
            try
            {
                var response = _securityInsightsFileImportFileImportsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fileImportId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/fileImports/{fileImportId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileImports_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsFileImportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileImportId"> File import ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileImportId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileImportId"/> is null. </exception>
        public virtual async Task<NullableResponse<SecurityInsightsFileImportResource>> GetIfExistsAsync(string fileImportId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileImportId, nameof(fileImportId));

            using var scope = _securityInsightsFileImportFileImportsClientDiagnostics.CreateScope("SecurityInsightsFileImportCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _securityInsightsFileImportFileImportsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fileImportId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SecurityInsightsFileImportResource>(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsFileImportResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/fileImports/{fileImportId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileImports_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsFileImportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileImportId"> File import ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileImportId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileImportId"/> is null. </exception>
        public virtual NullableResponse<SecurityInsightsFileImportResource> GetIfExists(string fileImportId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileImportId, nameof(fileImportId));

            using var scope = _securityInsightsFileImportFileImportsClientDiagnostics.CreateScope("SecurityInsightsFileImportCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _securityInsightsFileImportFileImportsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fileImportId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SecurityInsightsFileImportResource>(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsFileImportResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SecurityInsightsFileImportResource> IEnumerable<SecurityInsightsFileImportResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SecurityInsightsFileImportResource> IAsyncEnumerable<SecurityInsightsFileImportResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
