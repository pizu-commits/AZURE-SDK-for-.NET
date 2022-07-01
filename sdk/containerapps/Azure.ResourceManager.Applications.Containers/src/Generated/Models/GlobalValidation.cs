// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Applications.Containers.Models
{
    /// <summary> The configuration settings that determines the validation flow of users using ContainerApp Service Authentication/Authorization. </summary>
    public partial class GlobalValidation
    {
        /// <summary> Initializes a new instance of GlobalValidation. </summary>
        public GlobalValidation()
        {
            ExcludedPaths = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of GlobalValidation. </summary>
        /// <param name="unauthenticatedClientAction"> The action to take when an unauthenticated client attempts to access the app. </param>
        /// <param name="redirectToProvider">
        /// The default authentication provider to use when multiple providers are configured.
        /// This setting is only needed if multiple providers are configured and the unauthenticated client
        /// action is set to &quot;RedirectToLoginPage&quot;.
        /// </param>
        /// <param name="excludedPaths"> The paths for which unauthenticated flow would not be redirected to the login page. </param>
        internal GlobalValidation(UnauthenticatedClientActionV2? unauthenticatedClientAction, string redirectToProvider, IList<string> excludedPaths)
        {
            UnauthenticatedClientAction = unauthenticatedClientAction;
            RedirectToProvider = redirectToProvider;
            ExcludedPaths = excludedPaths;
        }

        /// <summary> The action to take when an unauthenticated client attempts to access the app. </summary>
        public UnauthenticatedClientActionV2? UnauthenticatedClientAction { get; set; }
        /// <summary>
        /// The default authentication provider to use when multiple providers are configured.
        /// This setting is only needed if multiple providers are configured and the unauthenticated client
        /// action is set to &quot;RedirectToLoginPage&quot;.
        /// </summary>
        public string RedirectToProvider { get; set; }
        /// <summary> The paths for which unauthenticated flow would not be redirected to the login page. </summary>
        public IList<string> ExcludedPaths { get; }
    }
}
