// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Sql;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents the Azure SQL capabilities for a region.
    /// </summary>
    public partial class LocationCapabilities
    {
        /// <summary>
        /// Initializes a new instance of the LocationCapabilities class.
        /// </summary>
        public LocationCapabilities() { }

        /// <summary>
        /// Initializes a new instance of the LocationCapabilities class.
        /// </summary>
        /// <param name="name">The region name.</param>
        /// <param name="status">The status for the region with respect to
        /// Azure SQL. Possible values include: 'Visible', 'Available',
        /// 'Default'</param>
        /// <param name="supportedServerVersions">The list of supported Azure
        /// SQL Server versions.</param>
        public LocationCapabilities(string name = default(string), CapabilityStatus? status = default(CapabilityStatus?), IList<ServerVersionCapability> supportedServerVersions = default(IList<ServerVersionCapability>))
        {
            Name = name;
            Status = status;
            SupportedServerVersions = supportedServerVersions;
        }

        /// <summary>
        /// Gets the region name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the status for the region with respect to Azure SQL. Possible
        /// values include: 'Visible', 'Available', 'Default'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public CapabilityStatus? Status { get; private set; }

        /// <summary>
        /// Gets the list of supported Azure SQL Server versions.
        /// </summary>
        [JsonProperty(PropertyName = "supportedServerVersions")]
        public IList<ServerVersionCapability> SupportedServerVersions { get; private set; }

    }
}
