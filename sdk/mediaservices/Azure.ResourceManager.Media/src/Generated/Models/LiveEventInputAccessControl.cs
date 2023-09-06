// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The IP access control for live event input. </summary>
    internal partial class LiveEventInputAccessControl
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LiveEventInputAccessControl"/>. </summary>
        public LiveEventInputAccessControl()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LiveEventInputAccessControl"/>. </summary>
        /// <param name="ip"> The IP access control properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LiveEventInputAccessControl(IPAccessControl ip, Dictionary<string, BinaryData> rawData)
        {
            IP = ip;
            _rawData = rawData;
        }

        /// <summary> The IP access control properties. </summary>
        internal IPAccessControl IP { get; set; }
        /// <summary> The IP allow list. </summary>
        public IList<IPRange> IPAllowedIPs
        {
            get
            {
                if (IP is null)
                    IP = new IPAccessControl();
                return IP.AllowedIPs;
            }
        }
    }
}
