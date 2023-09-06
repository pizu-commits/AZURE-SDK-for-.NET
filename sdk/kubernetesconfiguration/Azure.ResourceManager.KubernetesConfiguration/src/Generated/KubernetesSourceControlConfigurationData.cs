// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.KubernetesConfiguration.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.KubernetesConfiguration
{
    /// <summary>
    /// A class representing the KubernetesSourceControlConfiguration data model.
    /// The SourceControl Configuration object returned in Get &amp; Put response.
    /// </summary>
    public partial class KubernetesSourceControlConfigurationData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="KubernetesSourceControlConfigurationData"/>. </summary>
        public KubernetesSourceControlConfigurationData()
        {
            ConfigurationProtectedSettings = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="KubernetesSourceControlConfigurationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="repositoryUri"> Url of the SourceControl Repository. </param>
        /// <param name="operatorNamespace"> The namespace to which this operator is installed to. Maximum of 253 lower case alphanumeric characters, hyphen and period only. </param>
        /// <param name="operatorInstanceName"> Instance name of the operator - identifying the specific configuration. </param>
        /// <param name="operatorType"> Type of the operator. </param>
        /// <param name="operatorParams"> Any Parameters for the Operator instance in string format. </param>
        /// <param name="configurationProtectedSettings"> Name-value pairs of protected configuration settings for the configuration. </param>
        /// <param name="operatorScope"> Scope at which the operator will be installed. </param>
        /// <param name="repositoryPublicKey"> Public Key associated with this SourceControl configuration (either generated within the cluster or provided by the user). </param>
        /// <param name="sshKnownHostsContents"> Base64-encoded known_hosts contents containing public SSH keys required to access private Git instances. </param>
        /// <param name="isHelmOperatorEnabled"> Option to enable Helm Operator for this git configuration. </param>
        /// <param name="helmOperatorProperties"> Properties for Helm operator. </param>
        /// <param name="provisioningState"> The provisioning state of the resource provider. </param>
        /// <param name="complianceStatus"> Compliance Status of the Configuration. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KubernetesSourceControlConfigurationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Uri repositoryUri, string operatorNamespace, string operatorInstanceName, KubernetesOperator? operatorType, string operatorParams, IDictionary<string, string> configurationProtectedSettings, KubernetesOperatorScope? operatorScope, string repositoryPublicKey, string sshKnownHostsContents, bool? isHelmOperatorEnabled, HelmOperatorProperties helmOperatorProperties, KubernetesConfigurationProvisioningStateType? provisioningState, KubernetesConfigurationComplianceStatus complianceStatus, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            RepositoryUri = repositoryUri;
            OperatorNamespace = operatorNamespace;
            OperatorInstanceName = operatorInstanceName;
            OperatorType = operatorType;
            OperatorParams = operatorParams;
            ConfigurationProtectedSettings = configurationProtectedSettings;
            OperatorScope = operatorScope;
            RepositoryPublicKey = repositoryPublicKey;
            SshKnownHostsContents = sshKnownHostsContents;
            IsHelmOperatorEnabled = isHelmOperatorEnabled;
            HelmOperatorProperties = helmOperatorProperties;
            ProvisioningState = provisioningState;
            ComplianceStatus = complianceStatus;
            _rawData = rawData;
        }

        /// <summary> Url of the SourceControl Repository. </summary>
        public Uri RepositoryUri { get; set; }
        /// <summary> The namespace to which this operator is installed to. Maximum of 253 lower case alphanumeric characters, hyphen and period only. </summary>
        public string OperatorNamespace { get; set; }
        /// <summary> Instance name of the operator - identifying the specific configuration. </summary>
        public string OperatorInstanceName { get; set; }
        /// <summary> Type of the operator. </summary>
        public KubernetesOperator? OperatorType { get; set; }
        /// <summary> Any Parameters for the Operator instance in string format. </summary>
        public string OperatorParams { get; set; }
        /// <summary> Name-value pairs of protected configuration settings for the configuration. </summary>
        public IDictionary<string, string> ConfigurationProtectedSettings { get; }
        /// <summary> Scope at which the operator will be installed. </summary>
        public KubernetesOperatorScope? OperatorScope { get; set; }
        /// <summary> Public Key associated with this SourceControl configuration (either generated within the cluster or provided by the user). </summary>
        public string RepositoryPublicKey { get; }
        /// <summary> Base64-encoded known_hosts contents containing public SSH keys required to access private Git instances. </summary>
        public string SshKnownHostsContents { get; set; }
        /// <summary> Option to enable Helm Operator for this git configuration. </summary>
        public bool? IsHelmOperatorEnabled { get; set; }
        /// <summary> Properties for Helm operator. </summary>
        public HelmOperatorProperties HelmOperatorProperties { get; set; }
        /// <summary> The provisioning state of the resource provider. </summary>
        public KubernetesConfigurationProvisioningStateType? ProvisioningState { get; }
        /// <summary> Compliance Status of the Configuration. </summary>
        public KubernetesConfigurationComplianceStatus ComplianceStatus { get; }
    }
}
