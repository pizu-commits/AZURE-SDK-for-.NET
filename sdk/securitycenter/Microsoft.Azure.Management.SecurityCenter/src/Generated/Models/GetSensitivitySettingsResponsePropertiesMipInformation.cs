// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft information protection built-in and custom information types,
    /// labels, and integration status.
    /// </summary>
    public partial class GetSensitivitySettingsResponsePropertiesMipInformation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GetSensitivitySettingsResponsePropertiesMipInformation class.
        /// </summary>
        public GetSensitivitySettingsResponsePropertiesMipInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// GetSensitivitySettingsResponsePropertiesMipInformation class.
        /// </summary>
        /// <param name="mipIntegrationStatus">Possible values include: 'Ok',
        /// 'noConsent', 'noAutoLabelingRules', 'noMipLabels'</param>
        /// <param name="customInfoTypes">List of custom user-defined
        /// information types</param>
        /// <param name="builtInInfoTypes">List of pre-configured sensitive
        /// information types</param>
        public GetSensitivitySettingsResponsePropertiesMipInformation(string mipIntegrationStatus = default(string), IList<Label> labels = default(IList<Label>), IList<InfoType> customInfoTypes = default(IList<InfoType>), IList<BuiltInInfoType> builtInInfoTypes = default(IList<BuiltInInfoType>))
        {
            MipIntegrationStatus = mipIntegrationStatus;
            Labels = labels;
            CustomInfoTypes = customInfoTypes;
            BuiltInInfoTypes = builtInInfoTypes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'Ok', 'noConsent',
        /// 'noAutoLabelingRules', 'noMipLabels'
        /// </summary>
        [JsonProperty(PropertyName = "mipIntegrationStatus")]
        public string MipIntegrationStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "labels")]
        public IList<Label> Labels { get; set; }

        /// <summary>
        /// Gets or sets list of custom user-defined information types
        /// </summary>
        [JsonProperty(PropertyName = "customInfoTypes")]
        public IList<InfoType> CustomInfoTypes { get; set; }

        /// <summary>
        /// Gets or sets list of pre-configured sensitive information types
        /// </summary>
        [JsonProperty(PropertyName = "builtInInfoTypes")]
        public IList<BuiltInInfoType> BuiltInInfoTypes { get; set; }

    }
}
