// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace Azure.Messaging.WebPubSub;

/// <summary>
/// Options to apply when creating the client access token.
/// </summary>
public class GetClientAccessTokenOptions
{
    /// <summary>
    /// The default options instance.
    /// </summary>
    public static readonly GetClientAccessTokenOptions Default = new();

    /// <summary>
    /// Gets or sets the expire time of the generated token. The unit is minute. The default value is 60 minutes.
    /// </summary>
    public int MinutesToExpire { get; set; } = 60;

    /// <summary>
    /// Gets or sets the user id of the client.
    /// </summary>
    public string UserId { get; set; }

    /// <summary>
    /// Gets or sets the roles that the connection with the generated token will have.
    /// </summary>
    public IEnumerable<string> Roles { get; set; }

    /// <summary>
    /// Gets or sets the groups that the connection will join when it connects.
    /// </summary>
    public IEnumerable<string> Groups { get; set; }

    /// <summary>
    /// Gets or sets the client endpoint type. The default client endpoint starts with "/client".
    /// </summary>
    public ClientEndpointType ClientEndpoint { get; set; } = ClientEndpointType.Default;
}
