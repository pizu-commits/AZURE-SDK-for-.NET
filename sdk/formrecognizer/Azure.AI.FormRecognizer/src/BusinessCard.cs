﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// </summary>
    public class BusinessCard
    {
        internal BusinessCard()
        {
        }

        /// <summary>
        /// </summary>
        public IReadOnlyList<FormPageInfo> PageInfos { get; }

        /// <summary>
        /// </summary>
        public IReadOnlyList<FormPageText> TextElements { get; }
    }
}
