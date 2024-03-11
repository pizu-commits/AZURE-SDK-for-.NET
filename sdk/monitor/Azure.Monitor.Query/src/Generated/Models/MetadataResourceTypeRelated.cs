// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Monitor.Query;

namespace Azure.Monitor.Query.Models
{
    /// <summary> The related metadata items for the resource-type. </summary>
    internal partial class MetadataResourceTypeRelated
    {
        /// <summary> Initializes a new instance of <see cref="MetadataResourceTypeRelated"/>. </summary>
        internal MetadataResourceTypeRelated()
        {
            Tables = new ChangeTrackingList<string>();
            Functions = new ChangeTrackingList<string>();
            Categories = new ChangeTrackingList<string>();
            Queries = new ChangeTrackingList<string>();
            Workspaces = new ChangeTrackingList<string>();
            Resources = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="MetadataResourceTypeRelated"/>. </summary>
        /// <param name="tables"> The tables related to the resource-type. </param>
        /// <param name="functions"> The functions related to the resource-type. </param>
        /// <param name="categories"> The categories related to the resource-type. </param>
        /// <param name="queries"> The queries related to the resource-type. </param>
        /// <param name="workspaces"> The Log Analytics workspaces related to the resource-type. </param>
        /// <param name="resources"> The Azure resources related to the resource-type. </param>
        internal MetadataResourceTypeRelated(IReadOnlyList<string> tables, IReadOnlyList<string> functions, IReadOnlyList<string> categories, IReadOnlyList<string> queries, IReadOnlyList<string> workspaces, IReadOnlyList<string> resources)
        {
            Tables = tables;
            Functions = functions;
            Categories = categories;
            Queries = queries;
            Workspaces = workspaces;
            Resources = resources;
        }

        /// <summary> The tables related to the resource-type. </summary>
        public IReadOnlyList<string> Tables { get; }
        /// <summary> The functions related to the resource-type. </summary>
        public IReadOnlyList<string> Functions { get; }
        /// <summary> The categories related to the resource-type. </summary>
        public IReadOnlyList<string> Categories { get; }
        /// <summary> The queries related to the resource-type. </summary>
        public IReadOnlyList<string> Queries { get; }
        /// <summary> The Log Analytics workspaces related to the resource-type. </summary>
        public IReadOnlyList<string> Workspaces { get; }
        /// <summary> The Azure resources related to the resource-type. </summary>
        public IReadOnlyList<string> Resources { get; }
    }
}
