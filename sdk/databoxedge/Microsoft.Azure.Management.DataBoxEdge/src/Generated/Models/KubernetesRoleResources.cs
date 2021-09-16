// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBoxEdge.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Kubernetes role resources
    /// </summary>
    public partial class KubernetesRoleResources
    {
        /// <summary>
        /// Initializes a new instance of the KubernetesRoleResources class.
        /// </summary>
        public KubernetesRoleResources()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KubernetesRoleResources class.
        /// </summary>
        /// <param name="compute">Kubernetes role compute resource</param>
        /// <param name="storage">Kubernetes role storage resource</param>
        /// <param name="network">Kubernetes role network resource</param>
        public KubernetesRoleResources(KubernetesRoleCompute compute, KubernetesRoleStorage storage = default(KubernetesRoleStorage), KubernetesRoleNetwork network = default(KubernetesRoleNetwork))
        {
            Storage = storage;
            Compute = compute;
            Network = network;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets kubernetes role storage resource
        /// </summary>
        [JsonProperty(PropertyName = "storage")]
        public KubernetesRoleStorage Storage { get; set; }

        /// <summary>
        /// Gets or sets kubernetes role compute resource
        /// </summary>
        [JsonProperty(PropertyName = "compute")]
        public KubernetesRoleCompute Compute { get; set; }

        /// <summary>
        /// Gets kubernetes role network resource
        /// </summary>
        [JsonProperty(PropertyName = "network")]
        public KubernetesRoleNetwork Network { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Compute == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Compute");
            }
            if (Compute != null)
            {
                Compute.Validate();
            }
        }
    }
}
