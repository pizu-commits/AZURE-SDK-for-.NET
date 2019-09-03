﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

using System;
using System.Text.Json;

namespace Azure.Security.KeyVault.Keys.Cryptography
{
    /// <summary>
    /// Represents information about a sign operation
    /// </summary>
    public class SignResult : Model
    {
        private const string KeyIdPropertyName = "kid";
        private const string SignaturePropertyName = "value";

        /// <summary>
        /// The <see cref="KeyBase.Id"/> of the <see cref="Key"/> used to sign. This must be stored alongside the <see cref="Signature"/> as the same key must be used to verify it.
        /// </summary>
        public string KeyId { get; private set; }

        /// <summary>
        /// The signature
        /// </summary>
        public byte[] Signature { get; private set; }

        /// <summary>
        /// The algorithm used to sign. This must be stored alongside the <see cref="Signature"/> as the same algorithm must be used to verify it.
        /// </summary>
        public SignatureAlgorithm Algorithm { get; internal set; }

        internal override void ReadProperties(JsonElement json)
        {
            foreach (JsonProperty prop in json.EnumerateObject())
            {
                switch (prop.Name)
                {
                    case KeyIdPropertyName:
                        KeyId = prop.Value.GetString();
                        break;
                    case SignaturePropertyName:
                        Signature = Base64Url.Decode(prop.Value.GetString());
                        break;
                }
            }
        }

        internal override void WriteProperties(Utf8JsonWriter json) => throw new NotSupportedException();
    }
}
