// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Diagnostic parameters of diagnostic operations. </summary>
    public partial class ApplicationDiagnosticContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ApplicationDiagnosticContent"/>. </summary>
        public ApplicationDiagnosticContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationDiagnosticContent"/>. </summary>
        /// <param name="appInstance"> App instance name. </param>
        /// <param name="filePath"> Your target file path in your own BYOS. </param>
        /// <param name="durationValue"> Duration of your JFR. 1 min can be represented by 1m or 60s. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationDiagnosticContent(string appInstance, string filePath, string durationValue, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AppInstance = appInstance;
            FilePath = filePath;
            DurationValue = durationValue;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> App instance name. </summary>
        public string AppInstance { get; set; }
        /// <summary> Your target file path in your own BYOS. </summary>
        public string FilePath { get; set; }
        /// <summary> Duration of your JFR. 1 min can be represented by 1m or 60s. </summary>
        public string DurationValue { get; set; }
    }
}
