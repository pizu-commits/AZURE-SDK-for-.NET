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
    /// Represents the Azure SQL Server capabilities.
    /// </summary>
    public partial class ServerVersionCapability
    {
        /// <summary>
        /// Initializes a new instance of the ServerVersionCapability class.
        /// </summary>
        public ServerVersionCapability() { }

        /// <summary>
        /// Initializes a new instance of the ServerVersionCapability class.
        /// </summary>
        /// <param name="name">The server version name.</param>
        /// <param name="status">The status of the Azure SQL Server version.
        /// Possible values include: 'Visible', 'Available', 'Default'</param>
        /// <param name="supportedEditions">The list of supported Azure SQL
        /// Server editions.</param>
        public ServerVersionCapability(string name = default(string), CapabilityStatus? status = default(CapabilityStatus?), IList<EditionCapability> supportedEditions = default(IList<EditionCapability>))
        {
            Name = name;
            Status = status;
            SupportedEditions = supportedEditions;
        }

        /// <summary>
        /// Gets the server version name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the status of the Azure SQL Server version. Possible values
        /// include: 'Visible', 'Available', 'Default'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public CapabilityStatus? Status { get; private set; }

        /// <summary>
        /// Gets the list of supported Azure SQL Server editions.
        /// </summary>
        [JsonProperty(PropertyName = "supportedEditions")]
        public IList<EditionCapability> SupportedEditions { get; private set; }

    }
}
