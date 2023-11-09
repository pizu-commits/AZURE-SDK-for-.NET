// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> settings for security policy patterns to match. </summary>
    public partial class SecurityPolicyWebApplicationFirewallAssociation
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SecurityPolicyWebApplicationFirewallAssociation"/>. </summary>
        public SecurityPolicyWebApplicationFirewallAssociation()
        {
            Domains = new ChangeTrackingList<FrontDoorActivatedResourceInfo>();
            PatternsToMatch = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SecurityPolicyWebApplicationFirewallAssociation"/>. </summary>
        /// <param name="domains"> List of domains. </param>
        /// <param name="patternsToMatch"> List of paths. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityPolicyWebApplicationFirewallAssociation(IList<FrontDoorActivatedResourceInfo> domains, IList<string> patternsToMatch, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Domains = domains;
            PatternsToMatch = patternsToMatch;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of domains. </summary>
        public IList<FrontDoorActivatedResourceInfo> Domains { get; }
        /// <summary> List of paths. </summary>
        public IList<string> PatternsToMatch { get; }
    }
}
