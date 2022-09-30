// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Application logs to Azure table storage configuration. </summary>
    public partial class AppServiceTableStorageApplicationLogsConfig
    {
        /// <summary> Initializes a new instance of AppServiceTableStorageApplicationLogsConfig. </summary>
        /// <param name="sasUri"> SAS URL to an Azure table with add/query/delete permissions. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sasUri"/> is null. </exception>
        public AppServiceTableStorageApplicationLogsConfig(Uri sasUri)
        {
            if (sasUri == null)
            {
                throw new ArgumentNullException(nameof(sasUri));
            }

            SasUri = sasUri;
        }

        /// <summary> Initializes a new instance of AppServiceTableStorageApplicationLogsConfig. </summary>
        /// <param name="level"> Log level. </param>
        /// <param name="sasUri"> SAS URL to an Azure table with add/query/delete permissions. </param>
        internal AppServiceTableStorageApplicationLogsConfig(WebAppLogLevel? level, Uri sasUri)
        {
            Level = level;
            SasUri = sasUri;
        }

        /// <summary> Log level. </summary>
        public WebAppLogLevel? Level { get; set; }
        /// <summary> SAS URL to an Azure table with add/query/delete permissions. </summary>
        public Uri SasUri { get; set; }
    }
}
