// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> Resource metrics service provided by Microsoft.Insights resource provider. </summary>
    public partial class ServiceSpecification
    {
        /// <summary> Initializes a new instance of ServiceSpecification. </summary>
        internal ServiceSpecification()
        {
            MetricSpecifications = new ChangeTrackingList<MetricSpecification>();
            LogSpecifications = new ChangeTrackingList<LogSpecification>();
        }

        /// <summary> Initializes a new instance of ServiceSpecification. </summary>
        /// <param name="metricSpecifications"> . </param>
        /// <param name="logSpecifications"> . </param>
        internal ServiceSpecification(IReadOnlyList<MetricSpecification> metricSpecifications, IReadOnlyList<LogSpecification> logSpecifications)
        {
            MetricSpecifications = metricSpecifications;
            LogSpecifications = logSpecifications;
        }

        public IReadOnlyList<MetricSpecification> MetricSpecifications { get; }
        public IReadOnlyList<LogSpecification> LogSpecifications { get; }
    }
}
