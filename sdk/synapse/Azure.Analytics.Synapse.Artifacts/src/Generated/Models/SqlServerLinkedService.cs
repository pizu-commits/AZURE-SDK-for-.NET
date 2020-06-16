// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> SQL Server linked service. </summary>
    public partial class SqlServerLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of SqlServerLinkedService. </summary>
        /// <param name="connectionString"> The connection string. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        public SqlServerLinkedService(object connectionString)
        {
            if (connectionString == null)
            {
                throw new ArgumentNullException(nameof(connectionString));
            }

            ConnectionString = connectionString;
            Type = "SqlServer";
        }

        /// <summary> Initializes a new instance of SqlServerLinkedService. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="connectionString"> The connection string. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <param name="userName"> The on-premises Windows authentication user name. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> The on-premises Windows authentication password. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal SqlServerLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object connectionString, object userName, SecretBase password, object encryptedCredential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            ConnectionString = connectionString;
            UserName = userName;
            Password = password;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "SqlServer";
        }

        /// <summary> The connection string. Type: string, SecureString or AzureKeyVaultSecretReference. </summary>
        public object ConnectionString { get; set; }
        /// <summary> The on-premises Windows authentication user name. Type: string (or Expression with resultType string). </summary>
        public object UserName { get; set; }
        /// <summary> The on-premises Windows authentication password. </summary>
        public SecretBase Password { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
    }
}
