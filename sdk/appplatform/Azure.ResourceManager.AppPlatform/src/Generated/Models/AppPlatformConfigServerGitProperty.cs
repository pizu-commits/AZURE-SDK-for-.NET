// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Property of git. </summary>
    public partial class AppPlatformConfigServerGitProperty
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppPlatformConfigServerGitProperty"/>. </summary>
        /// <param name="uri"> URI of the repository. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        public AppPlatformConfigServerGitProperty(Uri uri)
        {
            Argument.AssertNotNull(uri, nameof(uri));

            Repositories = new ChangeTrackingList<ConfigServerGitPatternRepository>();
            Uri = uri;
            SearchPaths = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformConfigServerGitProperty"/>. </summary>
        /// <param name="repositories"> Repositories of git. </param>
        /// <param name="uri"> URI of the repository. </param>
        /// <param name="label"> Label of the repository. </param>
        /// <param name="searchPaths"> Searching path of the repository. </param>
        /// <param name="username"> Username of git repository basic auth. </param>
        /// <param name="password"> Password of git repository basic auth. </param>
        /// <param name="hostKey"> Public sshKey of git repository. </param>
        /// <param name="hostKeyAlgorithm"> SshKey algorithm of git repository. </param>
        /// <param name="privateKey"> Private sshKey algorithm of git repository. </param>
        /// <param name="isHostKeyCheckingStrict"> Strict host key checking or not. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppPlatformConfigServerGitProperty(IList<ConfigServerGitPatternRepository> repositories, Uri uri, string label, IList<string> searchPaths, string username, string password, string hostKey, string hostKeyAlgorithm, string privateKey, bool? isHostKeyCheckingStrict, Dictionary<string, BinaryData> rawData)
        {
            Repositories = repositories;
            Uri = uri;
            Label = label;
            SearchPaths = searchPaths;
            Username = username;
            Password = password;
            HostKey = hostKey;
            HostKeyAlgorithm = hostKeyAlgorithm;
            PrivateKey = privateKey;
            IsHostKeyCheckingStrict = isHostKeyCheckingStrict;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformConfigServerGitProperty"/> for deserialization. </summary>
        internal AppPlatformConfigServerGitProperty()
        {
        }

        /// <summary> Repositories of git. </summary>
        public IList<ConfigServerGitPatternRepository> Repositories { get; }
        /// <summary> URI of the repository. </summary>
        public Uri Uri { get; set; }
        /// <summary> Label of the repository. </summary>
        public string Label { get; set; }
        /// <summary> Searching path of the repository. </summary>
        public IList<string> SearchPaths { get; }
        /// <summary> Username of git repository basic auth. </summary>
        public string Username { get; set; }
        /// <summary> Password of git repository basic auth. </summary>
        public string Password { get; set; }
        /// <summary> Public sshKey of git repository. </summary>
        public string HostKey { get; set; }
        /// <summary> SshKey algorithm of git repository. </summary>
        public string HostKeyAlgorithm { get; set; }
        /// <summary> Private sshKey algorithm of git repository. </summary>
        public string PrivateKey { get; set; }
        /// <summary> Strict host key checking or not. </summary>
        public bool? IsHostKeyCheckingStrict { get; set; }
    }
}
