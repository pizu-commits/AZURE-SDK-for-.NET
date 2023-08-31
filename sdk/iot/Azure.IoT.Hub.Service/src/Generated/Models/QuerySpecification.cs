// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.IoT.Hub.Service.Models
{
    /// <summary> The Json query request. </summary>
    public partial class QuerySpecification
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="QuerySpecification"/>. </summary>
        public QuerySpecification()
        {
        }

        /// <summary> Initializes a new instance of <see cref="QuerySpecification"/>. </summary>
        /// <param name="query"> The query string. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal QuerySpecification(string query, Dictionary<string, BinaryData> rawData)
        {
            Query = query;
            _rawData = rawData;
        }

        /// <summary> The query string. </summary>
        public string Query { get; set; }
    }
}
