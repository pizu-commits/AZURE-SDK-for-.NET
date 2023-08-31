// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> The lab user list management profile. </summary>
    public partial class LabRosterProfile
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LabRosterProfile"/>. </summary>
        public LabRosterProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LabRosterProfile"/>. </summary>
        /// <param name="activeDirectoryGroupId"> The AAD group ID which this lab roster is populated from. Having this set enables AAD sync mode. </param>
        /// <param name="ltiContextId"> The unique context identifier for the lab in the lms. </param>
        /// <param name="lmsInstance"> The base URI identifying the lms instance. </param>
        /// <param name="ltiClientId"> The unique id of the azure lab services tool in the lms. </param>
        /// <param name="ltiRosterEndpoint"> The uri of the names and roles service endpoint on the lms for the class attached to this lab. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LabRosterProfile(string activeDirectoryGroupId, string ltiContextId, Uri lmsInstance, string ltiClientId, Uri ltiRosterEndpoint, Dictionary<string, BinaryData> rawData)
        {
            ActiveDirectoryGroupId = activeDirectoryGroupId;
            LtiContextId = ltiContextId;
            LmsInstance = lmsInstance;
            LtiClientId = ltiClientId;
            LtiRosterEndpoint = ltiRosterEndpoint;
            _rawData = rawData;
        }

        /// <summary> The AAD group ID which this lab roster is populated from. Having this set enables AAD sync mode. </summary>
        public string ActiveDirectoryGroupId { get; set; }
        /// <summary> The unique context identifier for the lab in the lms. </summary>
        public string LtiContextId { get; set; }
        /// <summary> The base URI identifying the lms instance. </summary>
        public Uri LmsInstance { get; set; }
        /// <summary> The unique id of the azure lab services tool in the lms. </summary>
        public string LtiClientId { get; set; }
        /// <summary> The uri of the names and roles service endpoint on the lms for the class attached to this lab. </summary>
        public Uri LtiRosterEndpoint { get; set; }
    }
}
