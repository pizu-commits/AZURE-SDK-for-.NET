// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Class encapsulating restore target parameters. </summary>
    public partial class RestoreTargetInfo : RestoreTargetInfoBase
    {
        /// <summary> Initializes a new instance of <see cref="RestoreTargetInfo"/>. </summary>
        /// <param name="recoverySetting"> Recovery Option. </param>
        /// <param name="dataSourceInfo"> Information of target DS. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSourceInfo"/> is null. </exception>
        public RestoreTargetInfo(RecoverySetting recoverySetting, DataSourceInfo dataSourceInfo) : base(recoverySetting)
        {
            Argument.AssertNotNull(dataSourceInfo, nameof(dataSourceInfo));

            DataSourceInfo = dataSourceInfo;
            ObjectType = "RestoreTargetInfo";
        }

        /// <summary> Initializes a new instance of <see cref="RestoreTargetInfo"/>. </summary>
        /// <param name="objectType"> Type of Datasource object, used to initialize the right inherited type. </param>
        /// <param name="recoverySetting"> Recovery Option. </param>
        /// <param name="restoreLocation"> Target Restore region. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="dataSourceInfo"> Information of target DS. </param>
        /// <param name="dataSourceSetInfo"> Information of target DS Set. </param>
        /// <param name="dataSourceAuthCredentials">
        /// Credentials to use to authenticate with data source provider.
        /// Please note <see cref="DataProtectionBackupAuthCredentials"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecretStoreBasedAuthCredentials"/>.
        /// </param>
        internal RestoreTargetInfo(string objectType, RecoverySetting recoverySetting, AzureLocation? restoreLocation, IDictionary<string, BinaryData> serializedAdditionalRawData, DataSourceInfo dataSourceInfo, DataSourceSetInfo dataSourceSetInfo, DataProtectionBackupAuthCredentials dataSourceAuthCredentials) : base(objectType, recoverySetting, restoreLocation, serializedAdditionalRawData)
        {
            DataSourceInfo = dataSourceInfo;
            DataSourceSetInfo = dataSourceSetInfo;
            DataSourceAuthCredentials = dataSourceAuthCredentials;
            ObjectType = objectType ?? "RestoreTargetInfo";
        }

        /// <summary> Initializes a new instance of <see cref="RestoreTargetInfo"/> for deserialization. </summary>
        internal RestoreTargetInfo()
        {
        }

        /// <summary> Information of target DS. </summary>
        public DataSourceInfo DataSourceInfo { get; }
        /// <summary> Information of target DS Set. </summary>
        public DataSourceSetInfo DataSourceSetInfo { get; set; }
        /// <summary>
        /// Credentials to use to authenticate with data source provider.
        /// Please note <see cref="DataProtectionBackupAuthCredentials"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecretStoreBasedAuthCredentials"/>.
        /// </summary>
        public DataProtectionBackupAuthCredentials DataSourceAuthCredentials { get; set; }
    }
}
