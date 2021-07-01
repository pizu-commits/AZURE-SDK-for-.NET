// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A long term retention backup for a managed database.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ManagedInstanceLongTermRetentionBackup : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ManagedInstanceLongTermRetentionBackup class.
        /// </summary>
        public ManagedInstanceLongTermRetentionBackup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ManagedInstanceLongTermRetentionBackup class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="managedInstanceName">The managed instance that the
        /// backup database belongs to.</param>
        /// <param name="managedInstanceCreateTime">The create time of the
        /// instance.</param>
        /// <param name="databaseName">The name of the database the backup
        /// belong to</param>
        /// <param name="databaseDeletionTime">The delete time of the
        /// database</param>
        /// <param name="backupTime">The time the backup was taken</param>
        /// <param name="backupExpirationTime">The time the long term retention
        /// backup will expire.</param>
        /// <param name="backupStorageRedundancy">The storage redundancy type
        /// of the backup. Possible values include: 'Geo', 'Local',
        /// 'Zone'</param>
        public ManagedInstanceLongTermRetentionBackup(string id = default(string), string name = default(string), string type = default(string), string managedInstanceName = default(string), System.DateTime? managedInstanceCreateTime = default(System.DateTime?), string databaseName = default(string), System.DateTime? databaseDeletionTime = default(System.DateTime?), System.DateTime? backupTime = default(System.DateTime?), System.DateTime? backupExpirationTime = default(System.DateTime?), string backupStorageRedundancy = default(string))
            : base(id, name, type)
        {
            ManagedInstanceName = managedInstanceName;
            ManagedInstanceCreateTime = managedInstanceCreateTime;
            DatabaseName = databaseName;
            DatabaseDeletionTime = databaseDeletionTime;
            BackupTime = backupTime;
            BackupExpirationTime = backupExpirationTime;
            BackupStorageRedundancy = backupStorageRedundancy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the managed instance that the backup database belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.managedInstanceName")]
        public string ManagedInstanceName { get; private set; }

        /// <summary>
        /// Gets the create time of the instance.
        /// </summary>
        [JsonProperty(PropertyName = "properties.managedInstanceCreateTime")]
        public System.DateTime? ManagedInstanceCreateTime { get; private set; }

        /// <summary>
        /// Gets the name of the database the backup belong to
        /// </summary>
        [JsonProperty(PropertyName = "properties.databaseName")]
        public string DatabaseName { get; private set; }

        /// <summary>
        /// Gets the delete time of the database
        /// </summary>
        [JsonProperty(PropertyName = "properties.databaseDeletionTime")]
        public System.DateTime? DatabaseDeletionTime { get; private set; }

        /// <summary>
        /// Gets the time the backup was taken
        /// </summary>
        [JsonProperty(PropertyName = "properties.backupTime")]
        public System.DateTime? BackupTime { get; private set; }

        /// <summary>
        /// Gets the time the long term retention backup will expire.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backupExpirationTime")]
        public System.DateTime? BackupExpirationTime { get; private set; }

        /// <summary>
        /// Gets the storage redundancy type of the backup. Possible values
        /// include: 'Geo', 'Local', 'Zone'
        /// </summary>
        [JsonProperty(PropertyName = "properties.backupStorageRedundancy")]
        public string BackupStorageRedundancy { get; private set; }

    }
}
