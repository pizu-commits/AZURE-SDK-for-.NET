// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Cdn.Models;

namespace Azure.ResourceManager.Cdn
{
    /// <summary>
    /// A Class representing a FrontDoorCustomDomain along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="FrontDoorCustomDomainResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetFrontDoorCustomDomainResource method.
    /// Otherwise you can get one from its parent resource <see cref="ProfileResource"/> using the GetFrontDoorCustomDomain method.
    /// </summary>
    public partial class FrontDoorCustomDomainResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="FrontDoorCustomDomainResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="profileName"> The profileName. </param>
        /// <param name="customDomainName"> The customDomainName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string profileName, string customDomainName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/customDomains/{customDomainName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _frontDoorCustomDomainClientDiagnostics;
        private readonly FrontDoorCustomDomainsRestOperations _frontDoorCustomDomainRestClient;
        private readonly FrontDoorCustomDomainData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Cdn/profiles/customDomains";

        /// <summary> Initializes a new instance of the <see cref="FrontDoorCustomDomainResource"/> class for mocking. </summary>
        protected FrontDoorCustomDomainResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FrontDoorCustomDomainResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal FrontDoorCustomDomainResource(ArmClient client, FrontDoorCustomDomainData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="FrontDoorCustomDomainResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal FrontDoorCustomDomainResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _frontDoorCustomDomainClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Cdn", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string frontDoorCustomDomainApiVersion);
            _frontDoorCustomDomainRestClient = new FrontDoorCustomDomainsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, frontDoorCustomDomainApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual FrontDoorCustomDomainData Data
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

        /// <summary>
        /// Gets an existing AzureFrontDoor domain with the specified domain name under the specified subscription, resource group and profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/customDomains/{customDomainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorCustomDomains_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorCustomDomainResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FrontDoorCustomDomainResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _frontDoorCustomDomainClientDiagnostics.CreateScope("FrontDoorCustomDomainResource.Get");
            scope.Start();
            try
            {
                var response = await _frontDoorCustomDomainRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FrontDoorCustomDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing AzureFrontDoor domain with the specified domain name under the specified subscription, resource group and profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/customDomains/{customDomainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorCustomDomains_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorCustomDomainResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FrontDoorCustomDomainResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _frontDoorCustomDomainClientDiagnostics.CreateScope("FrontDoorCustomDomainResource.Get");
            scope.Start();
            try
            {
                var response = _frontDoorCustomDomainRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FrontDoorCustomDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an existing AzureFrontDoor domain with the specified domain name under the specified subscription, resource group and profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/customDomains/{customDomainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorCustomDomains_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorCustomDomainResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _frontDoorCustomDomainClientDiagnostics.CreateScope("FrontDoorCustomDomainResource.Delete");
            scope.Start();
            try
            {
                var response = await _frontDoorCustomDomainRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CdnArmOperation(_frontDoorCustomDomainClientDiagnostics, Pipeline, _frontDoorCustomDomainRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an existing AzureFrontDoor domain with the specified domain name under the specified subscription, resource group and profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/customDomains/{customDomainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorCustomDomains_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorCustomDomainResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _frontDoorCustomDomainClientDiagnostics.CreateScope("FrontDoorCustomDomainResource.Delete");
            scope.Start();
            try
            {
                var response = _frontDoorCustomDomainRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new CdnArmOperation(_frontDoorCustomDomainClientDiagnostics, Pipeline, _frontDoorCustomDomainRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates an existing domain within a profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/customDomains/{customDomainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorCustomDomains_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorCustomDomainResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Domain properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<ArmOperation<FrontDoorCustomDomainResource>> UpdateAsync(WaitUntil waitUntil, FrontDoorCustomDomainPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _frontDoorCustomDomainClientDiagnostics.CreateScope("FrontDoorCustomDomainResource.Update");
            scope.Start();
            try
            {
                var response = await _frontDoorCustomDomainRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                var operation = new CdnArmOperation<FrontDoorCustomDomainResource>(new FrontDoorCustomDomainOperationSource(Client), _frontDoorCustomDomainClientDiagnostics, Pipeline, _frontDoorCustomDomainRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Updates an existing domain within a profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/customDomains/{customDomainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorCustomDomains_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorCustomDomainResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Domain properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual ArmOperation<FrontDoorCustomDomainResource> Update(WaitUntil waitUntil, FrontDoorCustomDomainPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _frontDoorCustomDomainClientDiagnostics.CreateScope("FrontDoorCustomDomainResource.Update");
            scope.Start();
            try
            {
                var response = _frontDoorCustomDomainRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken);
                var operation = new CdnArmOperation<FrontDoorCustomDomainResource>(new FrontDoorCustomDomainOperationSource(Client), _frontDoorCustomDomainClientDiagnostics, Pipeline, _frontDoorCustomDomainRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Updates the domain validation token.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/customDomains/{customDomainName}/refreshValidationToken</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorCustomDomains_RefreshValidationToken</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorCustomDomainResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> RefreshValidationTokenAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _frontDoorCustomDomainClientDiagnostics.CreateScope("FrontDoorCustomDomainResource.RefreshValidationToken");
            scope.Start();
            try
            {
                var response = await _frontDoorCustomDomainRestClient.RefreshValidationTokenAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CdnArmOperation(_frontDoorCustomDomainClientDiagnostics, Pipeline, _frontDoorCustomDomainRestClient.CreateRefreshValidationTokenRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates the domain validation token.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/customDomains/{customDomainName}/refreshValidationToken</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorCustomDomains_RefreshValidationToken</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorCustomDomainResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation RefreshValidationToken(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _frontDoorCustomDomainClientDiagnostics.CreateScope("FrontDoorCustomDomainResource.RefreshValidationToken");
            scope.Start();
            try
            {
                var response = _frontDoorCustomDomainRestClient.RefreshValidationToken(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new CdnArmOperation(_frontDoorCustomDomainClientDiagnostics, Pipeline, _frontDoorCustomDomainRestClient.CreateRefreshValidationTokenRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
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
