// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> Properties of a container. </summary>
    internal partial class ContainerPropertiesInternal
    {
        /// <summary> Initializes a new instance of ContainerPropertiesInternal. </summary>
        /// <param name="lastModified"> . </param>
        /// <param name="etag"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="etag"/> is null. </exception>
        internal ContainerPropertiesInternal(DateTimeOffset lastModified, string etag)
        {
            if (etag == null)
            {
                throw new ArgumentNullException(nameof(etag));
            }

            LastModified = lastModified;
            Etag = etag;
        }

        /// <summary> Initializes a new instance of ContainerPropertiesInternal. </summary>
        /// <param name="lastModified"> . </param>
        /// <param name="etag"> . </param>
        /// <param name="leaseStatus"> . </param>
        /// <param name="leaseState"> . </param>
        /// <param name="leaseDuration"> . </param>
        /// <param name="publicAccess"> . </param>
        /// <param name="hasImmutabilityPolicy"> . </param>
        /// <param name="hasLegalHold"> . </param>
        /// <param name="defaultEncryptionScope"> . </param>
        /// <param name="preventEncryptionScopeOverride"> . </param>
        /// <param name="deletedTime"> . </param>
        /// <param name="remainingRetentionDays"> . </param>
        /// <param name="isImmutableStorageWithVersioningEnabled"> Indicates if version level worm is enabled on this container. </param>
        internal ContainerPropertiesInternal(DateTimeOffset lastModified, string etag, LeaseStatus? leaseStatus, LeaseState? leaseState, LeaseDurationType? leaseDuration, PublicAccessType? publicAccess, bool? hasImmutabilityPolicy, bool? hasLegalHold, string defaultEncryptionScope, bool? preventEncryptionScopeOverride, DateTimeOffset? deletedTime, int? remainingRetentionDays, bool? isImmutableStorageWithVersioningEnabled)
        {
            LastModified = lastModified;
            Etag = etag;
            LeaseStatus = leaseStatus;
            LeaseState = leaseState;
            LeaseDuration = leaseDuration;
            PublicAccess = publicAccess;
            HasImmutabilityPolicy = hasImmutabilityPolicy;
            HasLegalHold = hasLegalHold;
            DefaultEncryptionScope = defaultEncryptionScope;
            PreventEncryptionScopeOverride = preventEncryptionScopeOverride;
            DeletedTime = deletedTime;
            RemainingRetentionDays = remainingRetentionDays;
            IsImmutableStorageWithVersioningEnabled = isImmutableStorageWithVersioningEnabled;
        }

        public DateTimeOffset LastModified { get; }
        public string Etag { get; }
        public LeaseStatus? LeaseStatus { get; }
        public LeaseState? LeaseState { get; }
        public LeaseDurationType? LeaseDuration { get; }
        public PublicAccessType? PublicAccess { get; }
        public bool? HasImmutabilityPolicy { get; }
        public bool? HasLegalHold { get; }
        public string DefaultEncryptionScope { get; }
        public bool? PreventEncryptionScopeOverride { get; }
        public DateTimeOffset? DeletedTime { get; }
        public int? RemainingRetentionDays { get; }
        /// <summary> Indicates if version level worm is enabled on this container. </summary>
        public bool? IsImmutableStorageWithVersioningEnabled { get; }
    }
}
