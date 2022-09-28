// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Operation status extended info for ValidateOperation action. </summary>
    public partial class OperationStatusValidateOperationExtendedInfo : OperationStatusExtendedInfo
    {
        /// <summary> Initializes a new instance of OperationStatusValidateOperationExtendedInfo. </summary>
        internal OperationStatusValidateOperationExtendedInfo()
        {
            ObjectType = "OperationStatusValidateOperationExtendedInfo";
        }

        /// <summary> Initializes a new instance of OperationStatusValidateOperationExtendedInfo. </summary>
        /// <param name="objectType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="validateOperationResponse"> Gets the validation operation response. </param>
        internal OperationStatusValidateOperationExtendedInfo(string objectType, ValidateOperationResponse validateOperationResponse) : base(objectType)
        {
            ValidateOperationResponse = validateOperationResponse;
            ObjectType = objectType ?? "OperationStatusValidateOperationExtendedInfo";
        }

        /// <summary> Gets the validation operation response. </summary>
        internal ValidateOperationResponse ValidateOperationResponse { get; }
        /// <summary> Gets the validation result. </summary>
        public IReadOnlyList<ErrorDetail> ValidateOperationResponseValidationResults
        {
            get => ValidateOperationResponse?.ValidationResults;
        }
    }
}
