// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> ArcIdentity details. </summary>
    public partial class ArcIdentityResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ArcIdentityResult"/>. </summary>
        internal ArcIdentityResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ArcIdentityResult"/>. </summary>
        /// <param name="arcApplicationClientId"></param>
        /// <param name="arcApplicationTenantId"></param>
        /// <param name="arcServicePrincipalObjectId"></param>
        /// <param name="arcApplicationObjectId"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ArcIdentityResult(Guid? arcApplicationClientId, Guid? arcApplicationTenantId, Guid? arcServicePrincipalObjectId, Guid? arcApplicationObjectId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ArcApplicationClientId = arcApplicationClientId;
            ArcApplicationTenantId = arcApplicationTenantId;
            ArcServicePrincipalObjectId = arcServicePrincipalObjectId;
            ArcApplicationObjectId = arcApplicationObjectId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the arc application client id. </summary>
        public Guid? ArcApplicationClientId { get; }
        /// <summary> Gets the arc application tenant id. </summary>
        public Guid? ArcApplicationTenantId { get; }
        /// <summary> Gets the arc service principal object id. </summary>
        public Guid? ArcServicePrincipalObjectId { get; }
        /// <summary> Gets the arc application object id. </summary>
        public Guid? ArcApplicationObjectId { get; }
    }
}
