// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;

namespace Azure.AI.FormRecognizer.Custom
{
    internal static class ModelStatusExtensions
    {
        public static string ToSerialString(this ModelStatus value) => value switch
        {
            ModelStatus.Creating => "creating",
            ModelStatus.Ready => "ready",
            ModelStatus.Invalid => "invalid",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ModelStatus value.")
        };

        public static ModelStatus ToModelStatus(this string value) => value switch
        {
            "creating" => ModelStatus.Creating,
            "ready" => ModelStatus.Ready,
            "invalid" => ModelStatus.Invalid,
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ModelStatus value.")
        };
    }
}
