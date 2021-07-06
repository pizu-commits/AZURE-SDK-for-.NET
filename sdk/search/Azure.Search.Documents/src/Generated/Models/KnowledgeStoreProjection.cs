// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Container object for various projection selectors. </summary>
    public partial class KnowledgeStoreProjection
    {
        /// <summary> Initializes a new instance of KnowledgeStoreProjection. </summary>
        public KnowledgeStoreProjection()
        {
            Tables = new ChangeTrackingList<KnowledgeStoreTableProjectionSelector>();
            Objects = new ChangeTrackingList<KnowledgeStoreObjectProjectionSelector>();
            Files = new ChangeTrackingList<KnowledgeStoreFileProjectionSelector>();
        }

        /// <summary> Initializes a new instance of KnowledgeStoreProjection. </summary>
        /// <param name="tables"> Projections to Azure Table storage. </param>
        /// <param name="objects"> Projections to Azure Blob storage. </param>
        /// <param name="files"> Projections to Azure File storage. </param>
        internal KnowledgeStoreProjection(IList<KnowledgeStoreTableProjectionSelector> tables, IList<KnowledgeStoreObjectProjectionSelector> objects, IList<KnowledgeStoreFileProjectionSelector> files)
        {
            Tables = tables;
            Objects = objects;
            Files = files;
        }

        /// <summary> Projections to Azure Table storage. </summary>
        public IList<KnowledgeStoreTableProjectionSelector> Tables { get; }
        /// <summary> Projections to Azure Blob storage. </summary>
        public IList<KnowledgeStoreObjectProjectionSelector> Objects { get; }
        /// <summary> Projections to Azure File storage. </summary>
        public IList<KnowledgeStoreFileProjectionSelector> Files { get; }
    }
}
