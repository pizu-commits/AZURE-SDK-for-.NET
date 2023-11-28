// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Communication.Models
{
    /// <summary> Input parameter for verification APIs. </summary>
    public partial class DomainsRecordVerificationContent
    {
        /// <summary> Initializes a new instance of <see cref="DomainsRecordVerificationContent"/>. </summary>
        /// <param name="verificationType"> Type of verification. </param>
        public DomainsRecordVerificationContent(DomainRecordVerificationType verificationType)
        {
            VerificationType = verificationType;
        }

        /// <summary> Type of verification. </summary>
        public DomainRecordVerificationType VerificationType { get; }
    }
}
