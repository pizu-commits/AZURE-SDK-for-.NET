// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Azure.Communication.Pipeline;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.Rooms
{
    /// <summary>
    /// The Azure Communication Services Rooms client.
    /// </summary>
    public class RoomsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;

        internal RoomsRestClient RoomsServiceClient { get; }

        #region public constructors - all arguments need null check

        /// <summary>
        /// Initializes a new instance of the <see cref="RoomsClient"/> class.
        /// </summary>
        /// <param name="connectionString"></param>
        public RoomsClient(string connectionString)
            : this(
                ConnectionString.Parse(Argument.CheckNotNullOrEmpty(connectionString, nameof(connectionString))),
                new RoomsClientOptions())
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoomsClient"/> class.
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="options"></param>
        public RoomsClient(string connectionString, RoomsClientOptions options)
            : this(
                ConnectionString.Parse(Argument.CheckNotNullOrEmpty(connectionString, nameof(connectionString))),
                options ?? new RoomsClientOptions())
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoomsClient"/> class.
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="keyCredential"></param>
        /// <param name="options"></param>
        public RoomsClient(Uri endpoint, AzureKeyCredential keyCredential, RoomsClientOptions options = default)
            : this(
                Argument.CheckNotNull(endpoint, nameof(endpoint)).AbsoluteUri,
                Argument.CheckNotNull(keyCredential, nameof(keyCredential)),
                options ?? new RoomsClientOptions())
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoomsClient"/> class.
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="tokenCredential"></param>
        /// <param name="options"></param>
        public RoomsClient(Uri endpoint, TokenCredential tokenCredential, RoomsClientOptions options = default)
            : this(
                Argument.CheckNotNull(endpoint, nameof(endpoint)).AbsoluteUri,
                Argument.CheckNotNull(tokenCredential, nameof(tokenCredential)),
                options ?? new RoomsClientOptions())
        { }

        #endregion

        #region private constructors

        private RoomsClient(ConnectionString connectionString, RoomsClientOptions options)
            : this(connectionString.GetRequired("endpoint"), options.BuildHttpPipeline(connectionString), options)
        { }

        private RoomsClient(string endpoint, TokenCredential tokenCredential, RoomsClientOptions options)
            : this(endpoint, options.BuildHttpPipeline(tokenCredential), options)
        { }

        private RoomsClient(string endpoint, AzureKeyCredential keyCredential, RoomsClientOptions options)
            : this(endpoint, options.BuildHttpPipeline(keyCredential), options)
        { }

        private RoomsClient(string endpoint, HttpPipeline httpPipeline, RoomsClientOptions options)
        {
            _clientDiagnostics = new ClientDiagnostics(options);
            RoomsServiceClient = new RoomsRestClient(_clientDiagnostics, httpPipeline, endpoint, options.ApiVersion);
        }
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="RoomsClient"/> class.
        /// </summary>
        protected RoomsClient()
        {
            _clientDiagnostics = null!;
            RoomsServiceClient = null!;
        }

        /// <summary>
        /// Creates a new room asynchronously.
        /// </summary>
        /// <param name="validFrom"></param>
        /// <param name="validUntil"></param>
        /// <param name="roomOpen"></param>
        /// <param name="participants"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        public virtual async Task<Response<RoomModel>> CreateRoomAsync(DateTimeOffset? validFrom = default, DateTimeOffset? validUntil = default, bool roomOpen = default, IEnumerable<RoomParticipant> participants = default, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(RoomsClient)}.{nameof(CreateRoom)}");
            scope.Start();
            try
            {
                Guid repeatabilityRequestId = Guid.NewGuid();
                DateTimeOffset repeatabilityFirstSent = DateTimeOffset.UtcNow;
                Response<RoomModelInternal> createRoomResponseInternal =
                    await RoomsServiceClient.CreateRoomAsync(repeatabilityRequestId, repeatabilityFirstSent, validFrom, validUntil, roomOpen, participants == null ? null : participants.Select(x => x.ToRoomParticipantInternal()), cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new RoomModel(createRoomResponseInternal.Value), createRoomResponseInternal.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Creates a new room.
        /// </summary>
        /// <param name="validFrom"></param>
        /// <param name="validUntil"></param>
        /// <param name="roomOpen"></param>
        /// <param name="participants"></param>
        /// <param name="cancellationToken"></param>
        public virtual Response<RoomModel> CreateRoom(DateTimeOffset? validFrom = default, DateTimeOffset? validUntil = default, bool roomOpen = default, IEnumerable<RoomParticipant> participants = default, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(RoomsClient)}.{nameof(CreateRoom)}");
            scope.Start();
            try
            {
                Guid repeatabilityRequestId = Guid.NewGuid();
                DateTimeOffset repeatabilityFirstSent = DateTimeOffset.UtcNow;
                Response<RoomModelInternal> createRoomResponseInternal =
                     RoomsServiceClient.CreateRoom(repeatabilityRequestId, repeatabilityFirstSent, validFrom, validUntil, roomOpen, participants == null ? null : participants.Select(x => x.ToRoomParticipantInternal()), cancellationToken);
                return Response.FromValue(new RoomModel(createRoomResponseInternal.Value), createRoomResponseInternal.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Updates a room asynchronously.
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="validFrom"></param>
        /// <param name="validUntil"></param>
        /// <param name="roomOpen"></param>
        /// <param name="participants"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        public virtual async Task<Response<RoomModel>> UpdateRoomAsync(string roomId, DateTimeOffset? validFrom = default, DateTimeOffset? validUntil = default, bool roomOpen = default, IEnumerable<RoomParticipant> participants = default, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(RoomsClient)}.{nameof(UpdateRoom)}");
            scope.Start();
            try
            {
                Response<RoomModelInternal> updateRoomResponseInternal =
                    await RoomsServiceClient.UpdateRoomAsync(roomId, validFrom, validUntil, roomOpen, participants == null ? null : participants.Select(x => x.ToRoomParticipantInternal()), cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new RoomModel(updateRoomResponseInternal.Value), updateRoomResponseInternal.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Updates a room.
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="validFrom"></param>
        /// <param name="validUntil"></param>
        /// <param name="roomOpen"></param>
        /// <param name="participants"></param>
        /// <param name="cancellationToken"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="roomId"/> is null. </exception>
        public virtual Response<RoomModel> UpdateRoom(string roomId, DateTimeOffset? validFrom = default, DateTimeOffset? validUntil = default, bool roomOpen = default, IEnumerable < RoomParticipant> participants = default, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(RoomsClient)}.{nameof(UpdateRoom)}");
            scope.Start();
            try
            {
                Response<RoomModelInternal> updateRoomResponseInternal =
                    RoomsServiceClient.UpdateRoom(roomId, validFrom, validUntil, roomOpen, participants == null ? null : participants.Select(x => x.ToRoomParticipantInternal()), cancellationToken);
                return Response.FromValue(new RoomModel(updateRoomResponseInternal.Value), updateRoomResponseInternal.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Gets a room by id asynchronously.
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        public virtual async Task<Response<RoomModel>> GetRoomAsync(string roomId, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(RoomsClient)}.{nameof(GetRoom)}");
            scope.Start();
            try
            {
                Response<RoomModelInternal> getRoomResponseInternal =
                    await RoomsServiceClient.GetRoomAsync(roomId, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new RoomModel(getRoomResponseInternal.Value), getRoomResponseInternal.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Gets a room.
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="cancellationToken"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="roomId"/> is null. </exception>
        public virtual Response<RoomModel> GetRoom(string roomId, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(RoomsClient)}.{nameof(GetRoom)}");
            scope.Start();
            try
            {
                Response<RoomModelInternal> getRoomResponseInternal =
                    RoomsServiceClient.GetRoom(roomId, cancellationToken);
                return Response.FromValue(new RoomModel(getRoomResponseInternal.Value), getRoomResponseInternal.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Deletes a room by id asynchronously.
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>A <see cref="Task{Response}"/> representing the result of the asynchronous operation.</returns>
        public virtual async Task<Response> DeleteRoomAsync(string roomId, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(RoomsClient)}.{nameof(DeleteRoom)}");
            scope.Start();
            try
            {
                return await RoomsServiceClient.DeleteRoomAsync(roomId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Deletes a room by id.
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="cancellationToken"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="roomId"/> is null. </exception>
        public virtual Response DeleteRoom(string roomId, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(RoomsClient)}.{nameof(DeleteRoom)}");
            scope.Start();
            try
            {
                return RoomsServiceClient.DeleteRoom(roomId, cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        #region Participants Operations

        /// <summary>
        /// Gets room participants asynchronously.
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        public virtual async Task<Response<ParticipantsCollection>> GetParticipantsAsync(string roomId, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(RoomsClient)}.{nameof(GetParticipants)}");
            scope.Start();
            try
            {
                Response<ParticipantsCollectionInternal> getParticipantsResponseInternal =
                    await RoomsServiceClient.GetParticipantsAsync(roomId, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ParticipantsCollection(getParticipantsResponseInternal.Value.Participants), getParticipantsResponseInternal.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Gets a room participants.
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="cancellationToken"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="roomId"/> is null. </exception>
        public virtual Response<ParticipantsCollection> GetParticipants(string roomId, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(RoomsClient)}.{nameof(GetParticipants)}");
            scope.Start();
            try
            {
                Response<ParticipantsCollectionInternal> getParticipantsResponseInternal =
                    RoomsServiceClient.GetParticipants(roomId, cancellationToken);
                return Response.FromValue(new ParticipantsCollection(getParticipantsResponseInternal.Value.Participants), getParticipantsResponseInternal.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Add Participants to a Room asynchronously
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="participants"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        public virtual async Task<Response<RoomModel>> AddParticipantsAsync(string roomId, IEnumerable<RoomParticipant> participants = default, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(RoomsClient)}.{nameof(AddParticipants)}");
            scope.Start();
            try
            {
                Response<RoomModelInternal> addParticipantsResponseInternal =
                    await RoomsServiceClient.AddParticipantsAsync(roomId, participants.Select(x => x.ToRoomParticipantInternal()), cancellationToken).ConfigureAwait(false);

                return Response.FromValue(new RoomModel(addParticipantsResponseInternal.Value), addParticipantsResponseInternal.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Add Participants to a Room
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="participants"></param>
        /// <param name="cancellationToken"></param>
        public virtual Response<RoomModel> AddParticipants(string roomId, IEnumerable<RoomParticipant> participants = default, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(RoomsClient)}.{nameof(AddParticipants)}");
            scope.Start();
            try
            {
                Response<RoomModelInternal> addParticipantsResponseInternal =
                    RoomsServiceClient.AddParticipants(roomId, participants.Select(x => x.ToRoomParticipantInternal()), cancellationToken);

                return Response.FromValue(new RoomModel(addParticipantsResponseInternal.Value), addParticipantsResponseInternal.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Update Participants in a Room asynchronously
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="participants"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        public virtual async Task<Response<RoomModel>> UpdateParticipantsAsync(string roomId, IEnumerable<RoomParticipant> participants = default, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(RoomsClient)}.{nameof(UpdateParticipants)}");
            scope.Start();
            try
            {
                Response<RoomModelInternal> updateParticipantsResponseInternal =
                    await RoomsServiceClient.UpdateParticipantsAsync(roomId, participants.Select(x => x.ToRoomParticipantInternal()), cancellationToken).ConfigureAwait(false);

                return Response.FromValue(new RoomModel(updateParticipantsResponseInternal.Value), updateParticipantsResponseInternal.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Update Participants in a Room
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="participants"></param>
        /// <param name="cancellationToken"></param>
        public virtual Response<RoomModel> UpdateParticipants(string roomId, IEnumerable<RoomParticipant> participants = default, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(RoomsClient)}.{nameof(UpdateParticipants)}");
            scope.Start();
            try
            {
                Response<RoomModelInternal> updateParticipantsResponseInternal =
                     RoomsServiceClient.UpdateParticipants(roomId, participants.Select(x => x.ToRoomParticipantInternal()), cancellationToken);
                return Response.FromValue(new RoomModel(updateParticipantsResponseInternal.Value), updateParticipantsResponseInternal.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Remove Participants from a Room asynchronously
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="participants"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        public virtual async Task<Response<RoomModel>> RemoveParticipantsAsync(string roomId, IEnumerable<RoomParticipant> participants = default, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(RoomsClient)}.{nameof(RemoveParticipants)}");
            scope.Start();
            try
            {
                Response<RoomModelInternal> removeParticipantsResponseInternal =
                    await RoomsServiceClient.RemoveParticipantsAsync(roomId, participants.Select(x => x.ToRoomParticipantInternal()), cancellationToken).ConfigureAwait(false);

                return Response.FromValue(new RoomModel(removeParticipantsResponseInternal.Value), removeParticipantsResponseInternal.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Remove Participants from a Room
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="participants"></param>
        /// <param name="cancellationToken"></param>
        public virtual Response<RoomModel> RemoveParticipants(string roomId, IEnumerable<RoomParticipant> participants = default, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(RoomsClient)}.{nameof(RemoveParticipants)}");
            scope.Start();
            try
            {
                Response<RoomModelInternal> removeParticipantsResponseInternal =
                     RoomsServiceClient.RemoveParticipants(roomId, participants.Select(x => x.ToRoomParticipantInternal()), cancellationToken);
                return Response.FromValue(new RoomModel(removeParticipantsResponseInternal.Value), removeParticipantsResponseInternal.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Remove room participants.
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="communicationIdentifiers"></param>
        /// <param name="cancellationToken"></param>
        public virtual Response<RoomModel> RemoveParticipants(string roomId, IEnumerable<CommunicationIdentifier> communicationIdentifiers, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(RoomsClient)}.{nameof(RemoveParticipants)}");
            scope.Start();
            try
            {
                List<RoomParticipantInternal> participants = new List<RoomParticipantInternal>();
                foreach (var communicationIdentifier in communicationIdentifiers)
                {
                    var participant = new RoomParticipant(communicationIdentifier);
                    participants.Add(participant.ToRoomParticipantInternal());
                }

                Response<RoomModelInternal> removeParticipantsResponse =
                RoomsServiceClient.RemoveParticipants(roomId, participants, cancellationToken);
                return Response.FromValue(new RoomModel(removeParticipantsResponse.Value), removeParticipantsResponse.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Delete room participants async.
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="communicationIdentifiers"></param>
        /// <param name="cancellationToken"></param>
        public virtual async Task<Response<RoomModel>> RemoveParticipantsAsync(string roomId, IEnumerable<CommunicationIdentifier> communicationIdentifiers, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(RoomsClient)}.{nameof(RemoveParticipants)}");
            scope.Start();
            try
            {
                List<RoomParticipantInternal> participants = new List<RoomParticipantInternal>();
                foreach (var communicationIdentifier in communicationIdentifiers)
                {
                    var participant = new RoomParticipant(communicationIdentifier);
                    participants.Add(participant.ToRoomParticipantInternal());
                }

                Response<RoomModelInternal> removeParticipantsResponse =
                await RoomsServiceClient.RemoveParticipantsAsync(roomId, participants, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new RoomModel(removeParticipantsResponse.Value), removeParticipantsResponse.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }
        #endregion
    }
}
