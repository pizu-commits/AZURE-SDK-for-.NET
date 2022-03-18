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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a SiteInstanceProcess along with the instance operations that can be performed on it. </summary>
    public partial class SiteInstanceProcess : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteInstanceProcess"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string instanceId, string processId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/processes/{processId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteInstanceProcessWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteInstanceProcessWebAppsRestClient;
        private readonly ProcessInfoData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteInstanceProcess"/> class for mocking. </summary>
        protected SiteInstanceProcess()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteInstanceProcess"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteInstanceProcess(ArmClient client, ProcessInfoData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteInstanceProcess"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteInstanceProcess(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteInstanceProcessWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string siteInstanceProcessWebAppsApiVersion);
            _siteInstanceProcessWebAppsRestClient = new WebAppsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteInstanceProcessWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/instances/processes";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ProcessInfoData Data
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

        /// <summary> Gets a collection of SiteInstanceProcessModules in the SiteInstanceProcessModule. </summary>
        /// <returns> An object representing collection of SiteInstanceProcessModules and their operations over a SiteInstanceProcessModule. </returns>
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
        public virtual async Task<Response<SiteInstanceProcessModule>> GetSiteInstanceProcessModuleAsync(string baseAddress, CancellationToken cancellationToken = default)
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
        public virtual Response<SiteInstanceProcessModule> GetSiteInstanceProcessModule(string baseAddress, CancellationToken cancellationToken = default)
        {
            return GetSiteInstanceProcessModules().Get(baseAddress, cancellationToken);
        }

        /// <summary>
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/processes/{processId}
        /// Operation Id: WebApps_GetInstanceProcess
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SiteInstanceProcess>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteInstanceProcess.Get");
            scope.Start();
            try
            {
                var response = await _siteInstanceProcessWebAppsRestClient.GetInstanceProcessAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteInstanceProcess(Client, response.Value), response.GetRawResponse());
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
        public virtual Response<SiteInstanceProcess> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteInstanceProcess.Get");
            scope.Start();
            try
            {
                var response = _siteInstanceProcessWebAppsRestClient.GetInstanceProcess(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteInstanceProcess(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Terminate a process by its ID for a web site, or a deployment slot, or specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/processes/{processId}
        /// Operation Id: WebApps_DeleteInstanceProcess
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _siteInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteInstanceProcess.Delete");
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

        /// <summary>
        /// Description for Terminate a process by its ID for a web site, or a deployment slot, or specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/processes/{processId}
        /// Operation Id: WebApps_DeleteInstanceProcess
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _siteInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteInstanceProcess.Delete");
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
            using var scope = _siteInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteInstanceProcess.GetInstanceProcessDump");
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
            using var scope = _siteInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteInstanceProcess.GetInstanceProcessDump");
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
                using var scope = _siteInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteInstanceProcess.GetInstanceProcessThreads");
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
                using var scope = _siteInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteInstanceProcess.GetInstanceProcessThreads");
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
                using var scope = _siteInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteInstanceProcess.GetInstanceProcessThreads");
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
                using var scope = _siteInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteInstanceProcess.GetInstanceProcessThreads");
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
