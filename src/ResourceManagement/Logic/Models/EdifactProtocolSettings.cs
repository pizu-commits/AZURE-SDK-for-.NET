// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Logic;
    using Microsoft.Azure.Management.Logic.Fluent;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The Edifact agreement protocol settings.
    /// </summary>
    public partial class EdifactProtocolSettings
    {
        /// <summary>
        /// Initializes a new instance of the EdifactProtocolSettings class.
        /// </summary>
        public EdifactProtocolSettings()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EdifactProtocolSettings class.
        /// </summary>
        /// <param name="validationSettings">The EDIFACT validation
        /// settings.</param>
        /// <param name="framingSettings">The EDIFACT framing settings.</param>
        /// <param name="envelopeSettings">The EDIFACT envelope
        /// settings.</param>
        /// <param name="acknowledgementSettings">The EDIFACT acknowledgement
        /// settings.</param>
        /// <param name="messageFilter">The EDIFACT message filter.</param>
        /// <param name="processingSettings">The EDIFACT processing
        /// Settings.</param>
        /// <param name="schemaReferences">The EDIFACT schema
        /// references.</param>
        /// <param name="envelopeOverrides">The EDIFACT envelope override
        /// settings.</param>
        /// <param name="messageFilterList">The EDIFACT message filter
        /// list.</param>
        /// <param name="validationOverrides">The EDIFACT validation override
        /// settings.</param>
        /// <param name="edifactDelimiterOverrides">The EDIFACT delimiter
        /// override settings.</param>
        public EdifactProtocolSettings(EdifactValidationSettings validationSettings, EdifactFramingSettings framingSettings, EdifactEnvelopeSettings envelopeSettings, EdifactAcknowledgementSettings acknowledgementSettings, EdifactMessageFilter messageFilter, EdifactProcessingSettings processingSettings, IList<EdifactSchemaReference> schemaReferences, IList<EdifactEnvelopeOverride> envelopeOverrides = default(IList<EdifactEnvelopeOverride>), IList<EdifactMessageIdentifier> messageFilterList = default(IList<EdifactMessageIdentifier>), IList<EdifactValidationOverride> validationOverrides = default(IList<EdifactValidationOverride>), IList<EdifactDelimiterOverride> edifactDelimiterOverrides = default(IList<EdifactDelimiterOverride>))
        {
            ValidationSettings = validationSettings;
            FramingSettings = framingSettings;
            EnvelopeSettings = envelopeSettings;
            AcknowledgementSettings = acknowledgementSettings;
            MessageFilter = messageFilter;
            ProcessingSettings = processingSettings;
            EnvelopeOverrides = envelopeOverrides;
            MessageFilterList = messageFilterList;
            SchemaReferences = schemaReferences;
            ValidationOverrides = validationOverrides;
            EdifactDelimiterOverrides = edifactDelimiterOverrides;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the EDIFACT validation settings.
        /// </summary>
        [JsonProperty(PropertyName = "validationSettings")]
        public EdifactValidationSettings ValidationSettings { get; set; }

        /// <summary>
        /// Gets or sets the EDIFACT framing settings.
        /// </summary>
        [JsonProperty(PropertyName = "framingSettings")]
        public EdifactFramingSettings FramingSettings { get; set; }

        /// <summary>
        /// Gets or sets the EDIFACT envelope settings.
        /// </summary>
        [JsonProperty(PropertyName = "envelopeSettings")]
        public EdifactEnvelopeSettings EnvelopeSettings { get; set; }

        /// <summary>
        /// Gets or sets the EDIFACT acknowledgement settings.
        /// </summary>
        [JsonProperty(PropertyName = "acknowledgementSettings")]
        public EdifactAcknowledgementSettings AcknowledgementSettings { get; set; }

        /// <summary>
        /// Gets or sets the EDIFACT message filter.
        /// </summary>
        [JsonProperty(PropertyName = "messageFilter")]
        public EdifactMessageFilter MessageFilter { get; set; }

        /// <summary>
        /// Gets or sets the EDIFACT processing Settings.
        /// </summary>
        [JsonProperty(PropertyName = "processingSettings")]
        public EdifactProcessingSettings ProcessingSettings { get; set; }

        /// <summary>
        /// Gets or sets the EDIFACT envelope override settings.
        /// </summary>
        [JsonProperty(PropertyName = "envelopeOverrides")]
        public IList<EdifactEnvelopeOverride> EnvelopeOverrides { get; set; }

        /// <summary>
        /// Gets or sets the EDIFACT message filter list.
        /// </summary>
        [JsonProperty(PropertyName = "messageFilterList")]
        public IList<EdifactMessageIdentifier> MessageFilterList { get; set; }

        /// <summary>
        /// Gets or sets the EDIFACT schema references.
        /// </summary>
        [JsonProperty(PropertyName = "schemaReferences")]
        public IList<EdifactSchemaReference> SchemaReferences { get; set; }

        /// <summary>
        /// Gets or sets the EDIFACT validation override settings.
        /// </summary>
        [JsonProperty(PropertyName = "validationOverrides")]
        public IList<EdifactValidationOverride> ValidationOverrides { get; set; }

        /// <summary>
        /// Gets or sets the EDIFACT delimiter override settings.
        /// </summary>
        [JsonProperty(PropertyName = "edifactDelimiterOverrides")]
        public IList<EdifactDelimiterOverride> EdifactDelimiterOverrides { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ValidationSettings == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ValidationSettings");
            }
            if (FramingSettings == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FramingSettings");
            }
            if (EnvelopeSettings == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "EnvelopeSettings");
            }
            if (AcknowledgementSettings == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AcknowledgementSettings");
            }
            if (MessageFilter == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MessageFilter");
            }
            if (ProcessingSettings == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ProcessingSettings");
            }
            if (SchemaReferences == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SchemaReferences");
            }
            if (ValidationSettings != null)
            {
                ValidationSettings.Validate();
            }
            if (FramingSettings != null)
            {
                FramingSettings.Validate();
            }
            if (EnvelopeSettings != null)
            {
                EnvelopeSettings.Validate();
            }
            if (AcknowledgementSettings != null)
            {
                AcknowledgementSettings.Validate();
            }
            if (MessageFilter != null)
            {
                MessageFilter.Validate();
            }
            if (ProcessingSettings != null)
            {
                ProcessingSettings.Validate();
            }
            if (MessageFilterList != null)
            {
                foreach (var element in MessageFilterList)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (SchemaReferences != null)
            {
                foreach (var element1 in SchemaReferences)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (ValidationOverrides != null)
            {
                foreach (var element2 in ValidationOverrides)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
            if (EdifactDelimiterOverrides != null)
            {
                foreach (var element3 in EdifactDelimiterOverrides)
                {
                    if (element3 != null)
                    {
                        element3.Validate();
                    }
                }
            }
        }
    }
}
