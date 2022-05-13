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
    /// A Class representing a FtpSiteSlotBasicPublishingCredentialsPolicy along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="FtpSiteSlotBasicPublishingCredentialsPolicyResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetFtpSiteSlotBasicPublishingCredentialsPolicyResource method.
    /// Otherwise you can get one from its parent resource <see cref="SiteSlotResource" /> using the GetFtpSiteSlotBasicPublishingCredentialsPolicy method.
    /// </summary>
    public partial class FtpSiteSlotBasicPublishingCredentialsPolicyResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="FtpSiteSlotBasicPublishingCredentialsPolicyResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/basicPublishingCredentialsPolicies/ftp";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _ftpSiteSlotBasicPublishingCredentialsPolicyWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _ftpSiteSlotBasicPublishingCredentialsPolicyWebAppsRestClient;
        private readonly CsmPublishingCredentialsPoliciesEntityData _data;

        /// <summary> Initializes a new instance of the <see cref="FtpSiteSlotBasicPublishingCredentialsPolicyResource"/> class for mocking. </summary>
        protected FtpSiteSlotBasicPublishingCredentialsPolicyResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "FtpSiteSlotBasicPublishingCredentialsPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal FtpSiteSlotBasicPublishingCredentialsPolicyResource(ArmClient client, CsmPublishingCredentialsPoliciesEntityData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="FtpSiteSlotBasicPublishingCredentialsPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal FtpSiteSlotBasicPublishingCredentialsPolicyResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _ftpSiteSlotBasicPublishingCredentialsPolicyWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string ftpSiteSlotBasicPublishingCredentialsPolicyWebAppsApiVersion);
            _ftpSiteSlotBasicPublishingCredentialsPolicyWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, ftpSiteSlotBasicPublishingCredentialsPolicyWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/slots/basicPublishingCredentialsPolicies";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CsmPublishingCredentialsPoliciesEntityData Data
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
        /// Returns whether FTP is allowed on the site or not.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/basicPublishingCredentialsPolicies/ftp
        /// Operation Id: WebApps_GetFtpAllowedSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FtpSiteSlotBasicPublishingCredentialsPolicyResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _ftpSiteSlotBasicPublishingCredentialsPolicyWebAppsClientDiagnostics.CreateScope("FtpSiteSlotBasicPublishingCredentialsPolicyResource.Get");
            scope.Start();
            try
            {
                var response = await _ftpSiteSlotBasicPublishingCredentialsPolicyWebAppsRestClient.GetFtpAllowedSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FtpSiteSlotBasicPublishingCredentialsPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns whether FTP is allowed on the site or not.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/basicPublishingCredentialsPolicies/ftp
        /// Operation Id: WebApps_GetFtpAllowedSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FtpSiteSlotBasicPublishingCredentialsPolicyResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _ftpSiteSlotBasicPublishingCredentialsPolicyWebAppsClientDiagnostics.CreateScope("FtpSiteSlotBasicPublishingCredentialsPolicyResource.Get");
            scope.Start();
            try
            {
                var response = _ftpSiteSlotBasicPublishingCredentialsPolicyWebAppsRestClient.GetFtpAllowedSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FtpSiteSlotBasicPublishingCredentialsPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates whether FTP is allowed on the site or not.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/basicPublishingCredentialsPolicies/ftp
        /// Operation Id: WebApps_UpdateFtpAllowedSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The CsmPublishingCredentialsPoliciesEntity to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<FtpSiteSlotBasicPublishingCredentialsPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, CsmPublishingCredentialsPoliciesEntityData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _ftpSiteSlotBasicPublishingCredentialsPolicyWebAppsClientDiagnostics.CreateScope("FtpSiteSlotBasicPublishingCredentialsPolicyResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _ftpSiteSlotBasicPublishingCredentialsPolicyWebAppsRestClient.UpdateFtpAllowedSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<FtpSiteSlotBasicPublishingCredentialsPolicyResource>(Response.FromValue(new FtpSiteSlotBasicPublishingCredentialsPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Updates whether FTP is allowed on the site or not.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/basicPublishingCredentialsPolicies/ftp
        /// Operation Id: WebApps_UpdateFtpAllowedSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The CsmPublishingCredentialsPoliciesEntity to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<FtpSiteSlotBasicPublishingCredentialsPolicyResource> CreateOrUpdate(WaitUntil waitUntil, CsmPublishingCredentialsPoliciesEntityData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _ftpSiteSlotBasicPublishingCredentialsPolicyWebAppsClientDiagnostics.CreateScope("FtpSiteSlotBasicPublishingCredentialsPolicyResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _ftpSiteSlotBasicPublishingCredentialsPolicyWebAppsRestClient.UpdateFtpAllowedSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, data, cancellationToken);
                var operation = new AppServiceArmOperation<FtpSiteSlotBasicPublishingCredentialsPolicyResource>(Response.FromValue(new FtpSiteSlotBasicPublishingCredentialsPolicyResource(Client, response), response.GetRawResponse()));
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
    }
}
