// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> Slot Config names azure resource. </summary>
    public partial class SlotConfigNamesResource : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of SlotConfigNamesResource. </summary>
        public SlotConfigNamesResource()
        {
            ConnectionStringNames = new ChangeTrackingList<string>();
            AppSettingNames = new ChangeTrackingList<string>();
            AzureStorageConfigNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of SlotConfigNamesResource. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource Name. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="connectionStringNames"> List of connection string names. </param>
        /// <param name="appSettingNames"> List of application settings names. </param>
        /// <param name="azureStorageConfigNames"> List of external Azure storage account identifiers. </param>
        internal SlotConfigNamesResource(string id, string name, string kind, string type, IList<string> connectionStringNames, IList<string> appSettingNames, IList<string> azureStorageConfigNames) : base(id, name, kind, type)
        {
            ConnectionStringNames = connectionStringNames;
            AppSettingNames = appSettingNames;
            AzureStorageConfigNames = azureStorageConfigNames;
        }

        /// <summary> List of connection string names. </summary>
        public IList<string> ConnectionStringNames { get; }
        /// <summary> List of application settings names. </summary>
        public IList<string> AppSettingNames { get; }
        /// <summary> List of external Azure storage account identifiers. </summary>
        public IList<string> AzureStorageConfigNames { get; }
    }
}
