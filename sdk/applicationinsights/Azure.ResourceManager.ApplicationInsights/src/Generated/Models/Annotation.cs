// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> Annotation associated with an application insights resource. </summary>
    public partial class Annotation
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="Annotation"/>. </summary>
        public Annotation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="Annotation"/>. </summary>
        /// <param name="annotationName"> Name of annotation. </param>
        /// <param name="category"> Category of annotation, free form. </param>
        /// <param name="eventOn"> Time when event occurred. </param>
        /// <param name="id"> Unique Id for annotation. </param>
        /// <param name="properties"> Serialized JSON object for detailed properties. </param>
        /// <param name="relatedAnnotation"> Related parent annotation if any. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal Annotation(string annotationName, string category, DateTimeOffset? eventOn, string id, string properties, string relatedAnnotation, Dictionary<string, BinaryData> rawData)
        {
            AnnotationName = annotationName;
            Category = category;
            EventOn = eventOn;
            Id = id;
            Properties = properties;
            RelatedAnnotation = relatedAnnotation;
            _rawData = rawData;
        }

        /// <summary> Name of annotation. </summary>
        public string AnnotationName { get; set; }
        /// <summary> Category of annotation, free form. </summary>
        public string Category { get; set; }
        /// <summary> Time when event occurred. </summary>
        public DateTimeOffset? EventOn { get; set; }
        /// <summary> Unique Id for annotation. </summary>
        public string Id { get; set; }
        /// <summary> Serialized JSON object for detailed properties. </summary>
        public string Properties { get; set; }
        /// <summary> Related parent annotation if any. </summary>
        public string RelatedAnnotation { get; set; }
    }
}
