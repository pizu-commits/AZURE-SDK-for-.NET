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

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A Class representing a MachineLearningRegistryEnvironmentContainer along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="MachineLearningRegistryEnvironmentContainerResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetMachineLearningRegistryEnvironmentContainerResource method.
    /// Otherwise you can get one from its parent resource <see cref="MachineLearningRegistryResource" /> using the GetMachineLearningRegistryEnvironmentContainer method.
    /// </summary>
    public partial class MachineLearningRegistryEnvironmentContainerResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MachineLearningRegistryEnvironmentContainerResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="registryName"> The registryName. </param>
        /// <param name="environmentName"> The environmentName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string registryName, string environmentName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/environments/{environmentName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _machineLearningRegistryEnvironmentContainerRegistryEnvironmentContainersClientDiagnostics;
        private readonly RegistryEnvironmentContainersRestOperations _machineLearningRegistryEnvironmentContainerRegistryEnvironmentContainersRestClient;
        private readonly MachineLearningEnvironmentContainerData _data;

        /// <summary> Initializes a new instance of the <see cref="MachineLearningRegistryEnvironmentContainerResource"/> class for mocking. </summary>
        protected MachineLearningRegistryEnvironmentContainerResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "MachineLearningRegistryEnvironmentContainerResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MachineLearningRegistryEnvironmentContainerResource(ArmClient client, MachineLearningEnvironmentContainerData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningRegistryEnvironmentContainerResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MachineLearningRegistryEnvironmentContainerResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _machineLearningRegistryEnvironmentContainerRegistryEnvironmentContainersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string machineLearningRegistryEnvironmentContainerRegistryEnvironmentContainersApiVersion);
            _machineLearningRegistryEnvironmentContainerRegistryEnvironmentContainersRestClient = new RegistryEnvironmentContainersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, machineLearningRegistryEnvironmentContainerRegistryEnvironmentContainersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.MachineLearningServices/registries/environments";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MachineLearningEnvironmentContainerData Data
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

        /// <summary> Gets a collection of MachineLearningRegistryEnvironmentVersionResources in the MachineLearningRegistryEnvironmentContainer. </summary>
        /// <returns> An object representing collection of MachineLearningRegistryEnvironmentVersionResources and their operations over a MachineLearningRegistryEnvironmentVersionResource. </returns>
        public virtual MachineLearningRegistryEnvironmentVersionCollection GetMachineLearningRegistryEnvironmentVersions()
        {
            return GetCachedClient(Client => new MachineLearningRegistryEnvironmentVersionCollection(Client, Id));
        }

        /// <summary>
        /// Get version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/environments/{environmentName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryEnvironmentVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<MachineLearningRegistryEnvironmentVersionResource>> GetMachineLearningRegistryEnvironmentVersionAsync(string version, CancellationToken cancellationToken = default)
        {
            return await GetMachineLearningRegistryEnvironmentVersions().GetAsync(version, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/environments/{environmentName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryEnvironmentVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<MachineLearningRegistryEnvironmentVersionResource> GetMachineLearningRegistryEnvironmentVersion(string version, CancellationToken cancellationToken = default)
        {
            return GetMachineLearningRegistryEnvironmentVersions().Get(version, cancellationToken);
        }

        /// <summary>
        /// Get container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/environments/{environmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryEnvironmentContainers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MachineLearningRegistryEnvironmentContainerResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _machineLearningRegistryEnvironmentContainerRegistryEnvironmentContainersClientDiagnostics.CreateScope("MachineLearningRegistryEnvironmentContainerResource.Get");
            scope.Start();
            try
            {
                var response = await _machineLearningRegistryEnvironmentContainerRegistryEnvironmentContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningRegistryEnvironmentContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/environments/{environmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryEnvironmentContainers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MachineLearningRegistryEnvironmentContainerResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _machineLearningRegistryEnvironmentContainerRegistryEnvironmentContainersClientDiagnostics.CreateScope("MachineLearningRegistryEnvironmentContainerResource.Get");
            scope.Start();
            try
            {
                var response = _machineLearningRegistryEnvironmentContainerRegistryEnvironmentContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningRegistryEnvironmentContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/environments/{environmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryEnvironmentContainers_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _machineLearningRegistryEnvironmentContainerRegistryEnvironmentContainersClientDiagnostics.CreateScope("MachineLearningRegistryEnvironmentContainerResource.Delete");
            scope.Start();
            try
            {
                var response = await _machineLearningRegistryEnvironmentContainerRegistryEnvironmentContainersRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation(_machineLearningRegistryEnvironmentContainerRegistryEnvironmentContainersClientDiagnostics, Pipeline, _machineLearningRegistryEnvironmentContainerRegistryEnvironmentContainersRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Delete container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/environments/{environmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryEnvironmentContainers_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _machineLearningRegistryEnvironmentContainerRegistryEnvironmentContainersClientDiagnostics.CreateScope("MachineLearningRegistryEnvironmentContainerResource.Delete");
            scope.Start();
            try
            {
                var response = _machineLearningRegistryEnvironmentContainerRegistryEnvironmentContainersRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new MachineLearningArmOperation(_machineLearningRegistryEnvironmentContainerRegistryEnvironmentContainersClientDiagnostics, Pipeline, _machineLearningRegistryEnvironmentContainerRegistryEnvironmentContainersRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/environments/{environmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryEnvironmentContainers_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Container entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MachineLearningRegistryEnvironmentContainerResource>> UpdateAsync(WaitUntil waitUntil, MachineLearningEnvironmentContainerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningRegistryEnvironmentContainerRegistryEnvironmentContainersClientDiagnostics.CreateScope("MachineLearningRegistryEnvironmentContainerResource.Update");
            scope.Start();
            try
            {
                var response = await _machineLearningRegistryEnvironmentContainerRegistryEnvironmentContainersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<MachineLearningRegistryEnvironmentContainerResource>(new MachineLearningRegistryEnvironmentContainerOperationSource(Client), _machineLearningRegistryEnvironmentContainerRegistryEnvironmentContainersClientDiagnostics, Pipeline, _machineLearningRegistryEnvironmentContainerRegistryEnvironmentContainersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Create or update container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/environments/{environmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryEnvironmentContainers_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Container entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MachineLearningRegistryEnvironmentContainerResource> Update(WaitUntil waitUntil, MachineLearningEnvironmentContainerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningRegistryEnvironmentContainerRegistryEnvironmentContainersClientDiagnostics.CreateScope("MachineLearningRegistryEnvironmentContainerResource.Update");
            scope.Start();
            try
            {
                var response = _machineLearningRegistryEnvironmentContainerRegistryEnvironmentContainersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new MachineLearningArmOperation<MachineLearningRegistryEnvironmentContainerResource>(new MachineLearningRegistryEnvironmentContainerOperationSource(Client), _machineLearningRegistryEnvironmentContainerRegistryEnvironmentContainersClientDiagnostics, Pipeline, _machineLearningRegistryEnvironmentContainerRegistryEnvironmentContainersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.OriginalUri);
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
