// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.StorSimple;
    using Microsoft.Azure.Management.StorSimple.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The OData filters to be used for Alert
    /// </summary>
    public partial class AlertFilterInner
    {
        /// <summary>
        /// Initializes a new instance of the AlertFilterInner class.
        /// </summary>
        public AlertFilterInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AlertFilterInner class.
        /// </summary>
        /// <param name="status">Specifies the status of the alerts to be
        /// filtered. Only 'Equality' operator is supported for this property.
        /// Possible values include: 'Active', 'Cleared'</param>
        /// <param name="severity">Specifies the severity of the alerts to be
        /// filtered. Only 'Equality' operator is supported for this property.
        /// Possible values include: 'Informational', 'Warning',
        /// 'Critical'</param>
        /// <param name="sourceType">Specifies the source type of the alerts to
        /// be filtered. Only 'Equality' operator is supported for this
        /// property. Possible values include: 'Resource', 'Device'</param>
        /// <param name="sourceName">Specifies the source name of the alerts to
        /// be filtered. Only 'Equality' operator is supported for this
        /// property.</param>
        /// <param name="appearedOnTime">Specifies the appeared time (in UTC)
        /// of the alerts to be filtered. Only 'Greater-Than' and 'Lesser-Than'
        /// operators are supported for this property.</param>
        public AlertFilterInner(AlertStatus? status = default(AlertStatus?), AlertSeverity? severity = default(AlertSeverity?), AlertSourceType? sourceType = default(AlertSourceType?), string sourceName = default(string), System.DateTime? appearedOnTime = default(System.DateTime?))
        {
            Status = status;
            Severity = severity;
            SourceType = sourceType;
            SourceName = sourceName;
            AppearedOnTime = appearedOnTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the status of the alerts to be filtered.
        /// Only 'Equality' operator is supported for this property. Possible
        /// values include: 'Active', 'Cleared'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public AlertStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets specifies the severity of the alerts to be filtered.
        /// Only 'Equality' operator is supported for this property. Possible
        /// values include: 'Informational', 'Warning', 'Critical'
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        public AlertSeverity? Severity { get; set; }

        /// <summary>
        /// Gets or sets specifies the source type of the alerts to be
        /// filtered. Only 'Equality' operator is supported for this property.
        /// Possible values include: 'Resource', 'Device'
        /// </summary>
        [JsonProperty(PropertyName = "sourceType")]
        public AlertSourceType? SourceType { get; set; }

        /// <summary>
        /// Gets or sets specifies the source name of the alerts to be
        /// filtered. Only 'Equality' operator is supported for this property.
        /// </summary>
        [JsonProperty(PropertyName = "sourceName")]
        public string SourceName { get; set; }

        /// <summary>
        /// Gets or sets specifies the appeared time (in UTC) of the alerts to
        /// be filtered. Only 'Greater-Than' and 'Lesser-Than' operators are
        /// supported for this property.
        /// </summary>
        [JsonProperty(PropertyName = "appearedOnTime")]
        public System.DateTime? AppearedOnTime { get; set; }

    }
}
