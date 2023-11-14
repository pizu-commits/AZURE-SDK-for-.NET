// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> Set the server/instance-level settings for SQL Server. </summary>
    public partial class SqlInstanceSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SqlInstanceSettings"/>. </summary>
        public SqlInstanceSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlInstanceSettings"/>. </summary>
        /// <param name="collation"> SQL Server Collation. </param>
        /// <param name="maxDop"> SQL Server MAXDOP. </param>
        /// <param name="isOptimizeForAdHocWorkloadsEnabled"> SQL Server Optimize for Adhoc workloads. </param>
        /// <param name="minServerMemoryInMB"> SQL Server minimum memory. </param>
        /// <param name="maxServerMemoryInMB"> SQL Server maximum memory. </param>
        /// <param name="isLpimEnabled"> SQL Server LPIM. </param>
        /// <param name="isIfiEnabled"> SQL Server IFI. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlInstanceSettings(string collation, int? maxDop, bool? isOptimizeForAdHocWorkloadsEnabled, int? minServerMemoryInMB, int? maxServerMemoryInMB, bool? isLpimEnabled, bool? isIfiEnabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Collation = collation;
            MaxDop = maxDop;
            IsOptimizeForAdHocWorkloadsEnabled = isOptimizeForAdHocWorkloadsEnabled;
            MinServerMemoryInMB = minServerMemoryInMB;
            MaxServerMemoryInMB = maxServerMemoryInMB;
            IsLpimEnabled = isLpimEnabled;
            IsIfiEnabled = isIfiEnabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> SQL Server Collation. </summary>
        public string Collation { get; set; }
        /// <summary> SQL Server MAXDOP. </summary>
        public int? MaxDop { get; set; }
        /// <summary> SQL Server Optimize for Adhoc workloads. </summary>
        public bool? IsOptimizeForAdHocWorkloadsEnabled { get; set; }
        /// <summary> SQL Server minimum memory. </summary>
        public int? MinServerMemoryInMB { get; set; }
        /// <summary> SQL Server maximum memory. </summary>
        public int? MaxServerMemoryInMB { get; set; }
        /// <summary> SQL Server LPIM. </summary>
        public bool? IsLpimEnabled { get; set; }
        /// <summary> SQL Server IFI. </summary>
        public bool? IsIfiEnabled { get; set; }
    }
}
