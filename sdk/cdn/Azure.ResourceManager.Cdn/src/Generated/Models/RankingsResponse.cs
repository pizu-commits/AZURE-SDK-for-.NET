// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Rankings Response. </summary>
    public partial class RankingsResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RankingsResponse"/>. </summary>
        internal RankingsResponse()
        {
            Tables = new ChangeTrackingList<RankingsResponseTablesItem>();
        }

        /// <summary> Initializes a new instance of <see cref="RankingsResponse"/>. </summary>
        /// <param name="dateTimeBegin"></param>
        /// <param name="dateTimeEnd"></param>
        /// <param name="tables"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RankingsResponse(DateTimeOffset? dateTimeBegin, DateTimeOffset? dateTimeEnd, IReadOnlyList<RankingsResponseTablesItem> tables, Dictionary<string, BinaryData> rawData)
        {
            DateTimeBegin = dateTimeBegin;
            DateTimeEnd = dateTimeEnd;
            Tables = tables;
            _rawData = rawData;
        }

        /// <summary> Gets the date time begin. </summary>
        public DateTimeOffset? DateTimeBegin { get; }
        /// <summary> Gets the date time end. </summary>
        public DateTimeOffset? DateTimeEnd { get; }
        /// <summary> Gets the tables. </summary>
        public IReadOnlyList<RankingsResponseTablesItem> Tables { get; }
    }
}
