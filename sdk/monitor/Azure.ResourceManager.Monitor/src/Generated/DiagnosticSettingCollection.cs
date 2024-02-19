// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Monitor
{
    /// <summary>
    /// A class representing a collection of <see cref="DiagnosticSettingResource"/> and their operations.
    /// Each <see cref="DiagnosticSettingResource"/> in the collection will belong to the same instance of <see cref="ArmResource"/>.
    /// To get a <see cref="DiagnosticSettingCollection"/> instance call the GetDiagnosticSettings method from an instance of <see cref="ArmResource"/>.
    /// </summary>
    public partial class DiagnosticSettingCollection : ArmCollection, IEnumerable<DiagnosticSettingResource>, IAsyncEnumerable<DiagnosticSettingResource>
    {
        private readonly ClientDiagnostics _diagnosticSettingClientDiagnostics;
        private readonly DiagnosticSettingsRestOperations _diagnosticSettingRestClient;

        /// <summary> Initializes a new instance of the <see cref="DiagnosticSettingCollection"/> class for mocking. </summary>
        protected DiagnosticSettingCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DiagnosticSettingCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DiagnosticSettingCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _diagnosticSettingClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Monitor", DiagnosticSettingResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DiagnosticSettingResource.ResourceType, out string diagnosticSettingApiVersion);
            _diagnosticSettingRestClient = new DiagnosticSettingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, diagnosticSettingApiVersion);
        }

        /// <summary>
        /// Creates or updates diagnostic settings for the specified resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiagnosticSettings_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiagnosticSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="data"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DiagnosticSettingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, DiagnosticSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _diagnosticSettingClientDiagnostics.CreateScope("DiagnosticSettingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _diagnosticSettingRestClient.CreateOrUpdateAsync(Id, name, data, cancellationToken).ConfigureAwait(false);
                var uri = _diagnosticSettingRestClient.CreateCreateOrUpdateRequestUri(Id, name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new MonitorArmOperation<DiagnosticSettingResource>(Response.FromValue(new DiagnosticSettingResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Creates or updates diagnostic settings for the specified resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiagnosticSettings_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiagnosticSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="data"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DiagnosticSettingResource> CreateOrUpdate(WaitUntil waitUntil, string name, DiagnosticSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _diagnosticSettingClientDiagnostics.CreateScope("DiagnosticSettingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _diagnosticSettingRestClient.CreateOrUpdate(Id, name, data, cancellationToken);
                var uri = _diagnosticSettingRestClient.CreateCreateOrUpdateRequestUri(Id, name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new MonitorArmOperation<DiagnosticSettingResource>(Response.FromValue(new DiagnosticSettingResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Gets the active diagnostic settings for the specified resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiagnosticSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiagnosticSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<DiagnosticSettingResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _diagnosticSettingClientDiagnostics.CreateScope("DiagnosticSettingCollection.Get");
            scope.Start();
            try
            {
                var response = await _diagnosticSettingRestClient.GetAsync(Id, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiagnosticSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the active diagnostic settings for the specified resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiagnosticSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiagnosticSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<DiagnosticSettingResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _diagnosticSettingClientDiagnostics.CreateScope("DiagnosticSettingCollection.Get");
            scope.Start();
            try
            {
                var response = _diagnosticSettingRestClient.Get(Id, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiagnosticSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the active diagnostic settings list for the specified resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Insights/diagnosticSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiagnosticSettings_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiagnosticSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DiagnosticSettingResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DiagnosticSettingResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _diagnosticSettingRestClient.CreateListRequest(Id);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new DiagnosticSettingResource(Client, DiagnosticSettingData.DeserializeDiagnosticSettingData(e)), _diagnosticSettingClientDiagnostics, Pipeline, "DiagnosticSettingCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets the active diagnostic settings list for the specified resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Insights/diagnosticSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiagnosticSettings_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiagnosticSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DiagnosticSettingResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DiagnosticSettingResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _diagnosticSettingRestClient.CreateListRequest(Id);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new DiagnosticSettingResource(Client, DiagnosticSettingData.DeserializeDiagnosticSettingData(e)), _diagnosticSettingClientDiagnostics, Pipeline, "DiagnosticSettingCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiagnosticSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiagnosticSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _diagnosticSettingClientDiagnostics.CreateScope("DiagnosticSettingCollection.Exists");
            scope.Start();
            try
            {
                var response = await _diagnosticSettingRestClient.GetAsync(Id, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiagnosticSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiagnosticSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _diagnosticSettingClientDiagnostics.CreateScope("DiagnosticSettingCollection.Exists");
            scope.Start();
            try
            {
                var response = _diagnosticSettingRestClient.Get(Id, name, cancellationToken: cancellationToken);
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
        /// <description>/{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiagnosticSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiagnosticSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<NullableResponse<DiagnosticSettingResource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _diagnosticSettingClientDiagnostics.CreateScope("DiagnosticSettingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _diagnosticSettingRestClient.GetAsync(Id, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DiagnosticSettingResource>(response.GetRawResponse());
                return Response.FromValue(new DiagnosticSettingResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiagnosticSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiagnosticSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual NullableResponse<DiagnosticSettingResource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _diagnosticSettingClientDiagnostics.CreateScope("DiagnosticSettingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _diagnosticSettingRestClient.Get(Id, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DiagnosticSettingResource>(response.GetRawResponse());
                return Response.FromValue(new DiagnosticSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DiagnosticSettingResource> IEnumerable<DiagnosticSettingResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DiagnosticSettingResource> IAsyncEnumerable<DiagnosticSettingResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
