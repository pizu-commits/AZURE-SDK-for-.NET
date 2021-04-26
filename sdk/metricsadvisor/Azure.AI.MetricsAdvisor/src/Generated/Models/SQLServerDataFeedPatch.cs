// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The SQLServerDataFeedPatch. </summary>
    internal partial class SQLServerDataFeedPatch : DataFeedDetailPatch
    {
        /// <summary> Initializes a new instance of SQLServerDataFeedPatch. </summary>
        public SQLServerDataFeedPatch()
        {
            DataSourceType = DataFeedSourceType.SqlServer;
        }

        public SqlSourceParameter DataSourceParameter { get; set; }
    }
}
