// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> The configuration settings of the app registration for providers that have app ids and app secrets. </summary>
    public partial class AppRegistration : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of AppRegistration. </summary>
        public AppRegistration()
        {
        }

        /// <summary> Initializes a new instance of AppRegistration. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource Name. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="appId"> The App ID of the app used for login. </param>
        /// <param name="appSecretSettingName"> The app setting name that contains the app secret. </param>
        internal AppRegistration(string id, string name, string kind, string type, string appId, string appSecretSettingName) : base(id, name, kind, type)
        {
            AppId = appId;
            AppSecretSettingName = appSecretSettingName;
        }

        /// <summary> The App ID of the app used for login. </summary>
        public string AppId { get; set; }
        /// <summary> The app setting name that contains the app secret. </summary>
        public string AppSecretSettingName { get; set; }
    }
}
