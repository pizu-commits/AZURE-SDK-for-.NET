// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using Azure;
    using Management;
    using Logic;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The integration account agreement.
    /// </summary>
    [JsonTransformation]
    public partial class IntegrationAccountAgreement : Resource
    {
        /// <summary>
        /// Initializes a new instance of the IntegrationAccountAgreement
        /// class.
        /// </summary>
        public IntegrationAccountAgreement() { }

        /// <summary>
        /// Initializes a new instance of the IntegrationAccountAgreement
        /// class.
        /// </summary>
        /// <param name="agreementType">The agreement type. Possible values
        /// include: 'NotSpecified', 'AS2', 'X12', 'Edifact'</param>
        /// <param name="hostPartner">The integration account partner that is
        /// set as host partner for this agreement.</param>
        /// <param name="guestPartner">The integration account partner that is
        /// set as guest partner for this agreement.</param>
        /// <param name="hostIdentity">The business identity of the host
        /// partner.</param>
        /// <param name="guestIdentity">The business identity of the guest
        /// partner.</param>
        /// <param name="content">The agreement content.</param>
        /// <param name="id">The resource id.</param>
        /// <param name="name">Gets the resource name.</param>
        /// <param name="type">Gets the resource type.</param>
        /// <param name="location">The resource location.</param>
        /// <param name="tags">The resource tags.</param>
        /// <param name="createdTime">The created time.</param>
        /// <param name="changedTime">The changed time.</param>
        /// <param name="metadata">The metadata.</param>
        public IntegrationAccountAgreement(AgreementType agreementType, string hostPartner, string guestPartner, BusinessIdentity hostIdentity, BusinessIdentity guestIdentity, AgreementContent content, string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), System.DateTime? createdTime = default(System.DateTime?), System.DateTime? changedTime = default(System.DateTime?), object metadata = default(object))
            : base(id, name, type, location, tags)
        {
            CreatedTime = createdTime;
            ChangedTime = changedTime;
            Metadata = metadata;
            AgreementType = agreementType;
            HostPartner = hostPartner;
            GuestPartner = guestPartner;
            HostIdentity = hostIdentity;
            GuestIdentity = guestIdentity;
            Content = content;
        }

        /// <summary>
        /// Gets the created time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdTime")]
        public System.DateTime? CreatedTime { get; protected set; }

        /// <summary>
        /// Gets the changed time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.changedTime")]
        public System.DateTime? ChangedTime { get; protected set; }

        /// <summary>
        /// Gets or sets the metadata.
        /// </summary>
        [JsonProperty(PropertyName = "properties.metadata")]
        public object Metadata { get; set; }

        /// <summary>
        /// Gets or sets the agreement type. Possible values include:
        /// 'NotSpecified', 'AS2', 'X12', 'Edifact'
        /// </summary>
        [JsonProperty(PropertyName = "properties.agreementType")]
        public AgreementType AgreementType { get; set; }

        /// <summary>
        /// Gets or sets the integration account partner that is set as host
        /// partner for this agreement.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostPartner")]
        public string HostPartner { get; set; }

        /// <summary>
        /// Gets or sets the integration account partner that is set as guest
        /// partner for this agreement.
        /// </summary>
        [JsonProperty(PropertyName = "properties.guestPartner")]
        public string GuestPartner { get; set; }

        /// <summary>
        /// Gets or sets the business identity of the host partner.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostIdentity")]
        public BusinessIdentity HostIdentity { get; set; }

        /// <summary>
        /// Gets or sets the business identity of the guest partner.
        /// </summary>
        [JsonProperty(PropertyName = "properties.guestIdentity")]
        public BusinessIdentity GuestIdentity { get; set; }

        /// <summary>
        /// Gets or sets the agreement content.
        /// </summary>
        [JsonProperty(PropertyName = "properties.content")]
        public AgreementContent Content { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (HostPartner == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "HostPartner");
            }
            if (GuestPartner == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "GuestPartner");
            }
            if (HostIdentity == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "HostIdentity");
            }
            if (GuestIdentity == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "GuestIdentity");
            }
            if (Content == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Content");
            }
            if (HostIdentity != null)
            {
                HostIdentity.Validate();
            }
            if (GuestIdentity != null)
            {
                GuestIdentity.Validate();
            }
            if (Content != null)
            {
                Content.Validate();
            }
        }
    }
}

