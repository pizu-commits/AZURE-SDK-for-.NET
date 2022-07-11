// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> OAuth Server Secrets Contract. </summary>
    public partial class AuthorizationServerSecretsContract
    {
        /// <summary> Initializes a new instance of AuthorizationServerSecretsContract. </summary>
        internal AuthorizationServerSecretsContract()
        {
        }

        /// <summary> Initializes a new instance of AuthorizationServerSecretsContract. </summary>
        /// <param name="clientSecret"> oAuth Authorization Server Secrets. </param>
        /// <param name="resourceOwnerUsername"> Can be optionally specified when resource owner password grant type is supported by this authorization server. Default resource owner username. </param>
        /// <param name="resourceOwnerPassword"> Can be optionally specified when resource owner password grant type is supported by this authorization server. Default resource owner password. </param>
        internal AuthorizationServerSecretsContract(string clientSecret, string resourceOwnerUsername, string resourceOwnerPassword)
        {
            ClientSecret = clientSecret;
            ResourceOwnerUsername = resourceOwnerUsername;
            ResourceOwnerPassword = resourceOwnerPassword;
        }

        /// <summary> oAuth Authorization Server Secrets. </summary>
        public string ClientSecret { get; }
        /// <summary> Can be optionally specified when resource owner password grant type is supported by this authorization server. Default resource owner username. </summary>
        public string ResourceOwnerUsername { get; }
        /// <summary> Can be optionally specified when resource owner password grant type is supported by this authorization server. Default resource owner password. </summary>
        public string ResourceOwnerPassword { get; }
    }
}
