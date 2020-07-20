// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.Models
{
    /// <summary> Ingest track discontinuity detected event data. </summary>
    public partial class MediaLiveEventTrackDiscontinuityDetectedEventData
    {
        /// <summary> Initializes a new instance of MediaLiveEventTrackDiscontinuityDetectedEventData. </summary>
        internal MediaLiveEventTrackDiscontinuityDetectedEventData()
        {
        }

        /// <summary> Initializes a new instance of MediaLiveEventTrackDiscontinuityDetectedEventData. </summary>
        /// <param name="trackType"> Gets the type of the track (Audio / Video). </param>
        /// <param name="trackName"> Gets the track name. </param>
        /// <param name="bitrate"> Gets the bitrate. </param>
        /// <param name="previousTimestamp"> Gets the timestamp of the previous fragment. </param>
        /// <param name="newTimestamp"> Gets the timestamp of the current fragment. </param>
        /// <param name="timescale"> Gets the timescale in which both timestamps and discontinuity gap are represented. </param>
        /// <param name="discontinuityGap"> Gets the discontinuity gap between PreviousTimestamp and NewTimestamp. </param>
        internal MediaLiveEventTrackDiscontinuityDetectedEventData(string trackType, string trackName, long? bitrate, string previousTimestamp, string newTimestamp, string timescale, string discontinuityGap)
        {
            TrackType = trackType;
            TrackName = trackName;
            Bitrate = bitrate;
            PreviousTimestamp = previousTimestamp;
            NewTimestamp = newTimestamp;
            Timescale = timescale;
            DiscontinuityGap = discontinuityGap;
        }

        /// <summary> Gets the type of the track (Audio / Video). </summary>
        public string TrackType { get; }
        /// <summary> Gets the track name. </summary>
        public string TrackName { get; }
        /// <summary> Gets the bitrate. </summary>
        public long? Bitrate { get; }
        /// <summary> Gets the timestamp of the previous fragment. </summary>
        public string PreviousTimestamp { get; }
        /// <summary> Gets the timestamp of the current fragment. </summary>
        public string NewTimestamp { get; }
        /// <summary> Gets the timescale in which both timestamps and discontinuity gap are represented. </summary>
        public string Timescale { get; }
        /// <summary> Gets the discontinuity gap between PreviousTimestamp and NewTimestamp. </summary>
        public string DiscontinuityGap { get; }
    }
}
