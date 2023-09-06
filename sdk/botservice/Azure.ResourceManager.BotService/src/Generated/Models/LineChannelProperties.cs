// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> The parameters to provide for the Line channel. </summary>
    public partial class LineChannelProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LineChannelProperties"/>. </summary>
        /// <param name="lineRegistrations"> The list of line channel registrations. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="lineRegistrations"/> is null. </exception>
        public LineChannelProperties(IEnumerable<LineRegistration> lineRegistrations)
        {
            Argument.AssertNotNull(lineRegistrations, nameof(lineRegistrations));

            LineRegistrations = lineRegistrations.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="LineChannelProperties"/>. </summary>
        /// <param name="lineRegistrations"> The list of line channel registrations. </param>
        /// <param name="callbackUri"> Callback Url to enter in line registration. </param>
        /// <param name="isValidated"> Whether this channel is validated for the bot. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LineChannelProperties(IList<LineRegistration> lineRegistrations, Uri callbackUri, bool? isValidated, Dictionary<string, BinaryData> rawData)
        {
            LineRegistrations = lineRegistrations;
            CallbackUri = callbackUri;
            IsValidated = isValidated;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="LineChannelProperties"/> for deserialization. </summary>
        internal LineChannelProperties()
        {
        }

        /// <summary> The list of line channel registrations. </summary>
        public IList<LineRegistration> LineRegistrations { get; }
        /// <summary> Callback Url to enter in line registration. </summary>
        public Uri CallbackUri { get; }
        /// <summary> Whether this channel is validated for the bot. </summary>
        public bool? IsValidated { get; }
    }
}
