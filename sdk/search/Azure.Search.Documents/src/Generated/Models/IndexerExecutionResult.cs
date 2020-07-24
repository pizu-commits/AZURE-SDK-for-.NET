// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Represents the result of an individual indexer execution. </summary>
    public partial class IndexerExecutionResult
    {
        /// <summary> Initializes a new instance of IndexerExecutionResult. </summary>
        /// <param name="status"> The outcome of this indexer execution. </param>
        /// <param name="errors"> The item-level indexing errors. </param>
        /// <param name="warnings"> The item-level indexing warnings. </param>
        /// <param name="itemCount"> The number of items that were processed during this indexer execution. This includes both successfully processed items and items where indexing was attempted but failed. </param>
        /// <param name="failedItemCount"> The number of items that failed to be indexed during this indexer execution. </param>
        internal IndexerExecutionResult(IndexerExecutionStatus status, IEnumerable<SearchIndexerError> errors, IEnumerable<SearchIndexerWarning> warnings, int itemCount, int failedItemCount)
        {
            if (errors == null)
            {
                throw new ArgumentNullException(nameof(errors));
            }
            if (warnings == null)
            {
                throw new ArgumentNullException(nameof(warnings));
            }

            Status = status;
            Errors = errors.ToList();
            Warnings = warnings.ToList();
            ItemCount = itemCount;
            FailedItemCount = failedItemCount;
        }

        /// <summary> Initializes a new instance of IndexerExecutionResult. </summary>
        /// <param name="status"> The outcome of this indexer execution. </param>
        /// <param name="errorMessage"> The error message indicating the top-level error, if any. </param>
        /// <param name="startTime"> The start time of this indexer execution. </param>
        /// <param name="endTime"> The end time of this indexer execution, if the execution has already completed. </param>
        /// <param name="errors"> The item-level indexing errors. </param>
        /// <param name="warnings"> The item-level indexing warnings. </param>
        /// <param name="itemCount"> The number of items that were processed during this indexer execution. This includes both successfully processed items and items where indexing was attempted but failed. </param>
        /// <param name="failedItemCount"> The number of items that failed to be indexed during this indexer execution. </param>
        /// <param name="initialTrackingState"> Change tracking state with which an indexer execution started. </param>
        /// <param name="finalTrackingState"> Change tracking state with which an indexer execution finished. </param>
        internal IndexerExecutionResult(IndexerExecutionStatus status, string errorMessage, DateTimeOffset? startTime, DateTimeOffset? endTime, IReadOnlyList<SearchIndexerError> errors, IReadOnlyList<SearchIndexerWarning> warnings, int itemCount, int failedItemCount, string initialTrackingState, string finalTrackingState)
        {
            Status = status;
            ErrorMessage = errorMessage;
            StartTime = startTime;
            EndTime = endTime;
            Errors = errors;
            Warnings = warnings;
            ItemCount = itemCount;
            FailedItemCount = failedItemCount;
            InitialTrackingState = initialTrackingState;
            FinalTrackingState = finalTrackingState;
        }

        /// <summary> The outcome of this indexer execution. </summary>
        public IndexerExecutionStatus Status { get; }
        /// <summary> The error message indicating the top-level error, if any. </summary>
        public string ErrorMessage { get; }
        /// <summary> The start time of this indexer execution. </summary>
        public DateTimeOffset? StartTime { get; }
        /// <summary> The end time of this indexer execution, if the execution has already completed. </summary>
        public DateTimeOffset? EndTime { get; }
        /// <summary> The item-level indexing errors. </summary>
        public IReadOnlyList<SearchIndexerError> Errors { get; }
        /// <summary> The item-level indexing warnings. </summary>
        public IReadOnlyList<SearchIndexerWarning> Warnings { get; }
        /// <summary> The number of items that were processed during this indexer execution. This includes both successfully processed items and items where indexing was attempted but failed. </summary>
        public int ItemCount { get; }
        /// <summary> The number of items that failed to be indexed during this indexer execution. </summary>
        public int FailedItemCount { get; }
        /// <summary> Change tracking state with which an indexer execution started. </summary>
        public string InitialTrackingState { get; }
        /// <summary> Change tracking state with which an indexer execution finished. </summary>
        public string FinalTrackingState { get; }
    }
}
