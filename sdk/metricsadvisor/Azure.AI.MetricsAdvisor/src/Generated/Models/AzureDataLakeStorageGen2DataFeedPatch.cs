// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AzureDataLakeStorageGen2DataFeedPatch. </summary>
    internal partial class AzureDataLakeStorageGen2DataFeedPatch : DataFeedDetailPatch
    {
        /// <summary> Initializes a new instance of <see cref="AzureDataLakeStorageGen2DataFeedPatch"/>. </summary>
        public AzureDataLakeStorageGen2DataFeedPatch()
        {
            DataSourceType = DataFeedSourceKind.AzureDataLakeStorage;
        }

        /// <summary> Gets or sets the data source parameter. </summary>
        public AzureDataLakeStorageGen2ParameterPatch DataSourceParameter { get; set; }
    }
}
