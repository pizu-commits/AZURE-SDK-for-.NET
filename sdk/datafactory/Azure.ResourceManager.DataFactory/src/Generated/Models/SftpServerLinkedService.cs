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
    /// <summary> A linked service for an SSH File Transfer Protocol (SFTP) server. </summary>
    public partial class SftpServerLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="SftpServerLinkedService"/>. </summary>
        /// <param name="host"> The SFTP server host name. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="host"/> is null. </exception>
        public SftpServerLinkedService(DataFactoryElement<string> host)
        {
            Argument.AssertNotNull(host, nameof(host));

            Host = host;
            LinkedServiceType = "Sftp";
        }

        /// <summary> Initializes a new instance of <see cref="SftpServerLinkedService"/>. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="host"> The SFTP server host name. Type: string (or Expression with resultType string). </param>
        /// <param name="port"> The TCP port number that the SFTP server uses to listen for client connections. Default value is 22. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="authenticationType"> The authentication type to be used to connect to the FTP server. </param>
        /// <param name="userName"> The username used to log on to the SFTP server. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> Password to logon the SFTP server for Basic authentication. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        /// <param name="privateKeyPath"> The SSH private key file path for SshPublicKey authentication. Only valid for on-premises copy. For on-premises copy with SshPublicKey authentication, either PrivateKeyPath or PrivateKeyContent should be specified. SSH private key should be OpenSSH format. Type: string (or Expression with resultType string). </param>
        /// <param name="privateKeyContent"> Base64 encoded SSH private key content for SshPublicKey authentication. For on-premises copy with SshPublicKey authentication, either PrivateKeyPath or PrivateKeyContent should be specified. SSH private key should be OpenSSH format. </param>
        /// <param name="passPhrase"> The password to decrypt the SSH private key if the SSH private key is encrypted. </param>
        /// <param name="skipHostKeyValidation"> If true, skip the SSH host key validation. Default value is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="hostKeyFingerprint"> The host key finger-print of the SFTP server. When SkipHostKeyValidation is false, HostKeyFingerprint should be specified. Type: string (or Expression with resultType string). </param>
        internal SftpServerLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> host, DataFactoryElement<int> port, SftpAuthenticationType? authenticationType, DataFactoryElement<string> userName, DataFactorySecret password, string encryptedCredential, DataFactoryElement<string> privateKeyPath, DataFactorySecret privateKeyContent, DataFactorySecret passPhrase, DataFactoryElement<bool> skipHostKeyValidation, DataFactoryElement<string> hostKeyFingerprint) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Host = host;
            Port = port;
            AuthenticationType = authenticationType;
            UserName = userName;
            Password = password;
            EncryptedCredential = encryptedCredential;
            PrivateKeyPath = privateKeyPath;
            PrivateKeyContent = privateKeyContent;
            PassPhrase = passPhrase;
            SkipHostKeyValidation = skipHostKeyValidation;
            HostKeyFingerprint = hostKeyFingerprint;
            LinkedServiceType = linkedServiceType ?? "Sftp";
        }

        /// <summary> Initializes a new instance of <see cref="SftpServerLinkedService"/> for deserialization. </summary>
        internal SftpServerLinkedService()
        {
        }

        /// <summary> The SFTP server host name. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Host { get; set; }
        /// <summary> The TCP port number that the SFTP server uses to listen for client connections. Default value is 22. Type: integer (or Expression with resultType integer), minimum: 0. </summary>
        public DataFactoryElement<int> Port { get; set; }
        /// <summary> The authentication type to be used to connect to the FTP server. </summary>
        public SftpAuthenticationType? AuthenticationType { get; set; }
        /// <summary> The username used to log on to the SFTP server. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> UserName { get; set; }
        /// <summary> Password to logon the SFTP server for Basic authentication. </summary>
        public DataFactorySecret Password { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
        /// <summary> The SSH private key file path for SshPublicKey authentication. Only valid for on-premises copy. For on-premises copy with SshPublicKey authentication, either PrivateKeyPath or PrivateKeyContent should be specified. SSH private key should be OpenSSH format. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> PrivateKeyPath { get; set; }
        /// <summary> Base64 encoded SSH private key content for SshPublicKey authentication. For on-premises copy with SshPublicKey authentication, either PrivateKeyPath or PrivateKeyContent should be specified. SSH private key should be OpenSSH format. </summary>
        public DataFactorySecret PrivateKeyContent { get; set; }
        /// <summary> The password to decrypt the SSH private key if the SSH private key is encrypted. </summary>
        public DataFactorySecret PassPhrase { get; set; }
        /// <summary> If true, skip the SSH host key validation. Default value is false. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> SkipHostKeyValidation { get; set; }
        /// <summary> The host key finger-print of the SFTP server. When SkipHostKeyValidation is false, HostKeyFingerprint should be specified. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> HostKeyFingerprint { get; set; }
    }
}
