// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The instance view of the init container. Only valid in response. </summary>
    public partial class InitContainerPropertiesDefinitionInstanceView
    {
        /// <summary> Initializes a new instance of InitContainerPropertiesDefinitionInstanceView. </summary>
        internal InitContainerPropertiesDefinitionInstanceView()
        {
            Events = new ChangeTrackingList<ContainerEvent>();
        }

        /// <summary> Initializes a new instance of InitContainerPropertiesDefinitionInstanceView. </summary>
        /// <param name="restartCount"> The number of times that the init container has been restarted. </param>
        /// <param name="currentState"> The current state of the init container. </param>
        /// <param name="previousState"> The previous state of the init container. </param>
        /// <param name="events"> The events of the init container. </param>
        internal InitContainerPropertiesDefinitionInstanceView(int? restartCount, ContainerState currentState, ContainerState previousState, IReadOnlyList<ContainerEvent> events)
        {
            RestartCount = restartCount;
            CurrentState = currentState;
            PreviousState = previousState;
            Events = events;
        }

        /// <summary> The number of times that the init container has been restarted. </summary>
        public int? RestartCount { get; }
        /// <summary> The current state of the init container. </summary>
        public ContainerState CurrentState { get; }
        /// <summary> The previous state of the init container. </summary>
        public ContainerState PreviousState { get; }
        /// <summary> The events of the init container. </summary>
        public IReadOnlyList<ContainerEvent> Events { get; }
    }
}
