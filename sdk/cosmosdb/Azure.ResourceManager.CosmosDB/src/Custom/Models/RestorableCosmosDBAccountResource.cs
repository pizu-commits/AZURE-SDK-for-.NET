﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Threading;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A Class representing a RestorableCosmosDBAccount along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="RestorableCosmosDBAccountResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetRestorableCosmosDBAccountResource method.
    /// Otherwise you can get one from its parent resource <see cref="CosmosDBLocationResource" /> using the GetRestorableCosmosDBAccount method.
    /// </summary>
    public partial class RestorableCosmosDBAccountResource : ArmResource
    {
        /// <summary>
        /// Show the event feed of all mutations done on all the Azure Cosmos DB MongoDB collections under a specific database.  This helps in scenario where container was accidentally deleted.  This API requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{instanceId}/restorableMongodbCollections
        /// Operation Id: RestorableMongodbCollections_List
        /// </summary>
        /// <param name="restorableMongoDBDatabaseRid"> The resource ID of the MongoDB database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RestorableMongoDBCollection" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RestorableMongoDBCollection> GetRestorableMongoDBCollectionsAsync(string restorableMongoDBDatabaseRid, CancellationToken cancellationToken)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _restorableMongoDBCollectionsRestClient.CreateListRequest(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Guid.Parse(Id.Name), restorableMongoDBDatabaseRid, null, null);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, RestorableMongoDBCollection.DeserializeRestorableMongoDBCollection, _restorableMongoDBCollectionsClientDiagnostics, Pipeline, "RestorableCosmosDBAccountResource.GetRestorableMongoDBCollections", "value", null, cancellationToken);
        }

        /// <summary>
        /// Show the event feed of all mutations done on all the Azure Cosmos DB MongoDB collections under a specific database.  This helps in scenario where container was accidentally deleted.  This API requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{instanceId}/restorableMongodbCollections
        /// Operation Id: RestorableMongodbCollections_List
        /// </summary>
        /// <param name="restorableMongoDBDatabaseRid"> The resource ID of the MongoDB database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RestorableMongoDBCollection" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RestorableMongoDBCollection> GetRestorableMongoDBCollections(string restorableMongoDBDatabaseRid, CancellationToken cancellationToken)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _restorableMongoDBCollectionsRestClient.CreateListRequest(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Guid.Parse(Id.Name), restorableMongoDBDatabaseRid, null, null);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, RestorableMongoDBCollection.DeserializeRestorableMongoDBCollection, _restorableMongoDBCollectionsClientDiagnostics, Pipeline, "RestorableCosmosDBAccountResource.GetRestorableMongoDBCollections", "value", null, cancellationToken);
        }
    }
}
