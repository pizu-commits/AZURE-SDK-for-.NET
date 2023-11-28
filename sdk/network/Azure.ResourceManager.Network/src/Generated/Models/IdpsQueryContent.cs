// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Will describe the query to run against the IDPS signatures DB. </summary>
    public partial class IdpsQueryContent
    {
        /// <summary> Initializes a new instance of <see cref="IdpsQueryContent"/>. </summary>
        public IdpsQueryContent()
        {
            Filters = new ChangeTrackingList<IdpsQueryFilterItems>();
        }

        /// <summary> Contain all filters names and values. </summary>
        public IList<IdpsQueryFilterItems> Filters { get; }
        /// <summary> Search term in all columns. </summary>
        public string Search { get; set; }
        /// <summary> Column to sort response by. </summary>
        public IdpsQueryOrderBy OrderBy { get; set; }
        /// <summary> The number of the results to return in each page. </summary>
        public int? ResultsPerPage { get; set; }
        /// <summary> The number of records matching the filter to skip. </summary>
        public int? Skip { get; set; }
    }
}
