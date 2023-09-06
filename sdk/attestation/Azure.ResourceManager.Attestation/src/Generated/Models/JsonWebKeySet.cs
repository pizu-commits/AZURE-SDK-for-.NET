// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Attestation.Models
{
    /// <summary> The JsonWebKeySet. </summary>
    internal partial class JsonWebKeySet
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="JsonWebKeySet"/>. </summary>
        public JsonWebKeySet()
        {
            Keys = new ChangeTrackingList<JsonWebKey>();
        }

        /// <summary> Initializes a new instance of <see cref="JsonWebKeySet"/>. </summary>
        /// <param name="keys">
        /// The value of the "keys" parameter is an array of JWK values.  By
        /// default, the order of the JWK values within the array does not imply
        /// an order of preference among them, although applications of JWK Sets
        /// can choose to assign a meaning to the order for their purposes, if
        /// desired.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal JsonWebKeySet(IList<JsonWebKey> keys, Dictionary<string, BinaryData> rawData)
        {
            Keys = keys;
            _rawData = rawData;
        }

        /// <summary>
        /// The value of the "keys" parameter is an array of JWK values.  By
        /// default, the order of the JWK values within the array does not imply
        /// an order of preference among them, although applications of JWK Sets
        /// can choose to assign a meaning to the order for their purposes, if
        /// desired.
        /// </summary>
        public IList<JsonWebKey> Keys { get; }
    }
}
