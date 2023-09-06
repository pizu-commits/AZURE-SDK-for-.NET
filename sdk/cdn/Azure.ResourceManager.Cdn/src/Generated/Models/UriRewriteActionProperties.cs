// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the parameters for the url rewrite action. </summary>
    public partial class UriRewriteActionProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="UriRewriteActionProperties"/>. </summary>
        /// <param name="actionType"></param>
        /// <param name="sourcePattern"> define a request URI pattern that identifies the type of requests that may be rewritten. If value is blank, all strings are matched. </param>
        /// <param name="destination"> Define the relative URL to which the above requests will be rewritten by. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourcePattern"/> or <paramref name="destination"/> is null. </exception>
        public UriRewriteActionProperties(UriRewriteActionType actionType, string sourcePattern, string destination)
        {
            Argument.AssertNotNull(sourcePattern, nameof(sourcePattern));
            Argument.AssertNotNull(destination, nameof(destination));

            ActionType = actionType;
            SourcePattern = sourcePattern;
            Destination = destination;
        }

        /// <summary> Initializes a new instance of <see cref="UriRewriteActionProperties"/>. </summary>
        /// <param name="actionType"></param>
        /// <param name="sourcePattern"> define a request URI pattern that identifies the type of requests that may be rewritten. If value is blank, all strings are matched. </param>
        /// <param name="destination"> Define the relative URL to which the above requests will be rewritten by. </param>
        /// <param name="preserveUnmatchedPath"> Whether to preserve unmatched path. Default value is true. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UriRewriteActionProperties(UriRewriteActionType actionType, string sourcePattern, string destination, bool? preserveUnmatchedPath, Dictionary<string, BinaryData> rawData)
        {
            ActionType = actionType;
            SourcePattern = sourcePattern;
            Destination = destination;
            PreserveUnmatchedPath = preserveUnmatchedPath;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="UriRewriteActionProperties"/> for deserialization. </summary>
        internal UriRewriteActionProperties()
        {
        }

        /// <summary> Gets or sets the action type. </summary>
        public UriRewriteActionType ActionType { get; set; }
        /// <summary> define a request URI pattern that identifies the type of requests that may be rewritten. If value is blank, all strings are matched. </summary>
        public string SourcePattern { get; set; }
        /// <summary> Define the relative URL to which the above requests will be rewritten by. </summary>
        public string Destination { get; set; }
        /// <summary> Whether to preserve unmatched path. Default value is true. </summary>
        public bool? PreserveUnmatchedPath { get; set; }
    }
}
