// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary>
    /// The integration account AS2 agreement content.
    /// Serialized Name: AS2AgreementContent
    /// </summary>
    public partial class AS2AgreementContent
    {
        /// <summary> Initializes a new instance of AS2AgreementContent. </summary>
        /// <param name="receiveAgreement">
        /// The AS2 one-way receive agreement.
        /// Serialized Name: AS2AgreementContent.receiveAgreement
        /// </param>
        /// <param name="sendAgreement">
        /// The AS2 one-way send agreement.
        /// Serialized Name: AS2AgreementContent.sendAgreement
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="receiveAgreement"/> or <paramref name="sendAgreement"/> is null. </exception>
        public AS2AgreementContent(AS2OneWayAgreement receiveAgreement, AS2OneWayAgreement sendAgreement)
        {
            if (receiveAgreement == null)
            {
                throw new ArgumentNullException(nameof(receiveAgreement));
            }
            if (sendAgreement == null)
            {
                throw new ArgumentNullException(nameof(sendAgreement));
            }

            ReceiveAgreement = receiveAgreement;
            SendAgreement = sendAgreement;
        }

        /// <summary>
        /// The AS2 one-way receive agreement.
        /// Serialized Name: AS2AgreementContent.receiveAgreement
        /// </summary>
        public AS2OneWayAgreement ReceiveAgreement { get; set; }
        /// <summary>
        /// The AS2 one-way send agreement.
        /// Serialized Name: AS2AgreementContent.sendAgreement
        /// </summary>
        public AS2OneWayAgreement SendAgreement { get; set; }
    }
}
