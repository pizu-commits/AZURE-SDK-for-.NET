// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.OperationalInsights;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The get schema operation response.
    /// </summary>
    public partial class SearchGetSchemaResponse
    {
        /// <summary>
        /// Initializes a new instance of the SearchGetSchemaResponse class.
        /// </summary>
        public SearchGetSchemaResponse()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SearchGetSchemaResponse class.
        /// </summary>
        /// <param name="metadata">The metadata from search results.</param>
        /// <param name="value">The array of result values.</param>
        public SearchGetSchemaResponse(SearchMetadata metadata = default(SearchMetadata), IList<SearchSchemaValue> value = default(IList<SearchSchemaValue>))
        {
            Metadata = metadata;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the metadata from search results.
        /// </summary>
        [JsonProperty(PropertyName = "__metadata")]
        public SearchMetadata Metadata { get; set; }

        /// <summary>
        /// Gets or sets the array of result values.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<SearchSchemaValue> Value { get; set; }

    }
}
