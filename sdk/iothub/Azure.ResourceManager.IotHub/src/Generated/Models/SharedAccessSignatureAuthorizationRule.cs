// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The properties of an IoT hub shared access policy. </summary>
    public partial class SharedAccessSignatureAuthorizationRule
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SharedAccessSignatureAuthorizationRule"/>. </summary>
        /// <param name="keyName"> The name of the shared access policy. </param>
        /// <param name="rights"> The permissions assigned to the shared access policy. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public SharedAccessSignatureAuthorizationRule(string keyName, IotHubSharedAccessRight rights)
        {
            Argument.AssertNotNull(keyName, nameof(keyName));

            KeyName = keyName;
            Rights = rights;
        }

        /// <summary> Initializes a new instance of <see cref="SharedAccessSignatureAuthorizationRule"/>. </summary>
        /// <param name="keyName"> The name of the shared access policy. </param>
        /// <param name="primaryKey"> The primary key. </param>
        /// <param name="secondaryKey"> The secondary key. </param>
        /// <param name="rights"> The permissions assigned to the shared access policy. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SharedAccessSignatureAuthorizationRule(string keyName, string primaryKey, string secondaryKey, IotHubSharedAccessRight rights, Dictionary<string, BinaryData> rawData)
        {
            KeyName = keyName;
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            Rights = rights;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="SharedAccessSignatureAuthorizationRule"/> for deserialization. </summary>
        internal SharedAccessSignatureAuthorizationRule()
        {
        }

        /// <summary> The name of the shared access policy. </summary>
        public string KeyName { get; set; }
        /// <summary> The primary key. </summary>
        public string PrimaryKey { get; set; }
        /// <summary> The secondary key. </summary>
        public string SecondaryKey { get; set; }
        /// <summary> The permissions assigned to the shared access policy. </summary>
        public IotHubSharedAccessRight Rights { get; set; }
    }
}
