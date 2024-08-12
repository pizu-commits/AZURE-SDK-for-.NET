// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A Class representing a TopicType along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="TopicTypeResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetTopicTypeResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource"/> using the GetTopicType method.
    /// </summary>
    public partial class TopicTypeResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="TopicTypeResource"/> instance. </summary>
        /// <param name="topicTypeName"> The topicTypeName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string topicTypeName)
        {
            var resourceId = $"/providers/Microsoft.EventGrid/topicTypes/{topicTypeName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _topicTypeClientDiagnostics;
        private readonly TopicTypesRestOperations _topicTypeRestClient;
        private readonly TopicTypeData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.EventGrid/topicTypes";

        /// <summary> Initializes a new instance of the <see cref="TopicTypeResource"/> class for mocking. </summary>
        protected TopicTypeResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TopicTypeResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal TopicTypeResource(ArmClient client, TopicTypeData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="TopicTypeResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TopicTypeResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _topicTypeClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string topicTypeApiVersion);
            _topicTypeRestClient = new TopicTypesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, topicTypeApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual TopicTypeData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get information about a topic type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.EventGrid/topicTypes/{topicTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopicTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TopicTypeResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _topicTypeClientDiagnostics.CreateScope("TopicTypeResource.Get");
            scope.Start();
            try
            {
                var response = await _topicTypeRestClient.GetAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TopicTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get information about a topic type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.EventGrid/topicTypes/{topicTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopicTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TopicTypeResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _topicTypeClientDiagnostics.CreateScope("TopicTypeResource.Get");
            scope.Start();
            try
            {
                var response = _topicTypeRestClient.Get(Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TopicTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List event types for a topic type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.EventGrid/topicTypes/{topicTypeName}/eventTypes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicTypes_ListEventTypes</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopicTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EventTypeUnderTopic"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EventTypeUnderTopic> GetEventTypesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _topicTypeRestClient.CreateListEventTypesRequest(Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => EventTypeUnderTopic.DeserializeEventTypeUnderTopic(e), _topicTypeClientDiagnostics, Pipeline, "TopicTypeResource.GetEventTypes", "value", null, cancellationToken);
        }

        /// <summary>
        /// List event types for a topic type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.EventGrid/topicTypes/{topicTypeName}/eventTypes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicTypes_ListEventTypes</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopicTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EventTypeUnderTopic"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EventTypeUnderTopic> GetEventTypes(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _topicTypeRestClient.CreateListEventTypesRequest(Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => EventTypeUnderTopic.DeserializeEventTypeUnderTopic(e), _topicTypeClientDiagnostics, Pipeline, "TopicTypeResource.GetEventTypes", "value", null, cancellationToken);
        }
    }
}
