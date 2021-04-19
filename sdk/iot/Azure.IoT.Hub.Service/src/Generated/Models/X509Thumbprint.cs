// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.IoT.Hub.Service.Models
{
    /// <summary> The X509Thumbprint. </summary>
    public partial class X509Thumbprint
    {
        /// <summary> Initializes a new instance of X509Thumbprint. </summary>
        public X509Thumbprint()
        {
        }

        /// <summary> Initializes a new instance of X509Thumbprint. </summary>
        /// <param name="primaryThumbprint"> The X509 client certificate primary thumbprint. </param>
        /// <param name="secondaryThumbprint"> The X509 client certificate secondary thumbprint. </param>
        internal X509Thumbprint(string primaryThumbprint, string secondaryThumbprint)
        {
            PrimaryThumbprint = primaryThumbprint;
            SecondaryThumbprint = secondaryThumbprint;
        }

        /// <summary> The X509 client certificate primary thumbprint. </summary>
        public string PrimaryThumbprint { get; set; }
        /// <summary> The X509 client certificate secondary thumbprint. </summary>
        public string SecondaryThumbprint { get; set; }
    }
}
