// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Streaming endpoint access control definition. </summary>
    public partial class StreamingEndpointAccessControl
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StreamingEndpointAccessControl"/>. </summary>
        public StreamingEndpointAccessControl()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StreamingEndpointAccessControl"/>. </summary>
        /// <param name="akamai"> The access control of Akamai. </param>
        /// <param name="iPs"> The IP access control of the streaming endpoint. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamingEndpointAccessControl(AkamaiAccessControl akamai, IPAccessControl iPs, Dictionary<string, BinaryData> rawData)
        {
            Akamai = akamai;
            IPs = iPs;
            _rawData = rawData;
        }

        /// <summary> The access control of Akamai. </summary>
        internal AkamaiAccessControl Akamai { get; set; }
        /// <summary> authentication key list. </summary>
        public IList<AkamaiSignatureHeaderAuthenticationKey> AkamaiSignatureHeaderAuthenticationKeyList
        {
            get
            {
                if (Akamai is null)
                    Akamai = new AkamaiAccessControl();
                return Akamai.AkamaiSignatureHeaderAuthenticationKeyList;
            }
        }

        /// <summary> The IP access control of the streaming endpoint. </summary>
        internal IPAccessControl IPs { get; set; }
        /// <summary> The IP allow list. </summary>
        public IList<IPRange> AllowedIPs
        {
            get
            {
                if (IPs is null)
                    IPs = new IPAccessControl();
                return IPs.AllowedIPs;
            }
        }
    }
}
