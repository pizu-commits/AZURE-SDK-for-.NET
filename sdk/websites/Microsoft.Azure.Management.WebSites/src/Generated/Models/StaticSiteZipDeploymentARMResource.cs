// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> Static site zip deployment ARM resource. </summary>
    public partial class StaticSiteZipDeploymentARMResource : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of StaticSiteZipDeploymentARMResource. </summary>
        public StaticSiteZipDeploymentARMResource()
        {
        }

        /// <summary> Initializes a new instance of StaticSiteZipDeploymentARMResource. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource Name. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="appZipUrl"> URL for the zipped app content. </param>
        /// <param name="apiZipUrl"> URL for the zipped api content. </param>
        /// <param name="deploymentTitle"> A title to label the deployment. </param>
        /// <param name="provider"> The provider submitting this deployment. </param>
        /// <param name="functionLanguage"> The language of the api content, if it exists. </param>
        internal StaticSiteZipDeploymentARMResource(string id, string name, string kind, string type, string appZipUrl, string apiZipUrl, string deploymentTitle, string provider, string functionLanguage) : base(id, name, kind, type)
        {
            AppZipUrl = appZipUrl;
            ApiZipUrl = apiZipUrl;
            DeploymentTitle = deploymentTitle;
            Provider = provider;
            FunctionLanguage = functionLanguage;
        }

        /// <summary> URL for the zipped app content. </summary>
        public string AppZipUrl { get; set; }
        /// <summary> URL for the zipped api content. </summary>
        public string ApiZipUrl { get; set; }
        /// <summary> A title to label the deployment. </summary>
        public string DeploymentTitle { get; set; }
        /// <summary> The provider submitting this deployment. </summary>
        public string Provider { get; set; }
        /// <summary> The language of the api content, if it exists. </summary>
        public string FunctionLanguage { get; set; }
    }
}
