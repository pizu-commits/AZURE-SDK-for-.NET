// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Ssis environment reference. </summary>
    public partial class SynapseSsisEnvironmentReference
    {
        /// <summary> Initializes a new instance of <see cref="SynapseSsisEnvironmentReference"/>. </summary>
        internal SynapseSsisEnvironmentReference()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SynapseSsisEnvironmentReference"/>. </summary>
        /// <param name="id"> Environment reference id. </param>
        /// <param name="environmentFolderName"> Environment folder name. </param>
        /// <param name="environmentName"> Environment name. </param>
        /// <param name="referenceType"> Reference type. </param>
        internal SynapseSsisEnvironmentReference(long? id, string environmentFolderName, string environmentName, string referenceType)
        {
            Id = id;
            EnvironmentFolderName = environmentFolderName;
            EnvironmentName = environmentName;
            ReferenceType = referenceType;
        }

        /// <summary> Environment reference id. </summary>
        public long? Id { get; }
        /// <summary> Environment folder name. </summary>
        public string EnvironmentFolderName { get; }
        /// <summary> Environment name. </summary>
        public string EnvironmentName { get; }
        /// <summary> Reference type. </summary>
        public string ReferenceType { get; }
    }
}
