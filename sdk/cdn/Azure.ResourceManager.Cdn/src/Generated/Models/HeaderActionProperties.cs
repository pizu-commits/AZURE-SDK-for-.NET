// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the parameters for the request header action. </summary>
    public partial class HeaderActionProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HeaderActionProperties"/>. </summary>
        /// <param name="actionType"></param>
        /// <param name="headerAction"> Action to perform. </param>
        /// <param name="headerName"> Name of the header to modify. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="headerName"/> is null. </exception>
        public HeaderActionProperties(HeaderActionType actionType, HeaderAction headerAction, string headerName)
        {
            Argument.AssertNotNull(headerName, nameof(headerName));

            ActionType = actionType;
            HeaderAction = headerAction;
            HeaderName = headerName;
        }

        /// <summary> Initializes a new instance of <see cref="HeaderActionProperties"/>. </summary>
        /// <param name="actionType"></param>
        /// <param name="headerAction"> Action to perform. </param>
        /// <param name="headerName"> Name of the header to modify. </param>
        /// <param name="value"> Value for the specified action. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HeaderActionProperties(HeaderActionType actionType, HeaderAction headerAction, string headerName, string value, Dictionary<string, BinaryData> rawData)
        {
            ActionType = actionType;
            HeaderAction = headerAction;
            HeaderName = headerName;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="HeaderActionProperties"/> for deserialization. </summary>
        internal HeaderActionProperties()
        {
        }

        /// <summary> Gets or sets the action type. </summary>
        public HeaderActionType ActionType { get; set; }
        /// <summary> Action to perform. </summary>
        public HeaderAction HeaderAction { get; set; }
        /// <summary> Name of the header to modify. </summary>
        public string HeaderName { get; set; }
        /// <summary> Value for the specified action. </summary>
        public string Value { get; set; }
    }
}
