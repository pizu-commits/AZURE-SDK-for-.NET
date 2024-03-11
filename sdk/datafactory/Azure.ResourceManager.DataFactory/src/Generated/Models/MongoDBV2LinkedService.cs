// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Linked service for MongoDB data source. </summary>
    public partial class MongoDBV2LinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="MongoDBV2LinkedService"/>. </summary>
        /// <param name="connectionString"> The MongoDB connection string. Type: string, SecureString or AzureKeyVaultSecretReference. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <param name="database"> The name of the MongoDB database that you want to access. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionString"/> or <paramref name="database"/> is null. </exception>
        public MongoDBV2LinkedService(DataFactoryElement<string> connectionString, DataFactoryElement<string> database)
        {
            Argument.AssertNotNull(connectionString, nameof(connectionString));
            Argument.AssertNotNull(database, nameof(database));

            ConnectionString = connectionString;
            Database = database;
            LinkedServiceType = "MongoDbV2";
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBV2LinkedService"/>. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="connectionString"> The MongoDB connection string. Type: string, SecureString or AzureKeyVaultSecretReference. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <param name="database"> The name of the MongoDB database that you want to access. Type: string (or Expression with resultType string). </param>
        internal MongoDBV2LinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> connectionString, DataFactoryElement<string> database) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            ConnectionString = connectionString;
            Database = database;
            LinkedServiceType = linkedServiceType ?? "MongoDbV2";
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBV2LinkedService"/> for deserialization. </summary>
        internal MongoDBV2LinkedService()
        {
        }

        /// <summary> The MongoDB connection string. Type: string, SecureString or AzureKeyVaultSecretReference. Type: string, SecureString or AzureKeyVaultSecretReference. </summary>
        public DataFactoryElement<string> ConnectionString { get; set; }
        /// <summary> The name of the MongoDB database that you want to access. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Database { get; set; }
    }
}
