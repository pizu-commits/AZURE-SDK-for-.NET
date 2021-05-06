// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> The AppServiceCertificateOrderPatchResourcePropertiesAppServiceCertificateNotRenewableReasonsItem. </summary>
    public readonly partial struct AppServiceCertificateOrderPatchResourcePropertiesAppServiceCertificateNotRenewableReasonsItem : IEquatable<AppServiceCertificateOrderPatchResourcePropertiesAppServiceCertificateNotRenewableReasonsItem>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="AppServiceCertificateOrderPatchResourcePropertiesAppServiceCertificateNotRenewableReasonsItem"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AppServiceCertificateOrderPatchResourcePropertiesAppServiceCertificateNotRenewableReasonsItem(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RegistrationStatusNotSupportedForRenewalValue = "RegistrationStatusNotSupportedForRenewal";
        private const string ExpirationNotInRenewalTimeRangeValue = "ExpirationNotInRenewalTimeRange";
        private const string SubscriptionNotActiveValue = "SubscriptionNotActive";

        /// <summary> RegistrationStatusNotSupportedForRenewal. </summary>
        public static AppServiceCertificateOrderPatchResourcePropertiesAppServiceCertificateNotRenewableReasonsItem RegistrationStatusNotSupportedForRenewal { get; } = new AppServiceCertificateOrderPatchResourcePropertiesAppServiceCertificateNotRenewableReasonsItem(RegistrationStatusNotSupportedForRenewalValue);
        /// <summary> ExpirationNotInRenewalTimeRange. </summary>
        public static AppServiceCertificateOrderPatchResourcePropertiesAppServiceCertificateNotRenewableReasonsItem ExpirationNotInRenewalTimeRange { get; } = new AppServiceCertificateOrderPatchResourcePropertiesAppServiceCertificateNotRenewableReasonsItem(ExpirationNotInRenewalTimeRangeValue);
        /// <summary> SubscriptionNotActive. </summary>
        public static AppServiceCertificateOrderPatchResourcePropertiesAppServiceCertificateNotRenewableReasonsItem SubscriptionNotActive { get; } = new AppServiceCertificateOrderPatchResourcePropertiesAppServiceCertificateNotRenewableReasonsItem(SubscriptionNotActiveValue);
        /// <summary> Determines if two <see cref="AppServiceCertificateOrderPatchResourcePropertiesAppServiceCertificateNotRenewableReasonsItem"/> values are the same. </summary>
        public static bool operator ==(AppServiceCertificateOrderPatchResourcePropertiesAppServiceCertificateNotRenewableReasonsItem left, AppServiceCertificateOrderPatchResourcePropertiesAppServiceCertificateNotRenewableReasonsItem right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AppServiceCertificateOrderPatchResourcePropertiesAppServiceCertificateNotRenewableReasonsItem"/> values are not the same. </summary>
        public static bool operator !=(AppServiceCertificateOrderPatchResourcePropertiesAppServiceCertificateNotRenewableReasonsItem left, AppServiceCertificateOrderPatchResourcePropertiesAppServiceCertificateNotRenewableReasonsItem right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AppServiceCertificateOrderPatchResourcePropertiesAppServiceCertificateNotRenewableReasonsItem"/>. </summary>
        public static implicit operator AppServiceCertificateOrderPatchResourcePropertiesAppServiceCertificateNotRenewableReasonsItem(string value) => new AppServiceCertificateOrderPatchResourcePropertiesAppServiceCertificateNotRenewableReasonsItem(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AppServiceCertificateOrderPatchResourcePropertiesAppServiceCertificateNotRenewableReasonsItem other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AppServiceCertificateOrderPatchResourcePropertiesAppServiceCertificateNotRenewableReasonsItem other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
