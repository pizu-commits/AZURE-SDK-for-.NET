// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Email Template Parameter contract. </summary>
    public partial class EmailTemplateParametersContractProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="EmailTemplateParametersContractProperties"/>. </summary>
        public EmailTemplateParametersContractProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EmailTemplateParametersContractProperties"/>. </summary>
        /// <param name="name"> Template parameter name. </param>
        /// <param name="title"> Template parameter title. </param>
        /// <param name="description"> Template parameter description. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EmailTemplateParametersContractProperties(string name, string title, string description, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Title = title;
            Description = description;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Template parameter name. </summary>
        public string Name { get; set; }
        /// <summary> Template parameter title. </summary>
        public string Title { get; set; }
        /// <summary> Template parameter description. </summary>
        public string Description { get; set; }
    }
}
