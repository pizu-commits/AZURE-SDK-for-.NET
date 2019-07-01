﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

using System;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.Storage.Blobs.Models
{
    /// <summary>
    /// Specifies options for listing containers with the 
    /// <see cref="BlobServiceClient.GetContainersAsync"/> operation.
    /// </summary>
    public struct GetContainersOptions : IEquatable<GetContainersOptions>
    {
        /// <summary>
        /// Gets or sets a string that filters the results to return only
        /// containers whose name begins with the specified prefix.
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of containers to return. If the
        /// request does not specify <see cref="PageSizeHint"/>, or specifies a
        /// value greater than 5000, the server will return up to 5000 items.
        /// 
        /// Note that if the listing operation crosses a partition boundary,
        /// then the client will need to make another request for retrieving
        /// the remainder of the results.  For this reason, it is possible that
        /// the service will return fewer results than specified by
        /// PageSizeHint, or than the default of 5000. 
        /// 
        /// If the parameter is set to a value less than or equal to zero, 
        /// a <see cref="StorageRequestFailedException"/> will be thrown.
        /// </summary>
        public int? PageSizeHint { get; set; }

        /// <summary>
        /// Gets or sets a flag specifing that the container's metadata should
        /// be included.
        /// </summary>
        public bool IncludeMetadata { get; set; }

        /// <summary>
        /// Convert the details into a ListContainersIncludeType value.
        /// </summary>
        /// <returns>A ListContainersIncludeType value.</returns>
        internal ListContainersIncludeType? AsIncludeType()
            => this.IncludeMetadata ?
                ListContainersIncludeType.Metadata :
                (ListContainersIncludeType?)null;

        /// <summary>
        /// Check if two GetContainersOptions instances are equal.
        /// </summary>
        /// <param name="obj">The instance to compare to.</param>
        /// <returns>True if they're equal, false otherwise.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) =>
            obj is GetContainersOptions other && this.Equals(other);

        /// <summary>
        /// Get a hash code for the GetContainersOptions.
        /// </summary>
        /// <returns>Hash code for the GetContainersOptions.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() =>
            this.IncludeMetadata.GetHashCode() ^
            this.Prefix.GetHashCode() ^
            this.PageSizeHint.GetHashCode();

        /// <summary>
        /// Check if two GetContainersOptions instances are equal.
        /// </summary>
        /// <param name="left">The first instance to compare.</param>
        /// <param name="right">The second instance to compare.</param>
        /// <returns>True if they're equal, false otherwise.</returns>
        public static bool operator ==(GetContainersOptions left, GetContainersOptions right) =>
            left.Equals(right);

        /// <summary>
        /// Check if two GetContainersOptions instances are not equal.
        /// </summary>
        /// <param name="left">The first instance to compare.</param>
        /// <param name="right">The second instance to compare.</param>
        /// <returns>True if they're not equal, false otherwise.</returns>
        public static bool operator !=(GetContainersOptions left, GetContainersOptions right) =>
            !(left == right);

        /// <summary>
        /// Check if two GetContainersOptions instances are equal.
        /// </summary>
        /// <param name="obj">The instance to compare to.</param>
        /// <returns>True if they're equal, false otherwise.</returns>
        public bool Equals(GetContainersOptions other) =>
            this.IncludeMetadata == other.IncludeMetadata &&
            this.PageSizeHint == other.PageSizeHint &&
            this.Prefix == other.Prefix;
    }

    internal class GetContainersAsyncCollection : StorageAsyncCollection<ContainerItem>
    {
        private readonly BlobServiceClient _client;
        private readonly GetContainersOptions? _options;

        public GetContainersAsyncCollection(
            BlobServiceClient client,
            GetContainersOptions? options,
            CancellationToken cancellationToken)
            : base(cancellationToken)
        {
            this._client = client;
            this._options = options;
            this.PageSizeHint = options?.PageSizeHint;
        }

        protected override async Task<Page<ContainerItem>> GetNextPageAsync(
            string continuationToken,
            bool isAsync,
            CancellationToken cancellationToken = default)
        {
            var task = this._client.GetContainersAsync(
                continuationToken,
                this._options,
                this.PageSizeHint,
                isAsync,
                cancellationToken);
            var response = isAsync ?
                await task.ConfigureAwait(false) :
                task.EnsureCompleted(syncOverAsync: true);
            return new Page<ContainerItem>(
                response.Value.ContainerItems.ToArray(),
                response.Value.NextMarker,
                response.GetRawResponse());
        }
    }
}
