// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The appliance package support URLs. </summary>
    public partial class ApplicationPackageSupportUrls
    {
        /// <summary> Initializes a new instance of ApplicationPackageSupportUrls. </summary>
        internal ApplicationPackageSupportUrls()
        {
        }

        /// <summary> Initializes a new instance of ApplicationPackageSupportUrls. </summary>
        /// <param name="publicAzure"> The public azure support URL. </param>
        /// <param name="governmentCloud"> The government cloud support URL. </param>
        internal ApplicationPackageSupportUrls(string publicAzure, string governmentCloud)
        {
            PublicAzure = publicAzure;
            GovernmentCloud = governmentCloud;
        }

        /// <summary> The public azure support URL. </summary>
        public string PublicAzure { get; }
        /// <summary> The government cloud support URL. </summary>
        public string GovernmentCloud { get; }
    }
}
