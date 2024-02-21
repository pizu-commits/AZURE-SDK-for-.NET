// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.CallAutomation
{
    /// <summary> Configuration of Media streaming. </summary>
    internal partial class MediaStreamingOptionsInternal
    {
        /// <summary> Initializes a new instance of <see cref="MediaStreamingOptionsInternal"/>. </summary>
        /// <param name="transportUrl"> Transport URL for media streaming. </param>
        /// <param name="transportType"> The type of transport to be used for media streaming, eg. Websocket. </param>
        /// <param name="contentType"> Content type to stream, eg. audio, audio/video. </param>
        /// <param name="audioChannelType"> Audio channel type to stream, eg. unmixed audio, mixed audio. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="transportUrl"/> is null. </exception>
        public MediaStreamingOptionsInternal(string transportUrl, MediaStreamingTransport transportType, MediaStreamingContent contentType, MediaStreamingAudioChannel audioChannelType)
        {
            if (transportUrl == null)
            {
                throw new ArgumentNullException(nameof(transportUrl));
            }

            TransportUrl = transportUrl;
            TransportType = transportType;
            ContentType = contentType;
            AudioChannelType = audioChannelType;
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
