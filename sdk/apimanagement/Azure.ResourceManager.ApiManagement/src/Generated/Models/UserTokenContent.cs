// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Get User Token parameters. </summary>
    public partial class UserTokenContent
    {
        /// <summary> Initializes a new instance of UserTokenContent. </summary>
        public UserTokenContent()
        {
        }

        /// <summary> The Key to be used to generate token for user. </summary>
        public TokenGenerationUsedKeyType? KeyType { get; set; }
        /// <summary>
        /// The Expiry time of the Token. Maximum token expiry time is set to 30 days. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        /// 
        /// </summary>
        public DateTimeOffset? ExpireOn { get; set; }
    }
}
