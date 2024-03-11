// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Analytics.Synapse.Artifacts;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Linked service for MongoDb data source. </summary>
    public partial class MongoDbLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of <see cref="MongoDbLinkedService"/>. </summary>
        /// <param name="server"> The IP address or server name of the MongoDB server. Type: string (or Expression with resultType string). </param>
        /// <param name="databaseName"> The name of the MongoDB database that you want to access. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="server"/> or <paramref name="databaseName"/> is null. </exception>
        public MongoDbLinkedService(object server, object databaseName)
        {
            Argument.AssertNotNull(server, nameof(server));
            Argument.AssertNotNull(databaseName, nameof(databaseName));

            Server = server;
            DatabaseName = databaseName;
            Type = "MongoDb";
        }

        /// <summary> Initializes a new instance of <see cref="MongoDbLinkedService"/>. </summary>
        /// <param name="type"> Type of linked service. </param>
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
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="authSource"> Database to verify the username and password. Type: string (or Expression with resultType string). </param>
        /// <param name="port"> The TCP port number that the MongoDB server uses to listen for client connections. The default value is 27017. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="enableSsl"> Specifies whether the connections to the server are encrypted using SSL. The default value is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="allowSelfSignedServerCert"> Specifies whether to allow self-signed certificates from the server. The default value is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal MongoDbLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object server, MongoDbAuthenticationType? authenticationType, object databaseName, object username, SecretBase password, object authSource, object port, object enableSsl, object allowSelfSignedServerCert, object encryptedCredential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
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
            Type = type ?? "MongoDb";
        }

        /// <summary> The IP address or server name of the MongoDB server. Type: string (or Expression with resultType string). </summary>
        public object Server { get; set; }
        /// <summary> The authentication type to be used to connect to the MongoDB database. </summary>
        public MongoDbAuthenticationType? AuthenticationType { get; set; }
        /// <summary> The name of the MongoDB database that you want to access. Type: string (or Expression with resultType string). </summary>
        public object DatabaseName { get; set; }
        /// <summary> Username for authentication. Type: string (or Expression with resultType string). </summary>
        public object Username { get; set; }
        /// <summary>
        /// Password for authentication.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase Password { get; set; }
        /// <summary> Database to verify the username and password. Type: string (or Expression with resultType string). </summary>
        public object AuthSource { get; set; }
        /// <summary> The TCP port number that the MongoDB server uses to listen for client connections. The default value is 27017. Type: integer (or Expression with resultType integer), minimum: 0. </summary>
        public object Port { get; set; }
        /// <summary> Specifies whether the connections to the server are encrypted using SSL. The default value is false. Type: boolean (or Expression with resultType boolean). </summary>
        public object EnableSsl { get; set; }
        /// <summary> Specifies whether to allow self-signed certificates from the server. The default value is false. Type: boolean (or Expression with resultType boolean). </summary>
        public object AllowSelfSignedServerCert { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
    }
}
