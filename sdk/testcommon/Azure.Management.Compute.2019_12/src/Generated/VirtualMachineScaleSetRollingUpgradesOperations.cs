// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.Management.Compute.Models;

namespace Azure.Management.Compute
{
    /// <summary> The VirtualMachineScaleSetRollingUpgrades service client. </summary>
    public partial class VirtualMachineScaleSetRollingUpgradesOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal VirtualMachineScaleSetRollingUpgradesRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of VirtualMachineScaleSetRollingUpgradesOperations for mocking. </summary>
        protected VirtualMachineScaleSetRollingUpgradesOperations()
        {
        }
        /// <summary> Initializes a new instance of VirtualMachineScaleSetRollingUpgradesOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal VirtualMachineScaleSetRollingUpgradesOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new VirtualMachineScaleSetRollingUpgradesRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the status of the latest virtual machine scale set rolling upgrade. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RollingUpgradeStatusInfo>> GetLatestAsync(string resourceGroupName, string vmScaleSetName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetRollingUpgradesOperations.GetLatest");
            scope.Start();
            try
            {
                return await RestClient.GetLatestAsync(resourceGroupName, vmScaleSetName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the status of the latest virtual machine scale set rolling upgrade. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RollingUpgradeStatusInfo> GetLatest(string resourceGroupName, string vmScaleSetName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetRollingUpgradesOperations.GetLatest");
            scope.Start();
            try
            {
                return RestClient.GetLatest(resourceGroupName, vmScaleSetName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Cancels the current virtual machine scale set rolling upgrade. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<VirtualMachineScaleSetRollingUpgradesCancelOperation> StartCancelAsync(string resourceGroupName, string vmScaleSetName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetRollingUpgradesOperations.StartCancel");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CancelAsync(resourceGroupName, vmScaleSetName, cancellationToken).ConfigureAwait(false);
                return new VirtualMachineScaleSetRollingUpgradesCancelOperation(_clientDiagnostics, _pipeline, RestClient.CreateCancelRequest(resourceGroupName, vmScaleSetName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Cancels the current virtual machine scale set rolling upgrade. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VirtualMachineScaleSetRollingUpgradesCancelOperation StartCancel(string resourceGroupName, string vmScaleSetName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetRollingUpgradesOperations.StartCancel");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Cancel(resourceGroupName, vmScaleSetName, cancellationToken);
                return new VirtualMachineScaleSetRollingUpgradesCancelOperation(_clientDiagnostics, _pipeline, RestClient.CreateCancelRequest(resourceGroupName, vmScaleSetName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts a rolling upgrade to move all virtual machine scale set instances to the latest available Platform Image OS version. Instances which are already running the latest available OS version are not affected. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<VirtualMachineScaleSetRollingUpgradesStartOSUpgradeOperation> StartStartOSUpgradeAsync(string resourceGroupName, string vmScaleSetName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetRollingUpgradesOperations.StartStartOSUpgrade");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.StartOSUpgradeAsync(resourceGroupName, vmScaleSetName, cancellationToken).ConfigureAwait(false);
                return new VirtualMachineScaleSetRollingUpgradesStartOSUpgradeOperation(_clientDiagnostics, _pipeline, RestClient.CreateStartOSUpgradeRequest(resourceGroupName, vmScaleSetName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts a rolling upgrade to move all virtual machine scale set instances to the latest available Platform Image OS version. Instances which are already running the latest available OS version are not affected. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VirtualMachineScaleSetRollingUpgradesStartOSUpgradeOperation StartStartOSUpgrade(string resourceGroupName, string vmScaleSetName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetRollingUpgradesOperations.StartStartOSUpgrade");
            scope.Start();
            try
            {
                var originalResponse = RestClient.StartOSUpgrade(resourceGroupName, vmScaleSetName, cancellationToken);
                return new VirtualMachineScaleSetRollingUpgradesStartOSUpgradeOperation(_clientDiagnostics, _pipeline, RestClient.CreateStartOSUpgradeRequest(resourceGroupName, vmScaleSetName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts a rolling upgrade to move all extensions for all virtual machine scale set instances to the latest available extension version. Instances which are already running the latest extension versions are not affected. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<VirtualMachineScaleSetRollingUpgradesStartExtensionUpgradeOperation> StartStartExtensionUpgradeAsync(string resourceGroupName, string vmScaleSetName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetRollingUpgradesOperations.StartStartExtensionUpgrade");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.StartExtensionUpgradeAsync(resourceGroupName, vmScaleSetName, cancellationToken).ConfigureAwait(false);
                return new VirtualMachineScaleSetRollingUpgradesStartExtensionUpgradeOperation(_clientDiagnostics, _pipeline, RestClient.CreateStartExtensionUpgradeRequest(resourceGroupName, vmScaleSetName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts a rolling upgrade to move all extensions for all virtual machine scale set instances to the latest available extension version. Instances which are already running the latest extension versions are not affected. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VirtualMachineScaleSetRollingUpgradesStartExtensionUpgradeOperation StartStartExtensionUpgrade(string resourceGroupName, string vmScaleSetName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetRollingUpgradesOperations.StartStartExtensionUpgrade");
            scope.Start();
            try
            {
                var originalResponse = RestClient.StartExtensionUpgrade(resourceGroupName, vmScaleSetName, cancellationToken);
                return new VirtualMachineScaleSetRollingUpgradesStartExtensionUpgradeOperation(_clientDiagnostics, _pipeline, RestClient.CreateStartExtensionUpgradeRequest(resourceGroupName, vmScaleSetName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
