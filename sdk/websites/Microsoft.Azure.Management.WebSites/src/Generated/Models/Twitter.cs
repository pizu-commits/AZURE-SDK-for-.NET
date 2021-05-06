// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> The configuration settings of the Twitter provider. </summary>
    public partial class Twitter : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of Twitter. </summary>
        public Twitter()
        {
        }

        /// <summary> Initializes a new instance of Twitter. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource Name. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="enabled"> &lt;code&gt;false&lt;/code&gt; if the Twitter provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;. </param>
        /// <param name="registration"> The configuration settings of the app registration for the Twitter provider. </param>
        internal Twitter(string id, string name, string kind, string type, bool? enabled, TwitterRegistration registration) : base(id, name, kind, type)
        {
            Enabled = enabled;
            Registration = registration;
        }

        /// <summary> &lt;code&gt;false&lt;/code&gt; if the Twitter provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;. </summary>
        public bool? Enabled { get; set; }
        /// <summary> The configuration settings of the app registration for the Twitter provider. </summary>
        public TwitterRegistration Registration { get; set; }
    }
}
