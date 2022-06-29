// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the ManagedInstance data model. </summary>
    public partial class ManagedInstanceData : TrackedResourceData
    {
        /// <summary> Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database. </summary>
        [CodeGenMember("RestorePointInOn")]
        public DateTimeOffset? RestorePointInTime { get; set; }
    }
}
