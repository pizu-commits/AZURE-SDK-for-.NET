// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary>
    /// The Edifact agreement content.
    /// Serialized Name: EdifactAgreementContent
    /// </summary>
    public partial class EdifactAgreementContent
    {
        /// <summary> Initializes a new instance of EdifactAgreementContent. </summary>
        /// <param name="receiveAgreement">
        /// The EDIFACT one-way receive agreement.
        /// Serialized Name: EdifactAgreementContent.receiveAgreement
        /// </param>
        /// <param name="sendAgreement">
        /// The EDIFACT one-way send agreement.
        /// Serialized Name: EdifactAgreementContent.sendAgreement
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="receiveAgreement"/> or <paramref name="sendAgreement"/> is null. </exception>
        public EdifactAgreementContent(EdifactOneWayAgreement receiveAgreement, EdifactOneWayAgreement sendAgreement)
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
        /// The EDIFACT one-way receive agreement.
        /// Serialized Name: EdifactAgreementContent.receiveAgreement
        /// </summary>
        public EdifactOneWayAgreement ReceiveAgreement { get; set; }
        /// <summary>
        /// The EDIFACT one-way send agreement.
        /// Serialized Name: EdifactAgreementContent.sendAgreement
        /// </summary>
        public EdifactOneWayAgreement SendAgreement { get; set; }
    }
}
