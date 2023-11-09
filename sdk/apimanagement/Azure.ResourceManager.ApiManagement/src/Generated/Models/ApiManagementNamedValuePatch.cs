// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> NamedValue update Parameters. </summary>
    public partial class ApiManagementNamedValuePatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ApiManagementNamedValuePatch"/>. </summary>
        public ApiManagementNamedValuePatch()
        {
            Tags = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementNamedValuePatch"/>. </summary>
        /// <param name="tags"> Optional tags that when provided can be used to filter the NamedValue list. </param>
        /// <param name="isSecret"> Determines whether the value is a secret and should be encrypted or not. Default value is false. </param>
        /// <param name="displayName"> Unique name of NamedValue. It may contain only letters, digits, period, dash, and underscore characters. </param>
        /// <param name="value"> Value of the NamedValue. Can contain policy expressions. It may not be empty or consist only of whitespace. </param>
        /// <param name="keyVault"> KeyVault location details of the namedValue. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiManagementNamedValuePatch(IList<string> tags, bool? isSecret, string displayName, string value, KeyVaultContractCreateProperties keyVault, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            IsSecret = isSecret;
            DisplayName = displayName;
            Value = value;
            KeyVault = keyVault;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Optional tags that when provided can be used to filter the NamedValue list. </summary>
        public IList<string> Tags { get; }
        /// <summary> Determines whether the value is a secret and should be encrypted or not. Default value is false. </summary>
        public bool? IsSecret { get; set; }
        /// <summary> Unique name of NamedValue. It may contain only letters, digits, period, dash, and underscore characters. </summary>
        public string DisplayName { get; set; }
        /// <summary> Value of the NamedValue. Can contain policy expressions. It may not be empty or consist only of whitespace. </summary>
        public string Value { get; set; }
        /// <summary> KeyVault location details of the namedValue. </summary>
        public KeyVaultContractCreateProperties KeyVault { get; set; }
    }
}
