// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity Google AdWords service source. </summary>
    public partial class GoogleAdWordsSource : TabularSource
    {
        /// <summary> Initializes a new instance of GoogleAdWordsSource. </summary>
        public GoogleAdWordsSource()
        {
            Type = "GoogleAdWordsSource";
        }

        /// <summary> Initializes a new instance of GoogleAdWordsSource. </summary>
        /// <param name="type"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="queryTimeout"> Query timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="additionalColumns"> Specifies the additional columns to be added to source data. Type: array of objects (or Expression with resultType array of objects). </param>
        /// <param name="query"> A query to retrieve data from source. Type: string (or Expression with resultType string). </param>
        internal GoogleAdWordsSource(string type, object sourceRetryCount, object sourceRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, object queryTimeout, IList<AdditionalColumns> additionalColumns, object query) : base(type, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, additionalProperties, queryTimeout, additionalColumns)
        {
            Query = query;
            Type = type ?? "GoogleAdWordsSource";
        }

        /// <summary> A query to retrieve data from source. Type: string (or Expression with resultType string). </summary>
        public object Query { get; set; }
    }
}
