// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of SourceControl and their operations over its parent. </summary>
    public partial class SourceControlCollection : ArmCollection, IEnumerable<SourceControl>, IAsyncEnumerable<SourceControl>
    {
        private readonly ClientDiagnostics _sourceControlClientDiagnostics;
        private readonly WebSiteManagementRestOperations _sourceControlRestClient;

        /// <summary> Initializes a new instance of the <see cref="SourceControlCollection"/> class for mocking. </summary>
        protected SourceControlCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SourceControlCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SourceControlCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sourceControlClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SourceControl.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(SourceControl.ResourceType, out string sourceControlApiVersion);
            _sourceControlRestClient = new WebSiteManagementRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, sourceControlApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Tenant.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Tenant.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Updates source control token
        /// Request Path: /providers/Microsoft.Web/sourcecontrols/{sourceControlType}
        /// Operation Id: UpdateSourceControl
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sourceControlType"> Type of source control. </param>
        /// <param name="requestMessage"> Source control token information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlType"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlType"/> or <paramref name="requestMessage"/> is null. </exception>
        public virtual async Task<ArmOperation<SourceControl>> CreateOrUpdateAsync(WaitUntil waitUntil, string sourceControlType, SourceControlData requestMessage, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlType, nameof(sourceControlType));
            Argument.AssertNotNull(requestMessage, nameof(requestMessage));

            using var scope = _sourceControlClientDiagnostics.CreateScope("SourceControlCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sourceControlRestClient.UpdateSourceControlAsync(sourceControlType, requestMessage, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<SourceControl>(Response.FromValue(new SourceControl(Client, response), response.GetRawResponse()));
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
        /// Description for Updates source control token
        /// Request Path: /providers/Microsoft.Web/sourcecontrols/{sourceControlType}
        /// Operation Id: UpdateSourceControl
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sourceControlType"> Type of source control. </param>
        /// <param name="requestMessage"> Source control token information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlType"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlType"/> or <paramref name="requestMessage"/> is null. </exception>
        public virtual ArmOperation<SourceControl> CreateOrUpdate(WaitUntil waitUntil, string sourceControlType, SourceControlData requestMessage, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlType, nameof(sourceControlType));
            Argument.AssertNotNull(requestMessage, nameof(requestMessage));

            using var scope = _sourceControlClientDiagnostics.CreateScope("SourceControlCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sourceControlRestClient.UpdateSourceControl(sourceControlType, requestMessage, cancellationToken);
                var operation = new AppServiceArmOperation<SourceControl>(Response.FromValue(new SourceControl(Client, response), response.GetRawResponse()));
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
        /// Description for Gets source control token
        /// Request Path: /providers/Microsoft.Web/sourcecontrols/{sourceControlType}
        /// Operation Id: GetSourceControl
        /// </summary>
        /// <param name="sourceControlType"> Type of source control. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlType"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlType"/> is null. </exception>
        public virtual async Task<Response<SourceControl>> GetAsync(string sourceControlType, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlType, nameof(sourceControlType));

            using var scope = _sourceControlClientDiagnostics.CreateScope("SourceControlCollection.Get");
            scope.Start();
            try
            {
                var response = await _sourceControlRestClient.GetSourceControlAsync(sourceControlType, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SourceControl(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets source control token
        /// Request Path: /providers/Microsoft.Web/sourcecontrols/{sourceControlType}
        /// Operation Id: GetSourceControl
        /// </summary>
        /// <param name="sourceControlType"> Type of source control. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlType"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlType"/> is null. </exception>
        public virtual Response<SourceControl> Get(string sourceControlType, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlType, nameof(sourceControlType));

            using var scope = _sourceControlClientDiagnostics.CreateScope("SourceControlCollection.Get");
            scope.Start();
            try
            {
                var response = _sourceControlRestClient.GetSourceControl(sourceControlType, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SourceControl(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the source controls available for Azure websites.
        /// Request Path: /providers/Microsoft.Web/sourcecontrols
        /// Operation Id: ListSourceControls
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SourceControl" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SourceControl> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SourceControl>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sourceControlClientDiagnostics.CreateScope("SourceControlCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sourceControlRestClient.ListSourceControlsAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SourceControl(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SourceControl>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sourceControlClientDiagnostics.CreateScope("SourceControlCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sourceControlRestClient.ListSourceControlsNextPageAsync(nextLink, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SourceControl(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Description for Gets the source controls available for Azure websites.
        /// Request Path: /providers/Microsoft.Web/sourcecontrols
        /// Operation Id: ListSourceControls
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SourceControl" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SourceControl> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SourceControl> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sourceControlClientDiagnostics.CreateScope("SourceControlCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sourceControlRestClient.ListSourceControls(cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SourceControl(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SourceControl> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sourceControlClientDiagnostics.CreateScope("SourceControlCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sourceControlRestClient.ListSourceControlsNextPage(nextLink, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SourceControl(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /providers/Microsoft.Web/sourcecontrols/{sourceControlType}
        /// Operation Id: GetSourceControl
        /// </summary>
        /// <param name="sourceControlType"> Type of source control. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlType"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlType"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sourceControlType, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlType, nameof(sourceControlType));

            using var scope = _sourceControlClientDiagnostics.CreateScope("SourceControlCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(sourceControlType, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /providers/Microsoft.Web/sourcecontrols/{sourceControlType}
        /// Operation Id: GetSourceControl
        /// </summary>
        /// <param name="sourceControlType"> Type of source control. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlType"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlType"/> is null. </exception>
        public virtual Response<bool> Exists(string sourceControlType, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlType, nameof(sourceControlType));

            using var scope = _sourceControlClientDiagnostics.CreateScope("SourceControlCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(sourceControlType, cancellationToken: cancellationToken);
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
        /// Request Path: /providers/Microsoft.Web/sourcecontrols/{sourceControlType}
        /// Operation Id: GetSourceControl
        /// </summary>
        /// <param name="sourceControlType"> Type of source control. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlType"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlType"/> is null. </exception>
        public virtual async Task<Response<SourceControl>> GetIfExistsAsync(string sourceControlType, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlType, nameof(sourceControlType));

            using var scope = _sourceControlClientDiagnostics.CreateScope("SourceControlCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sourceControlRestClient.GetSourceControlAsync(sourceControlType, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SourceControl>(null, response.GetRawResponse());
                return Response.FromValue(new SourceControl(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /providers/Microsoft.Web/sourcecontrols/{sourceControlType}
        /// Operation Id: GetSourceControl
        /// </summary>
        /// <param name="sourceControlType"> Type of source control. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlType"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlType"/> is null. </exception>
        public virtual Response<SourceControl> GetIfExists(string sourceControlType, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlType, nameof(sourceControlType));

            using var scope = _sourceControlClientDiagnostics.CreateScope("SourceControlCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sourceControlRestClient.GetSourceControl(sourceControlType, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SourceControl>(null, response.GetRawResponse());
                return Response.FromValue(new SourceControl(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SourceControl> IEnumerable<SourceControl>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SourceControl> IAsyncEnumerable<SourceControl>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
