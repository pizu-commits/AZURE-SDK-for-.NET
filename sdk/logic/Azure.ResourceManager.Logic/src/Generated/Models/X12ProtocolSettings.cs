// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The X12 agreement protocol settings. </summary>
    public partial class X12ProtocolSettings
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="X12ProtocolSettings"/>. </summary>
        /// <param name="validationSettings"> The X12 validation settings. </param>
        /// <param name="framingSettings"> The X12 framing settings. </param>
        /// <param name="envelopeSettings"> The X12 envelope settings. </param>
        /// <param name="acknowledgementSettings"> The X12 acknowledgment settings. </param>
        /// <param name="messageFilter"> The X12 message filter. </param>
        /// <param name="securitySettings"> The X12 security settings. </param>
        /// <param name="processingSettings"> The X12 processing settings. </param>
        /// <param name="schemaReferences"> The X12 schema references. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="validationSettings"/>, <paramref name="framingSettings"/>, <paramref name="envelopeSettings"/>, <paramref name="acknowledgementSettings"/>, <paramref name="messageFilter"/>, <paramref name="securitySettings"/>, <paramref name="processingSettings"/> or <paramref name="schemaReferences"/> is null. </exception>
        public X12ProtocolSettings(X12ValidationSettings validationSettings, X12FramingSettings framingSettings, X12EnvelopeSettings envelopeSettings, X12AcknowledgementSettings acknowledgementSettings, X12MessageFilter messageFilter, X12SecuritySettings securitySettings, X12ProcessingSettings processingSettings, IEnumerable<X12SchemaReference> schemaReferences)
        {
            Argument.AssertNotNull(validationSettings, nameof(validationSettings));
            Argument.AssertNotNull(framingSettings, nameof(framingSettings));
            Argument.AssertNotNull(envelopeSettings, nameof(envelopeSettings));
            Argument.AssertNotNull(acknowledgementSettings, nameof(acknowledgementSettings));
            Argument.AssertNotNull(messageFilter, nameof(messageFilter));
            Argument.AssertNotNull(securitySettings, nameof(securitySettings));
            Argument.AssertNotNull(processingSettings, nameof(processingSettings));
            Argument.AssertNotNull(schemaReferences, nameof(schemaReferences));

            ValidationSettings = validationSettings;
            FramingSettings = framingSettings;
            EnvelopeSettings = envelopeSettings;
            AcknowledgementSettings = acknowledgementSettings;
            MessageFilter = messageFilter;
            SecuritySettings = securitySettings;
            ProcessingSettings = processingSettings;
            EnvelopeOverrides = new ChangeTrackingList<X12EnvelopeOverride>();
            ValidationOverrides = new ChangeTrackingList<X12ValidationOverride>();
            MessageFilterList = new ChangeTrackingList<X12MessageIdentifier>();
            SchemaReferences = schemaReferences.ToList();
            X12DelimiterOverrides = new ChangeTrackingList<X12DelimiterOverrides>();
        }

        /// <summary> Initializes a new instance of <see cref="X12ProtocolSettings"/>. </summary>
        /// <param name="validationSettings"> The X12 validation settings. </param>
        /// <param name="framingSettings"> The X12 framing settings. </param>
        /// <param name="envelopeSettings"> The X12 envelope settings. </param>
        /// <param name="acknowledgementSettings"> The X12 acknowledgment settings. </param>
        /// <param name="messageFilter"> The X12 message filter. </param>
        /// <param name="securitySettings"> The X12 security settings. </param>
        /// <param name="processingSettings"> The X12 processing settings. </param>
        /// <param name="envelopeOverrides"> The X12 envelope override settings. </param>
        /// <param name="validationOverrides"> The X12 validation override settings. </param>
        /// <param name="messageFilterList"> The X12 message filter list. </param>
        /// <param name="schemaReferences"> The X12 schema references. </param>
        /// <param name="x12DelimiterOverrides"> The X12 delimiter override settings. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal X12ProtocolSettings(X12ValidationSettings validationSettings, X12FramingSettings framingSettings, X12EnvelopeSettings envelopeSettings, X12AcknowledgementSettings acknowledgementSettings, X12MessageFilter messageFilter, X12SecuritySettings securitySettings, X12ProcessingSettings processingSettings, IList<X12EnvelopeOverride> envelopeOverrides, IList<X12ValidationOverride> validationOverrides, IList<X12MessageIdentifier> messageFilterList, IList<X12SchemaReference> schemaReferences, IList<X12DelimiterOverrides> x12DelimiterOverrides, Dictionary<string, BinaryData> rawData)
        {
            ValidationSettings = validationSettings;
            FramingSettings = framingSettings;
            EnvelopeSettings = envelopeSettings;
            AcknowledgementSettings = acknowledgementSettings;
            MessageFilter = messageFilter;
            SecuritySettings = securitySettings;
            ProcessingSettings = processingSettings;
            EnvelopeOverrides = envelopeOverrides;
            ValidationOverrides = validationOverrides;
            MessageFilterList = messageFilterList;
            SchemaReferences = schemaReferences;
            X12DelimiterOverrides = x12DelimiterOverrides;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="X12ProtocolSettings"/> for deserialization. </summary>
        internal X12ProtocolSettings()
        {
        }

        /// <summary> The X12 validation settings. </summary>
        public X12ValidationSettings ValidationSettings { get; set; }
        /// <summary> The X12 framing settings. </summary>
        public X12FramingSettings FramingSettings { get; set; }
        /// <summary> The X12 envelope settings. </summary>
        public X12EnvelopeSettings EnvelopeSettings { get; set; }
        /// <summary> The X12 acknowledgment settings. </summary>
        public X12AcknowledgementSettings AcknowledgementSettings { get; set; }
        /// <summary> The X12 message filter. </summary>
        internal X12MessageFilter MessageFilter { get; set; }
        /// <summary> The message filter type. </summary>
        public MessageFilterType? MessageFilterType
        {
            get => MessageFilter is null ? default(MessageFilterType?) : MessageFilter.MessageFilterType;
            set
            {
                MessageFilter = value.HasValue ? new X12MessageFilter(value.Value) : null;
            }
        }

        /// <summary> The X12 security settings. </summary>
        public X12SecuritySettings SecuritySettings { get; set; }
        /// <summary> The X12 processing settings. </summary>
        public X12ProcessingSettings ProcessingSettings { get; set; }
        /// <summary> The X12 envelope override settings. </summary>
        public IList<X12EnvelopeOverride> EnvelopeOverrides { get; }
        /// <summary> The X12 validation override settings. </summary>
        public IList<X12ValidationOverride> ValidationOverrides { get; }
        /// <summary> The X12 message filter list. </summary>
        public IList<X12MessageIdentifier> MessageFilterList { get; }
        /// <summary> The X12 schema references. </summary>
        public IList<X12SchemaReference> SchemaReferences { get; }
        /// <summary> The X12 delimiter override settings. </summary>
        public IList<X12DelimiterOverrides> X12DelimiterOverrides { get; }
    }
}
