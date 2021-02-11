// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.Chat
{
    /// <summary> Collection of chat threads. </summary>
    internal partial class ChatThreadsInfoCollection
    {
        /// <summary> Initializes a new instance of ChatThreadsInfoCollection. </summary>
        /// <param name="value"> Collection of chat threads. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ChatThreadsInfoCollection(IEnumerable<ChatThreadInfo> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of ChatThreadsInfoCollection. </summary>
        /// <param name="value"> Collection of chat threads. </param>
        /// <param name="nextLink"> If there are more chat threads that can be retrieved, the next link will be populated. </param>
        internal ChatThreadsInfoCollection(IReadOnlyList<ChatThreadInfo> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Collection of chat threads. </summary>
        public IReadOnlyList<ChatThreadInfo> Value { get; }
        /// <summary> If there are more chat threads that can be retrieved, the next link will be populated. </summary>
        public string NextLink { get; }
    }
}
