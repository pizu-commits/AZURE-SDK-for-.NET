// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> API OAuth2 Authentication settings details. </summary>
    public partial class OpenIdAuthenticationSettingsContract
    {
        /// <summary> Initializes a new instance of OpenIdAuthenticationSettingsContract. </summary>
        public OpenIdAuthenticationSettingsContract()
        {
            BearerTokenSendingMethods = new Core.ChangeTrackingList<BearerTokenSendingMethod>();
        }

        /// <summary> Initializes a new instance of OpenIdAuthenticationSettingsContract. </summary>
        /// <param name="openIdProviderId"> OAuth authorization server identifier. </param>
        /// <param name="bearerTokenSendingMethods"> How to send token to the server. </param>
        internal OpenIdAuthenticationSettingsContract(string openIdProviderId, IList<BearerTokenSendingMethod> bearerTokenSendingMethods)
        {
            OpenIdProviderId = openIdProviderId;
            BearerTokenSendingMethods = bearerTokenSendingMethods;
        }

        /// <summary> OAuth authorization server identifier. </summary>
        public string OpenIdProviderId { get; set; }
        /// <summary> How to send token to the server. </summary>
        public IList<BearerTokenSendingMethod> BearerTokenSendingMethods { get; }
    }
}
