// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Information for connecting to MySQL server. </summary>
    public partial class MySqlConnectionInfo : ConnectionInfo
    {
        /// <summary> Initializes a new instance of MySqlConnectionInfo. </summary>
        /// <param name="serverName"> Name of the server. </param>
        /// <param name="port"> Port for Server. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public MySqlConnectionInfo(string serverName, int port)
        {
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }

            ServerName = serverName;
            Port = port;
            ConnectionInfoType = "MySqlConnectionInfo";
        }

        /// <summary> Initializes a new instance of MySqlConnectionInfo. </summary>
        /// <param name="connectionInfoType"> Type of connection info. </param>
        /// <param name="userName"> User name. </param>
        /// <param name="password"> Password credential. </param>
        /// <param name="serverName"> Name of the server. </param>
        /// <param name="dataSource"> Data source. </param>
        /// <param name="port"> Port for Server. </param>
        /// <param name="encryptConnection"> Whether to encrypt the connection. </param>
        /// <param name="authentication"> Authentication type to use for connection. </param>
        /// <param name="additionalSettings"> Additional connection settings. </param>
        internal MySqlConnectionInfo(string connectionInfoType, string userName, string password, string serverName, string dataSource, int port, bool? encryptConnection, AuthenticationType? authentication, string additionalSettings) : base(connectionInfoType, userName, password)
        {
            ServerName = serverName;
            DataSource = dataSource;
            Port = port;
            EncryptConnection = encryptConnection;
            Authentication = authentication;
            AdditionalSettings = additionalSettings;
            ConnectionInfoType = connectionInfoType ?? "MySqlConnectionInfo";
        }

        /// <summary> Name of the server. </summary>
        public string ServerName { get; set; }
        /// <summary> Data source. </summary>
        public string DataSource { get; set; }
        /// <summary> Port for Server. </summary>
        public int Port { get; set; }
        /// <summary> Whether to encrypt the connection. </summary>
        public bool? EncryptConnection { get; set; }
        /// <summary> Authentication type to use for connection. </summary>
        public AuthenticationType? Authentication { get; set; }
        /// <summary> Additional connection settings. </summary>
        public string AdditionalSettings { get; set; }
    }
}
