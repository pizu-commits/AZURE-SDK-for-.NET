// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The domain JSON object required for domain creation or update. </summary>
    public partial class FrontDoorRoutePatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FrontDoorRoutePatch"/>. </summary>
        public FrontDoorRoutePatch()
        {
            CustomDomains = new ChangeTrackingList<FrontDoorActivatedResourceInfo>();
            RuleSets = new ChangeTrackingList<WritableSubResource>();
            SupportedProtocols = new ChangeTrackingList<FrontDoorEndpointProtocol>();
            PatternsToMatch = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="FrontDoorRoutePatch"/>. </summary>
        /// <param name="endpointName"> The name of the endpoint which holds the route. </param>
        /// <param name="customDomains"> Domains referenced by this endpoint. </param>
        /// <param name="originGroup"> A reference to the origin group. </param>
        /// <param name="originPath"> A directory path on the origin that AzureFrontDoor can use to retrieve content from, e.g. contoso.cloudapp.net/originpath. </param>
        /// <param name="ruleSets"> rule sets referenced by this endpoint. </param>
        /// <param name="supportedProtocols"> List of supported protocols for this route. </param>
        /// <param name="patternsToMatch"> The route patterns of the rule. </param>
        /// <param name="cacheConfiguration"> The caching configuration for this route. To disable caching, do not provide a cacheConfiguration object. </param>
        /// <param name="forwardingProtocol"> Protocol this rule will use when forwarding traffic to backends. </param>
        /// <param name="linkToDefaultDomain"> whether this route will be linked to the default endpoint domain. </param>
        /// <param name="httpsRedirect"> Whether to automatically redirect HTTP traffic to HTTPS traffic. Note that this is a easy way to set up this rule and it will be the first rule that gets executed. </param>
        /// <param name="enabledState"> Whether to enable use of this rule. Permitted values are 'Enabled' or 'Disabled'. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FrontDoorRoutePatch(string endpointName, IList<FrontDoorActivatedResourceInfo> customDomains, WritableSubResource originGroup, string originPath, IList<WritableSubResource> ruleSets, IList<FrontDoorEndpointProtocol> supportedProtocols, IList<string> patternsToMatch, FrontDoorRouteCacheConfiguration cacheConfiguration, ForwardingProtocol? forwardingProtocol, LinkToDefaultDomain? linkToDefaultDomain, HttpsRedirect? httpsRedirect, EnabledState? enabledState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EndpointName = endpointName;
            CustomDomains = customDomains;
            OriginGroup = originGroup;
            OriginPath = originPath;
            RuleSets = ruleSets;
            SupportedProtocols = supportedProtocols;
            PatternsToMatch = patternsToMatch;
            CacheConfiguration = cacheConfiguration;
            ForwardingProtocol = forwardingProtocol;
            LinkToDefaultDomain = linkToDefaultDomain;
            HttpsRedirect = httpsRedirect;
            EnabledState = enabledState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the endpoint which holds the route. </summary>
        public string EndpointName { get; }
        /// <summary> Domains referenced by this endpoint. </summary>
        public IList<FrontDoorActivatedResourceInfo> CustomDomains { get; }
        /// <summary> A reference to the origin group. </summary>
        internal WritableSubResource OriginGroup { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier OriginGroupId
        {
            get => OriginGroup is null ? default : OriginGroup.Id;
            set
            {
                if (OriginGroup is null)
                    OriginGroup = new WritableSubResource();
                OriginGroup.Id = value;
            }
        }

        /// <summary> A directory path on the origin that AzureFrontDoor can use to retrieve content from, e.g. contoso.cloudapp.net/originpath. </summary>
        public string OriginPath { get; set; }
        /// <summary> rule sets referenced by this endpoint. </summary>
        public IList<WritableSubResource> RuleSets { get; }
        /// <summary> List of supported protocols for this route. </summary>
        public IList<FrontDoorEndpointProtocol> SupportedProtocols { get; }
        /// <summary> The route patterns of the rule. </summary>
        public IList<string> PatternsToMatch { get; }
        /// <summary> The caching configuration for this route. To disable caching, do not provide a cacheConfiguration object. </summary>
        public FrontDoorRouteCacheConfiguration CacheConfiguration { get; set; }
        /// <summary> Protocol this rule will use when forwarding traffic to backends. </summary>
        public ForwardingProtocol? ForwardingProtocol { get; set; }
        /// <summary> whether this route will be linked to the default endpoint domain. </summary>
        public LinkToDefaultDomain? LinkToDefaultDomain { get; set; }
        /// <summary> Whether to automatically redirect HTTP traffic to HTTPS traffic. Note that this is a easy way to set up this rule and it will be the first rule that gets executed. </summary>
        public HttpsRedirect? HttpsRedirect { get; set; }
        /// <summary> Whether to enable use of this rule. Permitted values are 'Enabled' or 'Disabled'. </summary>
        public EnabledState? EnabledState { get; set; }
    }
}
