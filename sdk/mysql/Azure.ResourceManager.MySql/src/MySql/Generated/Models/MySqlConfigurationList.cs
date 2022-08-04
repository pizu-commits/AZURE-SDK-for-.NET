// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MySql;

namespace Azure.ResourceManager.MySql.Models
{
    /// <summary> A list of server configurations. </summary>
    public partial class MySqlConfigurationList
    {
        /// <summary> Initializes a new instance of MySqlConfigurationList. </summary>
        public MySqlConfigurationList()
        {
            Value = new ChangeTrackingList<MySqlConfigurationData>();
        }

        /// <summary> Initializes a new instance of MySqlConfigurationList. </summary>
        /// <param name="value"> The list of server configurations. </param>
        internal MySqlConfigurationList(IList<MySqlConfigurationData> value)
        {
            Value = value;
        }

        /// <summary> The list of server configurations. </summary>
        public IList<MySqlConfigurationData> Value { get; }
    }
}
