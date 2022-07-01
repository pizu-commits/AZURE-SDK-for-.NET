// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A copy activity Dynamics CRM source. </summary>
    public partial class DynamicsCrmSource : CopySource
    {
        /// <summary> Initializes a new instance of DynamicsCrmSource. </summary>
        public DynamicsCrmSource()
        {
            CopySourceType = "DynamicsCrmSource";
        }

        /// <summary> Initializes a new instance of DynamicsCrmSource. </summary>
        /// <param name="copySourceType"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="query"> FetchXML is a proprietary query language that is used in Microsoft Dynamics CRM (online &amp; on-premises). Type: string (or Expression with resultType string). </param>
        /// <param name="additionalColumns"> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </param>
        internal DynamicsCrmSource(string copySourceType, BinaryData sourceRetryCount, BinaryData sourceRetryWait, BinaryData maxConcurrentConnections, BinaryData disableMetricsCollection, IDictionary<string, BinaryData> additionalProperties, BinaryData query, BinaryData additionalColumns) : base(copySourceType, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, disableMetricsCollection, additionalProperties)
        {
            Query = query;
            AdditionalColumns = additionalColumns;
            CopySourceType = copySourceType ?? "DynamicsCrmSource";
        }

        /// <summary> FetchXML is a proprietary query language that is used in Microsoft Dynamics CRM (online &amp; on-premises). Type: string (or Expression with resultType string). </summary>
        public BinaryData Query { get; set; }
        /// <summary> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </summary>
        public BinaryData AdditionalColumns { get; set; }
    }
}
