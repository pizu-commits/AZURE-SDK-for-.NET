// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> This property store root certificate related information. </summary>
    public partial class RootCertificateProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RootCertificateProperties"/>. </summary>
        public RootCertificateProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RootCertificateProperties"/>. </summary>
        /// <param name="isRootCertificateV2Enabled"> This property when set to true, hub will use G2 cert; while it's set to false, hub uses Baltimore Cert. </param>
        /// <param name="lastUpdatedOn"> the last update time to root certificate flag. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RootCertificateProperties(bool? isRootCertificateV2Enabled, DateTimeOffset? lastUpdatedOn, Dictionary<string, BinaryData> rawData)
        {
            IsRootCertificateV2Enabled = isRootCertificateV2Enabled;
            LastUpdatedOn = lastUpdatedOn;
            _rawData = rawData;
        }

        /// <summary> This property when set to true, hub will use G2 cert; while it's set to false, hub uses Baltimore Cert. </summary>
        public bool? IsRootCertificateV2Enabled { get; set; }
        /// <summary> the last update time to root certificate flag. </summary>
        public DateTimeOffset? LastUpdatedOn { get; }
    }
}
