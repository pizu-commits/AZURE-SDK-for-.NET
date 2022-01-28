// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a ExpressRouteCircuit along with the instance operations that can be performed on it. </summary>
    public partial class ExpressRouteCircuit : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ExpressRouteCircuit"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string circuitName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _expressRouteCircuitClientDiagnostics;
        private readonly ExpressRouteCircuitsRestOperations _expressRouteCircuitRestClient;
        private readonly ExpressRouteCircuitData _data;

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCircuit"/> class for mocking. </summary>
        protected ExpressRouteCircuit()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ExpressRouteCircuit"/> class. </summary>
        /// <param name="armClient"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ExpressRouteCircuit(ArmClient armClient, ExpressRouteCircuitData data) : this(armClient, new ResourceIdentifier(data.Id))
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCircuit"/> class. </summary>
        /// <param name="armClient"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ExpressRouteCircuit(ArmClient armClient, ResourceIdentifier id) : base(armClient, id)
        {
            _expressRouteCircuitClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(ResourceType, out string expressRouteCircuitApiVersion);
            _expressRouteCircuitRestClient = new ExpressRouteCircuitsRestOperations(_expressRouteCircuitClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, expressRouteCircuitApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/expressRouteCircuits";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ExpressRouteCircuitData Data
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

        /// <summary> Gets information about the specified express route circuit. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ExpressRouteCircuit>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _expressRouteCircuitClientDiagnostics.CreateScope("ExpressRouteCircuit.Get");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _expressRouteCircuitClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ExpressRouteCircuit(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets information about the specified express route circuit. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExpressRouteCircuit> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _expressRouteCircuitClientDiagnostics.CreateScope("ExpressRouteCircuit.Get");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _expressRouteCircuitClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuit(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<AzureLocation>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _expressRouteCircuitClientDiagnostics.CreateScope("ExpressRouteCircuit.GetAvailableLocations");
            scope.Start();
            try
            {
                return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<AzureLocation> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            using var scope = _expressRouteCircuitClientDiagnostics.CreateScope("ExpressRouteCircuit.GetAvailableLocations");
            scope.Start();
            try
            {
                return ListAvailableLocations(ResourceType, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified express route circuit. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ExpressRouteCircuitDeleteOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _expressRouteCircuitClientDiagnostics.CreateScope("ExpressRouteCircuit.Delete");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ExpressRouteCircuitDeleteOperation(_expressRouteCircuitClientDiagnostics, Pipeline, _expressRouteCircuitRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified express route circuit. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ExpressRouteCircuitDeleteOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _expressRouteCircuitClientDiagnostics.CreateScope("ExpressRouteCircuit.Delete");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new ExpressRouteCircuitDeleteOperation(_expressRouteCircuitClientDiagnostics, Pipeline, _expressRouteCircuitRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates an express route circuit tags. </summary>
        /// <param name="parameters"> Parameters supplied to update express route circuit tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<ExpressRouteCircuit>> UpdateAsync(TagsObject parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _expressRouteCircuitClientDiagnostics.CreateScope("ExpressRouteCircuit.Update");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitRestClient.UpdateTagsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ExpressRouteCircuit(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates an express route circuit tags. </summary>
        /// <param name="parameters"> Parameters supplied to update express route circuit tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual Response<ExpressRouteCircuit> Update(TagsObject parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _expressRouteCircuitClientDiagnostics.CreateScope("ExpressRouteCircuit.Update");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitRestClient.UpdateTags(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, parameters, cancellationToken);
                return Response.FromValue(new ExpressRouteCircuit(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the stats from an express route circuit in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ExpressRouteCircuitStats>> GetStatsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _expressRouteCircuitClientDiagnostics.CreateScope("ExpressRouteCircuit.GetStats");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitRestClient.GetStatsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the stats from an express route circuit in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExpressRouteCircuitStats> GetStats(CancellationToken cancellationToken = default)
        {
            using var scope = _expressRouteCircuitClientDiagnostics.CreateScope("ExpressRouteCircuit.GetStats");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitRestClient.GetStats(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        #region ExpressRouteCircuitAuthorization

        /// <summary> Gets a collection of ExpressRouteCircuitAuthorizations in the ExpressRouteCircuit. </summary>
        /// <returns> An object representing collection of ExpressRouteCircuitAuthorizations and their operations over a ExpressRouteCircuit. </returns>
        public virtual ExpressRouteCircuitAuthorizationCollection GetExpressRouteCircuitAuthorizations()
        {
            return new ExpressRouteCircuitAuthorizationCollection(this);
        }
        #endregion

        #region ExpressRouteCircuitPeering

        /// <summary> Gets a collection of ExpressRouteCircuitPeerings in the ExpressRouteCircuit. </summary>
        /// <returns> An object representing collection of ExpressRouteCircuitPeerings and their operations over a ExpressRouteCircuit. </returns>
        public virtual ExpressRouteCircuitPeeringCollection GetExpressRouteCircuitPeerings()
        {
            return new ExpressRouteCircuitPeeringCollection(this);
        }
        #endregion
    }
}
