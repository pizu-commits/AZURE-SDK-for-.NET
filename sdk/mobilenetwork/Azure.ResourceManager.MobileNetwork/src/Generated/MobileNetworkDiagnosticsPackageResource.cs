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

namespace Azure.ResourceManager.MobileNetwork
{
    /// <summary>
    /// A Class representing a MobileNetworkDiagnosticsPackage along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="MobileNetworkDiagnosticsPackageResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetMobileNetworkDiagnosticsPackageResource method.
    /// Otherwise you can get one from its parent resource <see cref="PacketCoreControlPlaneResource"/> using the GetMobileNetworkDiagnosticsPackage method.
    /// </summary>
    public partial class MobileNetworkDiagnosticsPackageResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MobileNetworkDiagnosticsPackageResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="packetCoreControlPlaneName"> The packetCoreControlPlaneName. </param>
        /// <param name="diagnosticsPackageName"> The diagnosticsPackageName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, string diagnosticsPackageName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/diagnosticsPackages/{diagnosticsPackageName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _mobileNetworkDiagnosticsPackageDiagnosticsPackagesClientDiagnostics;
        private readonly DiagnosticsPackagesRestOperations _mobileNetworkDiagnosticsPackageDiagnosticsPackagesRestClient;
        private readonly MobileNetworkDiagnosticsPackageData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.MobileNetwork/packetCoreControlPlanes/diagnosticsPackages";

        /// <summary> Initializes a new instance of the <see cref="MobileNetworkDiagnosticsPackageResource"/> class for mocking. </summary>
        protected MobileNetworkDiagnosticsPackageResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MobileNetworkDiagnosticsPackageResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MobileNetworkDiagnosticsPackageResource(ArmClient client, MobileNetworkDiagnosticsPackageData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MobileNetworkDiagnosticsPackageResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MobileNetworkDiagnosticsPackageResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mobileNetworkDiagnosticsPackageDiagnosticsPackagesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MobileNetwork", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string mobileNetworkDiagnosticsPackageDiagnosticsPackagesApiVersion);
            _mobileNetworkDiagnosticsPackageDiagnosticsPackagesRestClient = new DiagnosticsPackagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mobileNetworkDiagnosticsPackageDiagnosticsPackagesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MobileNetworkDiagnosticsPackageData Data
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
        /// Gets information about the specified diagnostics package.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/diagnosticsPackages/{diagnosticsPackageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiagnosticsPackages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MobileNetworkDiagnosticsPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MobileNetworkDiagnosticsPackageResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _mobileNetworkDiagnosticsPackageDiagnosticsPackagesClientDiagnostics.CreateScope("MobileNetworkDiagnosticsPackageResource.Get");
            scope.Start();
            try
            {
                var response = await _mobileNetworkDiagnosticsPackageDiagnosticsPackagesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MobileNetworkDiagnosticsPackageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified diagnostics package.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/diagnosticsPackages/{diagnosticsPackageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiagnosticsPackages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MobileNetworkDiagnosticsPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MobileNetworkDiagnosticsPackageResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _mobileNetworkDiagnosticsPackageDiagnosticsPackagesClientDiagnostics.CreateScope("MobileNetworkDiagnosticsPackageResource.Get");
            scope.Start();
            try
            {
                var response = _mobileNetworkDiagnosticsPackageDiagnosticsPackagesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MobileNetworkDiagnosticsPackageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified diagnostics package.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/diagnosticsPackages/{diagnosticsPackageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiagnosticsPackages_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MobileNetworkDiagnosticsPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _mobileNetworkDiagnosticsPackageDiagnosticsPackagesClientDiagnostics.CreateScope("MobileNetworkDiagnosticsPackageResource.Delete");
            scope.Start();
            try
            {
                var response = await _mobileNetworkDiagnosticsPackageDiagnosticsPackagesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MobileNetworkArmOperation(_mobileNetworkDiagnosticsPackageDiagnosticsPackagesClientDiagnostics, Pipeline, _mobileNetworkDiagnosticsPackageDiagnosticsPackagesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes the specified diagnostics package.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/diagnosticsPackages/{diagnosticsPackageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiagnosticsPackages_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MobileNetworkDiagnosticsPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _mobileNetworkDiagnosticsPackageDiagnosticsPackagesClientDiagnostics.CreateScope("MobileNetworkDiagnosticsPackageResource.Delete");
            scope.Start();
            try
            {
                var response = _mobileNetworkDiagnosticsPackageDiagnosticsPackagesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new MobileNetworkArmOperation(_mobileNetworkDiagnosticsPackageDiagnosticsPackagesClientDiagnostics, Pipeline, _mobileNetworkDiagnosticsPackageDiagnosticsPackagesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a diagnostics package.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/diagnosticsPackages/{diagnosticsPackageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiagnosticsPackages_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MobileNetworkDiagnosticsPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<MobileNetworkDiagnosticsPackageResource>> UpdateAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _mobileNetworkDiagnosticsPackageDiagnosticsPackagesClientDiagnostics.CreateScope("MobileNetworkDiagnosticsPackageResource.Update");
            scope.Start();
            try
            {
                var response = await _mobileNetworkDiagnosticsPackageDiagnosticsPackagesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MobileNetworkArmOperation<MobileNetworkDiagnosticsPackageResource>(new MobileNetworkDiagnosticsPackageOperationSource(Client), _mobileNetworkDiagnosticsPackageDiagnosticsPackagesClientDiagnostics, Pipeline, _mobileNetworkDiagnosticsPackageDiagnosticsPackagesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a diagnostics package.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/diagnosticsPackages/{diagnosticsPackageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiagnosticsPackages_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MobileNetworkDiagnosticsPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<MobileNetworkDiagnosticsPackageResource> Update(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _mobileNetworkDiagnosticsPackageDiagnosticsPackagesClientDiagnostics.CreateScope("MobileNetworkDiagnosticsPackageResource.Update");
            scope.Start();
            try
            {
                var response = _mobileNetworkDiagnosticsPackageDiagnosticsPackagesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new MobileNetworkArmOperation<MobileNetworkDiagnosticsPackageResource>(new MobileNetworkDiagnosticsPackageOperationSource(Client), _mobileNetworkDiagnosticsPackageDiagnosticsPackagesClientDiagnostics, Pipeline, _mobileNetworkDiagnosticsPackageDiagnosticsPackagesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
