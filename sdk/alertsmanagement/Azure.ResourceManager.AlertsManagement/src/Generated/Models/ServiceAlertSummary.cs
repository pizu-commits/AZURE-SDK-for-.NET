// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary> Summary of alerts based on the input filters and &apos;groupby&apos; parameters. </summary>
    public partial class ServiceAlertSummary : ResourceData
    {
        /// <summary> Initializes a new instance of ServiceAlertSummary. </summary>
        public ServiceAlertSummary()
        {
            Values = new ChangeTrackingList<ServiceAlertSummaryGroupItemInfo>();
        }

        /// <summary> Initializes a new instance of ServiceAlertSummary. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="total"> Total count of the result set. </param>
        /// <param name="smartGroupsCount"> Total count of the smart groups. </param>
        /// <param name="groupedBy"> Name of the field aggregated. </param>
        /// <param name="values"> List of the items. </param>
        internal ServiceAlertSummary(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, long? total, long? smartGroupsCount, string groupedBy, IList<ServiceAlertSummaryGroupItemInfo> values) : base(id, name, resourceType, systemData)
        {
            Total = total;
            SmartGroupsCount = smartGroupsCount;
            GroupedBy = groupedBy;
            Values = values;
        }

        /// <summary> Total count of the result set. </summary>
        public long? Total { get; set; }
        /// <summary> Total count of the smart groups. </summary>
        public long? SmartGroupsCount { get; set; }
        /// <summary> Name of the field aggregated. </summary>
        public string GroupedBy { get; set; }
        /// <summary> List of the items. </summary>
        public IList<ServiceAlertSummaryGroupItemInfo> Values { get; }
    }
}
