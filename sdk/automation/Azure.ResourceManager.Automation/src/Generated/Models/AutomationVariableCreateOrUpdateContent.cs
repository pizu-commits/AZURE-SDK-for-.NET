// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the create or update variable operation. </summary>
    public partial class AutomationVariableCreateOrUpdateContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AutomationVariableCreateOrUpdateContent"/>. </summary>
        /// <param name="name"> Gets or sets the name of the variable. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public AutomationVariableCreateOrUpdateContent(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="AutomationVariableCreateOrUpdateContent"/>. </summary>
        /// <param name="name"> Gets or sets the name of the variable. </param>
        /// <param name="value"> Gets or sets the value of the variable. </param>
        /// <param name="description"> Gets or sets the description of the variable. </param>
        /// <param name="isEncrypted"> Gets or sets the encrypted flag of the variable. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomationVariableCreateOrUpdateContent(string name, string value, string description, bool? isEncrypted, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Value = value;
            Description = description;
            IsEncrypted = isEncrypted;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AutomationVariableCreateOrUpdateContent"/> for deserialization. </summary>
        internal AutomationVariableCreateOrUpdateContent()
        {
        }

        /// <summary> Gets or sets the name of the variable. </summary>
        public string Name { get; }
        /// <summary> Gets or sets the value of the variable. </summary>
        public string Value { get; set; }
        /// <summary> Gets or sets the description of the variable. </summary>
        public string Description { get; set; }
        /// <summary> Gets or sets the encrypted flag of the variable. </summary>
        public bool? IsEncrypted { get; set; }
    }
}
