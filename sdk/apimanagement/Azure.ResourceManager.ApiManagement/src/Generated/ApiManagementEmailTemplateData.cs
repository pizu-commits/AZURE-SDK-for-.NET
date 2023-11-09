// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ApiManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing the ApiManagementEmailTemplate data model.
    /// Email Template details.
    /// </summary>
    public partial class ApiManagementEmailTemplateData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ApiManagementEmailTemplateData"/>. </summary>
        public ApiManagementEmailTemplateData()
        {
            Parameters = new ChangeTrackingList<EmailTemplateParametersContractProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementEmailTemplateData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="subject"> Subject of the Template. </param>
        /// <param name="body"> Email Template Body. This should be a valid XDocument. </param>
        /// <param name="title"> Title of the Template. </param>
        /// <param name="description"> Description of the Email Template. </param>
        /// <param name="isDefault"> Whether the template is the default template provided by API Management or has been edited. </param>
        /// <param name="parameters"> Email Template Parameter values. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiManagementEmailTemplateData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string subject, string body, string title, string description, bool? isDefault, IList<EmailTemplateParametersContractProperties> parameters, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Subject = subject;
            Body = body;
            Title = title;
            Description = description;
            IsDefault = isDefault;
            Parameters = parameters;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Subject of the Template. </summary>
        public string Subject { get; set; }
        /// <summary> Email Template Body. This should be a valid XDocument. </summary>
        public string Body { get; set; }
        /// <summary> Title of the Template. </summary>
        public string Title { get; set; }
        /// <summary> Description of the Email Template. </summary>
        public string Description { get; set; }
        /// <summary> Whether the template is the default template provided by API Management or has been edited. </summary>
        public bool? IsDefault { get; }
        /// <summary> Email Template Parameter values. </summary>
        public IList<EmailTemplateParametersContractProperties> Parameters { get; }
    }
}
