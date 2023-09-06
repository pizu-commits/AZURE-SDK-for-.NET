// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Custom domain of app resource payload. </summary>
    public partial class AppPlatformCustomDomainProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppPlatformCustomDomainProperties"/>. </summary>
        public AppPlatformCustomDomainProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformCustomDomainProperties"/>. </summary>
        /// <param name="thumbprint"> The thumbprint of bound certificate. </param>
        /// <param name="appName"> The app name of domain. </param>
        /// <param name="certName"> The bound certificate name of domain. </param>
        /// <param name="provisioningState"> Provisioning state of the Domain. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppPlatformCustomDomainProperties(string thumbprint, string appName, string certName, AppPlatformCustomDomainProvisioningState? provisioningState, Dictionary<string, BinaryData> rawData)
        {
            Thumbprint = thumbprint;
            AppName = appName;
            CertName = certName;
            ProvisioningState = provisioningState;
            _rawData = rawData;
        }

        /// <summary> The thumbprint of bound certificate. </summary>
        public string Thumbprint { get; set; }
        /// <summary> The app name of domain. </summary>
        public string AppName { get; }
        /// <summary> The bound certificate name of domain. </summary>
        public string CertName { get; set; }
        /// <summary> Provisioning state of the Domain. </summary>
        public AppPlatformCustomDomainProvisioningState? ProvisioningState { get; }
    }
}
