// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Response body with a run identifier. </summary>
    public partial class CreateRunResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CreateRunResponse"/>. </summary>
        /// <param name="runId"> Identifier of a run. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="runId"/> is null. </exception>
        internal CreateRunResponse(string runId)
        {
            Argument.AssertNotNull(runId, nameof(runId));

            RunId = runId;
        }

        /// <summary> Initializes a new instance of <see cref="CreateRunResponse"/>. </summary>
        /// <param name="runId"> Identifier of a run. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateRunResponse(string runId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RunId = runId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CreateRunResponse"/> for deserialization. </summary>
        internal CreateRunResponse()
        {
        }

        /// <summary> Identifier of a run. </summary>
        public string RunId { get; }
    }
}
