// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Data.Tables;

namespace Azure.Data.Tables.Models
{
    /// <summary> Azure Analytics Logging settings. </summary>
    public partial class TableAnalyticsLoggingSettings
    {
        /// <summary> Initializes a new instance of <see cref="TableAnalyticsLoggingSettings"/>. </summary>
        /// <param name="version"> The version of Analytics to configure. </param>
        /// <param name="delete"> Indicates whether all delete requests should be logged. </param>
        /// <param name="read"> Indicates whether all read requests should be logged. </param>
        /// <param name="write"> Indicates whether all write requests should be logged. </param>
        /// <param name="retentionPolicy"> The retention policy. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="retentionPolicy"/> is null. </exception>
        public TableAnalyticsLoggingSettings(string version, bool delete, bool read, bool write, TableRetentionPolicy retentionPolicy)
        {
            Argument.AssertNotNull(version, nameof(version));
            Argument.AssertNotNull(retentionPolicy, nameof(retentionPolicy));

            Version = version;
            Delete = delete;
            Read = read;
            Write = write;
            RetentionPolicy = retentionPolicy;
        }

        /// <summary> The version of Analytics to configure. </summary>
        public string Version { get; set; }
        /// <summary> Indicates whether all delete requests should be logged. </summary>
        public bool Delete { get; set; }
        /// <summary> Indicates whether all read requests should be logged. </summary>
        public bool Read { get; set; }
        /// <summary> Indicates whether all write requests should be logged. </summary>
        public bool Write { get; set; }
        /// <summary> The retention policy. </summary>
        public TableRetentionPolicy RetentionPolicy { get; set; }
    }
}
