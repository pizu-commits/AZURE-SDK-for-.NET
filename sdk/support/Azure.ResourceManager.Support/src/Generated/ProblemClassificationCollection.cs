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

namespace Azure.ResourceManager.Support
{
    /// <summary>
    /// A class representing a collection of <see cref="ProblemClassificationResource" /> and their operations.
    /// Each <see cref="ProblemClassificationResource" /> in the collection will belong to the same instance of <see cref="ServiceResource" />.
    /// To get a <see cref="ProblemClassificationCollection" /> instance call the GetProblemClassifications method from an instance of <see cref="ServiceResource" />.
    /// </summary>
    public partial class ProblemClassificationCollection : ArmCollection, IEnumerable<ProblemClassificationResource>, IAsyncEnumerable<ProblemClassificationResource>
    {
        private readonly ClientDiagnostics _problemClassificationClientDiagnostics;
        private readonly ProblemClassificationsRestOperations _problemClassificationRestClient;

        /// <summary> Initializes a new instance of the <see cref="ProblemClassificationCollection"/> class for mocking. </summary>
        protected ProblemClassificationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ProblemClassificationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ProblemClassificationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _problemClassificationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Support", ProblemClassificationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ProblemClassificationResource.ResourceType, out string problemClassificationApiVersion);
            _problemClassificationRestClient = new ProblemClassificationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, problemClassificationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get problem classification details for a specific Azure service.
        /// Request Path: /providers/Microsoft.Support/services/{serviceName}/problemClassifications/{problemClassificationName}
        /// Operation Id: ProblemClassifications_Get
        /// </summary>
        /// <param name="problemClassificationName"> Name of problem classification. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="problemClassificationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="problemClassificationName"/> is null. </exception>
        public virtual async Task<Response<ProblemClassificationResource>> GetAsync(string problemClassificationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(problemClassificationName, nameof(problemClassificationName));

            using var scope = _problemClassificationClientDiagnostics.CreateScope("ProblemClassificationCollection.Get");
            scope.Start();
            try
            {
                var response = await _problemClassificationRestClient.GetAsync(Id.Name, problemClassificationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProblemClassificationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get problem classification details for a specific Azure service.
        /// Request Path: /providers/Microsoft.Support/services/{serviceName}/problemClassifications/{problemClassificationName}
        /// Operation Id: ProblemClassifications_Get
        /// </summary>
        /// <param name="problemClassificationName"> Name of problem classification. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="problemClassificationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="problemClassificationName"/> is null. </exception>
        public virtual Response<ProblemClassificationResource> Get(string problemClassificationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(problemClassificationName, nameof(problemClassificationName));

            using var scope = _problemClassificationClientDiagnostics.CreateScope("ProblemClassificationCollection.Get");
            scope.Start();
            try
            {
                var response = _problemClassificationRestClient.Get(Id.Name, problemClassificationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProblemClassificationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the problem classifications (categories) available for a specific Azure service. Always use the service and problem classifications obtained programmatically. This practice ensures that you always have the most recent set of service and problem classification Ids.
        /// Request Path: /providers/Microsoft.Support/services/{serviceName}/problemClassifications
        /// Operation Id: ProblemClassifications_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProblemClassificationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ProblemClassificationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ProblemClassificationResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _problemClassificationClientDiagnostics.CreateScope("ProblemClassificationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _problemClassificationRestClient.ListAsync(Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ProblemClassificationResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Lists all the problem classifications (categories) available for a specific Azure service. Always use the service and problem classifications obtained programmatically. This practice ensures that you always have the most recent set of service and problem classification Ids.
        /// Request Path: /providers/Microsoft.Support/services/{serviceName}/problemClassifications
        /// Operation Id: ProblemClassifications_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProblemClassificationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ProblemClassificationResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ProblemClassificationResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _problemClassificationClientDiagnostics.CreateScope("ProblemClassificationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _problemClassificationRestClient.List(Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ProblemClassificationResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /providers/Microsoft.Support/services/{serviceName}/problemClassifications/{problemClassificationName}
        /// Operation Id: ProblemClassifications_Get
        /// </summary>
        /// <param name="problemClassificationName"> Name of problem classification. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="problemClassificationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="problemClassificationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string problemClassificationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(problemClassificationName, nameof(problemClassificationName));

            using var scope = _problemClassificationClientDiagnostics.CreateScope("ProblemClassificationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _problemClassificationRestClient.GetAsync(Id.Name, problemClassificationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /providers/Microsoft.Support/services/{serviceName}/problemClassifications/{problemClassificationName}
        /// Operation Id: ProblemClassifications_Get
        /// </summary>
        /// <param name="problemClassificationName"> Name of problem classification. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="problemClassificationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="problemClassificationName"/> is null. </exception>
        public virtual Response<bool> Exists(string problemClassificationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(problemClassificationName, nameof(problemClassificationName));

            using var scope = _problemClassificationClientDiagnostics.CreateScope("ProblemClassificationCollection.Exists");
            scope.Start();
            try
            {
                var response = _problemClassificationRestClient.Get(Id.Name, problemClassificationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ProblemClassificationResource> IEnumerable<ProblemClassificationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ProblemClassificationResource> IAsyncEnumerable<ProblemClassificationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
