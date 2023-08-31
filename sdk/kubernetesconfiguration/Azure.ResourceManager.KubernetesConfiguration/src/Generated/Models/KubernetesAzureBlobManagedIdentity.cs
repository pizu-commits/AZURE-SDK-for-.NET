// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    /// <summary> Parameters to authenticate using a Managed Identity. </summary>
    internal partial class KubernetesAzureBlobManagedIdentity
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="KubernetesAzureBlobManagedIdentity"/>. </summary>
        public KubernetesAzureBlobManagedIdentity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="KubernetesAzureBlobManagedIdentity"/>. </summary>
        /// <param name="clientId"> The client Id for authenticating a Managed Identity. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KubernetesAzureBlobManagedIdentity(Guid? clientId, Dictionary<string, BinaryData> rawData)
        {
            ClientId = clientId;
            _rawData = rawData;
        }

        /// <summary> The client Id for authenticating a Managed Identity. </summary>
        public Guid? ClientId { get; set; }
    }
}
