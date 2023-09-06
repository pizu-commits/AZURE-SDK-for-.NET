// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    /// <summary> Benefit scope response property. </summary>
    public partial class SavingsPlanValidateResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SavingsPlanValidateResult"/>. </summary>
        internal SavingsPlanValidateResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SavingsPlanValidateResult"/>. </summary>
        /// <param name="isValid"> Indicates if the provided input was valid. </param>
        /// <param name="reasonCode"> Failure reason code if the provided input was invalid. </param>
        /// <param name="reason"> Failure reason if the provided input was invalid. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SavingsPlanValidateResult(bool? isValid, string reasonCode, string reason, Dictionary<string, BinaryData> rawData)
        {
            IsValid = isValid;
            ReasonCode = reasonCode;
            Reason = reason;
            _rawData = rawData;
        }

        /// <summary> Indicates if the provided input was valid. </summary>
        public bool? IsValid { get; }
        /// <summary> Failure reason code if the provided input was invalid. </summary>
        public string ReasonCode { get; }
        /// <summary> Failure reason if the provided input was invalid. </summary>
        public string Reason { get; }
    }
}
