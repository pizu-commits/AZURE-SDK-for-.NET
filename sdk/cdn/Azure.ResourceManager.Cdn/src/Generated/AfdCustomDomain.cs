// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A Class representing a AfdCustomDomain along with the instance operations that can be performed on it. </summary>
    public partial class AfdCustomDomain : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AfdCustomDomain"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string profileName, string customDomainName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/customDomains/{customDomainName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _afdCustomDomainClientDiagnostics;
        private readonly AfdCustomDomainsRestOperations _afdCustomDomainRestClient;
        private readonly AfdCustomDomainData _data;

        /// <summary> Initializes a new instance of the <see cref="AfdCustomDomain"/> class for mocking. </summary>
        protected AfdCustomDomain()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "AfdCustomDomain"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AfdCustomDomain(ArmClient client, AfdCustomDomainData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AfdCustomDomain"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AfdCustomDomain(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _afdCustomDomainClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Cdn", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string afdCustomDomainApiVersion);
            _afdCustomDomainRestClient = new AfdCustomDomainsRestOperations(_afdCustomDomainClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, afdCustomDomainApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Cdn/profiles/customDomains";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AfdCustomDomainData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets an existing AzureFrontDoor domain with the specified domain name under the specified subscription, resource group and profile. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<AfdCustomDomain>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _afdCustomDomainClientDiagnostics.CreateScope("AfdCustomDomain.Get");
            scope.Start();
            try
            {
                var response = await _afdCustomDomainRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _afdCustomDomainClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AfdCustomDomain(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an existing AzureFrontDoor domain with the specified domain name under the specified subscription, resource group and profile. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AfdCustomDomain> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _afdCustomDomainClientDiagnostics.CreateScope("AfdCustomDomain.Get");
            scope.Start();
            try
            {
                var response = _afdCustomDomainRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _afdCustomDomainClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AfdCustomDomain(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes an existing AzureFrontDoor domain with the specified domain name under the specified subscription, resource group and profile. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _afdCustomDomainClientDiagnostics.CreateScope("AfdCustomDomain.Delete");
            scope.Start();
            try
            {
                var response = await _afdCustomDomainRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CdnArmOperation(_afdCustomDomainClientDiagnostics, Pipeline, _afdCustomDomainRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes an existing AzureFrontDoor domain with the specified domain name under the specified subscription, resource group and profile. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _afdCustomDomainClientDiagnostics.CreateScope("AfdCustomDomain.Delete");
            scope.Start();
            try
            {
                var response = _afdCustomDomainRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new CdnArmOperation(_afdCustomDomainClientDiagnostics, Pipeline, _afdCustomDomainRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates an existing domain within a profile. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="options"> Domain properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="options"/> is null. </exception>
        public async virtual Task<ArmOperation<AfdCustomDomain>> UpdateAsync(bool waitForCompletion, AfdCustomDomainUpdateOptions options, CancellationToken cancellationToken = default)
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            using var scope = _afdCustomDomainClientDiagnostics.CreateScope("AfdCustomDomain.Update");
            scope.Start();
            try
            {
                var response = await _afdCustomDomainRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, options, cancellationToken).ConfigureAwait(false);
                var operation = new CdnArmOperation<AfdCustomDomain>(new AfdCustomDomainOperationSource(Client), _afdCustomDomainClientDiagnostics, Pipeline, _afdCustomDomainRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, options).Request, response, OperationFinalStateVia.OriginalUri);
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

        /// <summary> Updates an existing domain within a profile. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="options"> Domain properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="options"/> is null. </exception>
        public virtual ArmOperation<AfdCustomDomain> Update(bool waitForCompletion, AfdCustomDomainUpdateOptions options, CancellationToken cancellationToken = default)
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            using var scope = _afdCustomDomainClientDiagnostics.CreateScope("AfdCustomDomain.Update");
            scope.Start();
            try
            {
                var response = _afdCustomDomainRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, options, cancellationToken);
                var operation = new CdnArmOperation<AfdCustomDomain>(new AfdCustomDomainOperationSource(Client), _afdCustomDomainClientDiagnostics, Pipeline, _afdCustomDomainRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, options).Request, response, OperationFinalStateVia.OriginalUri);
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

        /// <summary> Updates the domain validation token. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation<ValidationToken>> RefreshValidationTokenAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _afdCustomDomainClientDiagnostics.CreateScope("AfdCustomDomain.RefreshValidationToken");
            scope.Start();
            try
            {
                var response = await _afdCustomDomainRestClient.RefreshValidationTokenAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CdnArmOperation<ValidationToken>(new ValidationTokenOperationSource(), _afdCustomDomainClientDiagnostics, Pipeline, _afdCustomDomainRestClient.CreateRefreshValidationTokenRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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

        /// <summary> Updates the domain validation token. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<ValidationToken> RefreshValidationToken(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _afdCustomDomainClientDiagnostics.CreateScope("AfdCustomDomain.RefreshValidationToken");
            scope.Start();
            try
            {
                var response = _afdCustomDomainRestClient.RefreshValidationToken(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new CdnArmOperation<ValidationToken>(new ValidationTokenOperationSource(), _afdCustomDomainClientDiagnostics, Pipeline, _afdCustomDomainRestClient.CreateRefreshValidationTokenRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
    }
}
