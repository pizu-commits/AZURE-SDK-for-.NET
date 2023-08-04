// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.DeploymentManager;

namespace Azure.ResourceManager.DeploymentManager.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class DeploymentManagerResourceGroupMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="DeploymentManagerResourceGroupMockingExtension"/> class for mocking. </summary>
        protected DeploymentManagerResourceGroupMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeploymentManagerResourceGroupMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DeploymentManagerResourceGroupMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ServiceTopologyResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ServiceTopologyResources and their operations over a ServiceTopologyResource. </returns>
        public virtual ServiceTopologyResourceCollection GetServiceTopologyResources()
        {
            return GetCachedClient(Client => new ServiceTopologyResourceCollection(Client, Id));
        }

        /// <summary>
        /// Gets the service topology.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeploymentManager/serviceTopologies/{serviceTopologyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceTopologies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceTopologyName"> The name of the service topology . </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceTopologyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceTopologyName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ServiceTopologyResource>> GetServiceTopologyResourceAsync(string serviceTopologyName, CancellationToken cancellationToken = default)
        {
            return await GetServiceTopologyResources().GetAsync(serviceTopologyName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the service topology.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeploymentManager/serviceTopologies/{serviceTopologyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceTopologies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceTopologyName"> The name of the service topology . </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceTopologyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceTopologyName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<ServiceTopologyResource> GetServiceTopologyResource(string serviceTopologyName, CancellationToken cancellationToken = default)
        {
            return GetServiceTopologyResources().Get(serviceTopologyName, cancellationToken);
        }

        /// <summary> Gets a collection of StepResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of StepResources and their operations over a StepResource. </returns>
        public virtual StepResourceCollection GetStepResources()
        {
            return GetCachedClient(Client => new StepResourceCollection(Client, Id));
        }

        /// <summary>
        /// Gets the step.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeploymentManager/steps/{stepName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Steps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="stepName"> The name of the deployment step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stepName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<StepResource>> GetStepResourceAsync(string stepName, CancellationToken cancellationToken = default)
        {
            return await GetStepResources().GetAsync(stepName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the step.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeploymentManager/steps/{stepName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Steps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="stepName"> The name of the deployment step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stepName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<StepResource> GetStepResource(string stepName, CancellationToken cancellationToken = default)
        {
            return GetStepResources().Get(stepName, cancellationToken);
        }

        /// <summary> Gets a collection of RolloutResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of RolloutResources and their operations over a RolloutResource. </returns>
        public virtual RolloutCollection GetRollouts()
        {
            return GetCachedClient(Client => new RolloutCollection(Client, Id));
        }

        /// <summary>
        /// Gets detailed information of a rollout.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeploymentManager/rollouts/{rolloutName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Rollouts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="retryAttempt"> Rollout retry attempt ordinal to get the result of. If not specified, result of the latest attempt will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rolloutName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<RolloutResource>> GetRolloutAsync(string rolloutName, int? retryAttempt = null, CancellationToken cancellationToken = default)
        {
            return await GetRollouts().GetAsync(rolloutName, retryAttempt, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets detailed information of a rollout.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeploymentManager/rollouts/{rolloutName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Rollouts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="retryAttempt"> Rollout retry attempt ordinal to get the result of. If not specified, result of the latest attempt will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rolloutName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<RolloutResource> GetRollout(string rolloutName, int? retryAttempt = null, CancellationToken cancellationToken = default)
        {
            return GetRollouts().Get(rolloutName, retryAttempt, cancellationToken);
        }

        /// <summary> Gets a collection of ArtifactSourceResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ArtifactSourceResources and their operations over a ArtifactSourceResource. </returns>
        public virtual ArtifactSourceCollection GetArtifactSources()
        {
            return GetCachedClient(Client => new ArtifactSourceCollection(Client, Id));
        }

        /// <summary>
        /// Gets an artifact source.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeploymentManager/artifactSources/{artifactSourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ArtifactSources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="artifactSourceName"> The name of the artifact source. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="artifactSourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="artifactSourceName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ArtifactSourceResource>> GetArtifactSourceAsync(string artifactSourceName, CancellationToken cancellationToken = default)
        {
            return await GetArtifactSources().GetAsync(artifactSourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an artifact source.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeploymentManager/artifactSources/{artifactSourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ArtifactSources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="artifactSourceName"> The name of the artifact source. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="artifactSourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="artifactSourceName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<ArtifactSourceResource> GetArtifactSource(string artifactSourceName, CancellationToken cancellationToken = default)
        {
            return GetArtifactSources().Get(artifactSourceName, cancellationToken);
        }
    }
}
