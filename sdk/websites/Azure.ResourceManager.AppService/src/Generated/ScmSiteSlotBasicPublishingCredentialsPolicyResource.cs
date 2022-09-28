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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a ScmSiteSlotBasicPublishingCredentialsPolicy along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ScmSiteSlotBasicPublishingCredentialsPolicyResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetScmSiteSlotBasicPublishingCredentialsPolicyResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteSlotResource" /> using the GetScmSiteSlotBasicPublishingCredentialsPolicy method.
    /// </summary>
    public partial class ScmSiteSlotBasicPublishingCredentialsPolicyResource : CsmPublishingCredentialsPoliciesEntityResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ScmSiteSlotBasicPublishingCredentialsPolicyResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/basicPublishingCredentialsPolicies/scm";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _scmSiteSlotBasicPublishingCredentialsPolicyWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _scmSiteSlotBasicPublishingCredentialsPolicyWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ScmSiteSlotBasicPublishingCredentialsPolicyResource"/> class for mocking. </summary>
        protected ScmSiteSlotBasicPublishingCredentialsPolicyResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ScmSiteSlotBasicPublishingCredentialsPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ScmSiteSlotBasicPublishingCredentialsPolicyResource(ArmClient client, CsmPublishingCredentialsPoliciesEntityData data) : base(client, data)
        {
            _scmSiteSlotBasicPublishingCredentialsPolicyWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string scmSiteSlotBasicPublishingCredentialsPolicyWebAppsApiVersion);
            _scmSiteSlotBasicPublishingCredentialsPolicyWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, scmSiteSlotBasicPublishingCredentialsPolicyWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="ScmSiteSlotBasicPublishingCredentialsPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ScmSiteSlotBasicPublishingCredentialsPolicyResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _scmSiteSlotBasicPublishingCredentialsPolicyWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string scmSiteSlotBasicPublishingCredentialsPolicyWebAppsApiVersion);
            _scmSiteSlotBasicPublishingCredentialsPolicyWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, scmSiteSlotBasicPublishingCredentialsPolicyWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/slots/basicPublishingCredentialsPolicies";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Returns whether Scm basic auth is allowed on the site or not.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/basicPublishingCredentialsPolicies/scm
        /// Operation Id: WebApps_GetScmAllowedSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<CsmPublishingCredentialsPoliciesEntityResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _scmSiteSlotBasicPublishingCredentialsPolicyWebAppsClientDiagnostics.CreateScope("ScmSiteSlotBasicPublishingCredentialsPolicyResource.Get");
            scope.Start();
            try
            {
                var response = await _scmSiteSlotBasicPublishingCredentialsPolicyWebAppsRestClient.GetScmAllowedSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Returns whether Scm basic auth is allowed on the site or not.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/basicPublishingCredentialsPolicies/scm
        /// Operation Id: WebApps_GetScmAllowedSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<ScmSiteSlotBasicPublishingCredentialsPolicyResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((ScmSiteSlotBasicPublishingCredentialsPolicyResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Description for Returns whether Scm basic auth is allowed on the site or not.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/basicPublishingCredentialsPolicies/scm
        /// Operation Id: WebApps_GetScmAllowedSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<CsmPublishingCredentialsPoliciesEntityResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _scmSiteSlotBasicPublishingCredentialsPolicyWebAppsClientDiagnostics.CreateScope("ScmSiteSlotBasicPublishingCredentialsPolicyResource.Get");
            scope.Start();
            try
            {
                var response = _scmSiteSlotBasicPublishingCredentialsPolicyWebAppsRestClient.GetScmAllowedSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Returns whether Scm basic auth is allowed on the site or not.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/basicPublishingCredentialsPolicies/scm
        /// Operation Id: WebApps_GetScmAllowedSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<ScmSiteSlotBasicPublishingCredentialsPolicyResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((ScmSiteSlotBasicPublishingCredentialsPolicyResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Description for Updates whether user publishing credentials are allowed on the site or not.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/basicPublishingCredentialsPolicies/scm
        /// Operation Id: WebApps_UpdateScmAllowedSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The CsmPublishingCredentialsPoliciesEntity to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected override async Task<ArmOperation<CsmPublishingCredentialsPoliciesEntityResource>> CreateOrUpdateCoreAsync(WaitUntil waitUntil, CsmPublishingCredentialsPoliciesEntityData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scmSiteSlotBasicPublishingCredentialsPolicyWebAppsClientDiagnostics.CreateScope("ScmSiteSlotBasicPublishingCredentialsPolicyResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _scmSiteSlotBasicPublishingCredentialsPolicyWebAppsRestClient.UpdateScmAllowedSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<CsmPublishingCredentialsPoliciesEntityResource>(Response.FromValue(GetResource(Client, response), response.GetRawResponse()));
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
        /// Description for Updates whether user publishing credentials are allowed on the site or not.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/basicPublishingCredentialsPolicies/scm
        /// Operation Id: WebApps_UpdateScmAllowedSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The CsmPublishingCredentialsPoliciesEntity to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public new async Task<ArmOperation<ScmSiteSlotBasicPublishingCredentialsPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, CsmPublishingCredentialsPoliciesEntityData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            var result = await CreateOrUpdateCoreAsync(waitUntil, data, cancellationToken).ConfigureAwait(false);
            return new AppServiceArmOperation<ScmSiteSlotBasicPublishingCredentialsPolicyResource>(Response.FromValue((ScmSiteSlotBasicPublishingCredentialsPolicyResource)result.Value, result.GetRawResponse()));
        }

        /// <summary>
        /// Description for Updates whether user publishing credentials are allowed on the site or not.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/basicPublishingCredentialsPolicies/scm
        /// Operation Id: WebApps_UpdateScmAllowedSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The CsmPublishingCredentialsPoliciesEntity to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected override ArmOperation<CsmPublishingCredentialsPoliciesEntityResource> CreateOrUpdateCore(WaitUntil waitUntil, CsmPublishingCredentialsPoliciesEntityData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scmSiteSlotBasicPublishingCredentialsPolicyWebAppsClientDiagnostics.CreateScope("ScmSiteSlotBasicPublishingCredentialsPolicyResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _scmSiteSlotBasicPublishingCredentialsPolicyWebAppsRestClient.UpdateScmAllowedSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, data, cancellationToken);
                var operation = new AppServiceArmOperation<CsmPublishingCredentialsPoliciesEntityResource>(Response.FromValue(GetResource(Client, response), response.GetRawResponse()));
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
        /// Description for Updates whether user publishing credentials are allowed on the site or not.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/basicPublishingCredentialsPolicies/scm
        /// Operation Id: WebApps_UpdateScmAllowedSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The CsmPublishingCredentialsPoliciesEntity to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public new ArmOperation<ScmSiteSlotBasicPublishingCredentialsPolicyResource> CreateOrUpdate(WaitUntil waitUntil, CsmPublishingCredentialsPoliciesEntityData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            var result = CreateOrUpdateCore(waitUntil, data, cancellationToken);
            return new AppServiceArmOperation<ScmSiteSlotBasicPublishingCredentialsPolicyResource>(Response.FromValue((ScmSiteSlotBasicPublishingCredentialsPolicyResource)result.Value, result.GetRawResponse()));
        }
    }
}
