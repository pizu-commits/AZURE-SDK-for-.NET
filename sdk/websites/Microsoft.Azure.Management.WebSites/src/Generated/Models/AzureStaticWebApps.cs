// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> The configuration settings of the Azure Static Web Apps provider. </summary>
    public partial class AzureStaticWebApps : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of AzureStaticWebApps. </summary>
        public AzureStaticWebApps()
        {
        }

        /// <summary> Initializes a new instance of AzureStaticWebApps. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource Name. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="enabled"> &lt;code&gt;false&lt;/code&gt; if the Azure Static Web Apps provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;. </param>
        /// <param name="registration"> The configuration settings of the Azure Static Web Apps registration. </param>
        internal AzureStaticWebApps(string id, string name, string kind, string type, bool? enabled, AzureStaticWebAppsRegistration registration) : base(id, name, kind, type)
        {
            Enabled = enabled;
            Registration = registration;
        }

        /// <summary> &lt;code&gt;false&lt;/code&gt; if the Azure Static Web Apps provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;. </summary>
        public bool? Enabled { get; set; }
        /// <summary> The configuration settings of the Azure Static Web Apps registration. </summary>
        public AzureStaticWebAppsRegistration Registration { get; set; }
    }
}
