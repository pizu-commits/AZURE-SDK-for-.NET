// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Azure;
    using Management;
    using Sql;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents the maximum size limits for an Azure SQL Database.
    /// </summary>
    public partial class MaxSizeCapability
    {
        /// <summary>
        /// Initializes a new instance of the MaxSizeCapability class.
        /// </summary>
        public MaxSizeCapability() { }

        /// <summary>
        /// Initializes a new instance of the MaxSizeCapability class.
        /// </summary>
        /// <param name="limit">The maximum size of the database (see 'unit'
        /// for the units).</param>
        /// <param name="unit">The units that the limit is expressed in.
        /// Possible values include: 'Megabytes', 'Gigabytes', 'Terabytes',
        /// 'Petabytes'</param>
        /// <param name="status">The status of the maximum size capability.
        /// Possible values include: 'Visible', 'Available', 'Default'</param>
        public MaxSizeCapability(int? limit = default(int?), string unit = default(string), string status = default(string))
        {
            Limit = limit;
            Unit = unit;
            Status = status;
        }

        /// <summary>
        /// Gets the maximum size of the database (see 'unit' for the units).
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public int? Limit { get; protected set; }

        /// <summary>
        /// Gets the units that the limit is expressed in. Possible values
        /// include: 'Megabytes', 'Gigabytes', 'Terabytes', 'Petabytes'
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; protected set; }

        /// <summary>
        /// Gets the status of the maximum size capability. Possible values
        /// include: 'Visible', 'Available', 'Default'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; protected set; }

    }
}

