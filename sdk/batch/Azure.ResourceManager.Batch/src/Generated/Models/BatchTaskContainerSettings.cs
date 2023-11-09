// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> The container settings for a task. </summary>
    public partial class BatchTaskContainerSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BatchTaskContainerSettings"/>. </summary>
        /// <param name="imageName"> This is the full image reference, as would be specified to "docker pull". If no tag is provided as part of the image name, the tag ":latest" is used as a default. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        public BatchTaskContainerSettings(string imageName)
        {
            Argument.AssertNotNull(imageName, nameof(imageName));

            ImageName = imageName;
        }

        /// <summary> Initializes a new instance of <see cref="BatchTaskContainerSettings"/>. </summary>
        /// <param name="containerRunOptions"> These additional options are supplied as arguments to the "docker create" command, in addition to those controlled by the Batch Service. </param>
        /// <param name="imageName"> This is the full image reference, as would be specified to "docker pull". If no tag is provided as part of the image name, the tag ":latest" is used as a default. </param>
        /// <param name="registry"> This setting can be omitted if was already provided at pool creation. </param>
        /// <param name="workingDirectory"> A flag to indicate where the container task working directory is. The default is 'taskWorkingDirectory'. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchTaskContainerSettings(string containerRunOptions, string imageName, BatchVmContainerRegistry registry, BatchContainerWorkingDirectory? workingDirectory, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ContainerRunOptions = containerRunOptions;
            ImageName = imageName;
            Registry = registry;
            WorkingDirectory = workingDirectory;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchTaskContainerSettings"/> for deserialization. </summary>
        internal BatchTaskContainerSettings()
        {
        }

        /// <summary> These additional options are supplied as arguments to the "docker create" command, in addition to those controlled by the Batch Service. </summary>
        public string ContainerRunOptions { get; set; }
        /// <summary> This is the full image reference, as would be specified to "docker pull". If no tag is provided as part of the image name, the tag ":latest" is used as a default. </summary>
        public string ImageName { get; set; }
        /// <summary> This setting can be omitted if was already provided at pool creation. </summary>
        public BatchVmContainerRegistry Registry { get; set; }
        /// <summary> A flag to indicate where the container task working directory is. The default is 'taskWorkingDirectory'. </summary>
        public BatchContainerWorkingDirectory? WorkingDirectory { get; set; }
    }
}
