// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Represents the livePipelineDeactivate request. </summary>
    public partial class LivePipelineDeactivateRequest : ItemNonSetRequestBase
    {
        /// <summary> Initializes a new instance of LivePipelineDeactivateRequest. </summary>
        /// <param name="name"> method name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public LivePipelineDeactivateRequest(string name) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            MethodName = "livePipelineDeactivate";
        }

        /// <summary> Initializes a new instance of LivePipelineDeactivateRequest. </summary>
        /// <param name="methodName"> method name. </param>
        /// <param name="apiVersion"> api version. </param>
        /// <param name="name"> method name. </param>
        internal LivePipelineDeactivateRequest(string methodName, string apiVersion, string name) : base(methodName, apiVersion, name)
        {
            MethodName = methodName ?? "livePipelineDeactivate";
        }
    }
}
