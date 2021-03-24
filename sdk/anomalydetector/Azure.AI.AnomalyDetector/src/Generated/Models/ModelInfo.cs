// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.AnomalyDetector
{
    /// <summary> Train result of a model including status, errors and diagnose info for model and variables. </summary>
    public partial class ModelInfo
    {
        /// <summary> Initializes a new instance of ModelInfo. </summary>
        /// <param name="source"> source file link of the input variables, each variable will be a csv with two columns, the first column will be timestamp, the second column will be value.Besides these variable csv files, an extra meta.json can be included in th zip file if you would like to rename a variable.Be default, the file name of the variable will be used as the variable name. </param>
        /// <param name="startTime"> require field, start time of data be used for generating multivariate anomaly detection model, should be data-time. </param>
        /// <param name="endTime"> require field, end time of data be used for generating multivariate anomaly detection model, should be data-time. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> is null. </exception>
        public ModelInfo(string source, DateTimeOffset startTime, DateTimeOffset endTime)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            Source = source;
            StartTime = startTime;
            EndTime = endTime;
            Errors = new ChangeTrackingList<ErrorResponse>();
        }

        /// <summary> Initializes a new instance of ModelInfo. </summary>
        /// <param name="slidingWindow"> An optional field, indicates how many history points will be used to determine the anomaly score of one subsequent point. </param>
        /// <param name="alignPolicy"> An optional field, since those multivariate need to be aligned in the same timestamp before starting the detection. </param>
        /// <param name="source"> source file link of the input variables, each variable will be a csv with two columns, the first column will be timestamp, the second column will be value.Besides these variable csv files, an extra meta.json can be included in th zip file if you would like to rename a variable.Be default, the file name of the variable will be used as the variable name. </param>
        /// <param name="startTime"> require field, start time of data be used for generating multivariate anomaly detection model, should be data-time. </param>
        /// <param name="endTime"> require field, end time of data be used for generating multivariate anomaly detection model, should be data-time. </param>
        /// <param name="displayName"> optional field, name of the model. </param>
        /// <param name="status"> Model training status. </param>
        /// <param name="errors"> Error message when fails to create a model. </param>
        /// <param name="diagnosticsInfo"> Used for deep analysis model and variables. </param>
        internal ModelInfo(int? slidingWindow, AlignPolicy alignPolicy, string source, DateTimeOffset startTime, DateTimeOffset endTime, string displayName, ModelStatus? status, IReadOnlyList<ErrorResponse> errors, DiagnosticsInfo diagnosticsInfo)
        {
            SlidingWindow = slidingWindow;
            AlignPolicy = alignPolicy;
            Source = source;
            StartTime = startTime;
            EndTime = endTime;
            DisplayName = displayName;
            Status = status;
            Errors = errors;
            DiagnosticsInfo = diagnosticsInfo;
        }

        /// <summary> An optional field, indicates how many history points will be used to determine the anomaly score of one subsequent point. </summary>
        public int? SlidingWindow { get; set; }
        /// <summary> An optional field, since those multivariate need to be aligned in the same timestamp before starting the detection. </summary>
        public AlignPolicy AlignPolicy { get; set; }
        /// <summary> source file link of the input variables, each variable will be a csv with two columns, the first column will be timestamp, the second column will be value.Besides these variable csv files, an extra meta.json can be included in th zip file if you would like to rename a variable.Be default, the file name of the variable will be used as the variable name. </summary>
        public string Source { get; set; }
        /// <summary> require field, start time of data be used for generating multivariate anomaly detection model, should be data-time. </summary>
        public DateTimeOffset StartTime { get; set; }
        /// <summary> require field, end time of data be used for generating multivariate anomaly detection model, should be data-time. </summary>
        public DateTimeOffset EndTime { get; set; }
        /// <summary> optional field, name of the model. </summary>
        public string DisplayName { get; set; }
        /// <summary> Model training status. </summary>
        public ModelStatus? Status { get; }
        /// <summary> Error message when fails to create a model. </summary>
        public IReadOnlyList<ErrorResponse> Errors { get; }
        /// <summary> Used for deep analysis model and variables. </summary>
        public DiagnosticsInfo DiagnosticsInfo { get; }
    }
}
