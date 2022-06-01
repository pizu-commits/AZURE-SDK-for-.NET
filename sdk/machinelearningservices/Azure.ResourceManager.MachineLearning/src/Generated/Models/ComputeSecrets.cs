// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Secrets related to a Machine Learning compute. Might differ for every type of compute.
    /// Please note &lt;see cref=&quot;ComputeSecrets&quot;/&gt; is the base class. In order to more specifically assign or retrieve the value of this property, the derived class is needed.
    /// The available derived classes include &lt;see cref=&quot;AksComputeSecrets&quot;/&gt;, &lt;see cref=&quot;VirtualMachineSecrets&quot;/&gt;, &lt;see cref=&quot;DatabricksComputeSecrets&quot;/&gt;.
    /// </summary>
    public partial class ComputeSecrets
    {
        /// <summary> Initializes a new instance of ComputeSecrets. </summary>
        internal ComputeSecrets()
        {
        }

        /// <summary> Initializes a new instance of ComputeSecrets. </summary>
        /// <param name="computeType"> The type of compute. </param>
        internal ComputeSecrets(ComputeType computeType)
        {
            ComputeType = computeType;
        }

        /// <summary> The type of compute. </summary>
        internal ComputeType ComputeType { get; set; }
    }
}
