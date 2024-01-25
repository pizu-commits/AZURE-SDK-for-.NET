// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Changeable attributes. </summary>
    internal partial class TagWriteableProperties
    {
        /// <summary> Initializes a new instance of <see cref="TagWriteableProperties"/>. </summary>
        public TagWriteableProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TagWriteableProperties"/>. </summary>
        /// <param name="canDelete"> Delete enabled. </param>
        /// <param name="canWrite"> Write enabled. </param>
        /// <param name="canList"> List enabled. </param>
        /// <param name="canRead"> Read enabled. </param>
        internal TagWriteableProperties(bool? canDelete, bool? canWrite, bool? canList, bool? canRead)
        {
            CanDelete = canDelete;
            CanWrite = canWrite;
            CanList = canList;
            CanRead = canRead;
        }

        /// <summary> Delete enabled. </summary>
        public bool? CanDelete { get; set; }
        /// <summary> Write enabled. </summary>
        public bool? CanWrite { get; set; }
        /// <summary> List enabled. </summary>
        public bool? CanList { get; set; }
        /// <summary> Read enabled. </summary>
        public bool? CanRead { get; set; }
    }
}
