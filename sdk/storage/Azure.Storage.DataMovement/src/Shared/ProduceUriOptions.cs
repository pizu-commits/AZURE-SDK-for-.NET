﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.Storage.DataMovement.Shared
{
    /// <summary>
    /// Defines whether or not the class can produce a URL
    /// </summary>
    [Flags]
    public enum ProduceUriOptions
    {
        /// <summary>
        /// Produces Uri
        /// </summary>
        ProducesUri = 1,

        /// <summary>
        /// Cannot produce Uri
        /// </summary>
        NoUri = ~0,
    }
}
