// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary> The UnknownSecretInfoBase. </summary>
    internal partial class UnknownSecretInfoBase : SecretBaseInfo
    {
        /// <summary> Initializes a new instance of <see cref="UnknownSecretInfoBase"/>. </summary>
        /// <param name="secretType"> The secret type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownSecretInfoBase(LinkerSecretType secretType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(secretType, serializedAdditionalRawData)
        {
            SecretType = secretType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownSecretInfoBase"/> for deserialization. </summary>
        internal UnknownSecretInfoBase()
        {
        }
    }
}
