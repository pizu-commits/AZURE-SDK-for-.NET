// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Resource type used for verification. </summary>
    public readonly partial struct CheckQuotaNameResourceTypes : IEquatable<CheckQuotaNameResourceTypes>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CheckQuotaNameResourceTypes"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CheckQuotaNameResourceTypes(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MicrosoftNetAppNetAppAccountsValue = "Microsoft.NetApp/netAppAccounts";
        private const string MicrosoftNetAppNetAppAccountsCapacityPoolsValue = "Microsoft.NetApp/netAppAccounts/capacityPools";
        private const string MicrosoftNetAppNetAppAccountsCapacityPoolsVolumesValue = "Microsoft.NetApp/netAppAccounts/capacityPools/volumes";
        private const string MicrosoftNetAppNetAppAccountsCapacityPoolsVolumesSnapshotsValue = "Microsoft.NetApp/netAppAccounts/capacityPools/volumes/snapshots";

        /// <summary> Microsoft.NetApp/netAppAccounts. </summary>
        public static CheckQuotaNameResourceTypes MicrosoftNetAppNetAppAccounts { get; } = new CheckQuotaNameResourceTypes(MicrosoftNetAppNetAppAccountsValue);
        /// <summary> Microsoft.NetApp/netAppAccounts/capacityPools. </summary>
        public static CheckQuotaNameResourceTypes MicrosoftNetAppNetAppAccountsCapacityPools { get; } = new CheckQuotaNameResourceTypes(MicrosoftNetAppNetAppAccountsCapacityPoolsValue);
        /// <summary> Microsoft.NetApp/netAppAccounts/capacityPools/volumes. </summary>
        public static CheckQuotaNameResourceTypes MicrosoftNetAppNetAppAccountsCapacityPoolsVolumes { get; } = new CheckQuotaNameResourceTypes(MicrosoftNetAppNetAppAccountsCapacityPoolsVolumesValue);
        /// <summary> Microsoft.NetApp/netAppAccounts/capacityPools/volumes/snapshots. </summary>
        public static CheckQuotaNameResourceTypes MicrosoftNetAppNetAppAccountsCapacityPoolsVolumesSnapshots { get; } = new CheckQuotaNameResourceTypes(MicrosoftNetAppNetAppAccountsCapacityPoolsVolumesSnapshotsValue);
        /// <summary> Determines if two <see cref="CheckQuotaNameResourceTypes"/> values are the same. </summary>
        public static bool operator ==(CheckQuotaNameResourceTypes left, CheckQuotaNameResourceTypes right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CheckQuotaNameResourceTypes"/> values are not the same. </summary>
        public static bool operator !=(CheckQuotaNameResourceTypes left, CheckQuotaNameResourceTypes right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CheckQuotaNameResourceTypes"/>. </summary>
        public static implicit operator CheckQuotaNameResourceTypes(string value) => new CheckQuotaNameResourceTypes(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CheckQuotaNameResourceTypes other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CheckQuotaNameResourceTypes other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
