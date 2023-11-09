// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary> Configuration of Media streaming. </summary>
    internal partial class MediaStreamingOptionsInternal
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MediaStreamingOptionsInternal"/>. </summary>
        /// <param name="transportUrl"> Transport URL for media streaming. </param>
        /// <param name="transportType"> The type of transport to be used for media streaming, eg. Websocket. </param>
        /// <param name="contentType"> Content type to stream, eg. audio, audio/video. </param>
        /// <param name="audioChannelType"> Audio channel type to stream, eg. unmixed audio, mixed audio. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="transportUrl"/> is null. </exception>
        public MediaStreamingOptionsInternal(string transportUrl, MediaStreamingTransport transportType, MediaStreamingContent contentType, MediaStreamingAudioChannel audioChannelType)
        {
            Argument.AssertNotNull(transportUrl, nameof(transportUrl));

            TransportUrl = transportUrl;
            TransportType = transportType;
            ContentType = contentType;
            AudioChannelType = audioChannelType;
        }

        /// <summary> Initializes a new instance of <see cref="MediaStreamingOptionsInternal"/>. </summary>
        /// <param name="transportUrl"> Transport URL for media streaming. </param>
        /// <param name="transportType"> The type of transport to be used for media streaming, eg. Websocket. </param>
        /// <param name="contentType"> Content type to stream, eg. audio, audio/video. </param>
        /// <param name="audioChannelType"> Audio channel type to stream, eg. unmixed audio, mixed audio. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MediaStreamingOptionsInternal(string transportUrl, MediaStreamingTransport transportType, MediaStreamingContent contentType, MediaStreamingAudioChannel audioChannelType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TransportUrl = transportUrl;
            TransportType = transportType;
            ContentType = contentType;
            AudioChannelType = audioChannelType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MediaStreamingOptionsInternal"/> for deserialization. </summary>
        internal MediaStreamingOptionsInternal()
        {
        }

        /// <summary> Transport URL for media streaming. </summary>
        public string TransportUrl { get; }
        /// <summary> The type of transport to be used for media streaming, eg. Websocket. </summary>
        public MediaStreamingTransport TransportType { get; }
        /// <summary> Content type to stream, eg. audio, audio/video. </summary>
        public MediaStreamingContent ContentType { get; }
        /// <summary> Audio channel type to stream, eg. unmixed audio, mixed audio. </summary>
        public MediaStreamingAudioChannel AudioChannelType { get; }
    }
}
