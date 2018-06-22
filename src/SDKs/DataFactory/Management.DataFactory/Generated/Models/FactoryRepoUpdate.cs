// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 2.4.36.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Factory's git repo information.
    /// </summary>
    public partial class FactoryRepoUpdate
    {
        /// <summary>
        /// Initializes a new instance of the FactoryRepoUpdate class.
        /// </summary>
        public FactoryRepoUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FactoryRepoUpdate class.
        /// </summary>
        /// <param name="factoryResourceId">The factory resource id.</param>
        /// <param name="repoConfiguration">Git repo information of the
        /// factory.</param>
        public FactoryRepoUpdate(string factoryResourceId = default(string), FactoryRepoConfiguration repoConfiguration = default(FactoryRepoConfiguration))
        {
            FactoryResourceId = factoryResourceId;
            RepoConfiguration = repoConfiguration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the factory resource id.
        /// </summary>
        [JsonProperty(PropertyName = "factoryResourceId")]
        public string FactoryResourceId { get; set; }

        /// <summary>
        /// Gets or sets git repo information of the factory.
        /// </summary>
        [JsonProperty(PropertyName = "repoConfiguration")]
        public FactoryRepoConfiguration RepoConfiguration { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RepoConfiguration != null)
            {
                RepoConfiguration.Validate();
            }
        }
    }
}
