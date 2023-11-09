// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Authorization header information. </summary>
    public partial class BackendAuthorizationHeaderCredentials
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BackendAuthorizationHeaderCredentials"/>. </summary>
        /// <param name="scheme"> Authentication Scheme name. </param>
        /// <param name="parameter"> Authentication Parameter value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scheme"/> or <paramref name="parameter"/> is null. </exception>
        public BackendAuthorizationHeaderCredentials(string scheme, string parameter)
        {
            Argument.AssertNotNull(scheme, nameof(scheme));
            Argument.AssertNotNull(parameter, nameof(parameter));

            Scheme = scheme;
            Parameter = parameter;
        }

        /// <summary> Initializes a new instance of <see cref="BackendAuthorizationHeaderCredentials"/>. </summary>
        /// <param name="scheme"> Authentication Scheme name. </param>
        /// <param name="parameter"> Authentication Parameter value. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BackendAuthorizationHeaderCredentials(string scheme, string parameter, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Scheme = scheme;
            Parameter = parameter;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BackendAuthorizationHeaderCredentials"/> for deserialization. </summary>
        internal BackendAuthorizationHeaderCredentials()
        {
        }

        /// <summary> Authentication Scheme name. </summary>
        public string Scheme { get; set; }
        /// <summary> Authentication Parameter value. </summary>
        public string Parameter { get; set; }
    }
}
