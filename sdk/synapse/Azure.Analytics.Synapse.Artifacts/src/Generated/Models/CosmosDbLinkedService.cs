// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Microsoft Azure Cosmos Database (CosmosDB) linked service. </summary>
    public partial class CosmosDbLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of <see cref="CosmosDbLinkedService"/>. </summary>
        public CosmosDbLinkedService()
        {
            Type = "CosmosDb";
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDbLinkedService"/>. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="connectionString"> The connection string. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <param name="accountEndpoint"> The endpoint of the Azure CosmosDB account. Type: string (or Expression with resultType string). </param>
        /// <param name="database"> The name of the database. Type: string (or Expression with resultType string). </param>
        /// <param name="accountKey">
        /// The account key of the Azure CosmosDB account. Type: SecureString or AzureKeyVaultSecretReference.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        /// <param name="credential"> The credential reference containing authentication information. </param>
        internal CosmosDbLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object connectionString, object accountEndpoint, object database, SecretBase accountKey, object encryptedCredential, CredentialReference credential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            ConnectionString = connectionString;
            AccountEndpoint = accountEndpoint;
            Database = database;
            AccountKey = accountKey;
            EncryptedCredential = encryptedCredential;
            Credential = credential;
            Type = type ?? "CosmosDb";
        }

        /// <summary> The connection string. Type: string, SecureString or AzureKeyVaultSecretReference. </summary>
        public object ConnectionString { get; set; }
        /// <summary> The endpoint of the Azure CosmosDB account. Type: string (or Expression with resultType string). </summary>
        public object AccountEndpoint { get; set; }
        /// <summary> The name of the database. Type: string (or Expression with resultType string). </summary>
        public object Database { get; set; }
        /// <summary>
        /// The account key of the Azure CosmosDB account. Type: SecureString or AzureKeyVaultSecretReference.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase AccountKey { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
        /// <summary> The credential reference containing authentication information. </summary>
        public CredentialReference Credential { get; set; }
    }
}
