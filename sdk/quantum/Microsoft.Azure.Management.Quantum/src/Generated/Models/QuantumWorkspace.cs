// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Quantum.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The resource proxy definition object for quantum workspace.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class QuantumWorkspace : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the QuantumWorkspace class.
        /// </summary>
        public QuantumWorkspace()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QuantumWorkspace class.
        /// </summary>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="providers">List of Providers selected for this
        /// Workspace</param>
        /// <param name="usable">Whether the current workspace is ready to
        /// accept Jobs. Possible values include: 'Yes', 'No',
        /// 'Partial'</param>
        /// <param name="provisioningState">Provisioning status field. Possible
        /// values include: 'Succeeded', 'ProviderLaunching',
        /// 'ProviderUpdating', 'ProviderDeleting', 'ProviderProvisioning',
        /// 'Failed'</param>
        /// <param name="storageAccount">ARM Resource Id of the storage account
        /// associated with this workspace.</param>
        /// <param name="endpointUri">The URI of the workspace
        /// endpoint.</param>
        /// <param name="identity">Managed Identity information.</param>
        public QuantumWorkspace(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IList<Provider> providers = default(IList<Provider>), string usable = default(string), string provisioningState = default(string), string storageAccount = default(string), string endpointUri = default(string), QuantumWorkspaceIdentity identity = default(QuantumWorkspaceIdentity))
            : base(location, id, name, type, tags)
        {
            Providers = providers;
            Usable = usable;
            ProvisioningState = provisioningState;
            StorageAccount = storageAccount;
            EndpointUri = endpointUri;
            Identity = identity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of Providers selected for this Workspace
        /// </summary>
        [JsonProperty(PropertyName = "properties.providers")]
        public IList<Provider> Providers { get; set; }

        /// <summary>
        /// Gets whether the current workspace is ready to accept Jobs.
        /// Possible values include: 'Yes', 'No', 'Partial'
        /// </summary>
        [JsonProperty(PropertyName = "properties.usable")]
        public string Usable { get; private set; }

        /// <summary>
        /// Gets provisioning status field. Possible values include:
        /// 'Succeeded', 'ProviderLaunching', 'ProviderUpdating',
        /// 'ProviderDeleting', 'ProviderProvisioning', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets ARM Resource Id of the storage account associated with
        /// this workspace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccount")]
        public string StorageAccount { get; set; }

        /// <summary>
        /// Gets the URI of the workspace endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endpointUri")]
        public string EndpointUri { get; private set; }

        /// <summary>
        /// Gets or sets managed Identity information.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public QuantumWorkspaceIdentity Identity { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
