// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication
{
    /// <summary> A Microsoft Teams user. </summary>
    internal partial class MicrosoftTeamsUserIdentifierModel
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MicrosoftTeamsUserIdentifierModel"/>. </summary>
        /// <param name="userId"> The Id of the Microsoft Teams user. If not anonymous, this is the AAD object Id of the user. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userId"/> is null. </exception>
        public MicrosoftTeamsUserIdentifierModel(string userId)
        {
            Argument.AssertNotNull(userId, nameof(userId));

            UserId = userId;
        }

        /// <summary> Initializes a new instance of <see cref="MicrosoftTeamsUserIdentifierModel"/>. </summary>
        /// <param name="userId"> The Id of the Microsoft Teams user. If not anonymous, this is the AAD object Id of the user. </param>
        /// <param name="isAnonymous"> True if the Microsoft Teams user is anonymous. By default false if missing. </param>
        /// <param name="cloud"> The cloud that the Microsoft Teams user belongs to. By default 'public' if missing. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MicrosoftTeamsUserIdentifierModel(string userId, bool? isAnonymous, CommunicationCloudEnvironmentModel? cloud, Dictionary<string, BinaryData> rawData)
        {
            UserId = userId;
            IsAnonymous = isAnonymous;
            Cloud = cloud;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="MicrosoftTeamsUserIdentifierModel"/> for deserialization. </summary>
        internal MicrosoftTeamsUserIdentifierModel()
        {
        }

        /// <summary> The Id of the Microsoft Teams user. If not anonymous, this is the AAD object Id of the user. </summary>
        public string UserId { get; set; }
        /// <summary> True if the Microsoft Teams user is anonymous. By default false if missing. </summary>
        public bool? IsAnonymous { get; set; }
        /// <summary> The cloud that the Microsoft Teams user belongs to. By default 'public' if missing. </summary>
        public CommunicationCloudEnvironmentModel? Cloud { get; set; }
    }
}
