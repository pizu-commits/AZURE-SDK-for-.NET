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
using Azure.ResourceManager.Batch.Models;

namespace Azure.ResourceManager.Batch
{
    /// <summary>
    /// A class representing a collection of <see cref="BatchAccountCertificateResource"/> and their operations.
    /// Each <see cref="BatchAccountCertificateResource"/> in the collection will belong to the same instance of <see cref="BatchAccountResource"/>.
    /// To get a <see cref="BatchAccountCertificateCollection"/> instance call the GetBatchAccountCertificates method from an instance of <see cref="BatchAccountResource"/>.
    /// </summary>
    public partial class BatchAccountCertificateCollection : ArmCollection, IEnumerable<BatchAccountCertificateResource>, IAsyncEnumerable<BatchAccountCertificateResource>
    {
        private readonly ClientDiagnostics _batchAccountCertificateCertificateClientDiagnostics;
        private readonly CertificateRestOperations _batchAccountCertificateCertificateRestClient;

        /// <summary> Initializes a new instance of the <see cref="BatchAccountCertificateCollection"/> class for mocking. </summary>
        protected BatchAccountCertificateCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BatchAccountCertificateCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BatchAccountCertificateCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _batchAccountCertificateCertificateClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Batch", BatchAccountCertificateResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BatchAccountCertificateResource.ResourceType, out string batchAccountCertificateCertificateApiVersion);
            _batchAccountCertificateCertificateRestClient = new CertificateRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, batchAccountCertificateCertificateApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != BatchAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, BatchAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Warning: This operation is deprecated and will be removed after February, 2024. Please use the [Azure KeyVault Extension](https://learn.microsoft.com/azure/batch/batch-certificate-migration-guide) instead.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificate_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchAccountCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="certificateName"> The identifier for the certificate. This must be made up of algorithm and thumbprint separated by a dash, and must match the certificate data in the request. For example SHA1-a3d1c5. </param>
        /// <param name="content"> Additional parameters for certificate creation. </param>
        /// <param name="ifMatch"> The entity state (ETag) version of the certificate to update. A value of "*" can be used to apply the operation only if the certificate already exists. If omitted, this operation will always be applied. </param>
        /// <param name="ifNoneMatch"> Set to '*' to allow a new certificate to be created, but to prevent updating an existing certificate. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<BatchAccountCertificateResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string certificateName, BatchAccountCertificateCreateOrUpdateContent content, ETag? ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _batchAccountCertificateCertificateClientDiagnostics.CreateScope("BatchAccountCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _batchAccountCertificateCertificateRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, content, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                var uri = _batchAccountCertificateCertificateRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, content, ifMatch, ifNoneMatch);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new BatchArmOperation<BatchAccountCertificateResource>(Response.FromValue(new BatchAccountCertificateResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Warning: This operation is deprecated and will be removed after February, 2024. Please use the [Azure KeyVault Extension](https://learn.microsoft.com/azure/batch/batch-certificate-migration-guide) instead.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificate_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchAccountCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="certificateName"> The identifier for the certificate. This must be made up of algorithm and thumbprint separated by a dash, and must match the certificate data in the request. For example SHA1-a3d1c5. </param>
        /// <param name="content"> Additional parameters for certificate creation. </param>
        /// <param name="ifMatch"> The entity state (ETag) version of the certificate to update. A value of "*" can be used to apply the operation only if the certificate already exists. If omitted, this operation will always be applied. </param>
        /// <param name="ifNoneMatch"> Set to '*' to allow a new certificate to be created, but to prevent updating an existing certificate. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<BatchAccountCertificateResource> CreateOrUpdate(WaitUntil waitUntil, string certificateName, BatchAccountCertificateCreateOrUpdateContent content, ETag? ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _batchAccountCertificateCertificateClientDiagnostics.CreateScope("BatchAccountCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _batchAccountCertificateCertificateRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, content, ifMatch, ifNoneMatch, cancellationToken);
                var uri = _batchAccountCertificateCertificateRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, content, ifMatch, ifNoneMatch);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new BatchArmOperation<BatchAccountCertificateResource>(Response.FromValue(new BatchAccountCertificateResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Warning: This operation is deprecated and will be removed after February, 2024. Please use the [Azure KeyVault Extension](https://learn.microsoft.com/azure/batch/batch-certificate-migration-guide) instead.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificate_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchAccountCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> The identifier for the certificate. This must be made up of algorithm and thumbprint separated by a dash, and must match the certificate data in the request. For example SHA1-a3d1c5. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual async Task<Response<BatchAccountCertificateResource>> GetAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _batchAccountCertificateCertificateClientDiagnostics.CreateScope("BatchAccountCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = await _batchAccountCertificateCertificateRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BatchAccountCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Warning: This operation is deprecated and will be removed after February, 2024. Please use the [Azure KeyVault Extension](https://learn.microsoft.com/azure/batch/batch-certificate-migration-guide) instead.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificate_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchAccountCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> The identifier for the certificate. This must be made up of algorithm and thumbprint separated by a dash, and must match the certificate data in the request. For example SHA1-a3d1c5. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual Response<BatchAccountCertificateResource> Get(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _batchAccountCertificateCertificateClientDiagnostics.CreateScope("BatchAccountCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = _batchAccountCertificateCertificateRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BatchAccountCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Warning: This operation is deprecated and will be removed after February, 2024. Please use the [Azure KeyVault Extension](https://learn.microsoft.com/azure/batch/batch-certificate-migration-guide) instead.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/certificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificate_ListByBatchAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchAccountCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="select"> Comma separated list of properties that should be returned. e.g. "properties/provisioningState". Only top level properties under properties/ are valid for selection. </param>
        /// <param name="filter"> OData filter expression. Valid properties for filtering are "properties/provisioningState", "properties/provisioningStateTransitionTime", "name". </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BatchAccountCertificateResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BatchAccountCertificateResource> GetAllAsync(int? maxresults = null, string select = null, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _batchAccountCertificateCertificateRestClient.CreateListByBatchAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, maxresults, select, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _batchAccountCertificateCertificateRestClient.CreateListByBatchAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, maxresults, select, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new BatchAccountCertificateResource(Client, BatchAccountCertificateData.DeserializeBatchAccountCertificateData(e)), _batchAccountCertificateCertificateClientDiagnostics, Pipeline, "BatchAccountCertificateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Warning: This operation is deprecated and will be removed after February, 2024. Please use the [Azure KeyVault Extension](https://learn.microsoft.com/azure/batch/batch-certificate-migration-guide) instead.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/certificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificate_ListByBatchAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchAccountCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="select"> Comma separated list of properties that should be returned. e.g. "properties/provisioningState". Only top level properties under properties/ are valid for selection. </param>
        /// <param name="filter"> OData filter expression. Valid properties for filtering are "properties/provisioningState", "properties/provisioningStateTransitionTime", "name". </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BatchAccountCertificateResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BatchAccountCertificateResource> GetAll(int? maxresults = null, string select = null, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _batchAccountCertificateCertificateRestClient.CreateListByBatchAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, maxresults, select, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _batchAccountCertificateCertificateRestClient.CreateListByBatchAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, maxresults, select, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new BatchAccountCertificateResource(Client, BatchAccountCertificateData.DeserializeBatchAccountCertificateData(e)), _batchAccountCertificateCertificateClientDiagnostics, Pipeline, "BatchAccountCertificateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificate_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchAccountCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> The identifier for the certificate. This must be made up of algorithm and thumbprint separated by a dash, and must match the certificate data in the request. For example SHA1-a3d1c5. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _batchAccountCertificateCertificateClientDiagnostics.CreateScope("BatchAccountCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = await _batchAccountCertificateCertificateRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificate_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchAccountCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> The identifier for the certificate. This must be made up of algorithm and thumbprint separated by a dash, and must match the certificate data in the request. For example SHA1-a3d1c5. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual Response<bool> Exists(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _batchAccountCertificateCertificateClientDiagnostics.CreateScope("BatchAccountCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = _batchAccountCertificateCertificateRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificate_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchAccountCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> The identifier for the certificate. This must be made up of algorithm and thumbprint separated by a dash, and must match the certificate data in the request. For example SHA1-a3d1c5. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual async Task<NullableResponse<BatchAccountCertificateResource>> GetIfExistsAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _batchAccountCertificateCertificateClientDiagnostics.CreateScope("BatchAccountCertificateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _batchAccountCertificateCertificateRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<BatchAccountCertificateResource>(response.GetRawResponse());
                return Response.FromValue(new BatchAccountCertificateResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificate_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchAccountCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> The identifier for the certificate. This must be made up of algorithm and thumbprint separated by a dash, and must match the certificate data in the request. For example SHA1-a3d1c5. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual NullableResponse<BatchAccountCertificateResource> GetIfExists(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _batchAccountCertificateCertificateClientDiagnostics.CreateScope("BatchAccountCertificateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _batchAccountCertificateCertificateRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<BatchAccountCertificateResource>(response.GetRawResponse());
                return Response.FromValue(new BatchAccountCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BatchAccountCertificateResource> IEnumerable<BatchAccountCertificateResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BatchAccountCertificateResource> IAsyncEnumerable<BatchAccountCertificateResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
