// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Akamai access control. </summary>
    internal partial class AkamaiAccessControl
    {
        /// <summary> Initializes a new instance of AkamaiAccessControl. </summary>
        public AkamaiAccessControl()
        {
            AkamaiSignatureHeaderAuthenticationKeyList = new ChangeTrackingList<AkamaiSignatureHeaderAuthenticationKey>();
        }

        /// <summary> Initializes a new instance of AkamaiAccessControl. </summary>
        /// <param name="akamaiSignatureHeaderAuthenticationKeyList"> authentication key list. </param>
        internal AkamaiAccessControl(IList<AkamaiSignatureHeaderAuthenticationKey> akamaiSignatureHeaderAuthenticationKeyList)
        {
            AkamaiSignatureHeaderAuthenticationKeyList = akamaiSignatureHeaderAuthenticationKeyList;
        }

        /// <summary> authentication key list. </summary>
        public IList<AkamaiSignatureHeaderAuthenticationKey> AkamaiSignatureHeaderAuthenticationKeyList { get; }
    }
}
