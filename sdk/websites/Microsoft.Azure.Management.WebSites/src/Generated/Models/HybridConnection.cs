// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> Hybrid Connection contract. This is used to configure a Hybrid Connection. </summary>
    public partial class HybridConnection : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of HybridConnection. </summary>
        public HybridConnection()
        {
        }

        /// <summary> Initializes a new instance of HybridConnection. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource Name. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="serviceBusNamespace"> The name of the Service Bus namespace. </param>
        /// <param name="relayName"> The name of the Service Bus relay. </param>
        /// <param name="relayArmUri"> The ARM URI to the Service Bus relay. </param>
        /// <param name="hostname"> The hostname of the endpoint. </param>
        /// <param name="port"> The port of the endpoint. </param>
        /// <param name="sendKeyName"> The name of the Service Bus key which has Send permissions. This is used to authenticate to Service Bus. </param>
        /// <param name="sendKeyValue">
        /// The value of the Service Bus key. This is used to authenticate to Service Bus. In ARM this key will not be returned
        /// normally, use the POST /listKeys API instead.
        /// </param>
        /// <param name="serviceBusSuffix"> The suffix for the service bus endpoint. By default this is .servicebus.windows.net. </param>
        internal HybridConnection(string id, string name, string kind, string type, string serviceBusNamespace, string relayName, string relayArmUri, string hostname, int? port, string sendKeyName, string sendKeyValue, string serviceBusSuffix) : base(id, name, kind, type)
        {
            ServiceBusNamespace = serviceBusNamespace;
            RelayName = relayName;
            RelayArmUri = relayArmUri;
            Hostname = hostname;
            Port = port;
            SendKeyName = sendKeyName;
            SendKeyValue = sendKeyValue;
            ServiceBusSuffix = serviceBusSuffix;
        }

        /// <summary> The name of the Service Bus namespace. </summary>
        public string ServiceBusNamespace { get; set; }
        /// <summary> The name of the Service Bus relay. </summary>
        public string RelayName { get; set; }
        /// <summary> The ARM URI to the Service Bus relay. </summary>
        public string RelayArmUri { get; set; }
        /// <summary> The hostname of the endpoint. </summary>
        public string Hostname { get; set; }
        /// <summary> The port of the endpoint. </summary>
        public int? Port { get; set; }
        /// <summary> The name of the Service Bus key which has Send permissions. This is used to authenticate to Service Bus. </summary>
        public string SendKeyName { get; set; }
        /// <summary>
        /// The value of the Service Bus key. This is used to authenticate to Service Bus. In ARM this key will not be returned
        /// normally, use the POST /listKeys API instead.
        /// </summary>
        public string SendKeyValue { get; set; }
        /// <summary> The suffix for the service bus endpoint. By default this is .servicebus.windows.net. </summary>
        public string ServiceBusSuffix { get; set; }
    }
}
