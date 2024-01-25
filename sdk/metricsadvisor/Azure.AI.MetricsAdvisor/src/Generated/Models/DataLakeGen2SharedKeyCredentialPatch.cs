// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The DataLakeGen2SharedKeyCredentialPatch. </summary>
    internal partial class DataLakeGen2SharedKeyCredentialPatch : DataSourceCredentialPatch
    {
        /// <summary> Initializes a new instance of <see cref="DataLakeGen2SharedKeyCredentialPatch"/>. </summary>
        public DataLakeGen2SharedKeyCredentialPatch()
        {
            DataSourceCredentialType = DataSourceCredentialKind.DataLakeSharedKey;
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeGen2SharedKeyCredentialPatch"/>. </summary>
        /// <param name="dataSourceCredentialType"> Type of data source credential. </param>
        /// <param name="dataSourceCredentialName"> Name of data source credential. </param>
        /// <param name="dataSourceCredentialDescription"> Description of data source credential. </param>
        /// <param name="parameters"></param>
        internal DataLakeGen2SharedKeyCredentialPatch(DataSourceCredentialKind dataSourceCredentialType, string dataSourceCredentialName, string dataSourceCredentialDescription, DataLakeGen2SharedKeyParamPatch parameters) : base(dataSourceCredentialType, dataSourceCredentialName, dataSourceCredentialDescription)
        {
            Parameters = parameters;
            DataSourceCredentialType = dataSourceCredentialType;
        }

        /// <summary> Gets or sets the parameters. </summary>
        public DataLakeGen2SharedKeyParamPatch Parameters { get; set; }
    }
}
