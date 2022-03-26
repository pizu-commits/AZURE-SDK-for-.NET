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

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing a collection of <see cref="VirtualMachineScaleSetVirtualMachineRunCommandResource" /> and their operations.
    /// Each <see cref="VirtualMachineScaleSetVirtualMachineRunCommandResource" /> in the collection will belong to the same instance of <see cref="VirtualMachineScaleSetVmResource" />.
    /// To get a <see cref="VirtualMachineScaleSetVirtualMachineRunCommandCollection" /> instance call the GetVirtualMachineScaleSetVirtualMachineRunCommands method from an instance of <see cref="VirtualMachineScaleSetVmResource" />.
    /// </summary>
    public partial class VirtualMachineScaleSetVirtualMachineRunCommandCollection : ArmCollection, IEnumerable<VirtualMachineScaleSetVirtualMachineRunCommandResource>, IAsyncEnumerable<VirtualMachineScaleSetVirtualMachineRunCommandResource>
    {
        private readonly ClientDiagnostics _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics;
        private readonly VirtualMachineScaleSetVMRunCommandsRestOperations _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineScaleSetVirtualMachineRunCommandCollection"/> class for mocking. </summary>
        protected VirtualMachineScaleSetVirtualMachineRunCommandCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineScaleSetVirtualMachineRunCommandCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualMachineScaleSetVirtualMachineRunCommandCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", VirtualMachineScaleSetVirtualMachineRunCommandResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VirtualMachineScaleSetVirtualMachineRunCommandResource.ResourceType, out string virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsApiVersion);
            _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsRestClient = new VirtualMachineScaleSetVMRunCommandsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualMachineScaleSetVmResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualMachineScaleSetVmResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create or update the VMSS VM run command.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/runCommands/{runCommandName}
        /// Operation Id: VirtualMachineScaleSetVMRunCommands_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="data"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VirtualMachineScaleSetVirtualMachineRunCommandResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string runCommandName, VirtualMachineRunCommandData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineRunCommandCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, runCommandName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ComputeArmOperation<VirtualMachineScaleSetVirtualMachineRunCommandResource>(new VirtualMachineScaleSetVirtualMachineRunCommandOperationSource(Client), _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics, Pipeline, _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, runCommandName, data).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to create or update the VMSS VM run command.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/runCommands/{runCommandName}
        /// Operation Id: VirtualMachineScaleSetVMRunCommands_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="data"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VirtualMachineScaleSetVirtualMachineRunCommandResource> CreateOrUpdate(WaitUntil waitUntil, string runCommandName, VirtualMachineRunCommandData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineRunCommandCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, runCommandName, data, cancellationToken);
                var operation = new ComputeArmOperation<VirtualMachineScaleSetVirtualMachineRunCommandResource>(new VirtualMachineScaleSetVirtualMachineRunCommandOperationSource(Client), _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics, Pipeline, _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, runCommandName, data).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to get the VMSS VM run command.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/runCommands/{runCommandName}
        /// Operation Id: VirtualMachineScaleSetVMRunCommands_Get
        /// </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public virtual async Task<Response<VirtualMachineScaleSetVirtualMachineRunCommandResource>> GetAsync(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));

            using var scope = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineRunCommandCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, runCommandName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSetVirtualMachineRunCommandResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the VMSS VM run command.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/runCommands/{runCommandName}
        /// Operation Id: VirtualMachineScaleSetVMRunCommands_Get
        /// </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public virtual Response<VirtualMachineScaleSetVirtualMachineRunCommandResource> Get(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));

            using var scope = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineRunCommandCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, runCommandName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSetVirtualMachineRunCommandResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get all run commands of an instance in Virtual Machine Scaleset.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/runCommands
        /// Operation Id: VirtualMachineScaleSetVMRunCommands_List
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualMachineScaleSetVirtualMachineRunCommandResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualMachineScaleSetVirtualMachineRunCommandResource> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualMachineScaleSetVirtualMachineRunCommandResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineRunCommandCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetVirtualMachineRunCommandResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualMachineScaleSetVirtualMachineRunCommandResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineRunCommandCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetVirtualMachineRunCommandResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// The operation to get all run commands of an instance in Virtual Machine Scaleset.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/runCommands
        /// Operation Id: VirtualMachineScaleSetVMRunCommands_List
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualMachineScaleSetVirtualMachineRunCommandResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualMachineScaleSetVirtualMachineRunCommandResource> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            Page<VirtualMachineScaleSetVirtualMachineRunCommandResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineRunCommandCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetVirtualMachineRunCommandResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualMachineScaleSetVirtualMachineRunCommandResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineRunCommandCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetVirtualMachineRunCommandResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/runCommands/{runCommandName}
        /// Operation Id: VirtualMachineScaleSetVMRunCommands_Get
        /// </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));

            using var scope = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineRunCommandCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(runCommandName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/runCommands/{runCommandName}
        /// Operation Id: VirtualMachineScaleSetVMRunCommands_Get
        /// </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public virtual Response<bool> Exists(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));

            using var scope = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineRunCommandCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(runCommandName, expand: expand, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/runCommands/{runCommandName}
        /// Operation Id: VirtualMachineScaleSetVMRunCommands_Get
        /// </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public virtual async Task<Response<VirtualMachineScaleSetVirtualMachineRunCommandResource>> GetIfExistsAsync(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));

            using var scope = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineRunCommandCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, runCommandName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VirtualMachineScaleSetVirtualMachineRunCommandResource>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSetVirtualMachineRunCommandResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/runCommands/{runCommandName}
        /// Operation Id: VirtualMachineScaleSetVMRunCommands_Get
        /// </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public virtual Response<VirtualMachineScaleSetVirtualMachineRunCommandResource> GetIfExists(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));

            using var scope = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineRunCommandCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, runCommandName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VirtualMachineScaleSetVirtualMachineRunCommandResource>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSetVirtualMachineRunCommandResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualMachineScaleSetVirtualMachineRunCommandResource> IEnumerable<VirtualMachineScaleSetVirtualMachineRunCommandResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualMachineScaleSetVirtualMachineRunCommandResource> IAsyncEnumerable<VirtualMachineScaleSetVirtualMachineRunCommandResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
