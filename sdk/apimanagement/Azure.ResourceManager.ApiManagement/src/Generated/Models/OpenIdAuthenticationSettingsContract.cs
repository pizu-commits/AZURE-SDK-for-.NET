// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> API OAuth2 Authentication settings details. </summary>
    public partial class OpenIdAuthenticationSettingsContract
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="OpenIdAuthenticationSettingsContract"/>. </summary>
        public OpenIdAuthenticationSettingsContract()
        {
            BearerTokenSendingMethods = new ChangeTrackingList<BearerTokenSendingMethod>();
        }

        /// <summary> Initializes a new instance of <see cref="OpenIdAuthenticationSettingsContract"/>. </summary>
        /// <param name="openIdProviderId"> OAuth authorization server identifier. </param>
        /// <param name="bearerTokenSendingMethods"> How to send token to the server. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OpenIdAuthenticationSettingsContract(string openIdProviderId, IList<BearerTokenSendingMethod> bearerTokenSendingMethods, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OpenIdProviderId = openIdProviderId;
            BearerTokenSendingMethods = bearerTokenSendingMethods;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> OAuth authorization server identifier. </summary>
        public string OpenIdProviderId { get; set; }
        /// <summary> How to send token to the server. </summary>
        public IList<BearerTokenSendingMethod> BearerTokenSendingMethods { get; }
    }
}
