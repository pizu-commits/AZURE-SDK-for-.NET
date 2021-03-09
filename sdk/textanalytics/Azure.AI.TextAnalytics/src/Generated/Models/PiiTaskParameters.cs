// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The PiiTaskParameters. </summary>
    internal partial class PiiTaskParameters
    {
        /// <summary> Initializes a new instance of PiiTaskParameters. </summary>
        public PiiTaskParameters()
        {
            PiiCategories = new ChangeTrackingList<PiiEntityCategory>();
        }

        public PiiTaskParametersDomain? Domain { get; set; }
        public string ModelVersion { get; set; }
        /// <summary> (Optional) describes the PII categories to return. </summary>
        public IList<PiiEntityCategory> PiiCategories { get; }
        public StringIndexType? StringIndexType { get; set; }
    }
}
