// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Parameters to create and update an Azure Cosmos DB SQL Role Assignment. </summary>
    public partial class SqlRoleAssignmentCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of SqlRoleAssignmentCreateOrUpdateContent. </summary>
        public SqlRoleAssignmentCreateOrUpdateContent()
        {
        }

        /// <summary> The unique identifier for the associated Role Definition. </summary>
        public string RoleDefinitionId { get; set; }
        /// <summary> The data plane resource path for which access is being granted through this Role Assignment. </summary>
        public string Scope { get; set; }
        /// <summary> The unique identifier for the associated AAD principal in the AAD graph to which access is being granted through this Role Assignment. Tenant ID for the principal is inferred using the tenant associated with the subscription. </summary>
        public string PrincipalId { get; set; }
    }
}
