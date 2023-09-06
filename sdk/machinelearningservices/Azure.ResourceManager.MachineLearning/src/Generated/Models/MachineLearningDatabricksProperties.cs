// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Properties of Databricks. </summary>
    public partial class MachineLearningDatabricksProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningDatabricksProperties"/>. </summary>
        public MachineLearningDatabricksProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningDatabricksProperties"/>. </summary>
        /// <param name="databricksAccessToken"> Databricks access token. </param>
        /// <param name="workspaceUri"> Workspace Url. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningDatabricksProperties(string databricksAccessToken, Uri workspaceUri, Dictionary<string, BinaryData> rawData)
        {
            DatabricksAccessToken = databricksAccessToken;
            WorkspaceUri = workspaceUri;
            _rawData = rawData;
        }

        /// <summary> Databricks access token. </summary>
        public string DatabricksAccessToken { get; set; }
        /// <summary> Workspace Url. </summary>
        public Uri WorkspaceUri { get; set; }
    }
}
