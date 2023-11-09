// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The RecordingStateResponse. </summary>
    public partial class RecordingStateResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RecordingStateResult"/>. </summary>
        internal RecordingStateResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RecordingStateResult"/>. </summary>
        /// <param name="recordingId"></param>
        /// <param name="recordingState"></param>
        /// <param name="recordingType"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RecordingStateResult(string recordingId, RecordingState? recordingState, RecordingType? recordingType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RecordingId = recordingId;
            RecordingState = recordingState;
            RecordingType = recordingType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the recording id. </summary>
        public string RecordingId { get; }
        /// <summary> Gets the recording state. </summary>
        public RecordingState? RecordingState { get; }
        /// <summary> Gets the recording type. </summary>
        public RecordingType? RecordingType { get; }
    }
}
