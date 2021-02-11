// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.PhoneNumbers.Models
{
    /// <summary> Represents a release. </summary>
    public partial class PhoneNumberRelease
    {
        /// <summary> Initializes a new instance of PhoneNumberRelease. </summary>
        internal PhoneNumberRelease()
        {
            PhoneNumberReleaseStatusDetails = new ChangeTrackingDictionary<string, PhoneNumberReleaseDetails>();
        }

        /// <summary> Initializes a new instance of PhoneNumberRelease. </summary>
        /// <param name="releaseId"> The id of the release. </param>
        /// <param name="createdAt"> The creation time of the release. </param>
        /// <param name="status"> The release status. </param>
        /// <param name="errorMessage"> The underlying error message of a release. </param>
        /// <param name="phoneNumberReleaseStatusDetails"> The list of phone numbers in the release, mapped to its individual statuses. </param>
        internal PhoneNumberRelease(string releaseId, DateTimeOffset? createdAt, ReleaseStatus? status, string errorMessage, IReadOnlyDictionary<string, PhoneNumberReleaseDetails> phoneNumberReleaseStatusDetails)
        {
            ReleaseId = releaseId;
            CreatedAt = createdAt;
            Status = status;
            ErrorMessage = errorMessage;
            PhoneNumberReleaseStatusDetails = phoneNumberReleaseStatusDetails;
        }

        /// <summary> The id of the release. </summary>
        public string ReleaseId { get; }
        /// <summary> The creation time of the release. </summary>
        public DateTimeOffset? CreatedAt { get; }
        /// <summary> The release status. </summary>
        public ReleaseStatus? Status { get; }
        /// <summary> The underlying error message of a release. </summary>
        public string ErrorMessage { get; }
        /// <summary> The list of phone numbers in the release, mapped to its individual statuses. </summary>
        public IReadOnlyDictionary<string, PhoneNumberReleaseDetails> PhoneNumberReleaseStatusDetails { get; }
    }
}
