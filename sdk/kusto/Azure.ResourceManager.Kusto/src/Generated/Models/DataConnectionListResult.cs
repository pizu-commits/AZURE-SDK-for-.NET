// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Kusto;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> The list Kusto data connections operation response. </summary>
    internal partial class DataConnectionListResult
    {
        /// <summary> Initializes a new instance of DataConnectionListResult. </summary>
        internal DataConnectionListResult()
        {
            Value = new Core.ChangeTrackingList<KustoDataConnectionData>();
        }

        /// <summary> Initializes a new instance of DataConnectionListResult. </summary>
        /// <param name="value">
        /// The list of Kusto data connections.
        /// Please note <see cref="KustoDataConnectionData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="KustoCosmosDBDataConnection"/>, <see cref="KustoEventGridDataConnection"/>, <see cref="KustoEventHubDataConnection"/> and <see cref="KustoIotHubDataConnection"/>.
        /// </param>
        internal DataConnectionListResult(IReadOnlyList<KustoDataConnectionData> value)
        {
            Value = value;
        }

        /// <summary>
        /// The list of Kusto data connections.
        /// Please note <see cref="KustoDataConnectionData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="KustoCosmosDBDataConnection"/>, <see cref="KustoEventGridDataConnection"/>, <see cref="KustoEventHubDataConnection"/> and <see cref="KustoIotHubDataConnection"/>.
        /// </summary>
        public IReadOnlyList<KustoDataConnectionData> Value { get; }
    }
}
