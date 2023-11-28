// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> File system linked service. </summary>
    public partial class FileServerLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="FileServerLinkedService"/>. </summary>
        /// <param name="host"> Host name of the server. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="host"/> is null. </exception>
        public FileServerLinkedService(DataFactoryElement<string> host)
        {
            Argument.AssertNotNull(host, nameof(host));

            Host = host;
            LinkedServiceType = "FileServer";
        }

        /// <summary> Initializes a new instance of <see cref="FileServerLinkedService"/>. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="host"> Host name of the server. Type: string (or Expression with resultType string). </param>
        /// <param name="userId"> User ID to logon the server. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> Password to logon the server. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal FileServerLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> host, DataFactoryElement<string> userId, DataFactorySecretBaseDefinition password, string encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Host = host;
            UserId = userId;
            Password = password;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "FileServer";
        }

        /// <summary> Host name of the server. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Host { get; set; }
        /// <summary> User ID to logon the server. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> UserId { get; set; }
        /// <summary> Password to logon the server. </summary>
        public DataFactorySecretBaseDefinition Password { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}
