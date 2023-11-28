// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Validation result for custom domain. </summary>
    public partial class AppPlatformCustomDomainValidateResult
    {
        /// <summary> Initializes a new instance of <see cref="AppPlatformCustomDomainValidateResult"/>. </summary>
        internal AppPlatformCustomDomainValidateResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformCustomDomainValidateResult"/>. </summary>
        /// <param name="isValid"> Indicates if domain name is valid. </param>
        /// <param name="message"> Message of why domain name is invalid. </param>
        internal AppPlatformCustomDomainValidateResult(bool? isValid, string message)
        {
            IsValid = isValid;
            Message = message;
        }

        /// <summary> Indicates if domain name is valid. </summary>
        public bool? IsValid { get; }
        /// <summary> Message of why domain name is invalid. </summary>
        public string Message { get; }
    }
}
