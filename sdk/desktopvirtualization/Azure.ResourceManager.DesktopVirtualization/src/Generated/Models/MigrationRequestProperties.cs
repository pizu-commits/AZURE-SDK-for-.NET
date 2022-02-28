// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Properties for arm migration. </summary>
    public partial class MigrationRequestProperties
    {
        /// <summary> Initializes a new instance of MigrationRequestProperties. </summary>
        public MigrationRequestProperties()
        {
        }

        /// <summary> Initializes a new instance of MigrationRequestProperties. </summary>
        /// <param name="operation"> The type of operation for migration. </param>
        /// <param name="migrationPath"> The path to the legacy object to migrate. </param>
        internal MigrationRequestProperties(Operation? operation, string migrationPath)
        {
            Operation = operation;
            MigrationPath = migrationPath;
        }

        /// <summary> The type of operation for migration. </summary>
        public Operation? Operation { get; set; }
        /// <summary> The path to the legacy object to migrate. </summary>
        public string MigrationPath { get; set; }
    }
}
