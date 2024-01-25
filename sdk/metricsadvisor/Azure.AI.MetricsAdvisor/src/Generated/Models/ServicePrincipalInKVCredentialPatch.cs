// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The ServicePrincipalInKVCredentialPatch. </summary>
    internal partial class ServicePrincipalInKVCredentialPatch : DataSourceCredentialPatch
    {
        /// <summary> Initializes a new instance of <see cref="ServicePrincipalInKVCredentialPatch"/>. </summary>
        public ServicePrincipalInKVCredentialPatch()
        {
            DataSourceCredentialType = DataSourceCredentialKind.ServicePrincipalInKeyVault;
        }

        /// <summary> Initializes a new instance of <see cref="ServicePrincipalInKVCredentialPatch"/>. </summary>
        /// <param name="dataSourceCredentialType"> Type of data source credential. </param>
        /// <param name="dataSourceCredentialName"> Name of data source credential. </param>
        /// <param name="dataSourceCredentialDescription"> Description of data source credential. </param>
        /// <param name="parameters"></param>
        internal ServicePrincipalInKVCredentialPatch(DataSourceCredentialKind dataSourceCredentialType, string dataSourceCredentialName, string dataSourceCredentialDescription, ServicePrincipalInKVParamPatch parameters) : base(dataSourceCredentialType, dataSourceCredentialName, dataSourceCredentialDescription)
        {
            Parameters = parameters;
            DataSourceCredentialType = dataSourceCredentialType;
        }

        /// <summary> Gets or sets the parameters. </summary>
        public ServicePrincipalInKVParamPatch Parameters { get; set; }
    }
}
