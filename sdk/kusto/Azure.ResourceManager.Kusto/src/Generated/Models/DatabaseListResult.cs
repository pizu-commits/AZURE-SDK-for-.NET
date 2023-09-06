// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Kusto;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> The list Kusto databases operation response. </summary>
    internal partial class DatabaseListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DatabaseListResult"/>. </summary>
        internal DatabaseListResult()
        {
            Value = new ChangeTrackingList<KustoDatabaseData>();
        }

        /// <summary> Initializes a new instance of <see cref="DatabaseListResult"/>. </summary>
        /// <param name="nextLink"> Link to the next page of results. </param>
        /// <param name="value">
        /// The list of Kusto databases.
        /// Please note <see cref="KustoDatabaseData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="KustoReadOnlyFollowingDatabase"/> and <see cref="KustoReadWriteDatabase"/>.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DatabaseListResult(string nextLink, IReadOnlyList<KustoDatabaseData> value, Dictionary<string, BinaryData> rawData)
        {
            NextLink = nextLink;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Link to the next page of results. </summary>
        public string NextLink { get; }
        /// <summary>
        /// The list of Kusto databases.
        /// Please note <see cref="KustoDatabaseData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="KustoReadOnlyFollowingDatabase"/> and <see cref="KustoReadWriteDatabase"/>.
        /// </summary>
        public IReadOnlyList<KustoDatabaseData> Value { get; }
    }
}
