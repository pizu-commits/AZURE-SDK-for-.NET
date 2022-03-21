// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.Personalizer
{
    /// <summary> Client options for PersonalizerClient. </summary>
    public partial class PersonalizerClientOptions : ClientOptions
    {
        private bool useLocalInference;
        private float subsampleRate;
        private const ServiceVersion LatestVersion = ServiceVersion.V1_1_preview_3;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "v1.1-preview.3". </summary>
            V1_1_preview_3 = 1,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of PersonalizerClientV1Preview3ClientOptions. </summary>
        public PersonalizerClientOptions(ServiceVersion version = LatestVersion, bool useLocalInference = false, float subsampleRate = 1)
        {
            this.useLocalInference = useLocalInference;
            this.subsampleRate = subsampleRate;

            Version = version switch
            {
                ServiceVersion.V1_1_preview_3 => "v1.1-preview.3",
                _ => throw new NotSupportedException()
            };

            Retry.NetworkTimeout = TimeSpan.FromMinutes(8);
        }

        internal float SubsampleRate { get => subsampleRate; }
        internal bool UseLocalInference { get => useLocalInference; }
    }
}
