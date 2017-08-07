// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Logic;
    using Microsoft.Azure.Management.Logic.Fluent;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The X12 agreement content.
    /// </summary>
    public partial class X12AgreementContent
    {
        /// <summary>
        /// Initializes a new instance of the X12AgreementContent class.
        /// </summary>
        public X12AgreementContent()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the X12AgreementContent class.
        /// </summary>
        /// <param name="receiveAgreement">The X12 one-way receive
        /// agreement.</param>
        /// <param name="sendAgreement">The X12 one-way send agreement.</param>
        public X12AgreementContent(X12OneWayAgreement receiveAgreement, X12OneWayAgreement sendAgreement)
        {
            ReceiveAgreement = receiveAgreement;
            SendAgreement = sendAgreement;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the X12 one-way receive agreement.
        /// </summary>
        [JsonProperty(PropertyName = "receiveAgreement")]
        public X12OneWayAgreement ReceiveAgreement { get; set; }

        /// <summary>
        /// Gets or sets the X12 one-way send agreement.
        /// </summary>
        [JsonProperty(PropertyName = "sendAgreement")]
        public X12OneWayAgreement SendAgreement { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ReceiveAgreement == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ReceiveAgreement");
            }
            if (SendAgreement == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SendAgreement");
            }
            if (ReceiveAgreement != null)
            {
                ReceiveAgreement.Validate();
            }
            if (SendAgreement != null)
            {
                SendAgreement.Validate();
            }
        }
    }
}
