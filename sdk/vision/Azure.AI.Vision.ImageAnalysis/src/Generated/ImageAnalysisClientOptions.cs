// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.Vision.ImageAnalysis
{
    /// <summary> Client options for ImageAnalysisClient. </summary>
    public partial class ImageAnalysisClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V2023_10_01;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "2023-10-01". </summary>
            V2023_10_01 = 1,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of ImageAnalysisClientOptions. </summary>
        public ImageAnalysisClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V2023_10_01 => "2023-10-01",
                _ => throw new NotSupportedException()
            };
        }
    }
}
