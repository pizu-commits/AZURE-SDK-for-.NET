// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DeploymentManager.Models
{
    /// <summary> Defines the PUT rollout request body. </summary>
    public partial class RolloutCreateOrUpdateContent : TrackedResourceData
    {
        /// <summary> Initializes a new instance of RolloutCreateOrUpdateContent. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Identity for the resource. </param>
        /// <param name="buildVersion"> The version of the build being deployed. </param>
        /// <param name="targetServiceTopologyId"> The resource Id of the service topology from which service units are being referenced in step groups to be deployed. </param>
        /// <param name="stepGroups"> The list of step groups that define the orchestration. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="identity"/>, <paramref name="buildVersion"/>, <paramref name="targetServiceTopologyId"/> or <paramref name="stepGroups"/> is null. </exception>
        public RolloutCreateOrUpdateContent(AzureLocation location, Identity identity, string buildVersion, string targetServiceTopologyId, IEnumerable<StepGroup> stepGroups) : base(location)
        {
            if (identity == null)
            {
                throw new ArgumentNullException(nameof(identity));
            }
            if (buildVersion == null)
            {
                throw new ArgumentNullException(nameof(buildVersion));
            }
            if (targetServiceTopologyId == null)
            {
                throw new ArgumentNullException(nameof(targetServiceTopologyId));
            }
            if (stepGroups == null)
            {
                throw new ArgumentNullException(nameof(stepGroups));
            }

            Identity = identity;
            BuildVersion = buildVersion;
            TargetServiceTopologyId = targetServiceTopologyId;
            StepGroups = stepGroups.ToList();
        }

        /// <summary> Initializes a new instance of RolloutCreateOrUpdateContent. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Identity for the resource. </param>
        /// <param name="buildVersion"> The version of the build being deployed. </param>
        /// <param name="artifactSourceId"> The reference to the artifact source resource Id where the payload is located. </param>
        /// <param name="targetServiceTopologyId"> The resource Id of the service topology from which service units are being referenced in step groups to be deployed. </param>
        /// <param name="stepGroups"> The list of step groups that define the orchestration. </param>
        internal RolloutCreateOrUpdateContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, Identity identity, string buildVersion, string artifactSourceId, string targetServiceTopologyId, IList<StepGroup> stepGroups) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            BuildVersion = buildVersion;
            ArtifactSourceId = artifactSourceId;
            TargetServiceTopologyId = targetServiceTopologyId;
            StepGroups = stepGroups;
        }

        /// <summary> Identity for the resource. </summary>
        public Identity Identity { get; set; }
        /// <summary> The version of the build being deployed. </summary>
        public string BuildVersion { get; set; }
        /// <summary> The reference to the artifact source resource Id where the payload is located. </summary>
        public string ArtifactSourceId { get; set; }
        /// <summary> The resource Id of the service topology from which service units are being referenced in step groups to be deployed. </summary>
        public string TargetServiceTopologyId { get; set; }
        /// <summary> The list of step groups that define the orchestration. </summary>
        public IList<StepGroup> StepGroups { get; }
    }
}
