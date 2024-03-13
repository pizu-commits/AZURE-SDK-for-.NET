// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.MySql;

namespace Azure.ResourceManager.MySql.Models
{
    /// <summary> The properties used to create a new server. </summary>
    public partial class MySqlServerPropertiesForDefaultCreate : MySqlServerPropertiesForCreate
    {
        /// <summary> Initializes a new instance of <see cref="MySqlServerPropertiesForDefaultCreate"/>. </summary>
        /// <param name="administratorLogin"> The administrator's login name of a server. Can only be specified when the server is being created (and is required for creation). The login name is required when updating password. </param>
        /// <param name="administratorLoginPassword"> The password of the administrator login. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="administratorLogin"/> or <paramref name="administratorLoginPassword"/> is null. </exception>
        public MySqlServerPropertiesForDefaultCreate(string administratorLogin, string administratorLoginPassword)
        {
            Argument.AssertNotNull(administratorLogin, nameof(administratorLogin));
            Argument.AssertNotNull(administratorLoginPassword, nameof(administratorLoginPassword));

            AdministratorLogin = administratorLogin;
            AdministratorLoginPassword = administratorLoginPassword;
            CreateMode = MySqlCreateMode.Default;
        }

        /// <summary> Initializes a new instance of <see cref="MySqlServerPropertiesForDefaultCreate"/>. </summary>
        /// <param name="version"> Server version. </param>
        /// <param name="sslEnforcement"> Enable ssl enforcement or not when connect to server. </param>
        /// <param name="minimalTlsVersion"> Enforce a minimal Tls version for the server. </param>
        /// <param name="infrastructureEncryption"> Status showing whether the server enabled infrastructure encryption. </param>
        /// <param name="publicNetworkAccess"> Whether or not public network access is allowed for this server. Value is optional but if passed in, must be 'Enabled' or 'Disabled'. </param>
        /// <param name="storageProfile"> Storage profile of a server. </param>
        /// <param name="createMode"> The mode to create a new server. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="administratorLogin"> The administrator's login name of a server. Can only be specified when the server is being created (and is required for creation). The login name is required when updating password. </param>
        /// <param name="administratorLoginPassword"> The password of the administrator login. </param>
        internal MySqlServerPropertiesForDefaultCreate(MySqlServerVersion? version, MySqlSslEnforcementEnum? sslEnforcement, MySqlMinimalTlsVersionEnum? minimalTlsVersion, MySqlInfrastructureEncryption? infrastructureEncryption, MySqlPublicNetworkAccessEnum? publicNetworkAccess, MySqlStorageProfile storageProfile, MySqlCreateMode createMode, IDictionary<string, BinaryData> serializedAdditionalRawData, string administratorLogin, string administratorLoginPassword) : base(version, sslEnforcement, minimalTlsVersion, infrastructureEncryption, publicNetworkAccess, storageProfile, createMode, serializedAdditionalRawData)
        {
            AdministratorLogin = administratorLogin;
            AdministratorLoginPassword = administratorLoginPassword;
            CreateMode = createMode;
        }

        /// <summary> Initializes a new instance of <see cref="MySqlServerPropertiesForDefaultCreate"/> for deserialization. </summary>
        internal MySqlServerPropertiesForDefaultCreate()
        {
        }

        /// <summary> The administrator's login name of a server. Can only be specified when the server is being created (and is required for creation). The login name is required when updating password. </summary>
        [WirePath("administratorLogin")]
        public string AdministratorLogin { get; }
        /// <summary> The password of the administrator login. </summary>
        [WirePath("administratorLoginPassword")]
        public string AdministratorLoginPassword { get; }
    }
}
