// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The signed services accessible with the service SAS. Possible values include: Blob (b), Container (c), File (f), Share (s). </summary>
    public readonly partial struct ServiceSasSignedResourceType : IEquatable<ServiceSasSignedResourceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServiceSasSignedResourceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServiceSasSignedResourceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BValue = "b";
        private const string CValue = "c";
        private const string FValue = "f";
        private const string SValue = "s";

        /// <summary> b. </summary>
        public static ServiceSasSignedResourceType B { get; } = new ServiceSasSignedResourceType(BValue);
        /// <summary> c. </summary>
        public static ServiceSasSignedResourceType C { get; } = new ServiceSasSignedResourceType(CValue);
        /// <summary> f. </summary>
        public static ServiceSasSignedResourceType F { get; } = new ServiceSasSignedResourceType(FValue);
        /// <summary> s. </summary>
        public static ServiceSasSignedResourceType S { get; } = new ServiceSasSignedResourceType(SValue);
        /// <summary> Determines if two <see cref="ServiceSasSignedResourceType"/> values are the same. </summary>
        public static bool operator ==(ServiceSasSignedResourceType left, ServiceSasSignedResourceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServiceSasSignedResourceType"/> values are not the same. </summary>
        public static bool operator !=(ServiceSasSignedResourceType left, ServiceSasSignedResourceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ServiceSasSignedResourceType"/>. </summary>
        public static implicit operator ServiceSasSignedResourceType(string value) => new ServiceSasSignedResourceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServiceSasSignedResourceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServiceSasSignedResourceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
