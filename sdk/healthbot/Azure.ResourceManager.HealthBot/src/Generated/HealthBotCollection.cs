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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.HealthBot
{
    /// <summary>
    /// A class representing a collection of <see cref="HealthBotResource" /> and their operations.
    /// Each <see cref="HealthBotResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="HealthBotCollection" /> instance call the GetHealthBots method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class HealthBotCollection : ArmCollection, IEnumerable<HealthBotResource>, IAsyncEnumerable<HealthBotResource>
    {
        private readonly ClientDiagnostics _healthBotBotsClientDiagnostics;
        private readonly BotsRestOperations _healthBotBotsRestClient;

        /// <summary> Initializes a new instance of the <see cref="HealthBotCollection"/> class for mocking. </summary>
        protected HealthBotCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HealthBotCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HealthBotCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _healthBotBotsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HealthBot", HealthBotResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HealthBotResource.ResourceType, out string healthBotBotsApiVersion);
            _healthBotBotsRestClient = new BotsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, healthBotBotsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a new Azure Health Bot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthBot/healthBots/{botName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bots_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="botName"> The name of the Bot resource. </param>
        /// <param name="data"> The parameters to provide for the created Azure Health Bot. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="botName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="botName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<HealthBotResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string botName, HealthBotData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(botName, nameof(botName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _healthBotBotsClientDiagnostics.CreateScope("HealthBotCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _healthBotBotsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, botName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HealthBotArmOperation<HealthBotResource>(new HealthBotOperationSource(Client), _healthBotBotsClientDiagnostics, Pipeline, _healthBotBotsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, botName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a new Azure Health Bot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthBot/healthBots/{botName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bots_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="botName"> The name of the Bot resource. </param>
        /// <param name="data"> The parameters to provide for the created Azure Health Bot. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="botName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="botName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<HealthBotResource> CreateOrUpdate(WaitUntil waitUntil, string botName, HealthBotData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(botName, nameof(botName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _healthBotBotsClientDiagnostics.CreateScope("HealthBotCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _healthBotBotsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, botName, data, cancellationToken);
                var operation = new HealthBotArmOperation<HealthBotResource>(new HealthBotOperationSource(Client), _healthBotBotsClientDiagnostics, Pipeline, _healthBotBotsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, botName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a HealthBot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthBot/healthBots/{botName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bots_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="botName"> The name of the Bot resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="botName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="botName"/> is null. </exception>
        public virtual async Task<Response<HealthBotResource>> GetAsync(string botName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(botName, nameof(botName));

            using var scope = _healthBotBotsClientDiagnostics.CreateScope("HealthBotCollection.Get");
            scope.Start();
            try
            {
                var response = await _healthBotBotsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, botName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HealthBotResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a HealthBot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthBot/healthBots/{botName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bots_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="botName"> The name of the Bot resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="botName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="botName"/> is null. </exception>
        public virtual Response<HealthBotResource> Get(string botName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(botName, nameof(botName));

            using var scope = _healthBotBotsClientDiagnostics.CreateScope("HealthBotCollection.Get");
            scope.Start();
            try
            {
                var response = _healthBotBotsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, botName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HealthBotResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns all the resources of a particular type belonging to a resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthBot/healthBots</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bots_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HealthBotResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HealthBotResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _healthBotBotsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _healthBotBotsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new HealthBotResource(Client, HealthBotData.DeserializeHealthBotData(e)), _healthBotBotsClientDiagnostics, Pipeline, "HealthBotCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns all the resources of a particular type belonging to a resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthBot/healthBots</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bots_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HealthBotResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HealthBotResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _healthBotBotsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _healthBotBotsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new HealthBotResource(Client, HealthBotData.DeserializeHealthBotData(e)), _healthBotBotsClientDiagnostics, Pipeline, "HealthBotCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthBot/healthBots/{botName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bots_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="botName"> The name of the Bot resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="botName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="botName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string botName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(botName, nameof(botName));

            using var scope = _healthBotBotsClientDiagnostics.CreateScope("HealthBotCollection.Exists");
            scope.Start();
            try
            {
                var response = await _healthBotBotsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, botName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthBot/healthBots/{botName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bots_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="botName"> The name of the Bot resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="botName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="botName"/> is null. </exception>
        public virtual Response<bool> Exists(string botName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(botName, nameof(botName));

            using var scope = _healthBotBotsClientDiagnostics.CreateScope("HealthBotCollection.Exists");
            scope.Start();
            try
            {
                var response = _healthBotBotsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, botName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HealthBotResource> IEnumerable<HealthBotResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HealthBotResource> IAsyncEnumerable<HealthBotResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
