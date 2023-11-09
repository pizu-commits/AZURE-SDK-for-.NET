// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Tenant access information contract of the API Management service. </summary>
    public partial class TenantAccessInfoSecretsDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TenantAccessInfoSecretsDetails"/>. </summary>
        internal TenantAccessInfoSecretsDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TenantAccessInfoSecretsDetails"/>. </summary>
        /// <param name="accessInfoType"> Access Information type ('access' or 'gitAccess'). </param>
        /// <param name="principalId"> Principal (User) Identifier. </param>
        /// <param name="primaryKey"> Primary access key. This property will not be filled on 'GET' operations! Use '/listSecrets' POST request to get the value. </param>
        /// <param name="secondaryKey"> Secondary access key. This property will not be filled on 'GET' operations! Use '/listSecrets' POST request to get the value. </param>
        /// <param name="isDirectAccessEnabled"> Determines whether direct access is enabled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TenantAccessInfoSecretsDetails(string accessInfoType, string principalId, string primaryKey, string secondaryKey, bool? isDirectAccessEnabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AccessInfoType = accessInfoType;
            PrincipalId = principalId;
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            IsDirectAccessEnabled = isDirectAccessEnabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Access Information type ('access' or 'gitAccess'). </summary>
        public string AccessInfoType { get; }
        /// <summary> Principal (User) Identifier. </summary>
        public string PrincipalId { get; }
        /// <summary> Primary access key. This property will not be filled on 'GET' operations! Use '/listSecrets' POST request to get the value. </summary>
        public string PrimaryKey { get; }
        /// <summary> Secondary access key. This property will not be filled on 'GET' operations! Use '/listSecrets' POST request to get the value. </summary>
        public string SecondaryKey { get; }
        /// <summary> Determines whether direct access is enabled. </summary>
        public bool? IsDirectAccessEnabled { get; }
    }
}
