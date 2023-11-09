// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> Cluster Identity details. </summary>
    public partial class HciClusterIdentityResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="HciClusterIdentityResult"/>. </summary>
        internal HciClusterIdentityResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HciClusterIdentityResult"/>. </summary>
        /// <param name="aadClientId"></param>
        /// <param name="aadTenantId"></param>
        /// <param name="aadServicePrincipalObjectId"></param>
        /// <param name="aadApplicationObjectId"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HciClusterIdentityResult(Guid? aadClientId, Guid? aadTenantId, Guid? aadServicePrincipalObjectId, Guid? aadApplicationObjectId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AadClientId = aadClientId;
            AadTenantId = aadTenantId;
            AadServicePrincipalObjectId = aadServicePrincipalObjectId;
            AadApplicationObjectId = aadApplicationObjectId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the aad client id. </summary>
        public Guid? AadClientId { get; }
        /// <summary> Gets the aad tenant id. </summary>
        public Guid? AadTenantId { get; }
        /// <summary> Gets the aad service principal object id. </summary>
        public Guid? AadServicePrincipalObjectId { get; }
        /// <summary> Gets the aad application object id. </summary>
        public Guid? AadApplicationObjectId { get; }
    }
}
