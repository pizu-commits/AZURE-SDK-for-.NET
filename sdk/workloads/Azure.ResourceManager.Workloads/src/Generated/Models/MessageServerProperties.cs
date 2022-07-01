// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Defines the SAP message server properties. </summary>
    public partial class MessageServerProperties
    {
        /// <summary> Initializes a new instance of MessageServerProperties. </summary>
        public MessageServerProperties()
        {
        }

        /// <summary> Initializes a new instance of MessageServerProperties. </summary>
        /// <param name="msPort"> The message server port. </param>
        /// <param name="internalMsPort"> The message server internal MS port. </param>
        /// <param name="httpPort"> The message server http port. </param>
        /// <param name="httpsPort"> The message server https port. </param>
        /// <param name="hostname"> The message server SAP host name. </param>
        /// <param name="ipAddress"> The message server IP Address. </param>
        /// <param name="health"> Defines the SAP Instance health. </param>
        internal MessageServerProperties(long? msPort, long? internalMsPort, long? httpPort, long? httpsPort, string hostname, string ipAddress, SapHealthState? health)
        {
            MsPort = msPort;
            InternalMsPort = internalMsPort;
            HttpPort = httpPort;
            HttpsPort = httpsPort;
            Hostname = hostname;
            IPAddress = ipAddress;
            Health = health;
        }

        /// <summary> The message server port. </summary>
        public long? MsPort { get; }
        /// <summary> The message server internal MS port. </summary>
        public long? InternalMsPort { get; }
        /// <summary> The message server http port. </summary>
        public long? HttpPort { get; }
        /// <summary> The message server https port. </summary>
        public long? HttpsPort { get; }
        /// <summary> The message server SAP host name. </summary>
        public string Hostname { get; }
        /// <summary> The message server IP Address. </summary>
        public string IPAddress { get; }
        /// <summary> Defines the SAP Instance health. </summary>
        public SapHealthState? Health { get; }
    }
}
