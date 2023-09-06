// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    /// <summary> The Azure service principal used by Kubernetes for configuring load balancers. </summary>
    public partial class ServicePrincipalProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ServicePrincipalProperties"/>. </summary>
        /// <param name="clientId"> The service principal client ID. </param>
        /// <param name="secret"> The service principal secret. This is not returned in response of GET/PUT on the resource. To see this please call listKeys. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientId"/> or <paramref name="secret"/> is null. </exception>
        public ServicePrincipalProperties(string clientId, string secret)
        {
            Argument.AssertNotNull(clientId, nameof(clientId));
            Argument.AssertNotNull(secret, nameof(secret));

            ClientId = clientId;
            Secret = secret;
        }

        /// <summary> Initializes a new instance of <see cref="ServicePrincipalProperties"/>. </summary>
        /// <param name="clientId"> The service principal client ID. </param>
        /// <param name="secret"> The service principal secret. This is not returned in response of GET/PUT on the resource. To see this please call listKeys. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ServicePrincipalProperties(string clientId, string secret, Dictionary<string, BinaryData> rawData)
        {
            ClientId = clientId;
            Secret = secret;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ServicePrincipalProperties"/> for deserialization. </summary>
        internal ServicePrincipalProperties()
        {
        }

        /// <summary> The service principal client ID. </summary>
        public string ClientId { get; set; }
        /// <summary> The service principal secret. This is not returned in response of GET/PUT on the resource. To see this please call listKeys. </summary>
        public string Secret { get; set; }
    }
}
