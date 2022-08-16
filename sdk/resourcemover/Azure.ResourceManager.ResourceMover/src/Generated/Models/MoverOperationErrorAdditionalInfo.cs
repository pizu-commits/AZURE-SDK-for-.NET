// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> The operation error info. </summary>
    public partial class MoverOperationErrorAdditionalInfo
    {
        /// <summary> Initializes a new instance of MoverOperationErrorAdditionalInfo. </summary>
        internal MoverOperationErrorAdditionalInfo()
        {
        }

        /// <summary> Initializes a new instance of MoverOperationErrorAdditionalInfo. </summary>
        /// <param name="operationErrorAdditionalInfoType"> The error type. </param>
        /// <param name="info"> The operation error info. </param>
        internal MoverOperationErrorAdditionalInfo(string operationErrorAdditionalInfoType, MoveErrorInfo info)
        {
            OperationErrorAdditionalInfoType = operationErrorAdditionalInfoType;
            Info = info;
        }

        /// <summary> The error type. </summary>
        public string OperationErrorAdditionalInfoType { get; }
        /// <summary> The operation error info. </summary>
        internal MoveErrorInfo Info { get; }
        /// <summary> The affected move resources. </summary>
        public IReadOnlyList<MoverAffectedMoveResourceInfo> InfoMoveResources
        {
            get => Info?.MoveResources;
        }
    }
}
