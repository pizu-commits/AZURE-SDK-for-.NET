// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> The GitHub action container configuration. </summary>
    public partial class GitHubActionContainerConfiguration
    {
        /// <summary> Initializes a new instance of GitHubActionContainerConfiguration. </summary>
        public GitHubActionContainerConfiguration()
        {
        }

        /// <summary> Initializes a new instance of GitHubActionContainerConfiguration. </summary>
        /// <param name="serverUrl"> The server URL for the container registry where the build will be hosted. </param>
        /// <param name="imageName"> The image name for the build. </param>
        /// <param name="username"> The username used to upload the image to the container registry. </param>
        /// <param name="password"> The password used to upload the image to the container registry. </param>
        internal GitHubActionContainerConfiguration(string serverUrl, string imageName, string username, string password)
        {
            ServerUrl = serverUrl;
            ImageName = imageName;
            Username = username;
            Password = password;
        }

        /// <summary> The server URL for the container registry where the build will be hosted. </summary>
        public string ServerUrl { get; set; }
        /// <summary> The image name for the build. </summary>
        public string ImageName { get; set; }
        /// <summary> The username used to upload the image to the container registry. </summary>
        public string Username { get; set; }
        /// <summary> The password used to upload the image to the container registry. </summary>
        public string Password { get; set; }
    }
}
