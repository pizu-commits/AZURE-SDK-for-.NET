// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Kusto;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> Class representing an data connection validation. </summary>
    public partial class DataConnectionValidationContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataConnectionValidationContent"/>. </summary>
        public DataConnectionValidationContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataConnectionValidationContent"/>. </summary>
        /// <param name="dataConnectionName"> The name of the data connection. </param>
        /// <param name="properties">
        /// The data connection properties to validate.
        /// Please note <see cref="KustoDataConnectionData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="KustoCosmosDBDataConnection"/>, <see cref="KustoEventGridDataConnection"/>, <see cref="KustoEventHubDataConnection"/> and <see cref="KustoIotHubDataConnection"/>.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataConnectionValidationContent(string dataConnectionName, KustoDataConnectionData properties, Dictionary<string, BinaryData> rawData)
        {
            DataConnectionName = dataConnectionName;
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> The name of the data connection. </summary>
        public string DataConnectionName { get; set; }
        /// <summary>
        /// The data connection properties to validate.
        /// Please note <see cref="KustoDataConnectionData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="KustoCosmosDBDataConnection"/>, <see cref="KustoEventGridDataConnection"/>, <see cref="KustoEventHubDataConnection"/> and <see cref="KustoIotHubDataConnection"/>.
        /// </summary>
        public KustoDataConnectionData Properties { get; set; }
    }
}
