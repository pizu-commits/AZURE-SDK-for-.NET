// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary> An enumeration of shares. </summary>
    internal partial class ListSharesResponse
    {
        /// <summary> Initializes a new instance of ListSharesResponse. </summary>
        /// <param name="serviceEndpoint"></param>
        /// <param name="nextMarker"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpoint"/> or <paramref name="nextMarker"/> is null. </exception>
        internal ListSharesResponse(string serviceEndpoint, string nextMarker)
        {
            if (serviceEndpoint == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpoint));
            }
            if (nextMarker == null)
            {
                throw new ArgumentNullException(nameof(nextMarker));
            }

            ServiceEndpoint = serviceEndpoint;
            ShareItems = new ChangeTrackingList<ShareItemInternal>();
            NextMarker = nextMarker;
        }

        /// <summary> Initializes a new instance of ListSharesResponse. </summary>
        /// <param name="serviceEndpoint"></param>
        /// <param name="prefix"></param>
        /// <param name="marker"></param>
        /// <param name="maxResults"></param>
        /// <param name="shareItems"></param>
        /// <param name="nextMarker"></param>
        internal ListSharesResponse(string serviceEndpoint, string prefix, string marker, int? maxResults, IReadOnlyList<ShareItemInternal> shareItems, string nextMarker)
        {
            ServiceEndpoint = serviceEndpoint;
            Prefix = prefix;
            Marker = marker;
            MaxResults = maxResults;
            ShareItems = shareItems;
            NextMarker = nextMarker;
        }

        /// <summary> Gets the service endpoint. </summary>
        public string ServiceEndpoint { get; }
        /// <summary> Gets the prefix. </summary>
        public string Prefix { get; }
        /// <summary> Gets the marker. </summary>
        public string Marker { get; }
        /// <summary> Gets the max results. </summary>
        public int? MaxResults { get; }
        /// <summary> Gets the share items. </summary>
        public IReadOnlyList<ShareItemInternal> ShareItems { get; }
        /// <summary> Gets the next marker. </summary>
        public string NextMarker { get; }
    }
}
