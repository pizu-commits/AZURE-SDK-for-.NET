// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a SiteInstanceProcess along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SiteInstanceProcessResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSiteInstanceProcessResource method.
    /// Otherwise you can get one from its parent resource <see cref="SiteInstanceResource" /> using the GetSiteInstanceProcess method.
    /// </summary>
    public partial class SiteInstanceProcessResource : ProcessInfoResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteInstanceProcessResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string instanceId, string processId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/processes/{processId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteInstanceProcessWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteInstanceProcessWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteInstanceProcessResource"/> class for mocking. </summary>
        protected SiteInstanceProcessResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteInstanceProcessResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteInstanceProcessResource(ArmClient client, ProcessInfoData data) : base(client, data)
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteInstanceProcessResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteInstanceProcessResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteInstanceProcessWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteInstanceProcessWebAppsApiVersion);
            _siteInstanceProcessWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteInstanceProcessWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/instances/processes";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of SiteInstanceProcessModuleResources in the SiteInstanceProcess. </summary>
        /// <returns> An object representing collection of SiteInstanceProcessModuleResources and their operations over a SiteInstanceProcessModuleResource. </returns>
        public virtual SiteInstanceProcessModuleCollection GetSiteInstanceProcessModules()
        {
            return GetCachedClient(Client => new SiteInstanceProcessModuleCollection(Client, Id));
        }

        /// <summary>
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/processes/{processId}/modules/{baseAddress}
        /// Operation Id: WebApps_GetInstanceProcessModule
        /// </summary>
        /// <param name="baseAddress"> Module base address. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="baseAddress"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="baseAddress"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SiteInstanceProcessModuleResource>> GetSiteInstanceProcessModuleAsync(string baseAddress, CancellationToken cancellationToken = default)
        {
            return await GetSiteInstanceProcessModules().GetAsync(baseAddress, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/processes/{processId}/modules/{baseAddress}
        /// Operation Id: WebApps_GetInstanceProcessModule
        /// </summary>
        /// <param name="baseAddress"> Module base address. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="baseAddress"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="baseAddress"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<SiteInstanceProcessModuleResource> GetSiteInstanceProcessModule(string baseAddress, CancellationToken cancellationToken = default)
        {
            return GetSiteInstanceProcessModules().Get(baseAddress, cancellationToken);
        }

        /// <summary> The core implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<ProcessInfoResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteInstanceProcessResource.Get");
            scope.Start();
            try
            {
                var response = await _siteInstanceProcessWebAppsRestClient.GetInstanceProcessAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/processes/{processId}
        /// Operation Id: WebApps_GetInstanceProcess
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual async Task<Response<SiteInstanceProcessResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var value = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((SiteInstanceProcessResource)value.Value, value.GetRawResponse());
        }

        /// <summary> The core implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<ProcessInfoResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _siteInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteInstanceProcessResource.Get");
            scope.Start();
            try
            {
                var response = _siteInstanceProcessWebAppsRestClient.GetInstanceProcess(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/processes/{processId}
        /// Operation Id: WebApps_GetInstanceProcess
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual Response<SiteInstanceProcessResource> Get(CancellationToken cancellationToken = default)
        {
            var value = GetCore(cancellationToken);
            return Response.FromValue((SiteInstanceProcessResource)value.Value, value.GetRawResponse());
        }

        /// <summary> The core implementation for operation Delete. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<ArmOperation> DeleteCoreAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _siteInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteInstanceProcessResource.Delete");
            scope.Start();
            try
            {
                var response = await _siteInstanceProcessWebAppsRestClient.DeleteInstanceProcessAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation(response);
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

        /// <summary> The core implementation for operation Delete. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override ArmOperation DeleteCore(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _siteInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteInstanceProcessResource.Delete");
            scope.Start();
            try
            {
                var response = _siteInstanceProcessWebAppsRestClient.DeleteInstanceProcess(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppServiceArmOperation(response);
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
        /// Description for Get a memory dump of a process by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/processes/{processId}/dump
        /// Operation Id: WebApps_GetInstanceProcessDump
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Stream>> GetInstanceProcessDumpAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteInstanceProcessResource.GetInstanceProcessDump");
            scope.Start();
            try
            {
                var response = await _siteInstanceProcessWebAppsRestClient.GetInstanceProcessDumpAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get a memory dump of a process by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/processes/{processId}/dump
        /// Operation Id: WebApps_GetInstanceProcessDump
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Stream> GetInstanceProcessDump(CancellationToken cancellationToken = default)
        {
            using var scope = _siteInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteInstanceProcessResource.GetInstanceProcessDump");
            scope.Start();
            try
            {
                var response = _siteInstanceProcessWebAppsRestClient.GetInstanceProcessDump(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for List the threads in a process by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/processes/{processId}/threads
        /// Operation Id: WebApps_ListInstanceProcessThreads
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProcessThreadInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ProcessThreadInfo> GetInstanceProcessThreadsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ProcessThreadInfo>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteInstanceProcessResource.GetInstanceProcessThreads");
                scope.Start();
                try
                {
                    var response = await _siteInstanceProcessWebAppsRestClient.ListInstanceProcessThreadsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ProcessThreadInfo>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteInstanceProcessResource.GetInstanceProcessThreads");
                scope.Start();
                try
                {
                    var response = await _siteInstanceProcessWebAppsRestClient.ListInstanceProcessThreadsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
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
        /// Description for List the threads in a process by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/processes/{processId}/threads
        /// Operation Id: WebApps_ListInstanceProcessThreads
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProcessThreadInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ProcessThreadInfo> GetInstanceProcessThreads(CancellationToken cancellationToken = default)
        {
            Page<ProcessThreadInfo> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteInstanceProcessResource.GetInstanceProcessThreads");
                scope.Start();
                try
                {
                    var response = _siteInstanceProcessWebAppsRestClient.ListInstanceProcessThreads(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ProcessThreadInfo> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteInstanceProcessResource.GetInstanceProcessThreads");
                scope.Start();
                try
                {
                    var response = _siteInstanceProcessWebAppsRestClient.ListInstanceProcessThreadsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
