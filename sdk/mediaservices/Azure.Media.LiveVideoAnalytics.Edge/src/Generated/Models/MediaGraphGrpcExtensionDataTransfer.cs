// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Media.LiveVideoAnalytics.Edge.Models
{
    /// <summary> Describes how media should be transferred to the inferencing engine. </summary>
    public partial class MediaGraphGrpcExtensionDataTransfer
    {
        /// <summary> Initializes a new instance of MediaGraphGrpcExtensionDataTransfer. </summary>
        /// <param name="mode"> How frame data should be transmitted to the inferencing engine. </param>
        public MediaGraphGrpcExtensionDataTransfer(MediaGraphGrpcExtensionDataTransferMode mode)
        {
            Mode = mode;
        }

        /// <summary> Initializes a new instance of MediaGraphGrpcExtensionDataTransfer. </summary>
        /// <param name="sharedMemorySizeMiB"> The size of the buffer for all in-flight frames in mebibytes if mode is SharedMemory. Should not be specificed otherwise. </param>
        /// <param name="mode"> How frame data should be transmitted to the inferencing engine. </param>
        internal MediaGraphGrpcExtensionDataTransfer(string sharedMemorySizeMiB, MediaGraphGrpcExtensionDataTransferMode mode)
        {
            SharedMemorySizeMiB = sharedMemorySizeMiB;
            Mode = mode;
        }

        /// <summary> The size of the buffer for all in-flight frames in mebibytes if mode is SharedMemory. Should not be specificed otherwise. </summary>
        public string SharedMemorySizeMiB { get; set; }
        /// <summary> How frame data should be transmitted to the inferencing engine. </summary>
        public MediaGraphGrpcExtensionDataTransferMode Mode { get; set; }
    }
}
