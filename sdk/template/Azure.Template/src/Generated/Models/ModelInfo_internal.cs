// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Basic custom model information. </summary>
    internal partial class ModelInfo_internal
    {
        /// <summary> Model identifier. </summary>
        public Guid ModelId { get; set; }
        /// <summary> Status of the model. </summary>
        public ModelStatus Status { get; set; }
        /// <summary> Date and time (UTC) when the model was created. </summary>
        public DateTimeOffset CreatedDateTime { get; set; }
        /// <summary> Date and time (UTC) when the status was last updated. </summary>
        public DateTimeOffset LastUpdatedDateTime { get; set; }
    }
}
