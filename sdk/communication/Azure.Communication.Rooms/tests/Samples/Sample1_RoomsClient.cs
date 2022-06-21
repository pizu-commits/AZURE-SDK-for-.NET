// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Communication.Identity;
using Azure.Communication;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.Communication.Rooms.Tests.samples
{
    /// <summary>
    /// Samples that are used in the README.md file.
    /// </summary>
    ///
    public partial class Sample1_RoomsClient : RoomsClientLiveTestBase
    {
        public Sample1_RoomsClient(bool isAsync) : base(isAsync)
        {
        }

        [Test]
        public async Task AcsRoomRequestSample()
        {
            RoomsClient roomsClient = CreateInstrumentedRoomsClient(RoomsClientOptions.ServiceVersion.V2022_02_01_Preview);
            CommunicationIdentityClient communicationIdentityClient = CreateInstrumentedCommunicationIdentityClient();
            var communicationUser1 = communicationIdentityClient.CreateUserAsync().Result.Value.Id;
            var communicationUser2 = communicationIdentityClient.CreateUserAsync().Result.Value.Id;

            #region Snippet:Azure_Communication_Rooms_Tests_Samples_CreateRoomAsync
            var validFrom = DateTime.Now;
            var validUntil = validFrom.AddDays(1);
            var openRoom = false;
            List<RoomParticipant> createRoomParticipants = new List<RoomParticipant>();
            RoomParticipant participant1 = new RoomParticipant(new CommunicationUserIdentifier(communicationUser1), "Presenter");
            RoomParticipant participant2 = new RoomParticipant(new CommunicationUserIdentifier(communicationUser2), "Attendee");
            createRoomParticipants.Add(participant1);
            createRoomParticipants.Add(participant2);
            Response<RoomModel> createRoomResponse = await roomsClient.CreateRoomAsync(validFrom, validUntil, openRoom, createRoomParticipants);
            RoomModel createCommunicationRoom = createRoomResponse.Value;
            #endregion Snippet:Azure_Communication_Rooms_Tests_Samples_CreateRoomAsync

            Assert.IsFalse(string.IsNullOrWhiteSpace(createCommunicationRoom.Id));

            var createdRoomId = createCommunicationRoom.Id;

            #region Snippet:Azure_Communication_Rooms_Tests_Samples_UpdateRoomAsync
            Response<RoomModel> updateRoomResponse = await roomsClient.UpdateRoomAsync(createdRoomId, validFrom, validUntil);
            RoomModel updateCommunicationRoom = updateRoomResponse.Value;
            #endregion Snippet:Azure_Communication_Rooms_Tests_Samples_UpdateRoomAsync

            Assert.IsFalse(string.IsNullOrWhiteSpace(updateCommunicationRoom.Id));

            #region Snippet:Azure_Communication_Rooms_Tests_Samples_GetRoomAsync
            Response<RoomModel> getRoomResponse = await roomsClient.GetRoomAsync(
                //@@ createdRoomId: "existing room Id which is created already
                createdRoomId);
            RoomModel getCommunicationRoom = getRoomResponse.Value;
            #endregion Snippet:Azure_Communication_Rooms_Tests_Samples_GetRoomAsync

            Assert.IsFalse(string.IsNullOrWhiteSpace(getCommunicationRoom.Id));

            #region Snippet:Azure_Communication_Rooms_Tests_Samples_DeleteRoomAsync
            Response deleteRoomResponse = await roomsClient.DeleteRoomAsync(
                //@@ createdRoomId: "existing room Id which is created already
                 createdRoomId);
            #endregion Snippet:Azure_Communication_Rooms_Tests_Samples_DeleteRoomAsync

            Assert.AreEqual(204, deleteRoomResponse.Status);
        }

        [Test]
        public async Task AddParticipantsExample()
        {
            RoomsClient roomsClient = CreateInstrumentedRoomsClient(RoomsClientOptions.ServiceVersion.V2022_02_01_Preview);
            CommunicationIdentityClient communicationIdentityClient = CreateInstrumentedCommunicationIdentityClient();
            var communicationUser1 = communicationIdentityClient.CreateUserAsync().Result.Value.Id;
            var communicationUser2 = communicationIdentityClient.CreateUserAsync().Result.Value.Id;
            var communicationUser3 = communicationIdentityClient.CreateUserAsync().Result.Value.Id;

            var validFrom = DateTime.Now;
            var validUntil = validFrom.AddDays(1);
            var openRoom = false;
            List<RoomParticipant> createRoomParticipants = new List<RoomParticipant>();
            RoomParticipant participant1 = new RoomParticipant(new CommunicationUserIdentifier(communicationUser1), "Presenter");
            RoomParticipant participant2 = new RoomParticipant(new CommunicationUserIdentifier(communicationUser2), "Attendee");
            RoomParticipant participant3 = new RoomParticipant(new CommunicationUserIdentifier(communicationUser3), "Consumer");
            createRoomParticipants.Add(participant1);
            createRoomParticipants.Add(participant2);

            Response<RoomModel> createRoomResponse = await roomsClient.CreateRoomAsync(validFrom, validUntil, openRoom, createRoomParticipants);
            RoomModel createCommunicationRoom = createRoomResponse.Value;

            Assert.IsFalse(string.IsNullOrWhiteSpace(createCommunicationRoom.Id));

            var createdRoomId = createCommunicationRoom.Id;

            #region Snippet:Azure_Communication_Rooms_Tests_Samples_AddParticipants
            List<RoomParticipant> toAddCommunicationUsers = new List<RoomParticipant>();
            toAddCommunicationUsers.Add(participant3);

            Response<RoomModel> addParticipantResponse = await roomsClient.AddParticipantsAsync(createdRoomId, toAddCommunicationUsers);
            RoomModel addedParticipantsRoom = addParticipantResponse.Value;
            #endregion Snippet:Azure_Communication_Rooms_Tests_Samples_AddParticipants

            Assert.IsFalse(string.IsNullOrWhiteSpace(addedParticipantsRoom.Id));
        }

        [Test]
        public async Task RemoveParticipantsExample()
        {
            RoomsClient roomsClient = CreateInstrumentedRoomsClient(RoomsClientOptions.ServiceVersion.V2022_02_01_Preview);
            CommunicationIdentityClient communicationIdentityClient = CreateInstrumentedCommunicationIdentityClient();
            var communicationUser1 = communicationIdentityClient.CreateUserAsync().Result.Value.Id;
            var communicationUser2 = communicationIdentityClient.CreateUserAsync().Result.Value.Id;

            var validFrom = DateTime.Now;
            var validUntil = validFrom.AddDays(1);
            var openRoom = false;

            List<RoomParticipant> createRoomParticipants = new List<RoomParticipant>();
            RoomParticipant participant1 = new RoomParticipant(new CommunicationUserIdentifier(communicationUser1), "Presenter");
            RoomParticipant participant2 = new RoomParticipant(new CommunicationUserIdentifier(communicationUser2), "Attendee");
            createRoomParticipants.Add(participant1);
            createRoomParticipants.Add(participant2);

            Response<RoomModel> createRoomResponse = await roomsClient.CreateRoomAsync(validFrom, validUntil, openRoom, createRoomParticipants);
            RoomModel createCommunicationRoom = createRoomResponse.Value;

            Assert.IsFalse(string.IsNullOrWhiteSpace(createCommunicationRoom.Id));

            var createdRoomId = createCommunicationRoom.Id;

            #region Snippet:Azure_Communication_Rooms_Tests_Samples_RemoveParticipants
            List<RoomParticipant> toRemoveCommunicationUsers = new List<RoomParticipant>();
            toRemoveCommunicationUsers.Add(participant2);

            Response<RoomModel> removeParticipantResponse = await roomsClient.RemoveParticipantsAsync(createdRoomId, toRemoveCommunicationUsers);
            RoomModel removeParticipantsRoom = removeParticipantResponse.Value;
            #endregion Snippet:Azure_Communication_Rooms_Tests_Samples_RemoveParticipants

            Assert.IsFalse(string.IsNullOrWhiteSpace(removeParticipantsRoom.Id));
        }

        [Test]
        public async Task UpdateParticipantsExample()
        {
            RoomsClient roomsClient = CreateInstrumentedRoomsClient(RoomsClientOptions.ServiceVersion.V2022_02_01_Preview);
            CommunicationIdentityClient communicationIdentityClient = CreateInstrumentedCommunicationIdentityClient();
            var communicationUser1 = communicationIdentityClient.CreateUserAsync().Result.Value.Id;
            var communicationUser2 = communicationIdentityClient.CreateUserAsync().Result.Value.Id;
            var communicationUser3 = communicationIdentityClient.CreateUserAsync().Result.Value.Id;
            var communicationUser4 = communicationIdentityClient.CreateUserAsync().Result.Value.Id;

            var validFrom = DateTime.Now;
            var validUntil = validFrom.AddDays(1);
            var openRoom = false;
            List<RoomParticipant> createRoomParticipants = new List<RoomParticipant>();
            RoomParticipant participant1 = new RoomParticipant(new CommunicationUserIdentifier(communicationUser1), "Presenter");
            RoomParticipant participant2 = new RoomParticipant(new CommunicationUserIdentifier(communicationUser2), "Attendee");
            RoomParticipant participant3 = new RoomParticipant(new CommunicationUserIdentifier(communicationUser3), "Attendee");
            RoomParticipant participant4 = new RoomParticipant(new CommunicationUserIdentifier(communicationUser4), "Attendee");
            createRoomParticipants.Add(participant1);
            createRoomParticipants.Add(participant2);
            createRoomParticipants.Add(participant3);
            createRoomParticipants.Add(participant4);

            Response<RoomModel> createRoomResponse = await roomsClient.CreateRoomAsync(validFrom, validUntil, openRoom, createRoomParticipants);
            RoomModel createCommunicationRoom = createRoomResponse.Value;

            Assert.IsFalse(string.IsNullOrWhiteSpace(createCommunicationRoom.Id));

            var createdRoomId = createCommunicationRoom.Id;

            #region Snippet:Azure_Communication_Rooms_Tests_Samples_UpdateParticipants
            List<RoomParticipant> toUpdateCommunicationUsers = new List<RoomParticipant>();
            participant3 = new RoomParticipant(new CommunicationUserIdentifier(communicationUser3), "Presenter");
            participant4 = new RoomParticipant(new CommunicationUserIdentifier(communicationUser4), "Presenter");
            toUpdateCommunicationUsers.Add(participant3);
            toUpdateCommunicationUsers.Add(participant4);

            Response<RoomModel> updateParticipantResponse = await roomsClient.UpdateParticipantsAsync(createdRoomId, toUpdateCommunicationUsers);
            RoomModel updateParticipantsRoom = updateParticipantResponse.Value;
            #endregion Snippet:Azure_Communication_Rooms_Tests_Samples_UpdateParticipants

            Assert.IsFalse(string.IsNullOrWhiteSpace(updateParticipantsRoom.Id));
        }

        [Test]
        public async Task RoomRequestsTroubleShooting()
        {
            RoomsClient roomsClient = CreateInstrumentedRoomsClient(RoomsClientOptions.ServiceVersion.V2022_02_01_Preview);
            #region Snippet:Azure_Communication_RoomsClient_Tests_Troubleshooting
            try
            {
                CommunicationIdentityClient communicationIdentityClient = CreateInstrumentedCommunicationIdentityClient();
                var communicationUser1 = communicationIdentityClient.CreateUserAsync().Result.Value.Id;
                var communicationUser2 = communicationIdentityClient.CreateUserAsync().Result.Value.Id;
                var validFrom = DateTime.Now;
                var validUntil = validFrom.AddDays(1);
                var openRoom = false;
                List<RoomParticipant> createRoomParticipants = new List<RoomParticipant>();
                RoomParticipant participant1 = new RoomParticipant(new CommunicationUserIdentifier(communicationUser1), "Presenter");
                RoomParticipant participant2 = new RoomParticipant(new CommunicationUserIdentifier(communicationUser2), "Attendee");
                Response<RoomModel> createRoomResponse = await roomsClient.CreateRoomAsync(validFrom, validUntil, openRoom, createRoomParticipants);
                RoomModel createRoomResult = createRoomResponse.Value;
            }
            catch (RequestFailedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion Snippet:Azure_Communication_RoomsClient_Tests_Troubleshooting
        }
    }
}
