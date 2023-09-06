// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Validation result for configuration service settings. </summary>
    public partial class AppPlatformConfigurationServiceSettingsValidateResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppPlatformConfigurationServiceSettingsValidateResult"/>. </summary>
        internal AppPlatformConfigurationServiceSettingsValidateResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformConfigurationServiceSettingsValidateResult"/>. </summary>
        /// <param name="gitPropertyValidationResult"> Validation result for configuration service settings. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppPlatformConfigurationServiceSettingsValidateResult(AppPlatformConfigurationServiceGitValidateResult gitPropertyValidationResult, Dictionary<string, BinaryData> rawData)
        {
            GitPropertyValidationResult = gitPropertyValidationResult;
            _rawData = rawData;
        }

        /// <summary> Validation result for configuration service settings. </summary>
        public AppPlatformConfigurationServiceGitValidateResult GitPropertyValidationResult { get; }
    }
}
