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
    /// <summary> Linked service for Twilio. </summary>
    public partial class TwilioLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="TwilioLinkedService"/>. </summary>
        /// <param name="userName"> The Account SID of Twilio service. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> The auth token of Twilio service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userName"/> or <paramref name="password"/> is null. </exception>
        public TwilioLinkedService(DataFactoryElement<string> userName, DataFactorySecretBaseDefinition password)
        {
            Argument.AssertNotNull(userName, nameof(userName));
            Argument.AssertNotNull(password, nameof(password));

            UserName = userName;
            Password = password;
            LinkedServiceType = "Twilio";
        }

        /// <summary> Initializes a new instance of <see cref="TwilioLinkedService"/>. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="userName"> The Account SID of Twilio service. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> The auth token of Twilio service. </param>
        internal TwilioLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> userName, DataFactorySecretBaseDefinition password) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            UserName = userName;
            Password = password;
            LinkedServiceType = linkedServiceType ?? "Twilio";
        }

        /// <summary> Initializes a new instance of <see cref="TwilioLinkedService"/> for deserialization. </summary>
        internal TwilioLinkedService()
        {
        }

        /// <summary> The Account SID of Twilio service. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> UserName { get; set; }
        /// <summary> The auth token of Twilio service. </summary>
        public DataFactorySecretBaseDefinition Password { get; set; }
    }
}
