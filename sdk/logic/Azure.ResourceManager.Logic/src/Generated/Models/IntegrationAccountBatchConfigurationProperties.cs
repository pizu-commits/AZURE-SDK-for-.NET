// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The batch configuration properties definition. </summary>
    public partial class IntegrationAccountBatchConfigurationProperties : ArtifactProperties
    {
        /// <summary> Initializes a new instance of <see cref="IntegrationAccountBatchConfigurationProperties"/>. </summary>
        /// <param name="batchGroupName"> The name of the batch group. </param>
        /// <param name="releaseCriteria"> The batch release criteria. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="batchGroupName"/> or <paramref name="releaseCriteria"/> is null. </exception>
        public IntegrationAccountBatchConfigurationProperties(string batchGroupName, IntegrationAccountBatchReleaseCriteria releaseCriteria)
        {
            Argument.AssertNotNull(batchGroupName, nameof(batchGroupName));
            Argument.AssertNotNull(releaseCriteria, nameof(releaseCriteria));

            BatchGroupName = batchGroupName;
            ReleaseCriteria = releaseCriteria;
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountBatchConfigurationProperties"/>. </summary>
        /// <param name="createdOn"> The artifact creation time. </param>
        /// <param name="changedOn"> The artifact changed time. </param>
        /// <param name="metadata"> Anything. </param>
        /// <param name="batchGroupName"> The name of the batch group. </param>
        /// <param name="releaseCriteria"> The batch release criteria. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal IntegrationAccountBatchConfigurationProperties(DateTimeOffset? createdOn, DateTimeOffset? changedOn, BinaryData metadata, string batchGroupName, IntegrationAccountBatchReleaseCriteria releaseCriteria, Dictionary<string, BinaryData> rawData) : base(createdOn, changedOn, metadata, rawData)
        {
            BatchGroupName = batchGroupName;
            ReleaseCriteria = releaseCriteria;
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountBatchConfigurationProperties"/> for deserialization. </summary>
        internal IntegrationAccountBatchConfigurationProperties()
        {
        }

        /// <summary> The name of the batch group. </summary>
        public string BatchGroupName { get; set; }
        /// <summary> The batch release criteria. </summary>
        public IntegrationAccountBatchReleaseCriteria ReleaseCriteria { get; set; }
    }
}
