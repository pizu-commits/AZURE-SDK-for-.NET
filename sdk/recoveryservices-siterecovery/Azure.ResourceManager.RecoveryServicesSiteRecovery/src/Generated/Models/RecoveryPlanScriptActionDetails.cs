// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Recovery plan script action details. </summary>
    public partial class RecoveryPlanScriptActionDetails : RecoveryPlanActionDetails
    {
        /// <summary> Initializes a new instance of <see cref="RecoveryPlanScriptActionDetails"/>. </summary>
        /// <param name="path"> The script path. </param>
        /// <param name="fabricLocation"> The fabric location. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="path"/> is null. </exception>
        public RecoveryPlanScriptActionDetails(string path, RecoveryPlanActionLocation fabricLocation)
        {
            Argument.AssertNotNull(path, nameof(path));

            Path = path;
            FabricLocation = fabricLocation;
            InstanceType = "ScriptActionDetails";
        }

        /// <summary> Initializes a new instance of <see cref="RecoveryPlanScriptActionDetails"/>. </summary>
        /// <param name="instanceType"> Gets the type of action details (see RecoveryPlanActionDetailsTypes enum for possible values). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="path"> The script path. </param>
        /// <param name="timeout"> The script timeout. </param>
        /// <param name="fabricLocation"> The fabric location. </param>
        internal RecoveryPlanScriptActionDetails(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData, string path, string timeout, RecoveryPlanActionLocation fabricLocation) : base(instanceType, serializedAdditionalRawData)
        {
            Path = path;
            Timeout = timeout;
            FabricLocation = fabricLocation;
            InstanceType = instanceType ?? "ScriptActionDetails";
        }

        /// <summary> Initializes a new instance of <see cref="RecoveryPlanScriptActionDetails"/> for deserialization. </summary>
        internal RecoveryPlanScriptActionDetails()
        {
        }

        /// <summary> The script path. </summary>
        public string Path { get; set; }
        /// <summary> The script timeout. </summary>
        public string Timeout { get; set; }
        /// <summary> The fabric location. </summary>
        public RecoveryPlanActionLocation FabricLocation { get; set; }
    }
}
