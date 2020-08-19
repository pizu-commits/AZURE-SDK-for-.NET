// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Network.Models
{
    /// <summary> Parameters that define destination of connection. </summary>
    public partial class ConnectivityDestination
    {
        /// <summary> Initializes a new instance of ConnectivityDestination. </summary>
        public ConnectivityDestination()
        {
        }

        /// <summary> The ID of the resource to which a connection attempt will be made. </summary>
        public string ResourceId { get; set; }
        /// <summary> The IP address or URI the resource to which a connection attempt will be made. </summary>
        public string Address { get; set; }
        /// <summary> Port on which check connectivity will be performed. </summary>
        public int? Port { get; set; }
    }
}
