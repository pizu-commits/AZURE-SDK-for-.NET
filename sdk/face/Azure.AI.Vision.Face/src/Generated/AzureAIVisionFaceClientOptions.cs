// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.Vision.Face
{
    /// <summary> Client options for Azure.AI.Vision.Face library clients. </summary>
    public partial class AzureAIVisionFaceClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V1_1_Preview_1;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "v1.1-preview.1". </summary>
            V1_1_Preview_1 = 1,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of AzureAIVisionFaceClientOptions. </summary>
        public AzureAIVisionFaceClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V1_1_Preview_1 => "v1.1-preview.1",
                _ => throw new NotSupportedException()
            };
        }
    }
}
