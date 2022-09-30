// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ExtensionOptions. </summary>
    public partial class ExtensionOptions
    {
        /// <summary> Initializes a new instance of ExtensionOptions. </summary>
        public ExtensionOptions()
        {
            Request = new ChangeTrackingList<ExtensionOptionType>();
            Response = new ChangeTrackingList<ExtensionOptionType>();
        }

        /// <summary> Initializes a new instance of ExtensionOptions. </summary>
        /// <param name="request"></param>
        /// <param name="response"></param>
        internal ExtensionOptions(IList<ExtensionOptionType> request, IList<ExtensionOptionType> response)
        {
            Request = request;
            Response = response;
        }

        /// <summary> Gets the request. </summary>
        public IList<ExtensionOptionType> Request { get; }
        /// <summary> Gets the response. </summary>
        public IList<ExtensionOptionType> Response { get; }
    }
}
