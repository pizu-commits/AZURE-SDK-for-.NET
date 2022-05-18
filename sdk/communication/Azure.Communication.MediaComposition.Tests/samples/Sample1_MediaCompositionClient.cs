﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Communication.MediaComposition.Models;

namespace Azure.Communication.MediaComposition.Tests.samples
{
    /// <summary>
    /// Basic Azure Communication.MediaComposition samples.
    /// </summary>
    public partial class Sample1_MediaCompositionClient
    {
        // TODO: Update the samples to tests when the E2E flow is working
        private const string mediaCompositionId = "2x2Grid";
        public async Task CreateMediaCompositionAsync()
        {
            var mediaCompositionClient = CreateMediaCompositionClient();

            var layout = new MediaCompositionLayout()
            {
                Resolution = new LayoutResolution()
                {
                    Width = 1920,
                    Height = 1080
                },
                Grid = new GridLayoutOptions(
                    rows: 2,
                    columns: 2,
                    new string[2, 2] { { "jill", "jack" }, { "jane", "jerry" }
                }),
            };

            var inputs = new Dictionary<string, MediaInput>()
            {
                {
                    "jill",
                    new MediaInput()
                    { Participant = new ParticipantInput()
                        { Id = new CommunicationIdentifierModel()
                            { MicrosoftTeamsUser = new MicrosoftTeamsUserIdentifierModel("f3ba9014-6dca-4456-8ec0-fa03cfa2b7b7") },
                            Call = "teamsMeeting",
                            PlaceholderImageUri = "https://imageendpoint"
                        }
                    }
                },
                {
                    "jack",
                    new MediaInput()
                    { Participant = new ParticipantInput()
                        { Id = new CommunicationIdentifierModel()
                            { MicrosoftTeamsUser = new MicrosoftTeamsUserIdentifierModel("f3ba9014-6dca-4456-8ec0-fa03cfa2b7b7") },
                            Call = "teamsMeeting",
                            PlaceholderImageUri = "https://imageendpoint"
                        }
                    }
                },
                {
                    "jane",
                    new MediaInput()
                    { Participant = new ParticipantInput()
                        { Id = new CommunicationIdentifierModel()
                            { MicrosoftTeamsUser = new MicrosoftTeamsUserIdentifierModel("f3ba9014-6dca-4456-8ec0-fa03cfa2b7b7") },
                            Call = "teamsMeeting",
                            PlaceholderImageUri = "https://imageendpoint"
                        }
                    }
                },
                {
                    "jerry",
                    new MediaInput()
                    { Participant = new ParticipantInput()
                        { Id = new CommunicationIdentifierModel()
                            { MicrosoftTeamsUser = new MicrosoftTeamsUserIdentifierModel("f3ba9014-6dca-4456-8ec0-fa03cfa2b7b7") },
                            Call = "teamsMeeting",
                            PlaceholderImageUri = "https://imageendpoint"
                        }
                    }
                },
                {
                    "teamsMeeting",
                    new MediaInput()
                    {
                        TeamsMeeting = new TeamsMeeting() { TeamsJoinUrl = "https://teamsJoinUrl" }
                    }
                }
            };

            var outputs = new Dictionary<string, MediaOutput>()
            {
                {
                    "acsGroupCall",
                    new MediaOutput()
                    {
                        GroupCall = new GroupCall() { Id = "d12d2277-ffec-4e22-9979-8c0d8c13d191"}
                    }
                }
            };
            await mediaCompositionClient.CreateAsync(mediaCompositionId, layout, inputs, outputs);
        }

        public async Task GetMediaCompositionAsync()
        {
            var mediaCompositionClient = CreateMediaCompositionClient();
            var gridMediaComposition = await mediaCompositionClient.GetAsync(mediaCompositionId);
        }

        public async Task UpdateLayoutMediaCompositionAsync()
        {
            var mediaCompositionClient = CreateMediaCompositionClient();
            var layout = new MediaCompositionLayout()
            {
                Resolution = new LayoutResolution()
                {
                    Width = 720,
                    Height = 480
                },
                Presenter = new PresenterLayoutOptions("jill", "jack")
                {
                    SupportPosition = SupportPosition.BottomRight,
                    SupportAspectRatio = 3/2
                }
            };
            await mediaCompositionClient.UpdateAsync(mediaCompositionId, layout);
        }

        public async Task StartMediaCompositionAsync()
        {
            var mediaCompositionClient = CreateMediaCompositionClient();
            var compositionSteamState = await mediaCompositionClient.StartAsync(mediaCompositionId);
        }

        public async Task StopMediaCompositionAsync()
        {
            var mediaCompositionClient = CreateMediaCompositionClient();
            var compositionSteamState = await mediaCompositionClient.StopAsync(mediaCompositionId);
        }

        public async Task DeleteMediaCompositionAsync()
        {
            var mediaCompositionClient = CreateMediaCompositionClient();
            await mediaCompositionClient.DeleteAsync(mediaCompositionId);
        }

        /// <summary>
        /// Creates a <see cref="MediaCompositionClient" /> with the connectionstring via environment
        /// variables and instruments it to make use of the Azure Core Test Framework functionalities.
        /// </summary>
        /// <returns>The instrumented <see cref="MediaCompositionClient" />.</returns>
        protected MediaCompositionClient CreateMediaCompositionClient()
            => new MediaCompositionClient(
                    "REPLACE_WITH_CONNECTION_STRING",
                    new MediaCompositionClientOptions(MediaCompositionClientOptions.ServiceVersion.V2022_06_26_Preview));
    }
}
