// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The X12 agreement content. </summary>
    public partial class X12AgreementContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="X12AgreementContent"/>. </summary>
        /// <param name="receiveAgreement"> The X12 one-way receive agreement. </param>
        /// <param name="sendAgreement"> The X12 one-way send agreement. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="receiveAgreement"/> or <paramref name="sendAgreement"/> is null. </exception>
        public X12AgreementContent(X12OneWayAgreement receiveAgreement, X12OneWayAgreement sendAgreement)
        {
            Argument.AssertNotNull(receiveAgreement, nameof(receiveAgreement));
            Argument.AssertNotNull(sendAgreement, nameof(sendAgreement));

            ReceiveAgreement = receiveAgreement;
            SendAgreement = sendAgreement;
        }

        /// <summary> Initializes a new instance of <see cref="X12AgreementContent"/>. </summary>
        /// <param name="receiveAgreement"> The X12 one-way receive agreement. </param>
        /// <param name="sendAgreement"> The X12 one-way send agreement. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal X12AgreementContent(X12OneWayAgreement receiveAgreement, X12OneWayAgreement sendAgreement, Dictionary<string, BinaryData> rawData)
        {
            ReceiveAgreement = receiveAgreement;
            SendAgreement = sendAgreement;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="X12AgreementContent"/> for deserialization. </summary>
        internal X12AgreementContent()
        {
        }

        /// <summary> The X12 one-way receive agreement. </summary>
        public X12OneWayAgreement ReceiveAgreement { get; set; }
        /// <summary> The X12 one-way send agreement. </summary>
        public X12OneWayAgreement SendAgreement { get; set; }
    }
}
