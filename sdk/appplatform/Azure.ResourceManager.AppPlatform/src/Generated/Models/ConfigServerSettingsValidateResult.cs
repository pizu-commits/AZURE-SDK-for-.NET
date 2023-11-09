// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Validation result for config server settings. </summary>
    public partial class ConfigServerSettingsValidateResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ConfigServerSettingsValidateResult"/>. </summary>
        internal ConfigServerSettingsValidateResult()
        {
            Details = new ChangeTrackingList<ConfigServerSettingsErrorRecord>();
        }

        /// <summary> Initializes a new instance of <see cref="ConfigServerSettingsValidateResult"/>. </summary>
        /// <param name="isValid"> Indicate if the config server settings are valid. </param>
        /// <param name="details"> The detail validation results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConfigServerSettingsValidateResult(bool? isValid, IReadOnlyList<ConfigServerSettingsErrorRecord> details, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsValid = isValid;
            Details = details;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Indicate if the config server settings are valid. </summary>
        public bool? IsValid { get; }
        /// <summary> The detail validation results. </summary>
        public IReadOnlyList<ConfigServerSettingsErrorRecord> Details { get; }
    }
}
