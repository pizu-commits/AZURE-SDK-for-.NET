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
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of VirtualMachineRunCommand and their operations over its parent. </summary>
    public partial class VirtualMachineScaleSetVirtualMachineRunCommandCollection : ArmCollection, IEnumerable<VirtualMachineScaleSetVirtualMachineRunCommand>, IAsyncEnumerable<VirtualMachineScaleSetVirtualMachineRunCommand>
    {
        private readonly ClientDiagnostics _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics;
        private readonly VirtualMachineScaleSetVMRunCommandsRestOperations _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineScaleSetVirtualMachineRunCommandCollection"/> class for mocking. </summary>
        protected VirtualMachineScaleSetVirtualMachineRunCommandCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineScaleSetVirtualMachineRunCommandCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualMachineScaleSetVirtualMachineRunCommandCollection(ArmResource parent) : base(parent)
        {
            _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", VirtualMachineScaleSetVirtualMachineRunCommand.ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(VirtualMachineScaleSetVirtualMachineRunCommand.ResourceType, out string virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsApiVersion);
            _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsRestClient = new VirtualMachineScaleSetVMRunCommandsRestOperations(_virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualMachineScaleSetVm.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualMachineScaleSetVm.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> The operation to create or update the VMSS VM run command. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="runCommand"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> or <paramref name="runCommand"/> is null. </exception>
        public virtual VirtualMachineScaleSetVirtualMachineRunCommandCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string runCommandName, VirtualMachineRunCommandData runCommand, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));
            if (runCommand == null)
            {
                throw new ArgumentNullException(nameof(runCommand));
            }

            using var scope = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineRunCommandCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, runCommandName, runCommand, cancellationToken);
                var operation = new VirtualMachineScaleSetVirtualMachineRunCommandCreateOrUpdateOperation(ArmClient, _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics, Pipeline, _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, runCommandName, runCommand).Request, response);
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

        /// <summary> The operation to create or update the VMSS VM run command. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="runCommand"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> or <paramref name="runCommand"/> is null. </exception>
        public async virtual Task<VirtualMachineScaleSetVirtualMachineRunCommandCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string runCommandName, VirtualMachineRunCommandData runCommand, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));
            if (runCommand == null)
            {
                throw new ArgumentNullException(nameof(runCommand));
            }

            using var scope = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineRunCommandCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, runCommandName, runCommand, cancellationToken).ConfigureAwait(false);
                var operation = new VirtualMachineScaleSetVirtualMachineRunCommandCreateOrUpdateOperation(ArmClient, _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics, Pipeline, _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, runCommandName, runCommand).Request, response);
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

        /// <summary> The operation to get the VMSS VM run command. </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public virtual Response<VirtualMachineScaleSetVirtualMachineRunCommand> Get(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));

            using var scope = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineRunCommandCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, runCommandName, expand, cancellationToken);
                if (response.Value == null)
                    throw _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSetVirtualMachineRunCommand(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to get the VMSS VM run command. </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public async virtual Task<Response<VirtualMachineScaleSetVirtualMachineRunCommand>> GetAsync(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));

            using var scope = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineRunCommandCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, runCommandName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualMachineScaleSetVirtualMachineRunCommand(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public virtual Response<VirtualMachineScaleSetVirtualMachineRunCommand> GetIfExists(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));

            using var scope = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineRunCommandCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, runCommandName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VirtualMachineScaleSetVirtualMachineRunCommand>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSetVirtualMachineRunCommand(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public async virtual Task<Response<VirtualMachineScaleSetVirtualMachineRunCommand>> GetIfExistsAsync(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));

            using var scope = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineRunCommandCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, runCommandName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VirtualMachineScaleSetVirtualMachineRunCommand>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSetVirtualMachineRunCommand(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public virtual Response<bool> Exists(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));

            using var scope = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineRunCommandCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(runCommandName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));

            using var scope = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineRunCommandCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(runCommandName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to get all run commands of an instance in Virtual Machine Scaleset. </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualMachineScaleSetVirtualMachineRunCommand" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualMachineScaleSetVirtualMachineRunCommand> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            Page<VirtualMachineScaleSetVirtualMachineRunCommand> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineRunCommandCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetVirtualMachineRunCommand(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualMachineScaleSetVirtualMachineRunCommand> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineRunCommandCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetVirtualMachineRunCommand(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> The operation to get all run commands of an instance in Virtual Machine Scaleset. </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualMachineScaleSetVirtualMachineRunCommand" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualMachineScaleSetVirtualMachineRunCommand> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualMachineScaleSetVirtualMachineRunCommand>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineRunCommandCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetVirtualMachineRunCommand(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualMachineScaleSetVirtualMachineRunCommand>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineRunCommandCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualMachineScaleSetVirtualMachineRunCommandVirtualMachineScaleSetVMRunCommandsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetVirtualMachineRunCommand(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<VirtualMachineScaleSetVirtualMachineRunCommand> IEnumerable<VirtualMachineScaleSetVirtualMachineRunCommand>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualMachineScaleSetVirtualMachineRunCommand> IAsyncEnumerable<VirtualMachineScaleSetVirtualMachineRunCommand>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
