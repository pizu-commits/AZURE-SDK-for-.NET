// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.Sms
{
    /// <summary> Response for a single recipient. </summary>
    public partial class SmsSendResult
    {
        /// <summary> Initializes a new instance of SmsSendResult. </summary>
        /// <param name="to"> The recipients&apos;s phone number in E.164 format. </param>
        /// <param name="httpStatusCode"> HTTP Status code. </param>
        /// <param name="succeeded"> Flag to check if message processing succeeded or not. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="to"/> is null. </exception>
        internal SmsSendResult(string to, int httpStatusCode, bool succeeded)
        {
            if (to == null)
            {
                throw new ArgumentNullException(nameof(to));
            }

            To = to;
            HttpStatusCode = httpStatusCode;
            Succeeded = succeeded;
        }

        /// <summary> Initializes a new instance of SmsSendResult. </summary>
        /// <param name="to"> The recipients&apos;s phone number in E.164 format. </param>
        /// <param name="messageId"> The identifier of the outgoing SMS message. Only present if message processed. </param>
        /// <param name="httpStatusCode"> HTTP Status code. </param>
        /// <param name="succeeded"> Flag to check if message processing succeeded or not. </param>
        /// <param name="errorMessage"> Optional error message in case of 4xx or 5xx errors. </param>
        internal SmsSendResult(string to, string messageId, int httpStatusCode, bool succeeded, string errorMessage)
        {
            To = to;
            MessageId = messageId;
            HttpStatusCode = httpStatusCode;
            Succeeded = succeeded;
            ErrorMessage = errorMessage;
        }

        /// <summary> The recipients&apos;s phone number in E.164 format. </summary>
        public string To { get; }
        /// <summary> The identifier of the outgoing SMS message. Only present if message processed. </summary>
        public string MessageId { get; }
        /// <summary> HTTP Status code. </summary>
        public int HttpStatusCode { get; }
        /// <summary> Flag to check if message processing succeeded or not. </summary>
        public bool Succeeded { get; }
        /// <summary> Optional error message in case of 4xx or 5xx errors. </summary>
        public string ErrorMessage { get; }
    }
}
