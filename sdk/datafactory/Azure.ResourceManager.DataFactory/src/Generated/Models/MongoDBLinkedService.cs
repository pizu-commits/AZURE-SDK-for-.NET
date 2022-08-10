// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Linked service for MongoDb data source. </summary>
    public partial class MongoDBLinkedService : FactoryLinkedServiceDefinition
    {
        /// <summary> Initializes a new instance of MongoDBLinkedService. </summary>
        /// <param name="server"> The IP address or server name of the MongoDB server. Type: string (or Expression with resultType string). </param>
        /// <param name="databaseName"> The name of the MongoDB database that you want to access. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="server"/> or <paramref name="databaseName"/> is null. </exception>
        public MongoDBLinkedService(BinaryData server, BinaryData databaseName)
        {
            if (server == null)
            {
                throw new ArgumentNullException(nameof(server));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }

            Server = server;
            DatabaseName = databaseName;
            LinkedServiceType = "MongoDb";
        }

        /// <summary> Initializes a new instance of MongoDBLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="server"> The IP address or server name of the MongoDB server. Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> The authentication type to be used to connect to the MongoDB database. </param>
        /// <param name="databaseName"> The name of the MongoDB database that you want to access. Type: string (or Expression with resultType string). </param>
        /// <param name="username"> Username for authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="password">
        /// Password for authentication.
        /// Please note <see cref="FactorySecretBaseDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FactorySecretString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </param>
        /// <param name="authSource"> Database to verify the username and password. Type: string (or Expression with resultType string). </param>
        /// <param name="port"> The TCP port number that the MongoDB server uses to listen for client connections. The default value is 27017. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="enableSsl"> Specifies whether the connections to the server are encrypted using SSL. The default value is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="allowSelfSignedServerCert"> Specifies whether to allow self-signed certificates from the server. The default value is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal MongoDBLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, BinaryData server, MongoDBAuthenticationType? authenticationType, BinaryData databaseName, BinaryData username, FactorySecretBaseDefinition password, BinaryData authSource, BinaryData port, BinaryData enableSsl, BinaryData allowSelfSignedServerCert, BinaryData encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Server = server;
            AuthenticationType = authenticationType;
            DatabaseName = databaseName;
            Username = username;
            Password = password;
            AuthSource = authSource;
            Port = port;
            EnableSsl = enableSsl;
            AllowSelfSignedServerCert = allowSelfSignedServerCert;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "MongoDb";
        }

        /// <summary> The IP address or server name of the MongoDB server. Type: string (or Expression with resultType string). </summary>
        public BinaryData Server { get; set; }
        /// <summary> The authentication type to be used to connect to the MongoDB database. </summary>
        public MongoDBAuthenticationType? AuthenticationType { get; set; }
        /// <summary> The name of the MongoDB database that you want to access. Type: string (or Expression with resultType string). </summary>
        public BinaryData DatabaseName { get; set; }
        /// <summary> Username for authentication. Type: string (or Expression with resultType string). </summary>
        public BinaryData Username { get; set; }
        /// <summary>
        /// Password for authentication.
        /// Please note <see cref="FactorySecretBaseDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FactorySecretString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </summary>
        public FactorySecretBaseDefinition Password { get; set; }
        /// <summary> Database to verify the username and password. Type: string (or Expression with resultType string). </summary>
        public BinaryData AuthSource { get; set; }
        /// <summary> The TCP port number that the MongoDB server uses to listen for client connections. The default value is 27017. Type: integer (or Expression with resultType integer), minimum: 0. </summary>
        public BinaryData Port { get; set; }
        /// <summary> Specifies whether the connections to the server are encrypted using SSL. The default value is false. Type: boolean (or Expression with resultType boolean). </summary>
        public BinaryData EnableSsl { get; set; }
        /// <summary> Specifies whether to allow self-signed certificates from the server. The default value is false. Type: boolean (or Expression with resultType boolean). </summary>
        public BinaryData AllowSelfSignedServerCert { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public BinaryData EncryptedCredential { get; set; }
    }
}
