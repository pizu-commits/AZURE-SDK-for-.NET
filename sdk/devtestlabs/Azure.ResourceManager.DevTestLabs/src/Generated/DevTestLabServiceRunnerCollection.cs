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

namespace Azure.ResourceManager.DevTestLabs
{
    /// <summary>
    /// A class representing a collection of <see cref="DevTestLabServiceRunnerResource"/> and their operations.
    /// Each <see cref="DevTestLabServiceRunnerResource"/> in the collection will belong to the same instance of <see cref="DevTestLabResource"/>.
    /// To get a <see cref="DevTestLabServiceRunnerCollection"/> instance call the GetDevTestLabServiceRunners method from an instance of <see cref="DevTestLabResource"/>.
    /// </summary>
    public partial class DevTestLabServiceRunnerCollection : ArmCollection
    {
        private readonly ClientDiagnostics _devTestLabServiceRunnerServiceRunnersClientDiagnostics;
        private readonly ServiceRunnersRestOperations _devTestLabServiceRunnerServiceRunnersRestClient;

        /// <summary> Initializes a new instance of the <see cref="DevTestLabServiceRunnerCollection"/> class for mocking. </summary>
        protected DevTestLabServiceRunnerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DevTestLabServiceRunnerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DevTestLabServiceRunnerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _devTestLabServiceRunnerServiceRunnersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevTestLabs", DevTestLabServiceRunnerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DevTestLabServiceRunnerResource.ResourceType, out string devTestLabServiceRunnerServiceRunnersApiVersion);
            _devTestLabServiceRunnerServiceRunnersRestClient = new ServiceRunnersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, devTestLabServiceRunnerServiceRunnersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DevTestLabResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DevTestLabResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or replace an existing service runner.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/servicerunners/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceRunners_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabServiceRunnerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the service runner. </param>
        /// <param name="data"> A container for a managed identity to execute DevTest lab services. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DevTestLabServiceRunnerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, DevTestLabServiceRunnerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devTestLabServiceRunnerServiceRunnersClientDiagnostics.CreateScope("DevTestLabServiceRunnerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _devTestLabServiceRunnerServiceRunnersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new DevTestLabsArmOperation<DevTestLabServiceRunnerResource>(Response.FromValue(new DevTestLabServiceRunnerResource(Client, response), response.GetRawResponse()));
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
        /// Create or replace an existing service runner.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/servicerunners/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceRunners_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabServiceRunnerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the service runner. </param>
        /// <param name="data"> A container for a managed identity to execute DevTest lab services. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DevTestLabServiceRunnerResource> CreateOrUpdate(WaitUntil waitUntil, string name, DevTestLabServiceRunnerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devTestLabServiceRunnerServiceRunnersClientDiagnostics.CreateScope("DevTestLabServiceRunnerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _devTestLabServiceRunnerServiceRunnersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken);
                var operation = new DevTestLabsArmOperation<DevTestLabServiceRunnerResource>(Response.FromValue(new DevTestLabServiceRunnerResource(Client, response), response.GetRawResponse()));
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
        /// Get service runner.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/servicerunners/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceRunners_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabServiceRunnerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the service runner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<DevTestLabServiceRunnerResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabServiceRunnerServiceRunnersClientDiagnostics.CreateScope("DevTestLabServiceRunnerCollection.Get");
            scope.Start();
            try
            {
                var response = await _devTestLabServiceRunnerServiceRunnersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevTestLabServiceRunnerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get service runner.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/servicerunners/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceRunners_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabServiceRunnerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the service runner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<DevTestLabServiceRunnerResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabServiceRunnerServiceRunnersClientDiagnostics.CreateScope("DevTestLabServiceRunnerCollection.Get");
            scope.Start();
            try
            {
                var response = _devTestLabServiceRunnerServiceRunnersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevTestLabServiceRunnerResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/servicerunners/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceRunners_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabServiceRunnerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the service runner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabServiceRunnerServiceRunnersClientDiagnostics.CreateScope("DevTestLabServiceRunnerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _devTestLabServiceRunnerServiceRunnersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/servicerunners/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceRunners_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabServiceRunnerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the service runner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabServiceRunnerServiceRunnersClientDiagnostics.CreateScope("DevTestLabServiceRunnerCollection.Exists");
            scope.Start();
            try
            {
                var response = _devTestLabServiceRunnerServiceRunnersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/servicerunners/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceRunners_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabServiceRunnerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the service runner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<NullableResponse<DevTestLabServiceRunnerResource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabServiceRunnerServiceRunnersClientDiagnostics.CreateScope("DevTestLabServiceRunnerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _devTestLabServiceRunnerServiceRunnersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DevTestLabServiceRunnerResource>(response.GetRawResponse());
                return Response.FromValue(new DevTestLabServiceRunnerResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/servicerunners/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceRunners_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabServiceRunnerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the service runner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual NullableResponse<DevTestLabServiceRunnerResource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabServiceRunnerServiceRunnersClientDiagnostics.CreateScope("DevTestLabServiceRunnerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _devTestLabServiceRunnerServiceRunnersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DevTestLabServiceRunnerResource>(response.GetRawResponse());
                return Response.FromValue(new DevTestLabServiceRunnerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
