// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary>
    /// The api operations properties
    /// Serialized Name: ApiOperationPropertiesDefinition
    /// </summary>
    public partial class ApiOperationPropertiesDefinition
    {
        /// <summary> Initializes a new instance of ApiOperationPropertiesDefinition. </summary>
        public ApiOperationPropertiesDefinition()
        {
            ResponsesDefinition = new ChangeTrackingDictionary<string, SwaggerSchema>();
        }

        /// <summary> Initializes a new instance of ApiOperationPropertiesDefinition. </summary>
        /// <param name="summary">
        /// The summary of the api operation.
        /// Serialized Name: ApiOperationPropertiesDefinition.summary
        /// </param>
        /// <param name="description">
        /// The description of the api operation.
        /// Serialized Name: ApiOperationPropertiesDefinition.description
        /// </param>
        /// <param name="visibility">
        /// The visibility of the api operation.
        /// Serialized Name: ApiOperationPropertiesDefinition.visibility
        /// </param>
        /// <param name="trigger">
        /// The trigger type of api operation.
        /// Serialized Name: ApiOperationPropertiesDefinition.trigger
        /// </param>
        /// <param name="triggerHint">
        /// The trigger hint for the api operation.
        /// Serialized Name: ApiOperationPropertiesDefinition.triggerHint
        /// </param>
        /// <param name="pageable">
        /// Indicates whether the api operation is pageable.
        /// Serialized Name: ApiOperationPropertiesDefinition.pageable
        /// </param>
        /// <param name="annotation">
        /// The annotation of api operation.
        /// Serialized Name: ApiOperationPropertiesDefinition.annotation
        /// </param>
        /// <param name="api">
        /// The api reference.
        /// Serialized Name: ApiOperationPropertiesDefinition.api
        /// </param>
        /// <param name="inputsDefinition">
        /// The operation inputs definition schema.
        /// Serialized Name: ApiOperationPropertiesDefinition.inputsDefinition
        /// </param>
        /// <param name="responsesDefinition">
        /// The operation responses definition schemas.
        /// Serialized Name: ApiOperationPropertiesDefinition.responsesDefinition
        /// </param>
        /// <param name="isWebhook">
        /// Indicates whether the API operation is webhook or not.
        /// Serialized Name: ApiOperationPropertiesDefinition.isWebhook
        /// </param>
        /// <param name="isNotification">
        /// Indicates whether the API operation is notification or not.
        /// Serialized Name: ApiOperationPropertiesDefinition.isNotification
        /// </param>
        internal ApiOperationPropertiesDefinition(string summary, string description, string visibility, string trigger, string triggerHint, bool? pageable, ApiOperationAnnotation annotation, ApiReference api, SwaggerSchema inputsDefinition, IDictionary<string, SwaggerSchema> responsesDefinition, bool? isWebhook, bool? isNotification)
        {
            Summary = summary;
            Description = description;
            Visibility = visibility;
            Trigger = trigger;
            TriggerHint = triggerHint;
            Pageable = pageable;
            Annotation = annotation;
            Api = api;
            InputsDefinition = inputsDefinition;
            ResponsesDefinition = responsesDefinition;
            IsWebhook = isWebhook;
            IsNotification = isNotification;
        }

        /// <summary>
        /// The summary of the api operation.
        /// Serialized Name: ApiOperationPropertiesDefinition.summary
        /// </summary>
        public string Summary { get; set; }
        /// <summary>
        /// The description of the api operation.
        /// Serialized Name: ApiOperationPropertiesDefinition.description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The visibility of the api operation.
        /// Serialized Name: ApiOperationPropertiesDefinition.visibility
        /// </summary>
        public string Visibility { get; set; }
        /// <summary>
        /// The trigger type of api operation.
        /// Serialized Name: ApiOperationPropertiesDefinition.trigger
        /// </summary>
        public string Trigger { get; set; }
        /// <summary>
        /// The trigger hint for the api operation.
        /// Serialized Name: ApiOperationPropertiesDefinition.triggerHint
        /// </summary>
        public string TriggerHint { get; set; }
        /// <summary>
        /// Indicates whether the api operation is pageable.
        /// Serialized Name: ApiOperationPropertiesDefinition.pageable
        /// </summary>
        public bool? Pageable { get; set; }
        /// <summary>
        /// The annotation of api operation.
        /// Serialized Name: ApiOperationPropertiesDefinition.annotation
        /// </summary>
        public ApiOperationAnnotation Annotation { get; set; }
        /// <summary>
        /// The api reference.
        /// Serialized Name: ApiOperationPropertiesDefinition.api
        /// </summary>
        public ApiReference Api { get; set; }
        /// <summary>
        /// The operation inputs definition schema.
        /// Serialized Name: ApiOperationPropertiesDefinition.inputsDefinition
        /// </summary>
        public SwaggerSchema InputsDefinition { get; set; }
        /// <summary>
        /// The operation responses definition schemas.
        /// Serialized Name: ApiOperationPropertiesDefinition.responsesDefinition
        /// </summary>
        public IDictionary<string, SwaggerSchema> ResponsesDefinition { get; }
        /// <summary>
        /// Indicates whether the API operation is webhook or not.
        /// Serialized Name: ApiOperationPropertiesDefinition.isWebhook
        /// </summary>
        public bool? IsWebhook { get; set; }
        /// <summary>
        /// Indicates whether the API operation is notification or not.
        /// Serialized Name: ApiOperationPropertiesDefinition.isNotification
        /// </summary>
        public bool? IsNotification { get; set; }
    }
}
