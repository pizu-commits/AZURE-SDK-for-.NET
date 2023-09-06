// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.AnomalyDetector
{
    /// <summary>
    /// Training result of a model, including its status, errors, and diagnostics
    /// information.
    /// </summary>
    public partial class ModelInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of ModelInfo. </summary>
        /// <param name="dataSource">
        /// Source link to the input data to indicate an accessible Azure Storage URI.
        /// It either points to an Azure Blob Storage folder or points to a CSV file in
        /// Azure Blob Storage, based on your data schema selection.
        /// </param>
        /// <param name="startTime">
        /// Start date/time of training data, which should be
        /// in ISO 8601 format.
        /// </param>
        /// <param name="endTime">
        /// End date/time of training data, which should be
        /// in ISO 8601 format.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSource"/> is null. </exception>
        public ModelInfo(Uri dataSource, DateTimeOffset startTime, DateTimeOffset endTime)
        {
            Argument.AssertNotNull(dataSource, nameof(dataSource));

            DataSource = dataSource;
            StartTime = startTime;
            EndTime = endTime;
            Errors = new ChangeTrackingList<ErrorResponse>();
        }

        /// <summary> Initializes a new instance of ModelInfo. </summary>
        /// <param name="dataSource">
        /// Source link to the input data to indicate an accessible Azure Storage URI.
        /// It either points to an Azure Blob Storage folder or points to a CSV file in
        /// Azure Blob Storage, based on your data schema selection.
        /// </param>
        /// <param name="dataSchema">
        /// Data schema of the input data source. The default
        /// is OneTable.
        /// </param>
        /// <param name="startTime">
        /// Start date/time of training data, which should be
        /// in ISO 8601 format.
        /// </param>
        /// <param name="endTime">
        /// End date/time of training data, which should be
        /// in ISO 8601 format.
        /// </param>
        /// <param name="displayName">
        /// Display name of the model. Maximum length is 24
        /// characters.
        /// </param>
        /// <param name="slidingWindow">
        /// Number of previous time stamps that will be used to
        /// detect whether the time stamp is an anomaly or not.
        /// </param>
        /// <param name="alignPolicy"> Manner of aligning multiple variables. </param>
        /// <param name="status"> Model status. </param>
        /// <param name="errors"> Error messages after failure to create a model. </param>
        /// <param name="diagnosticsInfo"> Diagnostics information to help inspect the states of a model or variable. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ModelInfo(Uri dataSource, DataSchema? dataSchema, DateTimeOffset startTime, DateTimeOffset endTime, string displayName, int? slidingWindow, AlignPolicy alignPolicy, ModelStatus? status, IReadOnlyList<ErrorResponse> errors, DiagnosticsInfo diagnosticsInfo, Dictionary<string, BinaryData> rawData)
        {
            DataSource = dataSource;
            DataSchema = dataSchema;
            StartTime = startTime;
            EndTime = endTime;
            DisplayName = displayName;
            SlidingWindow = slidingWindow;
            AlignPolicy = alignPolicy;
            Status = status;
            Errors = errors;
            DiagnosticsInfo = diagnosticsInfo;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ModelInfo"/> for deserialization. </summary>
        internal ModelInfo()
        {
        }

        /// <summary>
        /// Source link to the input data to indicate an accessible Azure Storage URI.
        /// It either points to an Azure Blob Storage folder or points to a CSV file in
        /// Azure Blob Storage, based on your data schema selection.
        /// </summary>
        public Uri DataSource { get; set; }
        /// <summary>
        /// Data schema of the input data source. The default
        /// is OneTable.
        /// </summary>
        public DataSchema? DataSchema { get; set; }
        /// <summary>
        /// Start date/time of training data, which should be
        /// in ISO 8601 format.
        /// </summary>
        public DateTimeOffset StartTime { get; set; }
        /// <summary>
        /// End date/time of training data, which should be
        /// in ISO 8601 format.
        /// </summary>
        public DateTimeOffset EndTime { get; set; }
        /// <summary>
        /// Display name of the model. Maximum length is 24
        /// characters.
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// Number of previous time stamps that will be used to
        /// detect whether the time stamp is an anomaly or not.
        /// </summary>
        public int? SlidingWindow { get; set; }
        /// <summary> Manner of aligning multiple variables. </summary>
        public AlignPolicy AlignPolicy { get; set; }
        /// <summary> Model status. </summary>
        public ModelStatus? Status { get; }
        /// <summary> Error messages after failure to create a model. </summary>
        public IReadOnlyList<ErrorResponse> Errors { get; }
        /// <summary> Diagnostics information to help inspect the states of a model or variable. </summary>
        public DiagnosticsInfo DiagnosticsInfo { get; }
    }
}
