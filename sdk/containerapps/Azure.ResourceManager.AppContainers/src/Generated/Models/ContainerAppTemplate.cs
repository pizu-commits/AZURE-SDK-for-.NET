// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary>
    /// Container App versioned application definition.
    /// Defines the desired state of an immutable revision.
    /// Any changes to this section Will result in a new revision being created
    /// </summary>
    public partial class ContainerAppTemplate
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContainerAppTemplate"/>. </summary>
        public ContainerAppTemplate()
        {
            InitContainers = new ChangeTrackingList<ContainerAppInitContainer>();
            Containers = new ChangeTrackingList<ContainerAppContainer>();
            Volumes = new ChangeTrackingList<ContainerAppVolume>();
            ServiceBinds = new ChangeTrackingList<ContainerAppServiceBind>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppTemplate"/>. </summary>
        /// <param name="revisionSuffix"> User friendly suffix that is appended to the revision name. </param>
        /// <param name="terminationGracePeriodSeconds"> Optional duration in seconds the Container App Instance needs to terminate gracefully. Value must be non-negative integer. The value zero indicates stop immediately via the kill signal (no opportunity to shut down). If this value is nil, the default grace period will be used instead. Set this value longer than the expected cleanup time for your process. Defaults to 30 seconds. </param>
        /// <param name="initContainers"> List of specialized containers that run before app containers. </param>
        /// <param name="containers"> List of container definitions for the Container App. </param>
        /// <param name="scale"> Scaling properties for the Container App. </param>
        /// <param name="volumes"> List of volume definitions for the Container App. </param>
        /// <param name="serviceBinds"> List of container app services bound to the app. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppTemplate(string revisionSuffix, long? terminationGracePeriodSeconds, IList<ContainerAppInitContainer> initContainers, IList<ContainerAppContainer> containers, ContainerAppScale scale, IList<ContainerAppVolume> volumes, IList<ContainerAppServiceBind> serviceBinds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RevisionSuffix = revisionSuffix;
            TerminationGracePeriodSeconds = terminationGracePeriodSeconds;
            InitContainers = initContainers;
            Containers = containers;
            Scale = scale;
            Volumes = volumes;
            ServiceBinds = serviceBinds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> User friendly suffix that is appended to the revision name. </summary>
        [WirePath("revisionSuffix")]
        public string RevisionSuffix { get; set; }
        /// <summary> Optional duration in seconds the Container App Instance needs to terminate gracefully. Value must be non-negative integer. The value zero indicates stop immediately via the kill signal (no opportunity to shut down). If this value is nil, the default grace period will be used instead. Set this value longer than the expected cleanup time for your process. Defaults to 30 seconds. </summary>
        [WirePath("terminationGracePeriodSeconds")]
        public long? TerminationGracePeriodSeconds { get; set; }
        /// <summary> List of specialized containers that run before app containers. </summary>
        [WirePath("initContainers")]
        public IList<ContainerAppInitContainer> InitContainers { get; }
        /// <summary> List of container definitions for the Container App. </summary>
        [WirePath("containers")]
        public IList<ContainerAppContainer> Containers { get; }
        /// <summary> Scaling properties for the Container App. </summary>
        [WirePath("scale")]
        public ContainerAppScale Scale { get; set; }
        /// <summary> List of volume definitions for the Container App. </summary>
        [WirePath("volumes")]
        public IList<ContainerAppVolume> Volumes { get; }
        /// <summary> List of container app services bound to the app. </summary>
        [WirePath("serviceBinds")]
        public IList<ContainerAppServiceBind> ServiceBinds { get; }
    }
}
