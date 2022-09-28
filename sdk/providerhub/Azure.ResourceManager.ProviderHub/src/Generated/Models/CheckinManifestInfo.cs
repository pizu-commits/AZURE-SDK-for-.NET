// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The CheckinManifestInfo. </summary>
    public partial class CheckinManifestInfo
    {
        /// <summary> Initializes a new instance of CheckinManifestInfo. </summary>
        /// <param name="isCheckedIn"></param>
        /// <param name="statusMessage"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="statusMessage"/> is null. </exception>
        internal CheckinManifestInfo(bool isCheckedIn, string statusMessage)
        {
            if (statusMessage == null)
            {
                throw new ArgumentNullException(nameof(statusMessage));
            }

            IsCheckedIn = isCheckedIn;
            StatusMessage = statusMessage;
        }

        /// <summary> Initializes a new instance of CheckinManifestInfo. </summary>
        /// <param name="isCheckedIn"></param>
        /// <param name="statusMessage"></param>
        /// <param name="pullRequest"></param>
        /// <param name="commitId"></param>
        internal CheckinManifestInfo(bool isCheckedIn, string statusMessage, string pullRequest, string commitId)
        {
            IsCheckedIn = isCheckedIn;
            StatusMessage = statusMessage;
            PullRequest = pullRequest;
            CommitId = commitId;
        }

        /// <summary> Gets the is checked in. </summary>
        public bool IsCheckedIn { get; }
        /// <summary> Gets the status message. </summary>
        public string StatusMessage { get; }
        /// <summary> Gets the pull request. </summary>
        public string PullRequest { get; }
        /// <summary> Gets the commit id. </summary>
        public string CommitId { get; }
    }
}
