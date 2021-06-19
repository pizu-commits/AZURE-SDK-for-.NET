// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The resource of an Azure Cosmos DB SQL database event
    /// </summary>
    public partial class RestorableSqlDatabasePropertiesResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RestorableSqlDatabasePropertiesResource class.
        /// </summary>
        public RestorableSqlDatabasePropertiesResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RestorableSqlDatabasePropertiesResource class.
        /// </summary>
        /// <param name="_rid">A system generated property. A unique
        /// identifier.</param>
        /// <param name="operationType">The operation type of this database
        /// event. Possible values include: 'Create', 'Replace', 'Delete',
        /// 'SystemOperation'</param>
        /// <param name="eventTimestamp">The time when this database event
        /// happened.</param>
        /// <param name="ownerId">The name of the SQL database.</param>
        /// <param name="ownerResourceId">The resource ID of the SQL
        /// database.</param>
        /// <param name="database">Cosmos DB SQL database resource
        /// object</param>
        public RestorableSqlDatabasePropertiesResource(string _rid = default(string), string operationType = default(string), string eventTimestamp = default(string), string ownerId = default(string), string ownerResourceId = default(string), RestorableSqlDatabasePropertiesResourceDatabase database = default(RestorableSqlDatabasePropertiesResourceDatabase))
        {
            this._rid = _rid;
            OperationType = operationType;
            EventTimestamp = eventTimestamp;
            OwnerId = ownerId;
            OwnerResourceId = ownerResourceId;
            Database = database;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a system generated property. A unique identifier.
        /// </summary>
        [JsonProperty(PropertyName = "_rid")]
        public string _rid { get; private set; }

        /// <summary>
        /// Gets the operation type of this database event. Possible values
        /// include: 'Create', 'Replace', 'Delete', 'SystemOperation'
        /// </summary>
        [JsonProperty(PropertyName = "operationType")]
        public string OperationType { get; private set; }

        /// <summary>
        /// Gets the time when this database event happened.
        /// </summary>
        [JsonProperty(PropertyName = "eventTimestamp")]
        public string EventTimestamp { get; private set; }

        /// <summary>
        /// Gets the name of the SQL database.
        /// </summary>
        [JsonProperty(PropertyName = "ownerId")]
        public string OwnerId { get; private set; }

        /// <summary>
        /// Gets the resource ID of the SQL database.
        /// </summary>
        [JsonProperty(PropertyName = "ownerResourceId")]
        public string OwnerResourceId { get; private set; }

        /// <summary>
        /// Gets or sets cosmos DB SQL database resource object
        /// </summary>
        [JsonProperty(PropertyName = "database")]
        public RestorableSqlDatabasePropertiesResourceDatabase Database { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Database != null)
            {
                Database.Validate();
            }
        }
    }
}
