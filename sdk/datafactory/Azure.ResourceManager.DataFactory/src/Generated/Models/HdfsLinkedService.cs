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
    /// <summary> Hadoop Distributed File System (HDFS) linked service. </summary>
    public partial class HdfsLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="HdfsLinkedService"/>. </summary>
        /// <param name="uri"> The URL of the HDFS service endpoint, e.g. http://myhostname:50070/webhdfs/v1 . Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        public HdfsLinkedService(DataFactoryElement<string> uri)
        {
            Argument.AssertNotNull(uri, nameof(uri));

            Uri = uri;
            LinkedServiceType = "Hdfs";
        }

        /// <summary> Initializes a new instance of <see cref="HdfsLinkedService"/>. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="uri"> The URL of the HDFS service endpoint, e.g. http://myhostname:50070/webhdfs/v1 . Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> Type of authentication used to connect to the HDFS. Possible values are: Anonymous and Windows. Type: string (or Expression with resultType string). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        /// <param name="userName"> User name for Windows authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> Password for Windows authentication. </param>
        internal HdfsLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> uri, DataFactoryElement<string> authenticationType, string encryptedCredential, DataFactoryElement<string> userName, DataFactorySecretBaseDefinition password) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Uri = uri;
            AuthenticationType = authenticationType;
            EncryptedCredential = encryptedCredential;
            UserName = userName;
            Password = password;
            LinkedServiceType = linkedServiceType ?? "Hdfs";
        }

        /// <summary> Initializes a new instance of <see cref="HdfsLinkedService"/> for deserialization. </summary>
        internal HdfsLinkedService()
        {
        }

        /// <summary> The URL of the HDFS service endpoint, e.g. http://myhostname:50070/webhdfs/v1 . Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Uri { get; set; }
        /// <summary> Type of authentication used to connect to the HDFS. Possible values are: Anonymous and Windows. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> AuthenticationType { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
        /// <summary> User name for Windows authentication. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> UserName { get; set; }
        /// <summary> Password for Windows authentication. </summary>
        public DataFactorySecretBaseDefinition Password { get; set; }
    }
}
