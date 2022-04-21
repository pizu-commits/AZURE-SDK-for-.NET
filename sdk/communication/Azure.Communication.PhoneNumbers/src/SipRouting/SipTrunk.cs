﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;

namespace Azure.Communication.PhoneNumbers.SipRouting
{
    /// <summary> Gets or sets SIP signaling port of the trunk. </summary>
    [CodeGenClient("Trunk")]
    public partial class SipTrunk
    {
        /// <summary> Initializes a new instance of SipTrunk. </summary>
        /// <param name="fqdn">Name of the trunk</param>
        /// <param name="sipSignalingPort"> Gets or sets SIP signaling port for the gateway. </param>
        public SipTrunk(string fqdn, int sipSignalingPort)
        {
            Fqdn = fqdn;
            SipSignalingPort = sipSignalingPort;
        }

        private SipTrunk(int sipSignalingPort)
        {
            SipSignalingPort = sipSignalingPort;
        }

        /// <summary> Name of the trunk. </summary>
        public string Fqdn { get; internal set; }
    }
}
