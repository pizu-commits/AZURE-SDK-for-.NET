// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Impala server linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Impala")]
    [Rest.Serialization.JsonTransformation]
    public partial class ImpalaLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the ImpalaLinkedService class.
        /// </summary>
        public ImpalaLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImpalaLinkedService class.
        /// </summary>
        /// <param name="host">The IP address or host name of the Impala
        /// server. (i.e. 192.168.222.160)</param>
        /// <param name="authenticationType">The authentication type to use.
        /// Possible values include: 'Anonymous', 'SASLUsername',
        /// 'UsernameAndPassword'</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="port">The TCP port that the Impala server uses to
        /// listen for client connections. The default value is 21050.</param>
        /// <param name="username">The user name used to access the Impala
        /// server. The default value is anonymous when using
        /// SASLUsername.</param>
        /// <param name="password">The password corresponding to the user name
        /// when using UsernameAndPassword.</param>
        /// <param name="enableSsl">Specifies whether the connections to the
        /// server are encrypted using SSL. The default value is false.</param>
        /// <param name="trustedCertPath">The full path of the .pem file
        /// containing trusted CA certificates for verifying the server when
        /// connecting over SSL. This property can only be set when using SSL
        /// on self-hosted IR. The default value is the cacerts.pem file
        /// installed with the IR.</param>
        /// <param name="useSystemTrustStore">Specifies whether to use a CA
        /// certificate from the system trust store or from a specified PEM
        /// file. The default value is false.</param>
        /// <param name="allowHostNameCNMismatch">Specifies whether to require
        /// a CA-issued SSL certificate name to match the host name of the
        /// server when connecting over SSL. The default value is
        /// false.</param>
        /// <param name="allowSelfSignedServerCert">Specifies whether to allow
        /// self-signed certificates from the server. The default value is
        /// false.</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Type: string (or Expression with
        /// resultType string).</param>
        public ImpalaLinkedService(object host, string authenticationType, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), object port = default(object), object username = default(object), SecretBase password = default(SecretBase), object enableSsl = default(object), object trustedCertPath = default(object), object useSystemTrustStore = default(object), object allowHostNameCNMismatch = default(object), object allowSelfSignedServerCert = default(object), object encryptedCredential = default(object))
            : base(additionalProperties, connectVia, description)
        {
            Host = host;
            Port = port;
            AuthenticationType = authenticationType;
            Username = username;
            Password = password;
            EnableSsl = enableSsl;
            TrustedCertPath = trustedCertPath;
            UseSystemTrustStore = useSystemTrustStore;
            AllowHostNameCNMismatch = allowHostNameCNMismatch;
            AllowSelfSignedServerCert = allowSelfSignedServerCert;
            EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the IP address or host name of the Impala server.
        /// (i.e. 192.168.222.160)
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.host")]
        public object Host { get; set; }

        /// <summary>
        /// Gets or sets the TCP port that the Impala server uses to listen for
        /// client connections. The default value is 21050.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.port")]
        public object Port { get; set; }

        /// <summary>
        /// Gets or sets the authentication type to use. Possible values
        /// include: 'Anonymous', 'SASLUsername', 'UsernameAndPassword'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.authenticationType")]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// Gets or sets the user name used to access the Impala server. The
        /// default value is anonymous when using SASLUsername.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.username")]
        public object Username { get; set; }

        /// <summary>
        /// Gets or sets the password corresponding to the user name when using
        /// UsernameAndPassword.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.password")]
        public SecretBase Password { get; set; }

        /// <summary>
        /// Gets or sets specifies whether the connections to the server are
        /// encrypted using SSL. The default value is false.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.enableSsl")]
        public object EnableSsl { get; set; }

        /// <summary>
        /// Gets or sets the full path of the .pem file containing trusted CA
        /// certificates for verifying the server when connecting over SSL.
        /// This property can only be set when using SSL on self-hosted IR. The
        /// default value is the cacerts.pem file installed with the IR.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.trustedCertPath")]
        public object TrustedCertPath { get; set; }

        /// <summary>
        /// Gets or sets specifies whether to use a CA certificate from the
        /// system trust store or from a specified PEM file. The default value
        /// is false.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.useSystemTrustStore")]
        public object UseSystemTrustStore { get; set; }

        /// <summary>
        /// Gets or sets specifies whether to require a CA-issued SSL
        /// certificate name to match the host name of the server when
        /// connecting over SSL. The default value is false.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.allowHostNameCNMismatch")]
        public object AllowHostNameCNMismatch { get; set; }

        /// <summary>
        /// Gets or sets specifies whether to allow self-signed certificates
        /// from the server. The default value is false.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.allowSelfSignedServerCert")]
        public object AllowSelfSignedServerCert { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public object EncryptedCredential { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Host == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Host");
            }
            if (AuthenticationType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AuthenticationType");
            }
        }
    }
}
