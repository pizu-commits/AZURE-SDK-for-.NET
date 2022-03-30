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
    /// A class representing a collection of <see cref="SiteSlotPremierAddOnResource" /> and their operations.
    /// Each <see cref="SiteSlotPremierAddOnResource" /> in the collection will belong to the same instance of <see cref="SiteSlotResource" />.
    /// To get a <see cref="SiteSlotPremierAddOnCollection" /> instance call the GetSiteSlotPremierAddOns method from an instance of <see cref="SiteSlotResource" />.
    /// </summary>
    public partial class SiteSlotPremierAddOnCollection : ArmCollection
    {
        private readonly ClientDiagnostics _siteSlotPremierAddOnWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotPremierAddOnWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotPremierAddOnCollection"/> class for mocking. </summary>
        protected SiteSlotPremierAddOnCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotPremierAddOnCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteSlotPremierAddOnCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotPremierAddOnWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteSlotPremierAddOnResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteSlotPremierAddOnResource.ResourceType, out string siteSlotPremierAddOnWebAppsApiVersion);
            _siteSlotPremierAddOnWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotPremierAddOnWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteSlotResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteSlotResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Updates a named add-on of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/premieraddons/{premierAddOnName}
        /// Operation Id: WebApps_AddPremierAddOnSlot
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="data"> A JSON representation of the edited premier add-on. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="premierAddOnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteSlotPremierAddOnResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string premierAddOnName, PremierAddOnData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(premierAddOnName, nameof(premierAddOnName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteSlotPremierAddOnWebAppsClientDiagnostics.CreateScope("SiteSlotPremierAddOnCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteSlotPremierAddOnWebAppsRestClient.AddPremierAddOnSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, premierAddOnName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<SiteSlotPremierAddOnResource>(Response.FromValue(new SiteSlotPremierAddOnResource(Client, response), response.GetRawResponse()));
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
        /// Description for Updates a named add-on of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/premieraddons/{premierAddOnName}
        /// Operation Id: WebApps_AddPremierAddOnSlot
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="data"> A JSON representation of the edited premier add-on. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="premierAddOnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SiteSlotPremierAddOnResource> CreateOrUpdate(WaitUntil waitUntil, string premierAddOnName, PremierAddOnData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(premierAddOnName, nameof(premierAddOnName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteSlotPremierAddOnWebAppsClientDiagnostics.CreateScope("SiteSlotPremierAddOnCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteSlotPremierAddOnWebAppsRestClient.AddPremierAddOnSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, premierAddOnName, data, cancellationToken);
                var operation = new AppServiceArmOperation<SiteSlotPremierAddOnResource>(Response.FromValue(new SiteSlotPremierAddOnResource(Client, response), response.GetRawResponse()));
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
        /// Description for Gets a named add-on of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/premieraddons/{premierAddOnName}
        /// Operation Id: WebApps_GetPremierAddOnSlot
        /// </summary>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="premierAddOnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> is null. </exception>
        public virtual async Task<Response<SiteSlotPremierAddOnResource>> GetAsync(string premierAddOnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(premierAddOnName, nameof(premierAddOnName));

            using var scope = _siteSlotPremierAddOnWebAppsClientDiagnostics.CreateScope("SiteSlotPremierAddOnCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotPremierAddOnWebAppsRestClient.GetPremierAddOnSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, premierAddOnName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotPremierAddOnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets a named add-on of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/premieraddons/{premierAddOnName}
        /// Operation Id: WebApps_GetPremierAddOnSlot
        /// </summary>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="premierAddOnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> is null. </exception>
        public virtual Response<SiteSlotPremierAddOnResource> Get(string premierAddOnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(premierAddOnName, nameof(premierAddOnName));

            using var scope = _siteSlotPremierAddOnWebAppsClientDiagnostics.CreateScope("SiteSlotPremierAddOnCollection.Get");
            scope.Start();
            try
            {
                var response = _siteSlotPremierAddOnWebAppsRestClient.GetPremierAddOnSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, premierAddOnName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotPremierAddOnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/premieraddons/{premierAddOnName}
        /// Operation Id: WebApps_GetPremierAddOnSlot
        /// </summary>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="premierAddOnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string premierAddOnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(premierAddOnName, nameof(premierAddOnName));

            using var scope = _siteSlotPremierAddOnWebAppsClientDiagnostics.CreateScope("SiteSlotPremierAddOnCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(premierAddOnName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/premieraddons/{premierAddOnName}
        /// Operation Id: WebApps_GetPremierAddOnSlot
        /// </summary>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="premierAddOnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> is null. </exception>
        public virtual Response<bool> Exists(string premierAddOnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(premierAddOnName, nameof(premierAddOnName));

            using var scope = _siteSlotPremierAddOnWebAppsClientDiagnostics.CreateScope("SiteSlotPremierAddOnCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(premierAddOnName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/premieraddons/{premierAddOnName}
        /// Operation Id: WebApps_GetPremierAddOnSlot
        /// </summary>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="premierAddOnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> is null. </exception>
        public virtual async Task<Response<SiteSlotPremierAddOnResource>> GetIfExistsAsync(string premierAddOnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(premierAddOnName, nameof(premierAddOnName));

            using var scope = _siteSlotPremierAddOnWebAppsClientDiagnostics.CreateScope("SiteSlotPremierAddOnCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteSlotPremierAddOnWebAppsRestClient.GetPremierAddOnSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, premierAddOnName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotPremierAddOnResource>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotPremierAddOnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/premieraddons/{premierAddOnName}
        /// Operation Id: WebApps_GetPremierAddOnSlot
        /// </summary>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="premierAddOnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> is null. </exception>
        public virtual Response<SiteSlotPremierAddOnResource> GetIfExists(string premierAddOnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(premierAddOnName, nameof(premierAddOnName));

            using var scope = _siteSlotPremierAddOnWebAppsClientDiagnostics.CreateScope("SiteSlotPremierAddOnCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteSlotPremierAddOnWebAppsRestClient.GetPremierAddOnSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, premierAddOnName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotPremierAddOnResource>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotPremierAddOnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
