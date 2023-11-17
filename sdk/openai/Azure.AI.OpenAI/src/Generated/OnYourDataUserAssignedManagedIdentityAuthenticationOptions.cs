// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    /// <summary> The authentication option using user-assigned managed identity. </summary>
    public partial class OnYourDataUserAssignedManagedIdentityAuthenticationOptions : OnYourDataAuthenticationOptions
    {
        /// <summary> Initializes a new instance of OnYourDataUserAssignedManagedIdentityAuthenticationOptions. </summary>
        /// <param name="managedIdentityResourceId"> The resource ID of the user-assigned managed identity to use for authentication. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managedIdentityResourceId"/> is null. </exception>
        public OnYourDataUserAssignedManagedIdentityAuthenticationOptions(string managedIdentityResourceId)
        {
            Argument.AssertNotNull(managedIdentityResourceId, nameof(managedIdentityResourceId));

            Type = OnYourDataAuthenticationType.UserAssignedManagedIdentity;
            ManagedIdentityResourceId = managedIdentityResourceId;
        }

        /// <summary> Initializes a new instance of OnYourDataUserAssignedManagedIdentityAuthenticationOptions. </summary>
        /// <param name="type"> The Authentication type. </param>
        /// <param name="managedIdentityResourceId"> The resource ID of the user-assigned managed identity to use for authentication. </param>
        internal OnYourDataUserAssignedManagedIdentityAuthenticationOptions(OnYourDataAuthenticationType type, string managedIdentityResourceId) : base(type)
        {
            ManagedIdentityResourceId = managedIdentityResourceId;
        }

        /// <summary> The resource ID of the user-assigned managed identity to use for authentication. </summary>
        public string ManagedIdentityResourceId { get; }
    }
}
