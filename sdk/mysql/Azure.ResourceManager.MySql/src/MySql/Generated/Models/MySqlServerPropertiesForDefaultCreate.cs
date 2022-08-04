// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MySql.Models
{
    /// <summary> The properties used to create a new server. </summary>
    public partial class MySqlServerPropertiesForDefaultCreate : MySqlServerPropertiesForCreate
    {
        /// <summary> Initializes a new instance of MySqlServerPropertiesForDefaultCreate. </summary>
        /// <param name="administratorLogin"> The administrator&apos;s login name of a server. Can only be specified when the server is being created (and is required for creation). The login name is required when updating password. </param>
        /// <param name="administratorLoginPassword"> The password of the administrator login. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="administratorLogin"/> or <paramref name="administratorLoginPassword"/> is null. </exception>
        public MySqlServerPropertiesForDefaultCreate(string administratorLogin, string administratorLoginPassword)
        {
            if (administratorLogin == null)
            {
                throw new ArgumentNullException(nameof(administratorLogin));
            }
            if (administratorLoginPassword == null)
            {
                throw new ArgumentNullException(nameof(administratorLoginPassword));
            }

            AdministratorLogin = administratorLogin;
            AdministratorLoginPassword = administratorLoginPassword;
            CreateMode = MySqlCreateMode.Default;
        }

        /// <summary> The administrator&apos;s login name of a server. Can only be specified when the server is being created (and is required for creation). The login name is required when updating password. </summary>
        public string AdministratorLogin { get; }
        /// <summary> The password of the administrator login. </summary>
        public string AdministratorLoginPassword { get; }
    }
}
