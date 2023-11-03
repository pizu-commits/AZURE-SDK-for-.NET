// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable enable

using System;
using Azure.Core;

namespace Azure.AI.ChatProtocol;

/// <summary> Client options for ChatProtocolClient. </summary>
[CodeGenSuppress("ChatProtocolClientOptions", typeof(ChatProtocolClientOptions.ServiceVersion))]
public partial class ChatProtocolClientOptions : ClientOptions
{
    /// <summary> The route where the chat API can be found in the endpoint, if not set the default 'chat' is used. </summary>
    public string ChatRoute { get; set; }

    /// <summary> If set this will override the  OAuth2 scopes. </summary>
    public string[]? AuthorizationScopes { get; set;}

    /// <summary> If set this will override the header used in an API key flow. If not set 'api-key' is used. </summary>
    public string? APIKeyHeader { get; set;}

    /// <summary> Initializes new instance of ChatProtocolClientOptions. </summary>
    public ChatProtocolClientOptions(ServiceVersion version = LatestVersion, string chatRoute = "chat", string[]? authorizationScopes = null, string? apiKeyHeader = null)
    {
        Version = version switch
        {
            ServiceVersion.V2023_10_01_Preview => "2023-10-01-preview",
            _ => throw new NotSupportedException()
        };
        ChatRoute = chatRoute;
        AuthorizationScopes = authorizationScopes;
        APIKeyHeader = apiKeyHeader;
    }
}
