// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using Azure.AI.FormRecognizer;
using Azure.AI.FormRecognizer.Custom;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Response to the get custom model operation. </summary>
    internal partial class Model_internal
    {
        /// <summary> Basic custom model information. </summary>
        public ModelInfo_internal ModelInfo { get; set; } = new ModelInfo_internal();
        /// <summary> Keys extracted by the custom model. </summary>
        public KeysResult_internal Keys { get; set; }
        /// <summary> Custom model training result. </summary>
        public TrainResult_internal TrainResult { get; set; }
    }
}
