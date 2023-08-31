// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Security.KeyVault.Administration.Models
{
    /// <summary> Role definition create parameters. </summary>
    internal partial class RoleDefinitionCreateParameters
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RoleDefinitionCreateParameters"/>. </summary>
        /// <param name="properties"> Role definition properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public RoleDefinitionCreateParameters(RoleDefinitionProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="RoleDefinitionCreateParameters"/>. </summary>
        /// <param name="properties"> Role definition properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RoleDefinitionCreateParameters(RoleDefinitionProperties properties, Dictionary<string, BinaryData> rawData)
        {
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="RoleDefinitionCreateParameters"/> for deserialization. </summary>
        internal RoleDefinitionCreateParameters()
        {
        }

        /// <summary> Role definition properties. </summary>
        public RoleDefinitionProperties Properties { get; }
    }
}
