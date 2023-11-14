// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Class representing an update to a Kusto kusto pool. </summary>
    public partial class SynapseKustoPoolPatch : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SynapseKustoPoolPatch"/>. </summary>
        public SynapseKustoPoolPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="SynapseKustoPoolPatch"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="sku"> The SKU of the kusto pool. </param>
        /// <param name="state"> The state of the resource. </param>
        /// <param name="provisioningState"> The provisioned state of the resource. </param>
        /// <param name="uri"> The Kusto Pool URI. </param>
        /// <param name="dataIngestionUri"> The Kusto Pool data ingestion URI. </param>
        /// <param name="stateReason"> The reason for the Kusto Pool's current state. </param>
        /// <param name="optimizedAutoscale"> Optimized auto scale definition. </param>
        /// <param name="enableStreamingIngest"> A boolean value that indicates if the streaming ingest is enabled. </param>
        /// <param name="enablePurge"> A boolean value that indicates if the purge operations are enabled. </param>
        /// <param name="languageExtensions"> List of the Kusto Pool's language extensions. </param>
        /// <param name="workspaceUid"> The workspace unique identifier. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseKustoPoolPatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, SynapseDataSourceSku sku, KustoPoolState? state, ResourceProvisioningState? provisioningState, Uri uri, Uri dataIngestionUri, string stateReason, SynapseOptimizedAutoscale optimizedAutoscale, bool? enableStreamingIngest, bool? enablePurge, SynapseLanguageExtensionsList languageExtensions, Guid? workspaceUid, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Tags = tags;
            Sku = sku;
            State = state;
            ProvisioningState = provisioningState;
            Uri = uri;
            DataIngestionUri = dataIngestionUri;
            StateReason = stateReason;
            OptimizedAutoscale = optimizedAutoscale;
            EnableStreamingIngest = enableStreamingIngest;
            EnablePurge = enablePurge;
            LanguageExtensions = languageExtensions;
            WorkspaceUid = workspaceUid;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The SKU of the kusto pool. </summary>
        public SynapseDataSourceSku Sku { get; set; }
        /// <summary> The state of the resource. </summary>
        public KustoPoolState? State { get; }
        /// <summary> The provisioned state of the resource. </summary>
        public ResourceProvisioningState? ProvisioningState { get; }
        /// <summary> The Kusto Pool URI. </summary>
        public Uri Uri { get; }
        /// <summary> The Kusto Pool data ingestion URI. </summary>
        public Uri DataIngestionUri { get; }
        /// <summary> The reason for the Kusto Pool's current state. </summary>
        public string StateReason { get; }
        /// <summary> Optimized auto scale definition. </summary>
        public SynapseOptimizedAutoscale OptimizedAutoscale { get; set; }
        /// <summary> A boolean value that indicates if the streaming ingest is enabled. </summary>
        public bool? EnableStreamingIngest { get; set; }
        /// <summary> A boolean value that indicates if the purge operations are enabled. </summary>
        public bool? EnablePurge { get; set; }
        /// <summary> List of the Kusto Pool's language extensions. </summary>
        internal SynapseLanguageExtensionsList LanguageExtensions { get; }
        /// <summary> The list of language extensions. </summary>
        public IList<SynapseLanguageExtension> LanguageExtensionsValue
        {
            get => LanguageExtensions?.Value;
        }

        /// <summary> The workspace unique identifier. </summary>
        public Guid? WorkspaceUid { get; set; }
    }
}
