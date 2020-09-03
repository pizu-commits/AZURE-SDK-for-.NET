﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace OpenTelemetry.Exporter.AzureMonitor
{
    internal class UrlHelper
    {
        private const string SchemePostfix = "://";
        private const string Colon = ":";
        private const string HttpPort80 = "80";
        private const string HttpPort443 = "443";

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static string GetUrl(Dictionary<string, string> tags)
        {
            if (tags.TryGetValue(SemanticConventions.AttributeHttpUrl, out var url))
            {
                Uri.TryCreate(url, UriKind.RelativeOrAbsolute, out var uri);

                if (uri?.IsAbsoluteUri == true)
                {
                    return url;
                }
            }

            if (tags.TryGetValue(SemanticConventions.AttributeHttpScheme, out var httpScheme))
            {
                tags.TryGetValue(SemanticConventions.AttributeHttpTarget, out var httpTarget);
                if (tags.TryGetValue(SemanticConventions.AttributeHttpHost, out var httpHost) && !string.IsNullOrWhiteSpace(httpHost))
                {
                    tags.TryGetValue(SemanticConventions.AttributeHttpHostPort, out var httpPort);
                    if (httpPort != null && httpPort != HttpPort80 && httpPort != HttpPort443)
                    {
                        url = $"{httpScheme}{SchemePostfix}{httpHost}{Colon}{httpPort}{httpTarget}";
                    }
                    else
                    {
                        url = $"{httpScheme}{SchemePostfix}{httpHost}{httpTarget}";
                    }

                    return url;
                }
                else if (tags.TryGetValue(SemanticConventions.AttributeNetPeerName, out var netPeerName)
                         && tags.TryGetValue(SemanticConventions.AttributeNetPeerPort, out var netPeerPort))
                {
                    return string.IsNullOrWhiteSpace(netPeerName) ? null :  $"{httpScheme}{SchemePostfix}{netPeerName}{(string.IsNullOrWhiteSpace(netPeerPort) ? null : Colon)}{netPeerPort}{httpTarget}";
                }
                else if (tags.TryGetValue(SemanticConventions.AttributeNetPeerIp, out var netPeerIP)
                         && tags.TryGetValue(SemanticConventions.AttributeNetPeerPort, out netPeerPort))
                {
                    return string.IsNullOrWhiteSpace(netPeerIP) ? null : $"{httpScheme}{SchemePostfix}{netPeerIP}{(string.IsNullOrWhiteSpace(netPeerPort) ? null : Colon)}{netPeerPort}{httpTarget}";
                }
            }

            if (tags.TryGetValue(SemanticConventions.AttributeHttpHost, out var host) && !string.IsNullOrWhiteSpace(host))
            {
                tags.TryGetValue(SemanticConventions.AttributeHttpTarget, out var httpTarget);
                tags.TryGetValue(SemanticConventions.AttributeHttpHostPort, out var httpPort);
                url = $"{host}{(string.IsNullOrWhiteSpace(httpPort) ? null : Colon)}{httpPort}{httpTarget}";
                return url;
            }

            return string.IsNullOrWhiteSpace(url) ? null : url;
        }
    }
}
