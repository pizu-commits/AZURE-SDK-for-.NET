﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.DigitalTwins.Core.QueryBuilder
{
    /// <summary>
    /// Collections that can be queried.
    /// </summary>
    public enum AdtCollection
    {
        /// <summary>
        /// DigitalTwins collection in an ADT instance.
        /// </summary>
        DIGITALTWINS = 0,

        /// <summary>
        /// Relationships in an ADT instance.
        /// </summary>
        RELATIONSHIPS = 1,
    }
}
