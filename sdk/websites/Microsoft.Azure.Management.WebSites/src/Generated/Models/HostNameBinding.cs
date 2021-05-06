// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> A hostname binding object. </summary>
    public partial class HostNameBinding : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of HostNameBinding. </summary>
        public HostNameBinding()
        {
        }

        /// <summary> Initializes a new instance of HostNameBinding. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource Name. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="siteName"> App Service app name. </param>
        /// <param name="domainId"> Fully qualified ARM domain resource URI. </param>
        /// <param name="azureResourceName"> Azure resource name. </param>
        /// <param name="azureResourceType"> Azure resource type. </param>
        /// <param name="customHostNameDnsRecordType"> Custom DNS record type. </param>
        /// <param name="hostNameType"> Hostname type. </param>
        /// <param name="sslState"> SSL type. </param>
        /// <param name="thumbprint"> SSL certificate thumbprint. </param>
        /// <param name="virtualIP"> Virtual IP address assigned to the hostname if IP based SSL is enabled. </param>
        internal HostNameBinding(string id, string name, string kind, string type, string siteName, string domainId, string azureResourceName, AzureResourceType? azureResourceType, CustomHostNameDnsRecordType? customHostNameDnsRecordType, HostNameType? hostNameType, SslState? sslState, string thumbprint, string virtualIP) : base(id, name, kind, type)
        {
            SiteName = siteName;
            DomainId = domainId;
            AzureResourceName = azureResourceName;
            AzureResourceType = azureResourceType;
            CustomHostNameDnsRecordType = customHostNameDnsRecordType;
            HostNameType = hostNameType;
            SslState = sslState;
            Thumbprint = thumbprint;
            VirtualIP = virtualIP;
        }

        /// <summary> App Service app name. </summary>
        public string SiteName { get; set; }
        /// <summary> Fully qualified ARM domain resource URI. </summary>
        public string DomainId { get; set; }
        /// <summary> Azure resource name. </summary>
        public string AzureResourceName { get; set; }
        /// <summary> Azure resource type. </summary>
        public AzureResourceType? AzureResourceType { get; set; }
        /// <summary> Custom DNS record type. </summary>
        public CustomHostNameDnsRecordType? CustomHostNameDnsRecordType { get; set; }
        /// <summary> Hostname type. </summary>
        public HostNameType? HostNameType { get; set; }
        /// <summary> SSL type. </summary>
        public SslState? SslState { get; set; }
        /// <summary> SSL certificate thumbprint. </summary>
        public string Thumbprint { get; set; }
        /// <summary> Virtual IP address assigned to the hostname if IP based SSL is enabled. </summary>
        public string VirtualIP { get; }
    }
}
