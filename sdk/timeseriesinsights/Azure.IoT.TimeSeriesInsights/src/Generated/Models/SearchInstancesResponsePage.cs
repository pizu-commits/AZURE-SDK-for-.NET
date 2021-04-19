// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Single page of the search results. </summary>
    public partial class SearchInstancesResponsePage
    {
        /// <summary> Initializes a new instance of SearchInstancesResponsePage. </summary>
        internal SearchInstancesResponsePage()
        {
        }

        /// <summary> Initializes a new instance of SearchInstancesResponsePage. </summary>
        /// <param name="instances"> The instances matching the query based on the input. May be empty or null. </param>
        /// <param name="hierarchyNodes"> The hierarchy nodes which contains the instances matching the query based on the input. May be empty or null. </param>
        internal SearchInstancesResponsePage(SearchInstancesResponse instances, SearchHierarchyNodesResponse hierarchyNodes)
        {
            Instances = instances;
            HierarchyNodes = hierarchyNodes;
        }

        /// <summary> The instances matching the query based on the input. May be empty or null. </summary>
        public SearchInstancesResponse Instances { get; }
        /// <summary> The hierarchy nodes which contains the instances matching the query based on the input. May be empty or null. </summary>
        public SearchHierarchyNodesResponse HierarchyNodes { get; }
    }
}
