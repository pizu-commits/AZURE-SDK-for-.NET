// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Configuration for a scoring code asset. </summary>
    public partial class MachineLearningCodeConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningCodeConfiguration"/>. </summary>
        /// <param name="scoringScript"> [Required] The script to execute on startup. eg. "score.py". </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scoringScript"/> is null. </exception>
        public MachineLearningCodeConfiguration(string scoringScript)
        {
            Argument.AssertNotNull(scoringScript, nameof(scoringScript));

            ScoringScript = scoringScript;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningCodeConfiguration"/>. </summary>
        /// <param name="codeId"> ARM resource ID of the code asset. </param>
        /// <param name="scoringScript"> [Required] The script to execute on startup. eg. "score.py". </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningCodeConfiguration(ResourceIdentifier codeId, string scoringScript, Dictionary<string, BinaryData> rawData)
        {
            CodeId = codeId;
            ScoringScript = scoringScript;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningCodeConfiguration"/> for deserialization. </summary>
        internal MachineLearningCodeConfiguration()
        {
        }

        /// <summary> ARM resource ID of the code asset. </summary>
        public ResourceIdentifier CodeId { get; set; }
        /// <summary> [Required] The script to execute on startup. eg. "score.py". </summary>
        public string ScoringScript { get; set; }
    }
}
