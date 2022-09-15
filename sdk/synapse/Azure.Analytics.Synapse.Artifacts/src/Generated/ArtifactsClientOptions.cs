// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts
{
    /// <summary> Client options for ArtifactsClient. </summary>
    public partial class ArtifactsClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V2022_08_01_Preview;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "2020-12-01". </summary>
            V2020_12_01 = 1,
            /// <summary> Service version "2021-06-01-preview". </summary>
            V2021_06_01_Preview = 2,
            /// <summary> Service version "2021-07-01-preview". </summary>
            V2021_07_01_Preview = 3,
            /// <summary> Service version "2021-11-01-preview". </summary>
            V2021_11_01_Preview = 4,
            /// <summary> Service version "2022-08-01-preview". </summary>
            V2022_08_01_Preview = 5,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of ArtifactsClientOptions. </summary>
        public ArtifactsClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V2020_12_01 => "2020-12-01",
                ServiceVersion.V2021_06_01_Preview => "2021-06-01-preview",
                ServiceVersion.V2021_07_01_Preview => "2021-07-01-preview",
                ServiceVersion.V2021_11_01_Preview => "2021-11-01-preview",
                ServiceVersion.V2022_08_01_Preview => "2022-08-01-preview",
                _ => throw new NotSupportedException()
            };
        }
    }
}
