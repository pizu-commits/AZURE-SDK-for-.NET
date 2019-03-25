// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Blueprint.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// AAD object Id of the Azure Blueprints service principal in the tenant.
    /// </summary>
    public partial class WhoIsBlueprintContract
    {
        /// <summary>
        /// Initializes a new instance of the WhoIsBlueprintContract class.
        /// </summary>
        public WhoIsBlueprintContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WhoIsBlueprintContract class.
        /// </summary>
        /// <param name="objectId">Identifier.</param>
        public WhoIsBlueprintContract(string objectId = default(string))
        {
            ObjectId = objectId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets identifier.
        /// </summary>
        [JsonProperty(PropertyName = "objectId")]
        public string ObjectId { get; set; }

    }
}
