// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.IoT.Hub.Service.Models
{
    /// <summary> The ConfigurationQueriesTestInput. </summary>
    public partial class ConfigurationQueriesTestInput
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ConfigurationQueriesTestInput"/>. </summary>
        public ConfigurationQueriesTestInput()
        {
            CustomMetricQueries = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ConfigurationQueriesTestInput"/>. </summary>
        /// <param name="targetCondition"> The query used to define targeted devices or modules. The query is based on twin tags and/or reported properties. </param>
        /// <param name="customMetricQueries"> The key-value pairs with queries and their identifier. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ConfigurationQueriesTestInput(string targetCondition, IDictionary<string, string> customMetricQueries, Dictionary<string, BinaryData> rawData)
        {
            TargetCondition = targetCondition;
            CustomMetricQueries = customMetricQueries;
            _rawData = rawData;
        }

        /// <summary> The query used to define targeted devices or modules. The query is based on twin tags and/or reported properties. </summary>
        public string TargetCondition { get; set; }
        /// <summary> The key-value pairs with queries and their identifier. </summary>
        public IDictionary<string, string> CustomMetricQueries { get; }
    }
}
