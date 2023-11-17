// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.OpenAI
{
    /// <summary> The authentication option using system-assigned managed identity. </summary>
    public partial class OnYourDataSystemAssignedManagedIdentityAuthenticationOptions : OnYourDataAuthenticationOptions
    {
        /// <summary> Initializes a new instance of OnYourDataSystemAssignedManagedIdentityAuthenticationOptions. </summary>
        public OnYourDataSystemAssignedManagedIdentityAuthenticationOptions()
        {
            Type = OnYourDataAuthenticationType.SystemAssignedManagedIdentity;
        }

        /// <summary> Initializes a new instance of OnYourDataSystemAssignedManagedIdentityAuthenticationOptions. </summary>
        /// <param name="type"> The Authentication type. </param>
        internal OnYourDataSystemAssignedManagedIdentityAuthenticationOptions(OnYourDataAuthenticationType type) : base(type)
        {
        }
    }
}
