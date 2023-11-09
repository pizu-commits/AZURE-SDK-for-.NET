// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Validate messages of the configuration service git repositories. </summary>
    public partial class AppPlatformConfigurationServiceGitReposValidationMessages
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AppPlatformConfigurationServiceGitReposValidationMessages"/>. </summary>
        internal AppPlatformConfigurationServiceGitReposValidationMessages()
        {
            Messages = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformConfigurationServiceGitReposValidationMessages"/>. </summary>
        /// <param name="name"> The name of the configuration service git repository. </param>
        /// <param name="messages"> Detailed validation messages. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppPlatformConfigurationServiceGitReposValidationMessages(string name, IReadOnlyList<string> messages, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Messages = messages;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the configuration service git repository. </summary>
        public string Name { get; }
        /// <summary> Detailed validation messages. </summary>
        public IReadOnlyList<string> Messages { get; }
    }
}
