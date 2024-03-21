// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AlertResultList. </summary>
    internal partial class AlertResultList
    {
        /// <summary> Initializes a new instance of <see cref="AlertResultList"/>. </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal AlertResultList(IEnumerable<AnomalyAlert> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AlertResultList"/>. </summary>
        /// <param name="nextLink"></param>
        /// <param name="value"></param>
        internal AlertResultList(string nextLink, IReadOnlyList<AnomalyAlert> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
        /// <summary> Gets the value. </summary>
        public IReadOnlyList<AnomalyAlert> Value { get; }
    }
}
