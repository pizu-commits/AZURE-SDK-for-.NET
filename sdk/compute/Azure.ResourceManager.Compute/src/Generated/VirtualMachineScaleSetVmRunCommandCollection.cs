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

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing a collection of <see cref="VirtualMachineScaleSetVmRunCommandResource"/> and their operations.
    /// Each <see cref="VirtualMachineScaleSetVmRunCommandResource"/> in the collection will belong to the same instance of <see cref="VirtualMachineScaleSetVmResource"/>.
    /// To get a <see cref="VirtualMachineScaleSetVmRunCommandCollection"/> instance call the GetVirtualMachineScaleSetVmRunCommands method from an instance of <see cref="VirtualMachineScaleSetVmResource"/>.
    /// </summary>
    public partial class VirtualMachineScaleSetVmRunCommandCollection : ArmCollection, IEnumerable<VirtualMachineScaleSetVmRunCommandResource>, IAsyncEnumerable<VirtualMachineScaleSetVmRunCommandResource>
    {
        private readonly ClientDiagnostics _virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsClientDiagnostics;
        private readonly VirtualMachineScaleSetVMRunCommandsRestOperations _virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineScaleSetVmRunCommandCollection"/> class for mocking. </summary>
        protected VirtualMachineScaleSetVmRunCommandCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineScaleSetVmRunCommandCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualMachineScaleSetVmRunCommandCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", VirtualMachineScaleSetVmRunCommandResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VirtualMachineScaleSetVmRunCommandResource.ResourceType, out string virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsApiVersion);
            _virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsRestClient = new VirtualMachineScaleSetVMRunCommandsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsApiVersion);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/runCommands/{runCommandName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineScaleSetVMRunCommands_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualMachineScaleSetVmRunCommandResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="data"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VirtualMachineScaleSetVmRunCommandResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string runCommandName, VirtualMachineRunCommandData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVmRunCommandCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, runCommandName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ComputeArmOperation<VirtualMachineScaleSetVmRunCommandResource>(new VirtualMachineScaleSetVmRunCommandOperationSource(Client), _virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsClientDiagnostics, Pipeline, _virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, runCommandName, data).Request, response, OperationFinalStateVia.Location);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/runCommands/{runCommandName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineScaleSetVMRunCommands_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualMachineScaleSetVmRunCommandResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="data"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VirtualMachineScaleSetVmRunCommandResource> CreateOrUpdate(WaitUntil waitUntil, string runCommandName, VirtualMachineRunCommandData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVmRunCommandCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, runCommandName, data, cancellationToken);
                var operation = new ComputeArmOperation<VirtualMachineScaleSetVmRunCommandResource>(new VirtualMachineScaleSetVmRunCommandOperationSource(Client), _virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsClientDiagnostics, Pipeline, _virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, runCommandName, data).Request, response, OperationFinalStateVia.Location);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/runCommands/{runCommandName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineScaleSetVMRunCommands_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualMachineScaleSetVmRunCommandResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public virtual async Task<Response<VirtualMachineScaleSetVmRunCommandResource>> GetAsync(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));

            using var scope = _virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVmRunCommandCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, runCommandName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSetVmRunCommandResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the VMSS VM run command.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/runCommands/{runCommandName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineScaleSetVMRunCommands_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualMachineScaleSetVmRunCommandResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public virtual Response<VirtualMachineScaleSetVmRunCommandResource> Get(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));

            using var scope = _virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVmRunCommandCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, runCommandName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSetVmRunCommandResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get all run commands of an instance in Virtual Machine Scaleset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/runCommands</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineScaleSetVMRunCommands_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualMachineScaleSetVmRunCommandResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualMachineScaleSetVmRunCommandResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualMachineScaleSetVmRunCommandResource> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new VirtualMachineScaleSetVmRunCommandResource(Client, VirtualMachineRunCommandData.DeserializeVirtualMachineRunCommandData(e)), _virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsClientDiagnostics, Pipeline, "VirtualMachineScaleSetVmRunCommandCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// The operation to get all run commands of an instance in Virtual Machine Scaleset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/runCommands</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineScaleSetVMRunCommands_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualMachineScaleSetVmRunCommandResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualMachineScaleSetVmRunCommandResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualMachineScaleSetVmRunCommandResource> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new VirtualMachineScaleSetVmRunCommandResource(Client, VirtualMachineRunCommandData.DeserializeVirtualMachineRunCommandData(e)), _virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsClientDiagnostics, Pipeline, "VirtualMachineScaleSetVmRunCommandCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/runCommands/{runCommandName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineScaleSetVMRunCommands_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualMachineScaleSetVmRunCommandResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));

            using var scope = _virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVmRunCommandCollection.Exists");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, runCommandName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/runCommands/{runCommandName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineScaleSetVMRunCommands_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualMachineScaleSetVmRunCommandResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public virtual Response<bool> Exists(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));

            using var scope = _virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVmRunCommandCollection.Exists");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, runCommandName, expand, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/runCommands/{runCommandName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineScaleSetVMRunCommands_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualMachineScaleSetVmRunCommandResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public virtual async Task<NullableResponse<VirtualMachineScaleSetVmRunCommandResource>> GetIfExistsAsync(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));

            using var scope = _virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVmRunCommandCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, runCommandName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<VirtualMachineScaleSetVmRunCommandResource>(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSetVmRunCommandResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/runCommands/{runCommandName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineScaleSetVMRunCommands_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualMachineScaleSetVmRunCommandResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public virtual NullableResponse<VirtualMachineScaleSetVmRunCommandResource> GetIfExists(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));

            using var scope = _virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVmRunCommandCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetVmRunCommandVirtualMachineScaleSetVmRunCommandsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, runCommandName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<VirtualMachineScaleSetVmRunCommandResource>(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSetVmRunCommandResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualMachineScaleSetVmRunCommandResource> IEnumerable<VirtualMachineScaleSetVmRunCommandResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualMachineScaleSetVmRunCommandResource> IAsyncEnumerable<VirtualMachineScaleSetVmRunCommandResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
