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
using Azure.ResourceManager.Reservations.Models;

namespace Azure.ResourceManager.Reservations
{
    /// <summary>
    /// A Class representing a ReservationDetail along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ReservationDetailResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetReservationDetailResource method.
    /// Otherwise you can get one from its parent resource <see cref="ReservationOrderResource" /> using the GetReservationDetail method.
    /// </summary>
    public partial class ReservationDetailResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ReservationDetailResource"/> instance. </summary>
        /// <param name="reservationOrderId"> The reservationOrderId. </param>
        /// <param name="reservationId"> The reservationId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(Guid reservationOrderId, Guid reservationId)
        {
            var resourceId = $"/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _reservationDetailReservationClientDiagnostics;
        private readonly ReservationRestOperations _reservationDetailReservationRestClient;
        private readonly ReservationDetailData _data;

        /// <summary> Initializes a new instance of the <see cref="ReservationDetailResource"/> class for mocking. </summary>
        protected ReservationDetailResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ReservationDetailResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ReservationDetailResource(ArmClient client, ReservationDetailData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ReservationDetailResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ReservationDetailResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _reservationDetailReservationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Reservations", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string reservationDetailReservationApiVersion);
            _reservationDetailReservationRestClient = new ReservationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, reservationDetailReservationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Capacity/reservationOrders/reservations";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ReservationDetailData Data
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
        /// Get specific `Reservation` details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Supported value of this query is renewProperties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ReservationDetailResource>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _reservationDetailReservationClientDiagnostics.CreateScope("ReservationDetailResource.Get");
            scope.Start();
            try
            {
                var response = await _reservationDetailReservationRestClient.GetAsync(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ReservationDetailResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get specific `Reservation` details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Supported value of this query is renewProperties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ReservationDetailResource> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _reservationDetailReservationClientDiagnostics.CreateScope("ReservationDetailResource.Get");
            scope.Start();
            try
            {
                var response = _reservationDetailReservationRestClient.Get(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ReservationDetailResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates the applied scopes of the `Reservation`.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Information needed to patch a reservation item. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<ArmOperation<ReservationDetailResource>> UpdateAsync(WaitUntil waitUntil, ReservationDetailPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _reservationDetailReservationClientDiagnostics.CreateScope("ReservationDetailResource.Update");
            scope.Start();
            try
            {
                var response = await _reservationDetailReservationRestClient.UpdateAsync(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), patch, cancellationToken).ConfigureAwait(false);
                var operation = new ReservationsArmOperation<ReservationDetailResource>(new ReservationDetailOperationSource(Client), _reservationDetailReservationClientDiagnostics, Pipeline, _reservationDetailReservationRestClient.CreateUpdateRequest(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), patch).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Updates the applied scopes of the `Reservation`.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Information needed to patch a reservation item. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual ArmOperation<ReservationDetailResource> Update(WaitUntil waitUntil, ReservationDetailPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _reservationDetailReservationClientDiagnostics.CreateScope("ReservationDetailResource.Update");
            scope.Start();
            try
            {
                var response = _reservationDetailReservationRestClient.Update(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), patch, cancellationToken);
                var operation = new ReservationsArmOperation<ReservationDetailResource>(new ReservationDetailOperationSource(Client), _reservationDetailReservationClientDiagnostics, Pipeline, _reservationDetailReservationRestClient.CreateUpdateRequest(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), patch).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Check whether the scopes from request is valid for `Reservation`.
        ///
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}/availableScopes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_AvailableScopes</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Scopes to be checked for eligibility. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<AvailableScopesProperties>> GetAvailableScopesAsync(WaitUntil waitUntil, AvailableScopesContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _reservationDetailReservationClientDiagnostics.CreateScope("ReservationDetailResource.GetAvailableScopes");
            scope.Start();
            try
            {
                var response = await _reservationDetailReservationRestClient.AvailableScopesAsync(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), content, cancellationToken).ConfigureAwait(false);
                var operation = new ReservationsArmOperation<AvailableScopesProperties>(new AvailableScopesPropertiesOperationSource(), _reservationDetailReservationClientDiagnostics, Pipeline, _reservationDetailReservationRestClient.CreateAvailableScopesRequest(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), content).Request, response, OperationFinalStateVia.Location);
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
        /// Check whether the scopes from request is valid for `Reservation`.
        ///
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}/availableScopes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_AvailableScopes</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Scopes to be checked for eligibility. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<AvailableScopesProperties> GetAvailableScopes(WaitUntil waitUntil, AvailableScopesContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _reservationDetailReservationClientDiagnostics.CreateScope("ReservationDetailResource.GetAvailableScopes");
            scope.Start();
            try
            {
                var response = _reservationDetailReservationRestClient.AvailableScopes(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), content, cancellationToken);
                var operation = new ReservationsArmOperation<AvailableScopesProperties>(new AvailableScopesPropertiesOperationSource(), _reservationDetailReservationClientDiagnostics, Pipeline, _reservationDetailReservationRestClient.CreateAvailableScopesRequest(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), content).Request, response, OperationFinalStateVia.Location);
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
        /// Archiving a `Reservation` moves it to `Archived` state.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}/archive</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_Archive</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> ArchiveAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _reservationDetailReservationClientDiagnostics.CreateScope("ReservationDetailResource.Archive");
            scope.Start();
            try
            {
                var response = await _reservationDetailReservationRestClient.ArchiveAsync(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Archiving a `Reservation` moves it to `Archived` state.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}/archive</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_Archive</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Archive(CancellationToken cancellationToken = default)
        {
            using var scope = _reservationDetailReservationClientDiagnostics.CreateScope("ReservationDetailResource.Archive");
            scope.Start();
            try
            {
                var response = _reservationDetailReservationRestClient.Archive(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Restores a `Reservation` to the state it was before archiving.
        ///
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}/unarchive</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_Unarchive</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> UnarchiveAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _reservationDetailReservationClientDiagnostics.CreateScope("ReservationDetailResource.Unarchive");
            scope.Start();
            try
            {
                var response = await _reservationDetailReservationRestClient.UnarchiveAsync(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Restores a `Reservation` to the state it was before archiving.
        ///
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}/unarchive</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_Unarchive</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Unarchive(CancellationToken cancellationToken = default)
        {
            using var scope = _reservationDetailReservationClientDiagnostics.CreateScope("ReservationDetailResource.Unarchive");
            scope.Start();
            try
            {
                var response = _reservationDetailReservationRestClient.Unarchive(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
