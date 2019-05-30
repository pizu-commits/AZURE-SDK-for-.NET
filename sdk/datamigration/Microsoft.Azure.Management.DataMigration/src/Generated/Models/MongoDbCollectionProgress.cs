// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes the progress of a collection
    /// </summary>
    public partial class MongoDbCollectionProgress : MongoDbProgress
    {
        /// <summary>
        /// Initializes a new instance of the MongoDbCollectionProgress class.
        /// </summary>
        public MongoDbCollectionProgress()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MongoDbCollectionProgress class.
        /// </summary>
        /// <param name="bytesCopied">The number of document bytes copied
        /// during the Copying stage</param>
        /// <param name="documentsCopied">The number of documents copied during
        /// the Copying stage</param>
        /// <param name="elapsedTime">The elapsed time in the format
        /// [ddd.]hh:mm:ss[.fffffff] (i.e. TimeSpan format)</param>
        /// <param name="errors">The errors and warnings that have occurred for
        /// the current object. The keys are the error codes.</param>
        /// <param name="eventsPending">The number of oplog events awaiting
        /// replay</param>
        /// <param name="eventsReplayed">The number of oplog events replayed so
        /// far</param>
        /// <param name="resultType">The type of progress object. Possible
        /// values include: 'Migration', 'Database', 'Collection'</param>
        /// <param name="state">Possible values include: 'NotStarted',
        /// 'ValidatingInput', 'Initializing', 'Restarting', 'Copying',
        /// 'InitialReplay', 'Replaying', 'Finalizing', 'Complete', 'Canceled',
        /// 'Failed'</param>
        /// <param name="totalBytes">The total number of document bytes on the
        /// source at the beginning of the Copying stage, or -1 if the total
        /// size was unknown</param>
        /// <param name="totalDocuments">The total number of documents on the
        /// source at the beginning of the Copying stage, or -1 if the total
        /// count was unknown</param>
        /// <param name="lastEventTime">The timestamp of the last oplog event
        /// received, or null if no oplog event has been received yet</param>
        /// <param name="lastReplayTime">The timestamp of the last oplog event
        /// replayed, or null if no oplog event has been replayed yet</param>
        /// <param name="name">The name of the progress object. For a
        /// collection, this is the unqualified collection name. For a
        /// database, this is the database name. For the overall migration,
        /// this is null.</param>
        /// <param name="qualifiedName">The qualified name of the progress
        /// object. For a collection, this is the database-qualified name. For
        /// a database, this is the database name. For the overall migration,
        /// this is null.</param>
        public MongoDbCollectionProgress(long bytesCopied, long documentsCopied, string elapsedTime, IDictionary<string, MongoDbError> errors, long eventsPending, long eventsReplayed, string resultType, string state, long totalBytes, long totalDocuments, System.DateTimeOffset? lastEventTime = default(System.DateTimeOffset?), System.DateTimeOffset? lastReplayTime = default(System.DateTimeOffset?), string name = default(string), string qualifiedName = default(string))
            : base(bytesCopied, documentsCopied, elapsedTime, errors, eventsPending, eventsReplayed, resultType, state, totalBytes, totalDocuments, lastEventTime, lastReplayTime, name, qualifiedName)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
