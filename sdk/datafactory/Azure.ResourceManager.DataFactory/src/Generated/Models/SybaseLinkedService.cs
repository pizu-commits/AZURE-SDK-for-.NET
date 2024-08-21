// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Linked service for Sybase data source. </summary>
    public partial class SybaseLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="SybaseLinkedService"/>. </summary>
        /// <param name="server"> Server name for connection. Type: string (or Expression with resultType string). </param>
        /// <param name="database"> Database name for connection. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="server"/> or <paramref name="database"/> is null. </exception>
        public SybaseLinkedService(DataFactoryElement<string> server, DataFactoryElement<string> database)
        {
            Argument.AssertNotNull(server, nameof(server));
            Argument.AssertNotNull(database, nameof(database));

            Server = server;
            Database = database;
            LinkedServiceType = "Sybase";
        }

        /// <summary> Initializes a new instance of <see cref="SybaseLinkedService"/>. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="linkedServiceVersion"> Version of the linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="server"> Server name for connection. Type: string (or Expression with resultType string). </param>
        /// <param name="database"> Database name for connection. Type: string (or Expression with resultType string). </param>
        /// <param name="schema"> Schema name for connection. Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> AuthenticationType to be used for connection. </param>
        /// <param name="username"> Username for authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> Password for authentication. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal SybaseLinkedService(string linkedServiceType, string linkedServiceVersion, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> server, DataFactoryElement<string> database, DataFactoryElement<string> schema, SybaseAuthenticationType? authenticationType, DataFactoryElement<string> username, DataFactorySecret password, string encryptedCredential) : base(linkedServiceType, linkedServiceVersion, connectVia, description, parameters, annotations, additionalProperties)
        {
            Server = server;
            Database = database;
            Schema = schema;
            AuthenticationType = authenticationType;
            Username = username;
            Password = password;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "Sybase";
        }

        /// <summary> Initializes a new instance of <see cref="SybaseLinkedService"/> for deserialization. </summary>
        internal SybaseLinkedService()
        {
        }

        /// <summary> Server name for connection. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Server { get; set; }
        /// <summary> Database name for connection. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Database { get; set; }
        /// <summary> Schema name for connection. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Schema { get; set; }
        /// <summary> AuthenticationType to be used for connection. </summary>
        public SybaseAuthenticationType? AuthenticationType { get; set; }
        /// <summary> Username for authentication. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Username { get; set; }
        /// <summary> Password for authentication. </summary>
        public DataFactorySecret Password { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}
