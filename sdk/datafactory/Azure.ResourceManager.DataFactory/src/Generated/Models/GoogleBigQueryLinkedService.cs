// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Google BigQuery service linked service. </summary>
    public partial class GoogleBigQueryLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of GoogleBigQueryLinkedService. </summary>
        /// <param name="project"> The default BigQuery project to query against. </param>
        /// <param name="authenticationType"> The OAuth 2.0 authentication mechanism used for authentication. ServiceAuthentication can only be used on self-hosted IR. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="project"/> is null. </exception>
        public GoogleBigQueryLinkedService(BinaryData project, GoogleBigQueryAuthenticationType authenticationType)
        {
            if (project == null)
            {
                throw new ArgumentNullException(nameof(project));
            }

            Project = project;
            AuthenticationType = authenticationType;
            LinkedServiceType = "GoogleBigQuery";
        }

        /// <summary> Initializes a new instance of GoogleBigQueryLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="project"> The default BigQuery project to query against. </param>
        /// <param name="additionalProjects"> A comma-separated list of public BigQuery projects to access. </param>
        /// <param name="requestGoogleDriveScope"> Whether to request access to Google Drive. Allowing Google Drive access enables support for federated tables that combine BigQuery data with data from Google Drive. The default value is false. </param>
        /// <param name="authenticationType"> The OAuth 2.0 authentication mechanism used for authentication. ServiceAuthentication can only be used on self-hosted IR. </param>
        /// <param name="refreshToken">
        /// The refresh token obtained from Google for authorizing access to BigQuery for UserAuthentication.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecureString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </param>
        /// <param name="clientId"> The client id of the google application used to acquire the refresh token. Type: string (or Expression with resultType string). </param>
        /// <param name="clientSecret">
        /// The client secret of the google application used to acquire the refresh token.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecureString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </param>
        /// <param name="email"> The service account email ID that is used for ServiceAuthentication and can only be used on self-hosted IR. </param>
        /// <param name="keyFilePath"> The full path to the .p12 key file that is used to authenticate the service account email address and can only be used on self-hosted IR. </param>
        /// <param name="trustedCertPath"> The full path of the .pem file containing trusted CA certificates for verifying the server when connecting over SSL. This property can only be set when using SSL on self-hosted IR. The default value is the cacerts.pem file installed with the IR. </param>
        /// <param name="useSystemTrustStore"> Specifies whether to use a CA certificate from the system trust store or from a specified PEM file. The default value is false. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal GoogleBigQueryLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, BinaryData project, BinaryData additionalProjects, BinaryData requestGoogleDriveScope, GoogleBigQueryAuthenticationType authenticationType, SecretBase refreshToken, BinaryData clientId, SecretBase clientSecret, BinaryData email, BinaryData keyFilePath, BinaryData trustedCertPath, BinaryData useSystemTrustStore, BinaryData encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Project = project;
            AdditionalProjects = additionalProjects;
            RequestGoogleDriveScope = requestGoogleDriveScope;
            AuthenticationType = authenticationType;
            RefreshToken = refreshToken;
            ClientId = clientId;
            ClientSecret = clientSecret;
            Email = email;
            KeyFilePath = keyFilePath;
            TrustedCertPath = trustedCertPath;
            UseSystemTrustStore = useSystemTrustStore;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "GoogleBigQuery";
        }

        /// <summary> The default BigQuery project to query against. </summary>
        public BinaryData Project { get; set; }
        /// <summary> A comma-separated list of public BigQuery projects to access. </summary>
        public BinaryData AdditionalProjects { get; set; }
        /// <summary> Whether to request access to Google Drive. Allowing Google Drive access enables support for federated tables that combine BigQuery data with data from Google Drive. The default value is false. </summary>
        public BinaryData RequestGoogleDriveScope { get; set; }
        /// <summary> The OAuth 2.0 authentication mechanism used for authentication. ServiceAuthentication can only be used on self-hosted IR. </summary>
        public GoogleBigQueryAuthenticationType AuthenticationType { get; set; }
        /// <summary>
        /// The refresh token obtained from Google for authorizing access to BigQuery for UserAuthentication.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecureString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </summary>
        public SecretBase RefreshToken { get; set; }
        /// <summary> The client id of the google application used to acquire the refresh token. Type: string (or Expression with resultType string). </summary>
        public BinaryData ClientId { get; set; }
        /// <summary>
        /// The client secret of the google application used to acquire the refresh token.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecureString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </summary>
        public SecretBase ClientSecret { get; set; }
        /// <summary> The service account email ID that is used for ServiceAuthentication and can only be used on self-hosted IR. </summary>
        public BinaryData Email { get; set; }
        /// <summary> The full path to the .p12 key file that is used to authenticate the service account email address and can only be used on self-hosted IR. </summary>
        public BinaryData KeyFilePath { get; set; }
        /// <summary> The full path of the .pem file containing trusted CA certificates for verifying the server when connecting over SSL. This property can only be set when using SSL on self-hosted IR. The default value is the cacerts.pem file installed with the IR. </summary>
        public BinaryData TrustedCertPath { get; set; }
        /// <summary> Specifies whether to use a CA certificate from the system trust store or from a specified PEM file. The default value is false. </summary>
        public BinaryData UseSystemTrustStore { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public BinaryData EncryptedCredential { get; set; }
    }
}
