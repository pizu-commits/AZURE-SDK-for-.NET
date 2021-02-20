// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> An Azure SQL Database sync member. </summary>
    public partial class SyncMember : ProxyResource
    {
        /// <summary> Initializes a new instance of SyncMember. </summary>
        public SyncMember()
        {
        }

        /// <summary> Initializes a new instance of SyncMember. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="databaseType"> Database type of the sync member. </param>
        /// <param name="syncAgentId"> ARM resource id of the sync agent in the sync member. </param>
        /// <param name="sqlServerDatabaseId"> SQL Server database id of the sync member. </param>
        /// <param name="syncMemberAzureDatabaseResourceId"> ARM resource id of the sync member logical database, for sync members in Azure. </param>
        /// <param name="usePrivateLinkConnection"> Whether to use private link connection. </param>
        /// <param name="serverName"> Server name of the member database in the sync member. </param>
        /// <param name="databaseName"> Database name of the member database in the sync member. </param>
        /// <param name="userName"> User name of the member database in the sync member. </param>
        /// <param name="password"> Password of the member database in the sync member. </param>
        /// <param name="syncDirection"> Sync direction of the sync member. </param>
        /// <param name="syncState"> Sync state of the sync member. </param>
        internal SyncMember(string id, string name, string type, SyncMemberDbType? databaseType, string syncAgentId, Guid? sqlServerDatabaseId, string syncMemberAzureDatabaseResourceId, bool? usePrivateLinkConnection, string serverName, string databaseName, string userName, string password, SyncDirection? syncDirection, SyncMemberState? syncState) : base(id, name, type)
        {
            DatabaseType = databaseType;
            SyncAgentId = syncAgentId;
            SqlServerDatabaseId = sqlServerDatabaseId;
            SyncMemberAzureDatabaseResourceId = syncMemberAzureDatabaseResourceId;
            UsePrivateLinkConnection = usePrivateLinkConnection;
            ServerName = serverName;
            DatabaseName = databaseName;
            UserName = userName;
            Password = password;
            SyncDirection = syncDirection;
            SyncState = syncState;
        }

        /// <summary> Database type of the sync member. </summary>
        public SyncMemberDbType? DatabaseType { get; set; }
        /// <summary> ARM resource id of the sync agent in the sync member. </summary>
        public string SyncAgentId { get; set; }
        /// <summary> SQL Server database id of the sync member. </summary>
        public Guid? SqlServerDatabaseId { get; set; }
        /// <summary> ARM resource id of the sync member logical database, for sync members in Azure. </summary>
        public string SyncMemberAzureDatabaseResourceId { get; set; }
        /// <summary> Whether to use private link connection. </summary>
        public bool? UsePrivateLinkConnection { get; set; }
        /// <summary> Server name of the member database in the sync member. </summary>
        public string ServerName { get; set; }
        /// <summary> Database name of the member database in the sync member. </summary>
        public string DatabaseName { get; set; }
        /// <summary> User name of the member database in the sync member. </summary>
        public string UserName { get; set; }
        /// <summary> Password of the member database in the sync member. </summary>
        public string Password { get; set; }
        /// <summary> Sync direction of the sync member. </summary>
        public SyncDirection? SyncDirection { get; set; }
        /// <summary> Sync state of the sync member. </summary>
        public SyncMemberState? SyncState { get; }
    }
}
