// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Health.Insights.ClinicalMatching
{
    /// <summary> A clinical document related to a patient. Document here is in the wide sense - not just a text document (note). </summary>
    public partial class PatientDocument
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of PatientDocument. </summary>
        /// <param name="type"> The type of the patient document, such as 'note' (text document) or 'fhirBundle' (FHIR JSON document). </param>
        /// <param name="id"> A given identifier for the document. Has to be unique across all documents for a single patient. </param>
        /// <param name="content"> The content of the patient document. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="content"/> is null. </exception>
        public PatientDocument(DocumentType type, string id, DocumentContent content)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(content, nameof(content));

            Type = type;
            Id = id;
            Content = content;
        }

        /// <summary> Initializes a new instance of PatientDocument. </summary>
        /// <param name="type"> The type of the patient document, such as 'note' (text document) or 'fhirBundle' (FHIR JSON document). </param>
        /// <param name="clinicalType"> The type of the clinical document. </param>
        /// <param name="id"> A given identifier for the document. Has to be unique across all documents for a single patient. </param>
        /// <param name="language"> A 2 letter ISO 639-1 representation of the language of the document. </param>
        /// <param name="createdDateTime"> The date and time when the document was created. </param>
        /// <param name="content"> The content of the patient document. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PatientDocument(DocumentType type, ClinicalDocumentType? clinicalType, string id, string language, DateTimeOffset? createdDateTime, DocumentContent content, Dictionary<string, BinaryData> rawData)
        {
            Type = type;
            ClinicalType = clinicalType;
            Id = id;
            Language = language;
            CreatedDateTime = createdDateTime;
            Content = content;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="PatientDocument"/> for deserialization. </summary>
        internal PatientDocument()
        {
        }

        /// <summary> The type of the patient document, such as 'note' (text document) or 'fhirBundle' (FHIR JSON document). </summary>
        public DocumentType Type { get; }
        /// <summary> The type of the clinical document. </summary>
        public ClinicalDocumentType? ClinicalType { get; set; }
        /// <summary> A given identifier for the document. Has to be unique across all documents for a single patient. </summary>
        public string Id { get; }
        /// <summary> A 2 letter ISO 639-1 representation of the language of the document. </summary>
        public string Language { get; set; }
        /// <summary> The date and time when the document was created. </summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary> The content of the patient document. </summary>
        public DocumentContent Content { get; }
    }
}
