// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using Azure.Core;

namespace Azure.Developer.DevCenter.Models
{
    [CodeGenSuppress("DevCenterEnvironment", typeof(string), typeof(string), typeof(string))]
    public partial class DevCenterEnvironment
    {
        /// <summary> Initializes a new instance of <see cref="DevCenterEnvironment"/>. </summary>
        /// <param name="environmentName"> Environment name. </param>
        /// <param name="environmentTypeName"> Environment type. </param>
        /// <param name="catalogName"> Name of the catalog. </param>
        /// <param name="environmentDefinitionName"> Name of the environment definition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentName"/>, <paramref name="environmentTypeName"/>, <paramref name="catalogName"/> or <paramref name="environmentDefinitionName"/> is null. </exception>
        public DevCenterEnvironment(string environmentName, string environmentTypeName, string catalogName, string environmentDefinitionName)
        {
            Argument.AssertNotNull(environmentName, nameof(environmentName));
            Argument.AssertNotNull(environmentTypeName, nameof(environmentTypeName));
            Argument.AssertNotNull(catalogName, nameof(catalogName));
            Argument.AssertNotNull(environmentDefinitionName, nameof(environmentDefinitionName));

            Parameters = new ChangeTrackingDictionary<string, BinaryData>();
            Name = environmentName;
            EnvironmentTypeName = environmentTypeName;
            CatalogName = catalogName;
            EnvironmentDefinitionName = environmentDefinitionName;
        }

        /// <summary> The identifier of the resource group containing the environment's resources. </summary>
        public ResourceIdentifier ResourceGroupId { get; }
    }

    public partial class DevCenterEnvironment
    {
        /// <summary> Initializes a new instance of <see cref="DevCenterEnvironment"/>. </summary>
        /// <param name="parameters"> Parameters object for the environment. </param>
        /// <param name="name"> Environment name. </param>
        /// <param name="environmentTypeName"> Environment type. </param>
        /// <param name="userId"> The AAD object id of the owner of this Environment. </param>
        /// <param name="provisioningState"> The provisioning state of the environment. </param>
        /// <param name="resourceGroupId"> The identifier of the resource group containing the environment's resources. </param>
        /// <param name="catalogName"> Name of the catalog. </param>
        /// <param name="environmentDefinitionName"> Name of the environment definition. </param>
        /// <param name="error"> Provisioning error details. Populated only for error states. </param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public DevCenterEnvironment(IDictionary<string, BinaryData> parameters, string name, string environmentTypeName, Guid? userId, EnvironmentProvisioningState? provisioningState, ResourceIdentifier resourceGroupId, string catalogName, string environmentDefinitionName, ResponseError error)
        {
            Parameters = parameters;
            Name = name;
            EnvironmentTypeName = environmentTypeName;
            UserId = userId;
            ProvisioningState = provisioningState;
            ResourceGroupId = resourceGroupId;
            CatalogName = catalogName;
            EnvironmentDefinitionName = environmentDefinitionName;
            Error = error;
        }
    }
}
