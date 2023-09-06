// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.CallingServer
{
    /// <summary> The PlaySource. </summary>
    internal partial class PlaySourceInternal
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PlaySourceInternal"/>. </summary>
        /// <param name="sourceType"> Defines the type of the play source. </param>
        public PlaySourceInternal(PlaySourceTypeInternal sourceType)
        {
            SourceType = sourceType;
        }

        /// <summary> Initializes a new instance of <see cref="PlaySourceInternal"/>. </summary>
        /// <param name="sourceType"> Defines the type of the play source. </param>
        /// <param name="playSourceId"> Defines the identifier to be used for caching related media. </param>
        /// <param name="fileSource"> Defines the file source info to be used for play. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PlaySourceInternal(PlaySourceTypeInternal sourceType, string playSourceId, FileSourceInternal fileSource, Dictionary<string, BinaryData> rawData)
        {
            SourceType = sourceType;
            PlaySourceId = playSourceId;
            FileSource = fileSource;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="PlaySourceInternal"/> for deserialization. </summary>
        internal PlaySourceInternal()
        {
        }

        /// <summary> Defines the type of the play source. </summary>
        public PlaySourceTypeInternal SourceType { get; }
        /// <summary> Defines the identifier to be used for caching related media. </summary>
        public string PlaySourceId { get; set; }
        /// <summary> Defines the file source info to be used for play. </summary>
        public FileSourceInternal FileSource { get; set; }
    }
}
