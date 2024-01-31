// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Restore payload for Single File Snapshot Restore. </summary>
    public partial class NetAppVolumeSnapshotRestoreFilesContent
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

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeSnapshotRestoreFilesContent"/>. </summary>
        /// <param name="filePaths"> List of files to be restored. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="filePaths"/> is null. </exception>
        public NetAppVolumeSnapshotRestoreFilesContent(IEnumerable<string> filePaths)
        {
            Argument.AssertNotNull(filePaths, nameof(filePaths));

            FilePaths = filePaths.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeSnapshotRestoreFilesContent"/>. </summary>
        /// <param name="filePaths"> List of files to be restored. </param>
        /// <param name="destinationPath"> Destination folder where the files will be restored. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetAppVolumeSnapshotRestoreFilesContent(IList<string> filePaths, string destinationPath, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FilePaths = filePaths;
            DestinationPath = destinationPath;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeSnapshotRestoreFilesContent"/> for deserialization. </summary>
        internal NetAppVolumeSnapshotRestoreFilesContent()
        {
        }

        /// <summary> List of files to be restored. </summary>
        public IList<string> FilePaths { get; }
        /// <summary> Destination folder where the files will be restored. </summary>
        public string DestinationPath { get; set; }
    }
}
