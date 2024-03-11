// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.DigitalTwins.Core
{
    /// <summary> A collection of incoming relationships which relate digital twins together. </summary>
    internal partial class IncomingRelationshipCollection
    {
        /// <summary> Initializes a new instance of <see cref="IncomingRelationshipCollection"/>. </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal IncomingRelationshipCollection(IEnumerable<IncomingRelationship> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="IncomingRelationshipCollection"/>. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> A URI to retrieve the next page of objects. </param>
        internal IncomingRelationshipCollection(IReadOnlyList<IncomingRelationship> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<IncomingRelationship> Value { get; }
        /// <summary> A URI to retrieve the next page of objects. </summary>
        public string NextLink { get; }
    }
}
