// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Entity representing the reference to the deployment parameters. </summary>
    public partial class ArmDeploymentParametersLink
    {
        /// <summary> Initializes a new instance of ArmDeploymentParametersLink. </summary>
        /// <param name="uri"> The URI of the parameters file. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        public ArmDeploymentParametersLink(Uri uri)
        {
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }

            Uri = uri;
        }

        /// <summary> Initializes a new instance of ArmDeploymentParametersLink. </summary>
        /// <param name="uri"> The URI of the parameters file. </param>
        /// <param name="contentVersion"> If included, must match the ContentVersion in the template. </param>
        internal ArmDeploymentParametersLink(Uri uri, string contentVersion)
        {
            Uri = uri;
            ContentVersion = contentVersion;
        }

        /// <summary> The URI of the parameters file. </summary>
        public Uri Uri { get; set; }
        /// <summary> If included, must match the ContentVersion in the template. </summary>
        public string ContentVersion { get; set; }
    }
}
