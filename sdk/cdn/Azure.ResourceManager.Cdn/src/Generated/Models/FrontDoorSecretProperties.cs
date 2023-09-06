// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary>
    /// The json object containing secret parameters
    /// Please note <see cref="FrontDoorSecretProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AzureFirstPartyManagedCertificateProperties"/>, <see cref="CustomerCertificateProperties"/>, <see cref="ManagedCertificateProperties"/> and <see cref="UriSigningKeyProperties"/>.
    /// </summary>
    [AbstractTypeDeserializer(typeof(UnknownSecretProperties))]
    public abstract partial class FrontDoorSecretProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="FrontDoorSecretProperties"/>. </summary>
        protected FrontDoorSecretProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FrontDoorSecretProperties"/>. </summary>
        /// <param name="secretType"> The type of the secret resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FrontDoorSecretProperties(SecretType secretType, Dictionary<string, BinaryData> rawData)
        {
            SecretType = secretType;
            _rawData = rawData;
        }

        /// <summary> The type of the secret resource. </summary>
        internal SecretType SecretType { get; set; }
    }
}
