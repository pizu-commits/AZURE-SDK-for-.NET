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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of Certificate and their operations over its parent. </summary>
    public partial class CertificateCollection : ArmCollection, IEnumerable<Certificate>, IAsyncEnumerable<Certificate>
    {
        private readonly ClientDiagnostics _certificateClientDiagnostics;
        private readonly CertificatesRestOperations _certificateRestClient;

        /// <summary> Initializes a new instance of the <see cref="CertificateCollection"/> class for mocking. </summary>
        protected CertificateCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CertificateCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal CertificateCollection(ArmResource parent) : base(parent)
        {
            _certificateClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", Certificate.ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(Certificate.ResourceType, out string certificateApiVersion);
            _certificateRestClient = new CertificatesRestOperations(_certificateClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, certificateApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/certificates/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Certificates_CreateOrUpdate
        /// <summary> Description for Create or update a certificate. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="certificateEnvelope"> Details of certificate, if it exists already. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="certificateEnvelope"/> is null. </exception>
        public virtual CertificateCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string name, CertificateData certificateEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            if (certificateEnvelope == null)
            {
                throw new ArgumentNullException(nameof(certificateEnvelope));
            }

            using var scope = _certificateClientDiagnostics.CreateScope("CertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _certificateRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, name, certificateEnvelope, cancellationToken);
                var operation = new CertificateCreateOrUpdateOperation(ArmClient, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/certificates/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Certificates_CreateOrUpdate
        /// <summary> Description for Create or update a certificate. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="certificateEnvelope"> Details of certificate, if it exists already. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="certificateEnvelope"/> is null. </exception>
        public async virtual Task<CertificateCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string name, CertificateData certificateEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            if (certificateEnvelope == null)
            {
                throw new ArgumentNullException(nameof(certificateEnvelope));
            }

            using var scope = _certificateClientDiagnostics.CreateScope("CertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _certificateRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, name, certificateEnvelope, cancellationToken).ConfigureAwait(false);
                var operation = new CertificateCreateOrUpdateOperation(ArmClient, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/certificates/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Certificates_Get
        /// <summary> Description for Get a certificate. </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<Certificate> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _certificateClientDiagnostics.CreateScope("CertificateCollection.Get");
            scope.Start();
            try
            {
                var response = _certificateRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken);
                if (response.Value == null)
                    throw _certificateClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Certificate(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/certificates/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Certificates_Get
        /// <summary> Description for Get a certificate. </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<Certificate>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _certificateClientDiagnostics.CreateScope("CertificateCollection.Get");
            scope.Start();
            try
            {
                var response = await _certificateRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _certificateClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Certificate(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<Certificate> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _certificateClientDiagnostics.CreateScope("CertificateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _certificateRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<Certificate>(null, response.GetRawResponse());
                return Response.FromValue(new Certificate(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<Certificate>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _certificateClientDiagnostics.CreateScope("CertificateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _certificateRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<Certificate>(null, response.GetRawResponse());
                return Response.FromValue(new Certificate(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _certificateClientDiagnostics.CreateScope("CertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _certificateClientDiagnostics.CreateScope("CertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(name, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/certificates
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Certificates_ListByResourceGroup
        /// <summary> Description for Get all certificates in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Certificate" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Certificate> GetAll(CancellationToken cancellationToken = default)
        {
            Page<Certificate> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _certificateClientDiagnostics.CreateScope("CertificateCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _certificateRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Certificate(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Certificate> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _certificateClientDiagnostics.CreateScope("CertificateCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _certificateRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Certificate(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/certificates
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Certificates_ListByResourceGroup
        /// <summary> Description for Get all certificates in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Certificate" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Certificate> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Certificate>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _certificateClientDiagnostics.CreateScope("CertificateCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _certificateRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Certificate(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Certificate>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _certificateClientDiagnostics.CreateScope("CertificateCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _certificateRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Certificate(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<Certificate> IEnumerable<Certificate>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Certificate> IAsyncEnumerable<Certificate>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
